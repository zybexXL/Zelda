namespace Zelda
{
    partial class ExpressionTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scintilla = new ScintillaNET.Scintilla();
            this.menuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mCopySingleStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mCopySinglePreserve = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxTimer = new System.Windows.Forms.Timer(this.components);
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.menuEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // scintilla
            // 
            this.scintilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scintilla.ContextMenuStrip = this.menuEditor;
            this.scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla.EolMode = ScintillaNET.Eol.Lf;
            this.scintilla.Location = new System.Drawing.Point(0, 0);
            this.scintilla.Name = "scintilla";
            this.scintilla.Size = new System.Drawing.Size(200, 100);
            this.scintilla.TabIndex = 0;
            this.scintilla.WhitespaceSize = 2;
            this.scintilla.WrapStartIndent = 2;
            this.scintilla.WrapVisualFlagLocation = ScintillaNET.WrapVisualFlagLocation.StartByText;
            this.scintilla.WrapVisualFlags = ScintillaNET.WrapVisualFlags.End;
            this.scintilla.UpdateUI += new System.EventHandler<ScintillaNET.UpdateUIEventArgs>(this.scintilla_UpdateUI);
            this.scintilla.ZoomChanged += new System.EventHandler<System.EventArgs>(this.scintilla_ZoomChanged);
            this.scintilla.TextChanged += new System.EventHandler(this.scintilla_TextChanged);
            // 
            // menuEditor
            // 
            this.menuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUndo,
            this.mRedo,
            this.toolStripSeparator6,
            this.mCut,
            this.mCopy,
            this.mPaste,
            this.toolStripSeparator7,
            this.mSelectAll,
            this.mCopyAll,
            this.mCopySingleStrip,
            this.mCopySinglePreserve});
            this.menuEditor.Name = "menuEditor";
            this.menuEditor.Size = new System.Drawing.Size(255, 214);
            this.menuEditor.Opening += new System.ComponentModel.CancelEventHandler(this.menuEditor_Opening);
            // 
            // mUndo
            // 
            this.mUndo.Name = "mUndo";
            this.mUndo.Size = new System.Drawing.Size(261, 22);
            this.mUndo.Text = "Undo";
            this.mUndo.Click += mUndo_Click;
            // 
            // mRedo
            // 
            this.mRedo.Name = "mRedo";
            this.mRedo.Size = new System.Drawing.Size(261, 22);
            this.mRedo.Text = "Redo";
            this.mRedo.Click += MRedo_Click;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(258, 6);
            // 
            // mCut
            // 
            this.mCut.Name = "mCut";
            this.mCut.Size = new System.Drawing.Size(254, 22);
            this.mCut.Text = "Cut";
            this.mCut.Click += MCut_Click;
            // 
            // mCopy
            // 
            this.mCopy.Name = "mCopy";
            this.mCopy.Size = new System.Drawing.Size(261, 22);
            this.mCopy.Text = "Copy";
            this.mCopy.Click += MCopy_Click;
            // 
            // mPaste
            // 
            this.mPaste.Name = "mPaste";
            this.mPaste.Size = new System.Drawing.Size(261, 22);
            this.mPaste.Text = "Paste";
            this.mPaste.Click += MPaste_Click;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(258, 6);
            // 
            // mSelectAll
            // 
            this.mSelectAll.Name = "mSelectAll";
            this.mSelectAll.Size = new System.Drawing.Size(261, 22);
            this.mSelectAll.Text = "Select All";
            this.mSelectAll.Click += MSelectAll_Click;
            // 
            // mCopyAll
            // 
            this.mCopyAll.Name = "mCopyAll";
            this.mCopyAll.Size = new System.Drawing.Size(261, 22);
            this.mCopyAll.Text = "Copy All";
            this.mCopyAll.Click += MCopyAll_Click;
            // 
            // mCopySingleStrip
            // 
            this.mCopySingleStrip.Name = "mCopySingleStrip";
            this.mCopySingleStrip.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mCopySingleStrip.ShowShortcutKeys = false;
            this.mCopySingleStrip.Size = new System.Drawing.Size(254, 22);
            this.mCopySingleStrip.Text = "Copy as Single Line - Strip CRLF";
            this.mCopySingleStrip.Click += MCopySingleStrip_Click;
            // 
            // mCopySinglePreserve
            // 
            this.mCopySinglePreserve.Name = "mCopySinglePreserve";
            this.mCopySinglePreserve.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.mCopySinglePreserve.ShowShortcutKeys = false;
            this.mCopySinglePreserve.Size = new System.Drawing.Size(254, 22);
            this.mCopySinglePreserve.Text = "Copy as Single Line - Preserve CRLF";
            this.mCopySinglePreserve.Click += MCopySinglePreserve_Click;
            // 
            // syntaxTimer
            // 
            this.syntaxTimer.Interval = 250;
            this.syntaxTimer.Tick += new System.EventHandler(this.syntaxTimer_Tick);
            // 
            // runTimer
            // 
            this.runTimer.Interval = 500;
            this.runTimer.Tick += new System.EventHandler(this.runTimer_Tick);
            // 
            // ExpressionTab
            // 
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Expr1";
            this.UseVisualStyleBackColor = true;
            this.DoubleClick += new System.EventHandler(this.ExpressionTab_DoubleClick);
            this.menuEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal ScintillaNET.Scintilla scintilla;
        private System.Windows.Forms.Timer syntaxTimer;
        private System.Windows.Forms.Timer runTimer;
        private System.Windows.Forms.ContextMenuStrip menuEditor;
        private System.Windows.Forms.ToolStripMenuItem mUndo;
        private System.Windows.Forms.ToolStripMenuItem mRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mCut;
        private System.Windows.Forms.ToolStripMenuItem mCopy;
        private System.Windows.Forms.ToolStripMenuItem mPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mCopyAll;
        private System.Windows.Forms.ToolStripMenuItem mCopySingleStrip;
        private System.Windows.Forms.ToolStripMenuItem mCopySinglePreserve;
    }
}
