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
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMCWS = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.optAutomation = new System.Windows.Forms.RadioButton();
            this.optMCWS = new System.Windows.Forms.RadioButton();
            this.tabPrefs = new System.Windows.Forms.TabPage();
            this.delaySlide = new System.Windows.Forms.TrackBar();
            this.lblDelay = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPlaylistFilter = new System.Windows.Forms.TextBox();
            this.txtTooltip = new System.Windows.Forms.TextBox();
            this.chkPlaylistFilter = new System.Windows.Forms.CheckBox();
            this.chkTooltip = new System.Windows.Forms.CheckBox();
            this.chkSaveTabs = new System.Windows.Forms.CheckBox();
            this.chkFastStart = new System.Windows.Forms.CheckBox();
            this.chkMaximize = new System.Windows.Forms.CheckBox();
            this.chkTabs = new System.Windows.Forms.CheckBox();
            this.chkAPITime = new System.Windows.Forms.CheckBox();
            this.chkIndent = new System.Windows.Forms.CheckBox();
            this.chkLines = new System.Windows.Forms.CheckBox();
            this.chkSaveView = new System.Windows.Forms.CheckBox();
            this.chkLoadPlaylist = new System.Windows.Forms.CheckBox();
            this.tabColors = new System.Windows.Forms.TabPage();
            this.txtExtraFuncs = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkSyntaxComments = new System.Windows.Forms.CheckBox();
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
            this.tabControl1.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.panelMCWS.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(364, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabConnection);
            this.tabControl1.Controls.Add(this.tabPrefs);
            this.tabControl1.Controls.Add(this.tabColors);
            this.tabControl1.Controls.Add(this.tabCustomize);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 275);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.label1);
            this.tabConnection.Controls.Add(this.panelMCWS);
            this.tabConnection.Controls.Add(this.btnTestConnection);
            this.tabConnection.Controls.Add(this.optAutomation);
            this.tabConnection.Controls.Add(this.optMCWS);
            this.tabConnection.Location = new System.Drawing.Point(4, 24);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(457, 247);
            this.tabConnection.TabIndex = 3;
            this.tabConnection.Text = "Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select a method to connect to MC:";
            // 
            // panelMCWS
            // 
            this.panelMCWS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMCWS.Controls.Add(this.label6);
            this.panelMCWS.Controls.Add(this.label7);
            this.panelMCWS.Controls.Add(this.lblServer);
            this.panelMCWS.Controls.Add(this.txtUsername);
            this.panelMCWS.Controls.Add(this.txtPassword);
            this.panelMCWS.Controls.Add(this.txtServer);
            this.panelMCWS.Location = new System.Drawing.Point(8, 89);
            this.panelMCWS.Name = "panelMCWS";
            this.panelMCWS.Size = new System.Drawing.Size(434, 111);
            this.panelMCWS.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username:";
            // 
            // lblServer
            // 
            this.lblServer.Image = global::Zelda.Properties.Resources.help;
            this.lblServer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblServer.Location = new System.Drawing.Point(22, 12);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(67, 15);
            this.lblServer.TabIndex = 15;
            this.lblServer.Text = "Server:";
            this.toolTip1.SetToolTip(this.lblServer, resources.GetString("lblServer.ToolTip"));
            this.lblServer.Click += new System.EventHandler(this.lblServer_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(91, 38);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 23);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.connection_Changed);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(91, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.connection_Changed);
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(91, 9);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(331, 23);
            this.txtServer.TabIndex = 3;
            this.txtServer.Text = "http://localhost:52199";
            this.txtServer.TextChanged += new System.EventHandler(this.connection_Changed);
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.Location = new System.Drawing.Point(16, 206);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(112, 27);
            this.btnTestConnection.TabIndex = 6;
            this.btnTestConnection.Text = "Test connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // optAutomation
            // 
            this.optAutomation.AutoSize = true;
            this.optAutomation.Checked = true;
            this.optAutomation.Location = new System.Drawing.Point(16, 45);
            this.optAutomation.Name = "optAutomation";
            this.optAutomation.Size = new System.Drawing.Size(110, 19);
            this.optAutomation.TabIndex = 1;
            this.optAutomation.TabStop = true;
            this.optAutomation.Text = "Automation API";
            this.toolTip1.SetToolTip(this.optAutomation, "MC must be installed in this computer");
            this.optAutomation.UseVisualStyleBackColor = true;
            this.optAutomation.CheckedChanged += new System.EventHandler(this.optMCWS_CheckedChanged);
            // 
            // optMCWS
            // 
            this.optMCWS.AutoSize = true;
            this.optMCWS.Location = new System.Drawing.Point(16, 70);
            this.optMCWS.Name = "optMCWS";
            this.optMCWS.Size = new System.Drawing.Size(61, 19);
            this.optMCWS.TabIndex = 2;
            this.optMCWS.Text = "MCWS";
            this.toolTip1.SetToolTip(this.optMCWS, "Connect to Network or Local MC server");
            this.optMCWS.UseVisualStyleBackColor = true;
            this.optMCWS.CheckedChanged += new System.EventHandler(this.optMCWS_CheckedChanged);
            // 
            // tabPrefs
            // 
            this.tabPrefs.Controls.Add(this.delaySlide);
            this.tabPrefs.Controls.Add(this.lblDelay);
            this.tabPrefs.Controls.Add(this.label17);
            this.tabPrefs.Controls.Add(this.txtPlaylistFilter);
            this.tabPrefs.Controls.Add(this.txtTooltip);
            this.tabPrefs.Controls.Add(this.chkPlaylistFilter);
            this.tabPrefs.Controls.Add(this.chkTooltip);
            this.tabPrefs.Controls.Add(this.chkSaveTabs);
            this.tabPrefs.Controls.Add(this.chkFastStart);
            this.tabPrefs.Controls.Add(this.chkMaximize);
            this.tabPrefs.Controls.Add(this.chkTabs);
            this.tabPrefs.Controls.Add(this.chkAPITime);
            this.tabPrefs.Controls.Add(this.chkIndent);
            this.tabPrefs.Controls.Add(this.chkLines);
            this.tabPrefs.Controls.Add(this.chkSaveView);
            this.tabPrefs.Controls.Add(this.chkLoadPlaylist);
            this.tabPrefs.Location = new System.Drawing.Point(4, 24);
            this.tabPrefs.Name = "tabPrefs";
            this.tabPrefs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrefs.Size = new System.Drawing.Size(457, 247);
            this.tabPrefs.TabIndex = 0;
            this.tabPrefs.Text = "Preferences";
            this.tabPrefs.UseVisualStyleBackColor = true;
            // 
            // delaySlide
            // 
            this.delaySlide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delaySlide.AutoSize = false;
            this.delaySlide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.delaySlide.LargeChange = 200;
            this.delaySlide.Location = new System.Drawing.Point(114, 213);
            this.delaySlide.Maximum = 2000;
            this.delaySlide.Minimum = 100;
            this.delaySlide.Name = "delaySlide";
            this.delaySlide.Size = new System.Drawing.Size(289, 25);
            this.delaySlide.SmallChange = 50;
            this.delaySlide.TabIndex = 10;
            this.delaySlide.TickFrequency = 50;
            this.delaySlide.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.delaySlide, "Delay after typing stops before recalculating the expression result");
            this.delaySlide.Value = 500;
            this.delaySlide.ValueChanged += new System.EventHandler(this.delaySlide_ValueChanged);
            // 
            // lblDelay
            // 
            this.lblDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(403, 214);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(44, 15);
            this.lblDelay.TabIndex = 29;
            this.lblDelay.Text = "500 ms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 213);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 15);
            this.label17.TabIndex = 30;
            this.label17.Text = "Evaluation delay:";
            // 
            // txtPlaylistFilter
            // 
            this.txtPlaylistFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaylistFilter.Enabled = false;
            this.txtPlaylistFilter.Location = new System.Drawing.Point(124, 138);
            this.txtPlaylistFilter.Name = "txtPlaylistFilter";
            this.txtPlaylistFilter.Size = new System.Drawing.Size(323, 23);
            this.txtPlaylistFilter.TabIndex = 7;
            this.txtPlaylistFilter.TextChanged += new System.EventHandler(this.connection_Changed);
            // 
            // txtTooltip
            // 
            this.txtTooltip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTooltip.Enabled = false;
            this.txtTooltip.Location = new System.Drawing.Point(124, 167);
            this.txtTooltip.Name = "txtTooltip";
            this.txtTooltip.Size = new System.Drawing.Size(323, 23);
            this.txtTooltip.TabIndex = 9;
            // 
            // chkPlaylistFilter
            // 
            this.chkPlaylistFilter.AutoSize = true;
            this.chkPlaylistFilter.Location = new System.Drawing.Point(14, 140);
            this.chkPlaylistFilter.Name = "chkPlaylistFilter";
            this.chkPlaylistFilter.Size = new System.Drawing.Size(95, 19);
            this.chkPlaylistFilter.TabIndex = 6;
            this.chkPlaylistFilter.Text = "Playlist Filter:";
            this.toolTip1.SetToolTip(this.chkPlaylistFilter, resources.GetString("chkPlaylistFilter.ToolTip"));
            this.chkPlaylistFilter.UseVisualStyleBackColor = true;
            this.chkPlaylistFilter.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            this.chkPlaylistFilter.TextChanged += new System.EventHandler(this.connection_Changed);
            // 
            // chkTooltip
            // 
            this.chkTooltip.AutoSize = true;
            this.chkTooltip.Location = new System.Drawing.Point(14, 169);
            this.chkTooltip.Name = "chkTooltip";
            this.chkTooltip.Size = new System.Drawing.Size(101, 19);
            this.chkTooltip.TabIndex = 8;
            this.chkTooltip.Text = "Tooltip Folder:";
            this.toolTip1.SetToolTip(this.chkTooltip, "Set this path in case Zelda doesn\'t detect the Tooltip: location correctly.\r\nLeav" +
        "e blank to autodetect the Tooltip folder.");
            this.chkTooltip.UseVisualStyleBackColor = true;
            this.chkTooltip.CheckedChanged += new System.EventHandler(this.chkbox_CheckedChanged);
            // 
            // chkSaveTabs
            // 
            this.chkSaveTabs.AutoSize = true;
            this.chkSaveTabs.Checked = true;
            this.chkSaveTabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveTabs.Location = new System.Drawing.Point(14, 16);
            this.chkSaveTabs.Name = "chkSaveTabs";
            this.chkSaveTabs.Size = new System.Drawing.Size(185, 19);
            this.chkSaveTabs.TabIndex = 1;
            this.chkSaveTabs.Text = "Auto-save/restore expressions";
            this.chkSaveTabs.UseVisualStyleBackColor = true;
            // 
            // chkFastStart
            // 
            this.chkFastStart.AutoSize = true;
            this.chkFastStart.Location = new System.Drawing.Point(14, 91);
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
            this.chkMaximize.Location = new System.Drawing.Point(224, 116);
            this.chkMaximize.Name = "chkMaximize";
            this.chkMaximize.Size = new System.Drawing.Size(111, 19);
            this.chkMaximize.TabIndex = 4;
            this.chkMaximize.Text = "Start maximized";
            this.chkMaximize.UseVisualStyleBackColor = true;
            this.chkMaximize.Visible = false;
            // 
            // chkTabs
            // 
            this.chkTabs.AutoSize = true;
            this.chkTabs.Checked = true;
            this.chkTabs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTabs.Location = new System.Drawing.Point(224, 66);
            this.chkTabs.Name = "chkTabs";
            this.chkTabs.Size = new System.Drawing.Size(169, 19);
            this.chkTabs.TabIndex = 13;
            this.chkTabs.Text = "Insert spaces instead of Tab";
            this.chkTabs.UseVisualStyleBackColor = true;
            // 
            // chkAPITime
            // 
            this.chkAPITime.AutoSize = true;
            this.chkAPITime.Checked = true;
            this.chkAPITime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAPITime.Location = new System.Drawing.Point(224, 91);
            this.chkAPITime.Name = "chkAPITime";
            this.chkAPITime.Size = new System.Drawing.Size(211, 19);
            this.chkAPITime.TabIndex = 14;
            this.chkAPITime.Text = "Show API call times in Playlist table";
            this.chkAPITime.UseVisualStyleBackColor = true;
            // 
            // chkIndent
            // 
            this.chkIndent.AutoSize = true;
            this.chkIndent.Checked = true;
            this.chkIndent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIndent.Location = new System.Drawing.Point(224, 41);
            this.chkIndent.Name = "chkIndent";
            this.chkIndent.Size = new System.Drawing.Size(136, 19);
            this.chkIndent.TabIndex = 12;
            this.chkIndent.Text = "Indent wrapped lines";
            this.chkIndent.UseVisualStyleBackColor = true;
            // 
            // chkLines
            // 
            this.chkLines.AutoSize = true;
            this.chkLines.Checked = true;
            this.chkLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLines.Location = new System.Drawing.Point(224, 16);
            this.chkLines.Name = "chkLines";
            this.chkLines.Size = new System.Drawing.Size(127, 19);
            this.chkLines.TabIndex = 11;
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
            this.chkSaveView.TabIndex = 2;
            this.chkSaveView.Text = "Remember view settings";
            this.chkSaveView.UseVisualStyleBackColor = true;
            // 
            // chkLoadPlaylist
            // 
            this.chkLoadPlaylist.AutoSize = true;
            this.chkLoadPlaylist.Location = new System.Drawing.Point(14, 66);
            this.chkLoadPlaylist.Name = "chkLoadPlaylist";
            this.chkLoadPlaylist.Size = new System.Drawing.Size(180, 19);
            this.chkLoadPlaylist.TabIndex = 3;
            this.chkLoadPlaylist.Text = "Reload last playlist on startup";
            this.chkLoadPlaylist.UseVisualStyleBackColor = true;
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
            this.tabColors.Size = new System.Drawing.Size(457, 247);
            this.tabColors.TabIndex = 1;
            this.tabColors.Text = "Colors";
            this.tabColors.UseVisualStyleBackColor = true;
            // 
            // txtExtraFuncs
            // 
            this.txtExtraFuncs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtraFuncs.Location = new System.Drawing.Point(239, 34);
            this.txtExtraFuncs.Multiline = true;
            this.txtExtraFuncs.Name = "txtExtraFuncs";
            this.txtExtraFuncs.Size = new System.Drawing.Size(208, 51);
            this.txtExtraFuncs.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtExtraFuncs, "Add new function names for highlighting, separated by space.\r\nThis allows ZELDA t" +
        "o recognized recently added functions.\r\n\r\nRequires application restart to take e" +
        "ffect.");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(239, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(183, 15);
            this.label20.TabIndex = 15;
            this.label20.Text = "Additional functions to highlight:";
            // 
            // chkSyntaxComments
            // 
            this.chkSyntaxComments.AutoSize = true;
            this.chkSyntaxComments.Checked = true;
            this.chkSyntaxComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSyntaxComments.Location = new System.Drawing.Point(14, 91);
            this.chkSyntaxComments.Name = "chkSyntaxComments";
            this.chkSyntaxComments.Size = new System.Drawing.Size(193, 19);
            this.chkSyntaxComments.TabIndex = 4;
            this.chkSyntaxComments.Text = "Comment lines starting with ##";
            this.chkSyntaxComments.UseVisualStyleBackColor = true;
            // 
            // chkSyntaxDelim
            // 
            this.chkSyntaxDelim.AutoSize = true;
            this.chkSyntaxDelim.Checked = true;
            this.chkSyntaxDelim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSyntaxDelim.Location = new System.Drawing.Point(14, 66);
            this.chkSyntaxDelim.Name = "chkSyntaxDelim";
            this.chkSyntaxDelim.Size = new System.Drawing.Size(179, 19);
            this.chkSyntaxDelim.TabIndex = 3;
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
            this.chkSyntaxFunction.TabIndex = 2;
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
            this.chkSyntax.TabIndex = 1;
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
            this.radio2.TabIndex = 7;
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
            this.radio1.TabIndex = 6;
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
            this.groupBox2.Size = new System.Drawing.Size(433, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnBackColor
            // 
            this.btnBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackColor.AutoSize = true;
            this.btnBackColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackColor.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackColor.Location = new System.Drawing.Point(355, 79);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(71, 15);
            this.btnBackColor.TabIndex = 12;
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
            this.btnFont.Location = new System.Drawing.Point(355, 29);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(29, 15);
            this.btnFont.TabIndex = 10;
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
            this.btnTextColor.Location = new System.Drawing.Point(355, 54);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(57, 15);
            this.btnTextColor.TabIndex = 11;
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
            this.lblSampleColor.Size = new System.Drawing.Size(337, 70);
            this.lblSampleColor.TabIndex = 9;
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
            this.tabCustomize.Size = new System.Drawing.Size(457, 247);
            this.tabCustomize.TabIndex = 2;
            this.tabCustomize.Text = "Customize";
            this.tabCustomize.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 20);
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
            this.comboBox1.Location = new System.Drawing.Point(381, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 23);
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
            this.dgSyntax.RowHeadersWidth = 51;
            this.dgSyntax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgSyntax.Size = new System.Drawing.Size(439, 173);
            this.dgSyntax.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Element";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Text";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 34;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Text Color";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Back";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 38;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Back Color";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 89;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Sample";
            this.Column6.MinimumWidth = 6;
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
            // SettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 313);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZELDA Settings";
            this.Load += new System.EventHandler(this.SettingsUI_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingsUI_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.panelMCWS.ResumeLayout(false);
            this.panelMCWS.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkLoadPlaylist;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.CheckBox chkFastStart;
        private System.Windows.Forms.TabPage tabCustomize;
        private System.Windows.Forms.CheckBox chkSyntaxComments;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton optMCWS;
        private System.Windows.Forms.RadioButton optAutomation;
        private System.Windows.Forms.TrackBar delaySlide;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPlaylistFilter;
        private System.Windows.Forms.TextBox txtTooltip;
        private System.Windows.Forms.CheckBox chkPlaylistFilter;
        private System.Windows.Forms.CheckBox chkTooltip;
        private System.Windows.Forms.Panel panelMCWS;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label label1;
    }
}