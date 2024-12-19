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
using System.Linq.Expressions;

namespace Zelda
{
    public partial class ExpressionTab : TabPage
    {
        private static int uniqueID = 0;

        public string savedExpression { get; set; }
        internal bool isSaved { get; set; } = true;
        internal bool needsEvaluation { get; private set; }
        private bool textChanged { get; set; }
        internal JRiverAPI jrAPI { get; set; }
        Settings settings;

        internal ELSyntax highlighter { get; set; } = new ELSyntax();
        internal event EventHandler<int> ZoomChanged;
        internal event EventHandler<bool> ExpressionChanged;
        internal event EventHandler<bool> NeedsSavingChanged;
        internal event EventHandler<ELToken> FunctionChanged;
        internal ELToken selectedFunction = null;

        internal string Result { get; private set; }
        internal double APItime { get; private set; }
        JRFile currentFile;

        internal bool Paused { get; set; }
        internal string ID { get; private set; }
        internal string linkedField { get; set; }
        internal bool isLinkedTab => !string.IsNullOrEmpty(linkedField);

        bool wrap;
        bool viewEol;
        bool delayedWrap = false;

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

        public void SetContent(string content, int pos = -1)
        {
            wrap = scintilla.WrapMode != WrapMode.None;
            viewEol = scintilla.ViewEol;
            delayedWrap = true;
            scintilla.WrapMode = WrapMode.None;

            savedExpression = content;
            scintilla.Text = content;

            if (pos >=0)
                scintilla.GotoPosition(pos);
            scintilla.EmptyUndoBuffer();
            isSaved = true;

            syntaxHighlight(true);
        }

        public void Config(Settings settings)
        {
            this.settings = settings;

            scintilla.WhitespaceTextColor = Color.DimGray;
            scintilla.WhitespaceSize = 2;           // larger spaces for visibility
            scintilla.EolMode = Eol.Lf;             // LF only
            scintilla.Margins[1].Width = 10;

            scintilla.CaretLineBackColor = Color.Transparent;
            scintilla.WrapStartIndent = settings.WrapIndent ? 2 : 0;
            scintilla.UseTabs = !settings.ReplaceTabs;
            scintilla.Margins[0].Width = settings.ShowLineNumbers ? 25 : 0;
            scintilla.Margins[0].Type = MarginType.Number;

            scintilla.Styles[Style.Default].Font = settings.EditorFont.family;
            scintilla.Styles[Style.Default].Bold = settings.EditorFont.isBold;
            scintilla.Styles[Style.Default].Italic = settings.EditorFont.isItalic;
            scintilla.Styles[Style.Default].SizeF = settings.EditorFont.size;
            scintilla.Styles[Style.Default].ForeColor = settings.EditorFont.ForeColor;
            scintilla.Styles[Style.Default].BackColor = settings.EditorFont.BackColor;
            scintilla.StyleClearAll();

            foreach (ELTokenType token in Enum.GetValues(typeof(ELTokenType)))
                scintilla.Styles[(int)token].ForeColor = ELToken.GetColor(token);

            //scintilla.Styles[(int)ELTokenType.Literal].BackColor = Color.PaleGoldenrod;   // bg
            //scintilla.Styles[(int)ELTokenType.Escaped].BackColor = Color.PaleGoldenrod;   // bg

            scintilla.Styles[Style.LineNumber].BackColor = Color.WhiteSmoke;
            scintilla.Styles[Style.LineNumber].ForeColor = Color.DimGray;

            // set selection color (active/inactive)
            const int SCI_SETELEMENTCOLOUR = 2753;
            const int SC_ELEMENT_SELECTION_INACTIVE_BACK = 17;
            scintilla.DirectMessage(SCI_SETELEMENTCOLOUR, new IntPtr(SC_ELEMENT_SELECTION_INACTIVE_BACK), new IntPtr(Color.PaleGoldenrod.ToArgb()));
            scintilla.SelectionBackColor = Color.PaleGoldenrod;

            // function highlight indicator
            scintilla.Indicators[1].Style = IndicatorStyle.StraightBox;
            scintilla.Indicators[1].ForeColor = Color.Blue;
            scintilla.Indicators[1].Alpha = 30;
            scintilla.Indicators[1].Under = true;

            // function commas and parenthesis indicator
            scintilla.Indicators[2].Style = IndicatorStyle.FullBox;
            scintilla.Indicators[2].ForeColor = Color.Red;
            scintilla.Indicators[2].Alpha = 60;

            // word selection indicator
            scintilla.Indicators[3].Style = IndicatorStyle.StraightBox;
            scintilla.Indicators[3].Under = true;
            scintilla.Indicators[3].ForeColor = Color.Cyan;
            scintilla.Indicators[3].OutlineAlpha = 90;
            scintilla.Indicators[3].Alpha = 90;

            // change CR/LF representation
            //scintilla.SetRepresentation("\n", "LF");
            //scintilla.SetRepresentation("\r", "CR");

            runTimer.Interval = settings.EvaluateDelay;
        }

        private void scintilla_TextChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                textChanged = true;
                needsEvaluation = true;
                syntaxTimer.Stop();
                runTimer.Stop();
            }

            ExpressionChanged?.Invoke(this, false);

            syntaxTimer.Start();
            runTimer.Start();
        }

        public bool SetSavedExpression(string expression)
        {
            savedExpression = expression;
            isSaved = CheckSavedExpression();
            return isSaved;
        }

        public bool CheckSavedExpression()
        {
            bool wasSaved = isSaved;
            isSaved = Util.isSameExpression(scintilla.Text, savedExpression);
            if (wasSaved != isSaved)
                NeedsSavingChanged?.Invoke(this, isSaved);
            return isSaved;
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
                textChanged = false;
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

        // handle caret position change - highlight current function
        private void scintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            if (!textChanged && e.Change == UpdateChange.Selection)
            {
                HighlightWord(scintilla.SelectedText, scintilla.SelectionStart);
                syntaxIndicators();
            }
        }

        private void syntaxHighlight(List<ELToken> tokens, bool forced = false)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate { syntaxHighlight(tokens, forced); });
                return;
            }

            if ((textChanged && !forced) || !IsHandleCreated) return;

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

            if (delayedWrap)
            {
                delayedWrap = false;
                scintilla.ViewEol = viewEol;
                scintilla.WrapMode = wrap ? WrapMode.Word : WrapMode.None;
            }
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

            if (currFunc != null && string.IsNullOrEmpty(scintilla.SelectedText))
            {
                // function highlight - don't highlight the entire text (first function, usually)
                scintilla.IndicatorCurrent = 1;
                if (settings.HighlightFunction)
                    if (currFunc.pos > 2 || currFunc.functionLen < scintilla.Text.Trim().Length - 3 || pos <= currFunc.pos + currFunc.len)
                        scintilla.IndicatorFillRange(currFunc.pos, currFunc.functionLen);

                // commas/parenthesis highlight
                scintilla.IndicatorCurrent = 2;
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

        private void HighlightWord(string text, int position)
        {
            // clear all indicator occurences
            scintilla.IndicatorCurrent = 3;
            scintilla.IndicatorClearRange(0, scintilla.TextLength);

            if (string.IsNullOrEmpty(text) || text.Length < 2)
                return;

            // Search the document
            scintilla.TargetStart = 0;
            scintilla.TargetEnd = scintilla.TextLength;
            scintilla.SearchFlags = SearchFlags.None;
            while (scintilla.SearchInTarget(text) != -1)
            {
                // Mark the search results with the current indicator
                if (scintilla.TargetStart != position)
                    scintilla.IndicatorFillRange(scintilla.TargetStart, scintilla.TargetEnd - scintilla.TargetStart);

                // Search the remainder of the document
                scintilla.TargetStart = scintilla.TargetEnd;
                scintilla.TargetEnd = scintilla.TextLength;
            }
        }

        #endregion

        #region Expression evaluation

        private void runTimer_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                textChanged = false;
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
            CheckSavedExpression();

            needsEvaluation = false;
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
                            if (!textChanged)
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
            string stripped = Util.StripComments(scintilla.Text);
            stripped = Regex.Replace(stripped, @"(,\s*)\n", "$1");
            stripped = Regex.Replace(stripped, @"/[\r\n\s]+", "", RegexOptions.Singleline);
            stripped = Regex.Replace(stripped, @"\r?\n", "char(10)");
            SetClipboard(stripped);
        }

        private void MCopySingleStrip_Click(object sender, System.EventArgs e)
        {
            string stripped = Util.StripComments(scintilla.Text);
            stripped = Regex.Replace(stripped, @"/?\r?\n", "");
            SetClipboard(stripped);
        }

        private void MCopyAll_Click(object sender, System.EventArgs e)
        {
            SetClipboard(scintilla.Text);
        }

        private void SetClipboard(string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            try
            {
                Clipboard.SetText(text, TextDataFormat.UnicodeText);
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

        private void MCopyYabbClean_Click(object sender, System.EventArgs e)
        {
            getYabbBBCode(false, ModifierKeys.HasFlag(Keys.Control));
        }

        private void MCopyYabb_Click(object sender, System.EventArgs e)
        {
            getYabbBBCode(true, ModifierKeys.HasFlag(Keys.Control));
        }

        private void getYabbBBCode(bool keepComments, bool unquoted = false)
        {
            if (string.IsNullOrWhiteSpace(scintilla.Text) || highlighter.Tokens == null)
                return;

            string text = keepComments ? scintilla.Text.Trim() : Util.StripComments(scintilla.Text).Trim();
            var tokens = highlighter.getTokens(text);
            var sorted = new List<ELToken>();
            
            for (int i = 0; i < tokens.Count; i++)
            {
                bool add = true;
                for (int j = i + 1; j < tokens.Count; j++)
                    if (tokens[j].pos <= tokens[i].pos && tokens[j].pos + tokens[j].len >= tokens[i].pos + tokens[i].len)
                    {
                        add = false;
                        break;
                    }
                if (add) {
                    sorted.Add(new ELToken(tokens[i].type, $"[color={ELToken.GetColor(tokens[i].type).ToKnownColor()}]", tokens[i].pos) { functionLen = tokens[i].pos });
                    sorted.Add(new ELToken(tokens[i].type, $"[/color]", tokens[i].pos + tokens[i].len) { functionLen = tokens[i].pos });
                }
            }

            sorted = sorted.OrderBy(t=>t.pos).ThenBy(t=>t.functionLen).ToList();
            
            string warn = Regex.IsMatch(text, "<[biu]>") ? "Warning: HTML tags mangled for forum display, please re-type <\u200Bb>/<\u200Bu>/<\u200Bi> tags" : "";
            if (sorted.Any(t => t.type == ELTokenType.Comment))
                warn += "\r\nWarning: ## comment lines included, remove before use";
            warn = warn.Trim();
            bool usePre = !string.IsNullOrEmpty(warn) || Regex.IsMatch(text, @"[ \t][\r\n]");
            if (!string.IsNullOrEmpty(warn))
                warn = $"[size=8pt][red]{warn}[/red][/size]";

            StringBuilder sb = new StringBuilder();
            sb.Append(unquoted ? "[size=8pt][b]ZELDA code snippet[/b]:[/size][hr]" : $"[quote author=ZELDA]");
            sb.Append($"{warn}[font=consolas,courier][size=10pt][color=Black]");
            if (usePre) sb.Append("[pre]");

            int currToken = 0;
            for (int i=0; i<text.Length; i++)
            {
                while (currToken < sorted.Count && sorted[currToken].pos <= i)
                    sb.Append(sorted[currToken++].text);
                sb.Append(text[i]);
            }
            while (currToken < sorted.Count)
                sb.Append(sorted[currToken++].text);

            if (usePre) sb.Append("[/pre]");
            sb.Append($"[/color][/size][/font]");
            sb.AppendLine(unquoted ? "[hr]" : "[/quote]");
            sb.AppendLine();

            text = sb.ToString();
            text = Regex.Replace(text, "<([biu])>", "<\u200B$1>", RegexOptions.IgnoreCase);

            SetClipboard(text);
        }
    }
}
