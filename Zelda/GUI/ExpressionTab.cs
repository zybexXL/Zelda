using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Zelda
{
    public partial class ExpressionTab : TabPage
    {
        private static int uniqueID = 0;

        internal bool isModified { get; private set; }
        internal bool changed { get; private set; }
        internal JRiverAPI jrAPI { get; set; }
        Settings settings;

        internal ELSyntax highlighter { get; set; } = new ELSyntax();
        internal event EventHandler<int> ZoomChanged;
        internal event EventHandler<bool> ExpressionChanged;
        internal event EventHandler<ELToken> FunctionChanged;
        internal ELToken selectedFunction = null;

        internal string Result { get; private set; }
        internal double APItime { get; private set; }
        JRFile currentFile;

        internal bool Paused { get; set; }
        internal string ID { get; private set; }

        public ExpressionTab(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            ID = $"expr{++uniqueID}";
            scintilla.LexerName = null;

            this.Controls.Add(scintilla);
            Config(settings);
        }

        public ExpressionTab(string title, Settings settings) : this(settings)
        {
            Text = title;
        }

        public void SetContent(string content)
        {
            scintilla.Text = content;
            if (IsHandleCreated)
                syntaxHighlight(true);
            else
                this.HandleCreated += (a, b) => syntaxHighlight(true);
        }

        public void Config(Settings settings)
        {
            this.settings = settings;

            scintilla.SetWhitespaceForeColor(true, Color.DimGray);
            scintilla.WhitespaceSize = 2;           // larger spaces for visibility
            scintilla.EolMode = Eol.Lf;             // LF only
            scintilla.Margins[1].Width = 10;

            scintilla.CaretLineVisible = false;
            scintilla.WrapStartIndent = settings.WrapIndent ? 2 : 0;
            scintilla.UseTabs = !settings.ReplaceTabs;
            scintilla.Margins[0].Width = settings.ShowLineNumbers ? 25 : 0;

            scintilla.Styles[Style.Default].Font = settings.EditorFont.family;
            scintilla.Styles[Style.Default].Bold = settings.EditorFont.isBold;
            scintilla.Styles[Style.Default].Italic = settings.EditorFont.isItalic;
            scintilla.Styles[Style.Default].SizeF = settings.EditorFont.size;
            scintilla.Styles[Style.Default].ForeColor = settings.EditorFont.ForeColor;
            scintilla.Styles[Style.Default].BackColor = settings.EditorFont.BackColor;
            scintilla.StyleClearAll();

            scintilla.Styles[(int)ELTokenType.Field].ForeColor = Color.DarkGreen;
            scintilla.Styles[(int)ELTokenType.Math].ForeColor = Color.DarkCyan;
            scintilla.Styles[(int)ELTokenType.Function].ForeColor = Color.Blue;
            scintilla.Styles[(int)ELTokenType.HTML].ForeColor = Color.DarkMagenta;
            scintilla.Styles[(int)ELTokenType.Literal].BackColor = Color.PaleGoldenrod;
            scintilla.Styles[(int)ELTokenType.Escaped].BackColor = Color.PaleGoldenrod;
            scintilla.Styles[(int)ELTokenType.Literal].ForeColor = Color.Black;
            scintilla.Styles[(int)ELTokenType.Escaped].ForeColor = Color.Black;
            scintilla.Styles[(int)ELTokenType.Number].ForeColor = Color.DarkOrange;
            scintilla.Styles[(int)ELTokenType.Symbol].ForeColor = Color.Red;
            scintilla.Styles[(int)ELTokenType.Comment].ForeColor = Color.Gray;

            // change CR/LF representation
            //scintilla.SetRepresentation("\n", "LF");
            //scintilla.SetRepresentation("\r", "CR");

            runTimer.Interval = settings.EvaluateDelay;
            syntaxHighlight();
        }

        private void scintilla_TextChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                changed = true;
                isModified = true;
                syntaxTimer.Stop();
                runTimer.Stop();
            }

            ExpressionChanged?.Invoke(this, false); // changed, not evaluated
            
            syntaxTimer.Start();
            runTimer.Start();
        }

        // handle caret position change - highlight current function
        private void scintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            if (e.Change == UpdateChange.Content || changed) return;
            syntaxIndicators();
        }

        private void scintilla_ZoomChanged(object sender, EventArgs e)
        {
            SetZoom(scintilla.Zoom, true);
        }

        internal void SetZoom(int zoom, bool invoke = false)
        {
            if (scintilla.Margins[0].Width > 0)
                scintilla.Margins[0].Width = Math.Max(20, 30 + 3 * zoom);
            if (scintilla.Zoom != zoom)
                scintilla.Zoom = zoom;
            if (invoke)
                ZoomChanged?.Invoke(this, scintilla.Zoom);
        }

        internal void InsertFont()
        {
            string currFont = null;
            int currpos = scintilla.CurrentPosition;
            var token = highlighter.Tokens.Where(t => t.type == ELTokenType.HTML && t.pos <= currpos && t.pos + t.len >= currpos).FirstOrDefault();
            if (token != null && token.text.ToLower().StartsWith("<font"))
                currFont = token.text;

            var dialog = new InsertFont(currFont);
            bool isEdit = token != null;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (isEdit)
                {
                    scintilla.SetSelection(token.pos + token.len, token.pos);
                    InsertText(dialog.SelectedFont.ToExpression(), "", "", !isEdit, isEdit);
                }
                else
                    InsertText(dialog.SelectedFont.ToExpression(), "text content", "<//font>");
            }
        }

        internal void InsertImg()
        {
            string currImg = null;
            int currpos = scintilla.CurrentPosition;
            var token = highlighter.Tokens.Where(t => t.type == ELTokenType.HTML && t.pos <= currpos && t.pos + t.len >= currpos).FirstOrDefault();
            if (token != null && token.text.ToLower().StartsWith("<img"))
                currImg = token.text;

            var dialog = new InsertImg(currImg);
            bool isEdit = token != null;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                if (isEdit) scintilla.SetSelection(token.pos + token.len, token.pos);
                InsertText(dialog.SelectedImg.ToExpression(), "", "", false, true);
            }
        }

        internal void InsertText(string prefix, string text, string suffix, bool select = true, bool replace = false)
        {
            string sel = replace ? text : scintilla.SelectedText;
            if (string.IsNullOrEmpty(sel)) sel = text;

            scintilla.ReplaceSelection("");
            int position = scintilla.CurrentPosition;
            string all = $"{prefix}{sel}{suffix}";
            scintilla.AddText(all);

            if (select)
                scintilla.SetSelection(position + prefix.Length, position + prefix.Length + sel.Length);
            else
                scintilla.SetEmptySelection(position + all.Length);

            syntaxHighlight();
        }

        #region syntax highlight

        private void syntaxTimer_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                changed = false;
                syntaxTimer.Stop();
            }
            syntaxHighlight();
        }

        private void syntaxHighlight(bool forced = false)
        {
            string text = scintilla.Text;
            Task.Run(() =>
            {
                lock (this)
                    highlighter.getTokens(text, settings.HighlightComments);
                if (forced || !syntaxTimer.Enabled)
                    syntaxHighlight(highlighter.Tokens, forced);
            });
        }

        private void syntaxHighlight(List<ELToken> tokens, bool forced = false)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate { syntaxHighlight(tokens, forced); });
                return;
            }

            if ((changed && !forced) || !IsHandleCreated) return;

            //txtExpression.ClearDocumentStyle();       // causes problems with Word wrap!
            scintilla.StartStyling(0);
            scintilla.SetStyling(scintilla.TextLength, 0);

            if (settings.HighlightSyntax)
            {

                ELToken last = null;
                foreach (var token in tokens)
                {
                    int style = (int)token.type;
                    scintilla.StartStyling(token.pos);
                    if (token.pos + token.len == scintilla.TextLength)
                        last = token;
                    scintilla.SetStyling(token.len, style);
                }
                // bugfix: re-paint last character because it loses the style
                if (last != null)
                {
                    scintilla.StartStyling(scintilla.TextLength - 1);
                    scintilla.SetStyling(1, (int)last.type);
                }
            }

            syntaxIndicators();
        }

        private void syntaxIndicators()
        {
            var funcs = highlighter.Functions;
            int pos = scintilla.CurrentPosition;

            ELToken currFunc = null;
            foreach (var f in funcs)
                if (pos >= f.pos && pos <= f.pos + f.functionLen)
                    currFunc = f;

            scintilla.IndicatorCurrent = 1;
            scintilla.IndicatorClearRange(0, scintilla.TextLength);
            scintilla.IndicatorCurrent = 2;
            scintilla.IndicatorClearRange(0, scintilla.TextLength);
            if (currFunc != null)
            {
                scintilla.IndicatorCurrent = 1;
                scintilla.Indicators[1].Style = IndicatorStyle.StraightBox;
                scintilla.IndicatorClearRange(0, scintilla.TextLength);
                // don't highlight the entire text (first function, usually)
                if (settings.HighlightFunction)
                    if (currFunc.pos > 2 || currFunc.functionLen < scintilla.Text.Trim().Length - 3 || pos <= currFunc.pos + currFunc.len)
                        scintilla.IndicatorFillRange(currFunc.pos, currFunc.functionLen);

                scintilla.IndicatorCurrent = 2;
                scintilla.Indicators[2].Style = IndicatorStyle.FullBox;
                scintilla.Indicators[2].ForeColor = Color.Red;
                scintilla.Indicators[2].Alpha = 60;
                scintilla.IndicatorClearRange(0, scintilla.TextLength);

                if (settings.HighlightDelimiters)
                    foreach (int p in currFunc.separators)
                        scintilla.IndicatorFillRange(p, 1);
            }
            if (currFunc != selectedFunction)
            {
                selectedFunction = currFunc;
                FunctionChanged?.Invoke(this, selectedFunction);
            }
        }

        #endregion

        #region Expression evaluation

        private void runTimer_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                changed = false;
                runTimer.Stop();
            }
            Evaluate();
        }

        internal void Evaluate(JRFile file)
        {
            currentFile = file;
            Evaluate();
        }

        internal void Evaluate(bool forced = false)
        {
            if (!forced && Paused) return;

            isModified = false;
            try
            {
                if (currentFile == null)
                {
                    Result = "Please select a file!";
                    ExpressionChanged?.Invoke(this, true);
                }
                else
                {
                    string expression = scintilla.Text?.Replace("\r\n", "\n") ?? "";
                    if (string.IsNullOrWhiteSpace(expression))
                    {
                        Result = expression;
                        ExpressionChanged?.Invoke(this, true);
                    }
                    else
                    {
                        Task.Run(() =>
                        {
                            Stopwatch sw = Stopwatch.StartNew();
                            Result = jrAPI.resolveExpression(currentFile, expression, settings.HighlightComments);
                            sw.Stop();
                            APItime = TimeSpan.FromTicks(sw.ElapsedTicks).TotalMilliseconds;
                            if (!changed)
                                ExpressionChanged?.Invoke(this, true);
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Result = $"Expression error, please check!\n\n{ex}";
                ExpressionChanged?.Invoke(this, true);
            }
        }

        #endregion

        private void ExpressionTab_DoubleClick(object sender, EventArgs e)
        {
            Rename();
        }

        internal void Rename()
        {
            InputBox box = new InputBox("Enter expression tab name", Text);
            if (box.ShowDialog(this) == DialogResult.OK)
                Text = box.Value;
        }

        private void menuEditor_Opening(object sender, CancelEventArgs e)
        {
            mUndo.Enabled = scintilla.CanUndo;
            mRedo.Enabled = scintilla.CanRedo;

            bool hasSelection = !string.IsNullOrEmpty(scintilla.SelectedText);
            bool hasText = scintilla.TextLength > 0;
            mCopy.Enabled = mCut.Enabled = hasSelection;
            mPaste.Enabled = scintilla.CanPaste;
            mSelectAll.Enabled = mCopyAll.Enabled = hasText;
            mCopySinglePreserve.Enabled = mCopySingleStrip.Enabled = hasText; 
        }

        private void MCopySinglePreserve_Click(object sender, System.EventArgs e)
        {
            string stripped = Regex.Replace(scintilla.Text, @"(,\s*)\n", "$1");
            stripped = Regex.Replace(stripped, @"/?\r?\n", "char(10)");
            try
            {
                Clipboard.SetText(stripped, TextDataFormat.UnicodeText);
            }
            catch { }
        }

        private void MCopySingleStrip_Click(object sender, System.EventArgs e)
        {
            string stripped = Regex.Replace(scintilla.Text, @"/?\r?\n", "");
            try
            {
                Clipboard.SetText(stripped, TextDataFormat.UnicodeText);
            }
            catch { }
        }

        private void MCopyAll_Click(object sender, System.EventArgs e)
        {
            try
            {
                Clipboard.SetText(scintilla.Text, TextDataFormat.UnicodeText);
            }
            catch { }
        }

        private void MSelectAll_Click(object sender, System.EventArgs e)
        {
            scintilla.SelectAll();
        }

        private void mUndo_Click(object sender, System.EventArgs e)
        {
            scintilla.Undo();
        }

        private void MRedo_Click(object sender, System.EventArgs e)
        {
            scintilla.Redo();
        }

        private void MCut_Click(object sender, System.EventArgs e)
        {
            scintilla.Cut();
        }

        private void MCopy_Click(object sender, System.EventArgs e)
        {
            scintilla.Copy();
        }

        private void MPaste_Click(object sender, System.EventArgs e)
        {
            scintilla.Paste();
        }
    }
}
