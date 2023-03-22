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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUI));
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrefs = new System.Windows.Forms.TabPage();
            this.txtPlaylistFilter = new System.Windows.Forms.TextBox();
            this.txtTooltip = new System.Windows.Forms.TextBox();
            this.delaySlide = new System.Windows.Forms.TrackBar();
            this.chkSaveTabs = new System.Windows.Forms.CheckBox();
            this.chkPlaylistFilter = new System.Windows.Forms.CheckBox();
            this.chkTooltip = new System.Windows.Forms.CheckBox();
            this.chkFastStart = new System.Windows.Forms.CheckBox();
            this.chkMaximize = new System.Windows.Forms.CheckBox();
            this.chkTabs = new System.Windows.Forms.CheckBox();
            this.chkAPITime = new System.Windows.Forms.CheckBox();
            this.chkIndent = new System.Windows.Forms.CheckBox();
            this.chkLines = new System.Windows.Forms.CheckBox();
            this.chkSaveView = new System.Windows.Forms.CheckBox();
            this.chkLoadPlaylist = new System.Windows.Forms.CheckBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabColors = new System.Windows.Forms.TabPage();
            this.txtExtraFuncs = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkSyntaxDelim = new System.Windows.Forms.CheckBox();
            this.chkSyntaxFunction = new System.Windows.Forms.CheckBox();
            this.chkSyntax = new System.Windows.Forms.CheckBox();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBackColor = new System.Windows.Forms.LinkLabel();
            this.btnFont = new System.Windows.Forms.LinkLabel();
            this.btnTextColor = new System.Windows.Forms.LinkLabel();
            this.lblSampleColor = new System.Windows.Forms.Label();
            this.tabCustomize = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSyntax = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.chkSyntaxComments = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPrefs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaySlide)).BeginInit();
            this.tabColors.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabCustomize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSyntax)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(427, 290);
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
            this.tabControl1.Controls.Add(this.tabPrefs);
            this.tabControl1.Controls.Add(this.tabColors);
            this.tabControl1.Controls.Add(this.tabCustomize);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 285);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPrefs
            // 
            this.tabPrefs.Controls.Add(this.txtPlaylistFilter);
            this.tabPrefs.Controls.Add(this.txtTooltip);
            this.tabPrefs.Controls.Add(this.delaySlide);
            this.tabPrefs.Controls.Add(this.chkSaveTabs);
            this.tabPrefs.Controls.Add(this.chkPlaylistFilter);
            this.tabPrefs.Controls.Add(this.chkTooltip);
            this.tabPrefs.Controls.Add(this.chkFastStart);
            this.tabPrefs.Controls.Add(this.chkMaximize);
            this.tabPrefs.Controls.Add(this.chkTabs);
            this.tabPrefs.Controls.Add(this.chkAPITime);
            this.tabPrefs.Controls.Add(this.chkIndent);
            this.tabPrefs.Controls.Add(this.chkLines);
            this.tabPrefs.Controls.Add(this.chkSaveView);
            this.tabPrefs.Controls.Add(this.chkLoadPlaylist);
            this.tabPrefs.Controls.Add(this.lblDelay);
            this.tabPrefs.Controls.Add(this.label17);
            this.tabPrefs.Location = new System.Drawing.Point(4, 24);
            this.tabPrefs.Name = "tabPrefs";
            this.tabPrefs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrefs.Size = new System.Drawing.Size(520, 257);
            this.tabPrefs.TabIndex = 0;
            this.tabPrefs.Text = "Preferences";
            this.tabPrefs.UseVisualStyleBackColor = true;
            // 
            // txtPlaylistFilter
            // 
            this.txtPlaylistFilter.Enabled = false;
            this.txtPlaylistFilter.Location = new System.Drawing.Point(122, 153);
            this.txtPlaylistFilter.Name = "txtPlaylistFilter";
            this.txtPlaylistFilter.Size = new System.Drawing.Size(383, 23);
            this.txtPlaylistFilter.TabIndex = 9;
            // 
            // txtTooltip
            // 
            this.txtTooltip.Enabled = false;
            this.txtTooltip.Location = new System.Drawing.Point(122, 183);
            this.txtTooltip.Name = "txtTooltip";
            this.txtTooltip.Size = new System.Drawing.Size(383, 23);
            this.txtTooltip.TabIndex = 9;
            // 
            // delaySlide
            // 
            this.delaySlide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delaySlide.AutoSize = false;
            this.delaySlide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.delaySlide.LargeChange = 200;
            this.delaySlide.Location = new System.Drawing.Point(115, 224);
            this.delaySlide.Maximum = 2000;
            this.delaySlide.Minimum = 100;
            this.delaySlide.Name = "delaySlide";
            this.delaySlide.Size = new System.Drawing.Size(345, 25);
            this.delaySlide.SmallChange = 50;
            this.delaySlide.TabIndex = 6;
            this.delaySlide.TickFrequency = 50;
            this.delaySlide.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.delaySlide, "Delay after typing stops before recalculating the expression result");
            this.delaySlide.Value = 500;
            this.delaySlide.ValueChanged += new System.EventHandler(this.delaySlide_ValueChanged);
            // 
            // chkSaveTabs
            // 
            this.chkSaveTabs.AutoSize = true;
            this.chkSaveTabs.Checked = true;
            this.chkSaveTabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveTabs.Location = new System.Drawing.Point(14, 16);
            this.chkSaveTabs.Name = "chkSaveTabs";
            this.chkSaveTabs.Size = new System.Drawing.Size(185, 19);
            this.chkSaveTabs.TabIndex = 5;
            this.chkSaveTabs.Text = "Auto-save/restore expressions";
            this.chkSaveTabs.UseVisualStyleBackColor = true;
            // 
            // chkPlaylistFilter
            // 
            this.chkPlaylistFilter.AutoSize = true;
            this.chkPlaylistFilter.Location = new System.Drawing.Point(14, 155);
            this.chkPlaylistFilter.Name = "chkPlaylistFilter";
            this.chkPlaylistFilter.Size = new System.Drawing.Size(95, 19);
            this.chkPlaylistFilter.TabIndex = 5;
            this.chkPlaylistFilter.Text = "Playlist Filter:";
            this.toolTip1.SetToolTip(this.chkPlaylistFilter, resources.GetString("chkPlaylistFilter.ToolTip"));
            this.chkPlaylistFilter.UseVisualStyleBackColor = true;
            this.chkPlaylistFilter.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            // 
            // chkTooltip
            // 
            this.chkTooltip.AutoSize = true;
            this.chkTooltip.Location = new System.Drawing.Point(14, 185);
            this.chkTooltip.Name = "chkTooltip";
            this.chkTooltip.Size = new System.Drawing.Size(101, 19);
            this.chkTooltip.TabIndex = 5;
            this.chkTooltip.Text = "Tooltip Folder:";
            this.toolTip1.SetToolTip(this.chkTooltip, "Set this path in case Zelda doesn\'t detect the Tooltip: location correctly.\r\nLeav" +
        "e blank to autodetect the Tooltip folder.");
            this.chkTooltip.UseVisualStyleBackColor = true;
            this.chkTooltip.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            // 
            // chkFastStart
            // 
            this.chkFastStart.AutoSize = true;
            this.chkFastStart.Location = new System.Drawing.Point(14, 116);
            this.chkFastStart.Name = "chkFastStart";
            this.chkFastStart.Size = new System.Drawing.Size(73, 19);
            this.chkFastStart.TabIndex = 5;
            this.chkFastStart.Text = "Fast start";
            this.toolTip1.SetToolTip(this.chkFastStart, "Enable this option to get just the Playlist names without the file count for each" +
        " one.\r\nGetting the filecount for many playlists can be slow, specially for Smart" +
        "lists.");
            this.chkFastStart.UseVisualStyleBackColor = true;
            // 
            // chkMaximize
            // 
            this.chkMaximize.AutoSize = true;
            this.chkMaximize.Checked = true;
            this.chkMaximize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaximize.Location = new System.Drawing.Point(14, 91);
            this.chkMaximize.Name = "chkMaximize";
            this.chkMaximize.Size = new System.Drawing.Size(111, 19);
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
            this.chkTabs.Size = new System.Drawing.Size(169, 19);
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
            this.lblDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(461, 227);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(44, 15);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "500 ms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Evaluation delay:";
            // 
            // tabColors
            // 
            this.tabColors.Controls.Add(this.txtExtraFuncs);
            this.tabColors.Controls.Add(this.label20);
            this.tabColors.Controls.Add(this.chkSyntaxComments);
            this.tabColors.Controls.Add(this.chkSyntaxDelim);
            this.tabColors.Controls.Add(this.chkSyntaxFunction);
            this.tabColors.Controls.Add(this.chkSyntax);
            this.tabColors.Controls.Add(this.radio3);
            this.tabColors.Controls.Add(this.radio2);
            this.tabColors.Controls.Add(this.radio1);
            this.tabColors.Controls.Add(this.groupBox2);
            this.tabColors.Location = new System.Drawing.Point(4, 24);
            this.tabColors.Name = "tabColors";
            this.tabColors.Padding = new System.Windows.Forms.Padding(3);
            this.tabColors.Size = new System.Drawing.Size(520, 257);
            this.tabColors.TabIndex = 1;
            this.tabColors.Text = "Colors";
            this.tabColors.UseVisualStyleBackColor = true;
            // 
            // txtExtraFuncs
            // 
            this.txtExtraFuncs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtraFuncs.Location = new System.Drawing.Point(254, 34);
            this.txtExtraFuncs.Multiline = true;
            this.txtExtraFuncs.Name = "txtExtraFuncs";
            this.txtExtraFuncs.Size = new System.Drawing.Size(251, 51);
            this.txtExtraFuncs.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtExtraFuncs, "Add new function names for highlighting, separated by space.\r\nThis allows ZELDA t" +
        "o recognized recently added functions.\r\n\r\nRequires application restart to take e" +
        "ffect.");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(251, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 15);
            this.label20.TabIndex = 15;
            this.label20.Text = "Additional functions to highlight:";
            // 
            // chkSyntaxDelim
            // 
            this.chkSyntaxDelim.AutoSize = true;
            this.chkSyntaxDelim.Checked = true;
            this.chkSyntaxDelim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSyntaxDelim.Location = new System.Drawing.Point(14, 66);
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
            this.chkSyntaxFunction.Location = new System.Drawing.Point(14, 41);
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
            this.chkSyntax.Location = new System.Drawing.Point(14, 16);
            this.chkSyntax.Name = "chkSyntax";
            this.chkSyntax.Size = new System.Drawing.Size(166, 19);
            this.chkSyntax.TabIndex = 13;
            this.chkSyntax.Text = "Enable syntax highlighting";
            this.toolTip1.SetToolTip(this.chkSyntax, "Colorize language elements");
            this.chkSyntax.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio3.BackColor = System.Drawing.Color.White;
            this.radio3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.radio3.FlatAppearance.BorderSize = 0;
            this.radio3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.radio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio3.Location = new System.Drawing.Point(167, 127);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(73, 22);
            this.radio3.TabIndex = 8;
            this.radio3.Text = "Rendered Output";
            this.radio3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio3.UseVisualStyleBackColor = false;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio2.BackColor = System.Drawing.Color.White;
            this.radio2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.radio2.FlatAppearance.BorderSize = 0;
            this.radio2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.radio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio2.Location = new System.Drawing.Point(81, 127);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(87, 22);
            this.radio2.TabIndex = 8;
            this.radio2.Text = "Text Output";
            this.radio2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio2.UseVisualStyleBackColor = false;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio1.BackColor = System.Drawing.Color.White;
            this.radio1.Checked = true;
            this.radio1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.radio1.FlatAppearance.BorderSize = 0;
            this.radio1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.radio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio1.Location = new System.Drawing.Point(27, 127);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(54, 22);
            this.radio1.TabIndex = 8;
            this.radio1.TabStop = true;
            this.radio1.Text = "Editor";
            this.radio1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio1.UseVisualStyleBackColor = false;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBackColor);
            this.groupBox2.Controls.Add(this.btnFont);
            this.groupBox2.Controls.Add(this.btnTextColor);
            this.groupBox2.Controls.Add(this.lblSampleColor);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnBackColor
            // 
            this.btnBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackColor.AutoSize = true;
            this.btnBackColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackColor.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackColor.Location = new System.Drawing.Point(414, 79);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(71, 15);
            this.btnBackColor.TabIndex = 9;
            this.btnBackColor.TabStop = true;
            this.btnBackColor.Text = "background";
            this.btnBackColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnBackColor_LinkClicked);
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFont.AutoSize = true;
            this.btnFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFont.Location = new System.Drawing.Point(414, 29);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(29, 15);
            this.btnFont.TabIndex = 9;
            this.btnFont.TabStop = true;
            this.btnFont.Text = "font";
            this.btnFont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnFont_LinkClicked);
            // 
            // btnTextColor
            // 
            this.btnTextColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTextColor.AutoSize = true;
            this.btnTextColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextColor.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTextColor.Location = new System.Drawing.Point(414, 54);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(57, 15);
            this.btnTextColor.TabIndex = 9;
            this.btnTextColor.TabStop = true;
            this.btnTextColor.Text = "text color";
            this.btnTextColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnTextColor_LinkClicked);
            // 
            // lblSampleColor
            // 
            this.lblSampleColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSampleColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSampleColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSampleColor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleColor.ForeColor = System.Drawing.Color.White;
            this.lblSampleColor.Location = new System.Drawing.Point(13, 29);
            this.lblSampleColor.Name = "lblSampleColor";
            this.lblSampleColor.Padding = new System.Windows.Forms.Padding(3);
            this.lblSampleColor.Size = new System.Drawing.Size(395, 70);
            this.lblSampleColor.TabIndex = 3;
            this.lblSampleColor.Text = resources.GetString("lblSampleColor.Text");
            // 
            // tabCustomize
            // 
            this.tabCustomize.Controls.Add(this.label3);
            this.tabCustomize.Controls.Add(this.comboBox1);
            this.tabCustomize.Controls.Add(this.label2);
            this.tabCustomize.Controls.Add(this.dgSyntax);
            this.tabCustomize.Location = new System.Drawing.Point(4, 24);
            this.tabCustomize.Name = "tabCustomize";
            this.tabCustomize.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomize.Size = new System.Drawing.Size(520, 257);
            this.tabCustomize.TabIndex = 2;
            this.tabCustomize.Text = "Customize";
            this.tabCustomize.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preset:";
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Default - Dark",
            "Custom",
            "Custom - Dark"});
            this.comboBox1.Location = new System.Drawing.Point(389, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Custom colors are not yet implemented";
            // 
            // dgSyntax
            // 
            this.dgSyntax.AllowUserToAddRows = false;
            this.dgSyntax.AllowUserToDeleteRows = false;
            this.dgSyntax.AllowUserToResizeColumns = false;
            this.dgSyntax.AllowUserToResizeRows = false;
            this.dgSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgSyntax.Location = new System.Drawing.Point(8, 55);
            this.dgSyntax.Name = "dgSyntax";
            this.dgSyntax.RowHeadersVisible = false;
            this.dgSyntax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgSyntax.Size = new System.Drawing.Size(502, 173);
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
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.AllowVerticalFonts = false;
            this.fontDialog.FontMustExist = true;
            this.fontDialog.MaxSize = 48;
            this.fontDialog.MinSize = 6;
            this.fontDialog.ShowEffects = false;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // chkComments
            // 
            this.chkSyntaxComments.AutoSize = true;
            this.chkSyntaxComments.Checked = true;
            this.chkSyntaxComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSyntaxComments.Location = new System.Drawing.Point(14, 91);
            this.chkSyntaxComments.Name = "chkComments";
            this.chkSyntaxComments.Size = new System.Drawing.Size(193, 19);
            this.chkSyntaxComments.TabIndex = 13;
            this.chkSyntaxComments.Text = "Comment lines starting with ##";
            this.chkSyntaxComments.UseVisualStyleBackColor = true;
            // 
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 323);
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
            this.tabPrefs.ResumeLayout(false);
            this.tabPrefs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaySlide)).EndInit();
            this.tabColors.ResumeLayout(false);
            this.tabColors.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabCustomize.ResumeLayout(false);
            this.tabCustomize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSyntax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrefs;
        private System.Windows.Forms.TrackBar delaySlide;
        private System.Windows.Forms.CheckBox chkLoadPlaylist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabColors;
        private System.Windows.Forms.DataGridView dgSyntax;
        private System.Windows.Forms.CheckBox chkSyntax;
        private System.Windows.Forms.CheckBox chkSaveTabs;
        private System.Windows.Forms.CheckBox chkLines;
        private System.Windows.Forms.Label lblSampleColor;
        private System.Windows.Forms.CheckBox chkIndent;
        private System.Windows.Forms.LinkLabel btnBackColor;
        private System.Windows.Forms.LinkLabel btnTextColor;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.TextBox txtExtraFuncs;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkTabs;
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
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.LinkLabel btnFont;
        private System.Windows.Forms.TextBox txtTooltip;
        private System.Windows.Forms.CheckBox chkTooltip;
        private System.Windows.Forms.TextBox txtPlaylistFilter;
        private System.Windows.Forms.CheckBox chkPlaylistFilter;
        private System.Windows.Forms.CheckBox chkFastStart;
        private System.Windows.Forms.TabPage tabCustomize;
        private System.Windows.Forms.CheckBox chkSyntaxComments;
    }
}