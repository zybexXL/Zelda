namespace Zelda
{
    partial class InsertImg
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
            this.btnOK = new System.Windows.Forms.Button();
            this.chkWidth = new System.Windows.Forms.CheckBox();
            this.chkHeight = new System.Windows.Forms.CheckBox();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.browseFile = new System.Windows.Forms.OpenFileDialog();
            this.chkVAlign = new System.Windows.Forms.CheckBox();
            this.comboVAlign = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(455, 61);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(58, 27);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkWidth
            // 
            this.chkWidth.AutoSize = true;
            this.chkWidth.Location = new System.Drawing.Point(12, 65);
            this.chkWidth.Name = "chkWidth";
            this.chkWidth.Size = new System.Drawing.Size(61, 19);
            this.chkWidth.TabIndex = 7;
            this.chkWidth.Text = "Width:";
            this.chkWidth.UseVisualStyleBackColor = true;
            // 
            // chkHeight
            // 
            this.chkHeight.AutoSize = true;
            this.chkHeight.Location = new System.Drawing.Point(140, 65);
            this.chkHeight.Name = "chkHeight";
            this.chkHeight.Size = new System.Drawing.Size(65, 19);
            this.chkHeight.TabIndex = 7;
            this.chkHeight.Text = "Height:";
            this.chkHeight.UseVisualStyleBackColor = true;
            // 
            // colorPicker
            // 
            this.colorPicker.AnyColor = true;
            this.colorPicker.FullOpen = true;
            this.colorPicker.SolidColorOnly = true;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(12, 27);
            this.txtPath.MaxLength = 1000;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(501, 23);
            this.txtPath.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "PNG image path:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(72, 63);
            this.txtWidth.MaxLength = 4;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(45, 23);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(205, 63);
            this.txtHeight.MaxLength = 4;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(45, 23);
            this.txtHeight.TabIndex = 8;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Image = global::Zelda.Properties.Resources.folder;
            this.btnBrowse.Location = new System.Drawing.Point(517, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(24, 24);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // browseFile
            // 
            this.browseFile.DefaultExt = "png";
            this.browseFile.Filter = "Image files|*.png;*.bmp;*.jpg;*.gif;*.tif";
            // 
            // chkVAlign
            // 
            this.chkVAlign.AutoSize = true;
            this.chkVAlign.Location = new System.Drawing.Point(275, 65);
            this.chkVAlign.Name = "chkVAlign";
            this.chkVAlign.Size = new System.Drawing.Size(63, 19);
            this.chkVAlign.TabIndex = 7;
            this.chkVAlign.Text = "VAlign:";
            this.chkVAlign.UseVisualStyleBackColor = true;
            // 
            // comboVAlign
            // 
            this.comboVAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVAlign.FormattingEnabled = true;
            this.comboVAlign.Items.AddRange(new object[] {
            "Top",
            "Middle",
            "Bottom"});
            this.comboVAlign.Location = new System.Drawing.Point(338, 63);
            this.comboVAlign.Name = "comboVAlign";
            this.comboVAlign.Size = new System.Drawing.Size(73, 23);
            this.comboVAlign.TabIndex = 10;
            this.comboVAlign.SelectedIndexChanged += new System.EventHandler(this.comboVAlign_SelectedIndexChanged);
            // 
            // InsertImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 96);
            this.Controls.Add(this.comboVAlign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.chkVAlign);
            this.Controls.Add(this.chkHeight);
            this.Controls.Add(this.chkWidth);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertImg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert <img>";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsUI_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkWidth;
        private System.Windows.Forms.CheckBox chkHeight;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog browseFile;
        private System.Windows.Forms.CheckBox chkVAlign;
        private System.Windows.Forms.ComboBox comboVAlign;
    }
}