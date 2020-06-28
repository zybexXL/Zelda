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
            this.syntaxTimer = new System.Windows.Forms.Timer(this.components);
            this.runTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // scintilla
            // 
            this.scintilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.ResumeLayout(false);

        }

        #endregion

        internal ScintillaNET.Scintilla scintilla;
        private System.Windows.Forms.Timer syntaxTimer;
        private System.Windows.Forms.Timer runTimer;
    }
}
