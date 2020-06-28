namespace Zelda
{
    partial class SettingsUI
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delaySlide = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ddFont = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.ddFontSize = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSaveTabs = new System.Windows.Forms.CheckBox();
            this.chkDark = new System.Windows.Forms.CheckBox();
            this.chkMaximize = new System.Windows.Forms.CheckBox();
            this.chkTabs = new System.Windows.Forms.CheckBox();
            this.chkAPITime = new System.Windows.Forms.CheckBox();
            this.chkIndent = new System.Windows.Forms.CheckBox();
            this.chkLines = new System.Windows.Forms.CheckBox();
            this.chkSaveView = new System.Windows.Forms.CheckBox();
            this.chkLoadPlaylist = new System.Windows.Forms.CheckBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtExtraFuncs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgSyntax = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSyntaxDelim = new System.Windows.Forms.CheckBox();
            this.chkSyntaxFunction = new System.Windows.Forms.CheckBox();
            this.chkSyntax = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaySlide)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSyntax)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(427, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 361);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.delaySlide);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chkSaveTabs);
            this.tabPage1.Controls.Add(this.chkDark);
            this.tabPage1.Controls.Add(this.chkMaximize);
            this.tabPage1.Controls.Add(this.chkTabs);
            this.tabPage1.Controls.Add(this.chkAPITime);
            this.tabPage1.Controls.Add(this.chkIndent);
            this.tabPage1.Controls.Add(this.chkLines);
            this.tabPage1.Controls.Add(this.chkSaveView);
            this.tabPage1.Controls.Add(this.chkLoadPlaylist);
            this.tabPage1.Controls.Add(this.lblDelay);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preferences";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // delaySlide
            // 
            this.delaySlide.AutoSize = false;
            this.delaySlide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.delaySlide.LargeChange = 200;
            this.delaySlide.Location = new System.Drawing.Point(8, 151);
            this.delaySlide.Maximum = 2000;
            this.delaySlide.Minimum = 100;
            this.delaySlide.Name = "delaySlide";
            this.delaySlide.Size = new System.Drawing.Size(251, 25);
            this.delaySlide.SmallChange = 50;
            this.delaySlide.TabIndex = 6;
            this.delaySlide.TickFrequency = 50;
            this.delaySlide.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.delaySlide, "Delay after typing stops before recalculating the expression result");
            this.delaySlide.Value = 500;
            this.delaySlide.ValueChanged += new System.EventHandler(this.delaySlide_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.ddFont);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.ddFontSize);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 117);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel2.Location = new System.Drawing.Point(375, 79);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(101, 15);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "background color";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(313, 79);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "text color";
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.White;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Location = new System.Drawing.Point(152, -1);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 22);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Rendered Output";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.White;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(66, -1);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 22);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Text Output";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // ddFont
            // 
            this.ddFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddFont.FormattingEnabled = true;
            this.ddFont.Location = new System.Drawing.Point(53, 31);
            this.ddFont.Name = "ddFont";
            this.ddFont.Size = new System.Drawing.Size(326, 23);
            this.ddFont.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(13, -1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 22);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Editor";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(53, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(254, 43);
            this.label21.TabIndex = 3;
            this.label21.Text = "sample text";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddFontSize
            // 
            this.ddFontSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddFontSize.FormattingEnabled = true;
            this.ddFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.ddFontSize.Location = new System.Drawing.Point(429, 31);
            this.ddFontSize.Name = "ddFontSize";
            this.ddFontSize.Size = new System.Drawing.Size(47, 23);
            this.ddFontSize.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(392, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 15);
            this.label22.TabIndex = 2;
            this.label22.Text = "Size:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Font:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(261, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Custom colors/fonts are not yet implemented";
            // 
            // chkSaveTabs
            // 
            this.chkSaveTabs.AutoSize = true;
            this.chkSaveTabs.Checked = true;
            this.chkSaveTabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveTabs.Location = new System.Drawing.Point(14, 16);
            this.chkSaveTabs.Name = "chkSaveTabs";
            this.chkSaveTabs.Size = new System.Drawing.Size(184, 19);
            this.chkSaveTabs.TabIndex = 5;
            this.chkSaveTabs.Text = "Auto-save/restore expressions";
            this.chkSaveTabs.UseVisualStyleBackColor = true;
            // 
            // chkDark
            // 
            this.chkDark.AutoSize = true;
            this.chkDark.Checked = true;
            this.chkDark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDark.Location = new System.Drawing.Point(298, 116);
            this.chkDark.Name = "chkDark";
            this.chkDark.Size = new System.Drawing.Size(90, 19);
            this.chkDark.TabIndex = 5;
            this.chkDark.Text = "Dark Theme";
            this.chkDark.UseVisualStyleBackColor = true;
            this.chkDark.Visible = false;
            // 
            // chkMaximize
            // 
            this.chkMaximize.AutoSize = true;
            this.chkMaximize.Checked = true;
            this.chkMaximize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaximize.Location = new System.Drawing.Point(14, 91);
            this.chkMaximize.Name = "chkMaximize";
            this.chkMaximize.Size = new System.Drawing.Size(110, 19);
            this.chkMaximize.TabIndex = 5;
            this.chkMaximize.Text = "Start maximized";
            this.chkMaximize.UseVisualStyleBackColor = true;
            // 
            // chkTabs
            // 
            this.chkTabs.AutoSize = true;
            this.chkTabs.Checked = true;
            this.chkTabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTabs.Location = new System.Drawing.Point(298, 66);
            this.chkTabs.Name = "chkTabs";
            this.chkTabs.Size = new System.Drawing.Size(170, 19);
            this.chkTabs.TabIndex = 5;
            this.chkTabs.Text = "Insert spaces instead of Tab";
            this.chkTabs.UseVisualStyleBackColor = true;
            // 
            // chkAPITime
            // 
            this.chkAPITime.AutoSize = true;
            this.chkAPITime.Checked = true;
            this.chkAPITime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAPITime.Location = new System.Drawing.Point(298, 91);
            this.chkAPITime.Name = "chkAPITime";
            this.chkAPITime.Size = new System.Drawing.Size(211, 19);
            this.chkAPITime.TabIndex = 5;
            this.chkAPITime.Text = "Show API call times in Playlist table";
            this.chkAPITime.UseVisualStyleBackColor = true;
            // 
            // chkIndent
            // 
            this.chkIndent.AutoSize = true;
            this.chkIndent.Checked = true;
            this.chkIndent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIndent.Location = new System.Drawing.Point(298, 41);
            this.chkIndent.Name = "chkIndent";
            this.chkIndent.Size = new System.Drawing.Size(136, 19);
            this.chkIndent.TabIndex = 5;
            this.chkIndent.Text = "Indent wrapped lines";
            this.chkIndent.UseVisualStyleBackColor = true;
            // 
            // chkLines
            // 
            this.chkLines.AutoSize = true;
            this.chkLines.Checked = true;
            this.chkLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLines.Location = new System.Drawing.Point(298, 16);
            this.chkLines.Name = "chkLines";
            this.chkLines.Size = new System.Drawing.Size(127, 19);
            this.chkLines.TabIndex = 5;
            this.chkLines.Text = "Show line numbers";
            this.chkLines.UseVisualStyleBackColor = true;
            // 
            // chkSaveView
            // 
            this.chkSaveView.AutoSize = true;
            this.chkSaveView.Checked = true;
            this.chkSaveView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveView.Location = new System.Drawing.Point(14, 41);
            this.chkSaveView.Name = "chkSaveView";
            this.chkSaveView.Size = new System.Drawing.Size(155, 19);
            this.chkSaveView.TabIndex = 5;
            this.chkSaveView.Text = "Remember view settings";
            this.chkSaveView.UseVisualStyleBackColor = true;
            // 
            // chkLoadPlaylist
            // 
            this.chkLoadPlaylist.AutoSize = true;
            this.chkLoadPlaylist.Location = new System.Drawing.Point(14, 66);
            this.chkLoadPlaylist.Name = "chkLoadPlaylist";
            this.chkLoadPlaylist.Size = new System.Drawing.Size(180, 19);
            this.chkLoadPlaylist.TabIndex = 5;
            this.chkLoadPlaylist.Text = "Reload last playlist on startup";
            this.chkLoadPlaylist.UseVisualStyleBackColor = true;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(108, 133);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(44, 15);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "500 ms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Evaluation delay:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.txtExtraFuncs);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.dgSyntax);
            this.tabPage2.Controls.Add(this.chkSyntaxDelim);
            this.tabPage2.Controls.Add(this.chkSyntaxFunction);
            this.tabPage2.Controls.Add(this.chkSyntax);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Syntax highlight";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(86, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Custom colors are not yet implemented";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Default - Dark",
            "Custom",
            "Custom - Dark"});
            this.comboBox1.Location = new System.Drawing.Point(60, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Visible = false;
            // 
            // txtExtraFuncs
            // 
            this.txtExtraFuncs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtraFuncs.Location = new System.Drawing.Point(139, 299);
            this.txtExtraFuncs.Name = "txtExtraFuncs";
            this.txtExtraFuncs.Size = new System.Drawing.Size(368, 23);
            this.txtExtraFuncs.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtExtraFuncs, "Add new function names for highlighting, separated by space.\r\nThis allows ZELDA t" +
        "o recognized recently added functions.\r\n\r\nRequires application restart to take e" +
        "ffect.");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preset:";
            this.label3.Visible = false;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 302);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 15);
            this.label20.TabIndex = 15;
            this.label20.Text = "Additional Functions:";
            // 
            // dgSyntax
            // 
            this.dgSyntax.AllowUserToAddRows = false;
            this.dgSyntax.AllowUserToDeleteRows = false;
            this.dgSyntax.AllowUserToResizeColumns = false;
            this.dgSyntax.AllowUserToResizeRows = false;
            this.dgSyntax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSyntax.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgSyntax.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgSyntax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSyntax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgSyntax.Enabled = false;
            this.dgSyntax.Location = new System.Drawing.Point(16, 63);
            this.dgSyntax.Name = "dgSyntax";
            this.dgSyntax.RowHeadersVisible = false;
            this.dgSyntax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgSyntax.Size = new System.Drawing.Size(491, 225);
            this.dgSyntax.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Element";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Text";
            this.Column2.Name = "Column2";
            this.Column2.Width = 34;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Text Color";
            this.Column3.Name = "Column3";
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Back";
            this.Column4.Name = "Column4";
            this.Column4.Width = 38;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Back Color";
            this.Column5.Name = "Column5";
            this.Column5.Width = 89;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Sample";
            this.Column6.Name = "Column6";
            // 
            // chkSyntaxDelim
            // 
            this.chkSyntaxDelim.AutoSize = true;
            this.chkSyntaxDelim.Checked = true;
            this.chkSyntaxDelim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSyntaxDelim.Location = new System.Drawing.Point(328, 35);
            this.chkSyntaxDelim.Name = "chkSyntaxDelim";
            this.chkSyntaxDelim.Size = new System.Drawing.Size(179, 19);
            this.chkSyntaxDelim.TabIndex = 13;
            this.chkSyntaxDelim.Text = "Highlight function delimiters";
            this.toolTip1.SetToolTip(this.chkSyntaxDelim, "Shade the delimiters (commas and parethesis) of the function under the cursor pos" +
        "ition");
            this.chkSyntaxDelim.UseVisualStyleBackColor = true;
            // 
            // chkSyntaxFunction
            // 
            this.chkSyntaxFunction.AutoSize = true;
            this.chkSyntaxFunction.Checked = true;
            this.chkSyntaxFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSyntaxFunction.Location = new System.Drawing.Point(328, 10);
            this.chkSyntaxFunction.Name = "chkSyntaxFunction";
            this.chkSyntaxFunction.Size = new System.Drawing.Size(165, 19);
            this.chkSyntaxFunction.TabIndex = 13;
            this.chkSyntaxFunction.Text = "Highlight current function";
            this.toolTip1.SetToolTip(this.chkSyntaxFunction, "Shade the full text of the function under the cursor position");
            this.chkSyntaxFunction.UseVisualStyleBackColor = true;
            // 
            // chkSyntax
            // 
            this.chkSyntax.AutoSize = true;
            this.chkSyntax.Checked = true;
            this.chkSyntax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSyntax.Location = new System.Drawing.Point(16, 10);
            this.chkSyntax.Name = "chkSyntax";
            this.chkSyntax.Size = new System.Drawing.Size(165, 19);
            this.chkSyntax.TabIndex = 13;
            this.chkSyntax.Text = "Enable syntax highlighting";
            this.toolTip1.SetToolTip(this.chkSyntax, "Colorize language elements");
            this.chkSyntax.UseVisualStyleBackColor = true;
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 399);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZELDA Settings";
            this.Load += new System.EventHandler(this.SettingsUI_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsUI_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaySlide)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSyntax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar delaySlide;
        private System.Windows.Forms.CheckBox chkLoadPlaylist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ddFont;
        private System.Windows.Forms.ComboBox ddFontSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgSyntax;
        private System.Windows.Forms.CheckBox chkSyntax;
        private System.Windows.Forms.CheckBox chkSaveTabs;
        private System.Windows.Forms.CheckBox chkLines;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chkIndent;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtExtraFuncs;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTabs;
        private System.Windows.Forms.CheckBox chkDark;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.CheckBox chkSyntaxDelim;
        private System.Windows.Forms.CheckBox chkSyntaxFunction;
        private System.Windows.Forms.CheckBox chkMaximize;
        private System.Windows.Forms.CheckBox chkAPITime;
        private System.Windows.Forms.CheckBox chkSaveView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}