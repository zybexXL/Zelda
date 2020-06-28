namespace Zelda
{
    partial class InsertFont
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ddFont = new System.Windows.Forms.ComboBox();
            this.ddFontSize = new System.Windows.Forms.ComboBox();
            this.chkFont = new System.Windows.Forms.CheckBox();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.chkColor = new System.Windows.Forms.CheckBox();
            this.chkBackcolor = new System.Windows.Forms.CheckBox();
            this.chkAlpha = new System.Windows.Forms.CheckBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblBackcolor = new System.Windows.Forms.Label();
            this.ddAlpha = new System.Windows.Forms.ComboBox();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(378, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ddFont
            // 
            this.ddFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddFont.FormattingEnabled = true;
            this.ddFont.Location = new System.Drawing.Point(90, 10);
            this.ddFont.Name = "ddFont";
            this.ddFont.Size = new System.Drawing.Size(345, 23);
            this.ddFont.TabIndex = 3;
            this.ddFont.SelectedIndexChanged += new System.EventHandler(this.ddFont_SelectedIndexChanged);
            // 
            // ddFontSize
            // 
            this.ddFontSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddFontSize.Items.AddRange(new object[] {
            "50",
            "60",
            "80",
            "100",
            "120",
            "150",
            "175",
            "200",
            "250",
            "300",
            "350",
            "400",
            "500"});
            this.ddFontSize.Location = new System.Drawing.Point(90, 49);
            this.ddFontSize.MaxLength = 4;
            this.ddFontSize.Name = "ddFontSize";
            this.ddFontSize.Size = new System.Drawing.Size(54, 23);
            this.ddFontSize.TabIndex = 4;
            this.ddFontSize.TextChanged += new System.EventHandler(this.ddFontSize_TextChanged);
            this.ddFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ddFontSize_KeyPress);
            // 
            // chkFont
            // 
            this.chkFont.AutoSize = true;
            this.chkFont.Location = new System.Drawing.Point(14, 14);
            this.chkFont.Name = "chkFont";
            this.chkFont.Size = new System.Drawing.Size(53, 19);
            this.chkFont.TabIndex = 7;
            this.chkFont.Text = "Font:";
            this.chkFont.UseVisualStyleBackColor = true;
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(14, 51);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(70, 19);
            this.chkSize.TabIndex = 7;
            this.chkSize.Text = "Size (%):";
            this.chkSize.UseVisualStyleBackColor = true;
            // 
            // chkColor
            // 
            this.chkColor.AutoSize = true;
            this.chkColor.Location = new System.Drawing.Point(14, 88);
            this.chkColor.Name = "chkColor";
            this.chkColor.Size = new System.Drawing.Size(58, 19);
            this.chkColor.TabIndex = 7;
            this.chkColor.Text = "Color:";
            this.chkColor.UseVisualStyleBackColor = true;
            // 
            // chkBackcolor
            // 
            this.chkBackcolor.AutoSize = true;
            this.chkBackcolor.Location = new System.Drawing.Point(230, 88);
            this.chkBackcolor.Name = "chkBackcolor";
            this.chkBackcolor.Size = new System.Drawing.Size(84, 19);
            this.chkBackcolor.TabIndex = 7;
            this.chkBackcolor.Text = "Back color:";
            this.chkBackcolor.UseVisualStyleBackColor = true;
            // 
            // chkAlpha
            // 
            this.chkAlpha.AutoSize = true;
            this.chkAlpha.Location = new System.Drawing.Point(230, 51);
            this.chkAlpha.Name = "chkAlpha";
            this.chkAlpha.Size = new System.Drawing.Size(81, 19);
            this.chkAlpha.TabIndex = 7;
            this.chkAlpha.Text = "Alpha (%):";
            this.chkAlpha.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Teal;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(90, 84);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(116, 26);
            this.lblColor.TabIndex = 8;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // lblBackcolor
            // 
            this.lblBackcolor.BackColor = System.Drawing.Color.Teal;
            this.lblBackcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBackcolor.Location = new System.Drawing.Point(320, 84);
            this.lblBackcolor.Name = "lblBackcolor";
            this.lblBackcolor.Size = new System.Drawing.Size(116, 26);
            this.lblBackcolor.TabIndex = 8;
            this.lblBackcolor.Click += new System.EventHandler(this.lblBackcolor_Click);
            // 
            // ddAlpha
            // 
            this.ddAlpha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddAlpha.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.ddAlpha.Location = new System.Drawing.Point(320, 49);
            this.ddAlpha.MaxLength = 3;
            this.ddAlpha.Name = "ddAlpha";
            this.ddAlpha.Size = new System.Drawing.Size(54, 23);
            this.ddAlpha.TabIndex = 4;
            this.ddAlpha.TextChanged += new System.EventHandler(this.ddAlpha_TextChanged);
            this.ddAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ddFontSize_KeyPress);
            // 
            // colorPicker
            // 
            this.colorPicker.AnyColor = true;
            this.colorPicker.FullOpen = true;
            this.colorPicker.SolidColorOnly = true;
            // 
            // InsertFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 172);
            this.Controls.Add(this.lblBackcolor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.chkAlpha);
            this.Controls.Add(this.chkBackcolor);
            this.Controls.Add(this.chkColor);
            this.Controls.Add(this.chkSize);
            this.Controls.Add(this.chkFont);
            this.Controls.Add(this.ddFont);
            this.Controls.Add(this.ddAlpha);
            this.Controls.Add(this.ddFontSize);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertFont";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert <font>";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsUI_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ddFont;
        private System.Windows.Forms.ComboBox ddFontSize;
        private System.Windows.Forms.CheckBox chkFont;
        private System.Windows.Forms.CheckBox chkSize;
        private System.Windows.Forms.CheckBox chkColor;
        private System.Windows.Forms.CheckBox chkBackcolor;
        private System.Windows.Forms.CheckBox chkAlpha;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblBackcolor;
        private System.Windows.Forms.ComboBox ddAlpha;
        private System.Windows.Forms.ColorDialog colorPicker;
    }
}