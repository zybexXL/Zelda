namespace Zelda
{
    partial class TextEditor
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
            this.txtExpression = new ScintillaNET.Scintilla();
            this.SuspendLayout();
            // 
            // txtExpression
            // 
            this.txtExpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExpression.Location = new System.Drawing.Point(0, 0);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(504, 383);
            this.txtExpression.TabIndex = 2;
            this.txtExpression.WhitespaceSize = 2;
            this.txtExpression.WrapStartIndent = 2;
            this.txtExpression.WrapVisualFlagLocation = ScintillaNET.WrapVisualFlagLocation.StartByText;
            this.txtExpression.WrapVisualFlags = ScintillaNET.WrapVisualFlags.End;
            this.txtExpression.ZoomChanged += new System.EventHandler<System.EventArgs>(this.txtExpression_ZoomChanged);
            this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtExpression);
            this.Name = "TextEditor";
            this.Size = new System.Drawing.Size(504, 383);
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla txtExpression;
    }
}
