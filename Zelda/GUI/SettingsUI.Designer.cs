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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUI));
            btnSave = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabConnection = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            panelMCWS = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblServer = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtServer = new System.Windows.Forms.TextBox();
            btnTestConnection = new System.Windows.Forms.Button();
            optAutomation = new System.Windows.Forms.RadioButton();
            optMCWS = new System.Windows.Forms.RadioButton();
            tabPrefs = new System.Windows.Forms.TabPage();
            delaySlide = new System.Windows.Forms.TrackBar();
            lblDelay = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            txtPlaylistFilter = new System.Windows.Forms.TextBox();
            txtTooltip = new System.Windows.Forms.TextBox();
            chkPlaylistFilter = new System.Windows.Forms.CheckBox();
            chkTooltip = new System.Windows.Forms.CheckBox();
            chkSaveTabs = new System.Windows.Forms.CheckBox();
            chkFastStart = new System.Windows.Forms.CheckBox();
            chkSafeMode = new System.Windows.Forms.CheckBox();
            chkMaximize = new System.Windows.Forms.CheckBox();
            chkTabs = new System.Windows.Forms.CheckBox();
            chkAPITime = new System.Windows.Forms.CheckBox();
            chkIndent = new System.Windows.Forms.CheckBox();
            chkLines = new System.Windows.Forms.CheckBox();
            chkSaveView = new System.Windows.Forms.CheckBox();
            chkLoadPlaylist = new System.Windows.Forms.CheckBox();
            tabColors = new System.Windows.Forms.TabPage();
            txtExtraFuncs = new System.Windows.Forms.TextBox();
            label20 = new System.Windows.Forms.Label();
            chkSyntaxComments = new System.Windows.Forms.CheckBox();
            chkSyntaxDelim = new System.Windows.Forms.CheckBox();
            chkSyntaxFunction = new System.Windows.Forms.CheckBox();
            chkSyntax = new System.Windows.Forms.CheckBox();
            radio3 = new System.Windows.Forms.RadioButton();
            radio2 = new System.Windows.Forms.RadioButton();
            radio1 = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnBackColor = new System.Windows.Forms.LinkLabel();
            btnFont = new System.Windows.Forms.LinkLabel();
            btnTextColor = new System.Windows.Forms.LinkLabel();
            lblSampleColor = new System.Windows.Forms.Label();
            tabCustomize = new System.Windows.Forms.TabPage();
            label3 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            dgSyntax = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            fontDialog = new System.Windows.Forms.FontDialog();
            colorDialog = new System.Windows.Forms.ColorDialog();
            tabControl1.SuspendLayout();
            tabConnection.SuspendLayout();
            panelMCWS.SuspendLayout();
            tabPrefs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delaySlide).BeginInit();
            tabColors.SuspendLayout();
            groupBox2.SuspendLayout();
            tabCustomize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSyntax).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Location = new System.Drawing.Point(364, 280);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(87, 27);
            btnSave.TabIndex = 20;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabConnection);
            tabControl1.Controls.Add(tabPrefs);
            tabControl1.Controls.Add(tabColors);
            tabControl1.Controls.Add(tabCustomize);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(465, 275);
            tabControl1.TabIndex = 0;
            // 
            // tabConnection
            // 
            tabConnection.Controls.Add(label1);
            tabConnection.Controls.Add(panelMCWS);
            tabConnection.Controls.Add(btnTestConnection);
            tabConnection.Controls.Add(optAutomation);
            tabConnection.Controls.Add(optMCWS);
            tabConnection.Location = new System.Drawing.Point(4, 24);
            tabConnection.Name = "tabConnection";
            tabConnection.Padding = new System.Windows.Forms.Padding(3);
            tabConnection.Size = new System.Drawing.Size(457, 247);
            tabConnection.TabIndex = 3;
            tabConnection.Text = "Connection";
            tabConnection.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(13, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(200, 15);
            label1.TabIndex = 17;
            label1.Text = "Select a method to connect to MC:";
            // 
            // panelMCWS
            // 
            panelMCWS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelMCWS.Controls.Add(label6);
            panelMCWS.Controls.Add(label7);
            panelMCWS.Controls.Add(lblServer);
            panelMCWS.Controls.Add(txtUsername);
            panelMCWS.Controls.Add(txtPassword);
            panelMCWS.Controls.Add(txtServer);
            panelMCWS.Location = new System.Drawing.Point(8, 89);
            panelMCWS.Name = "panelMCWS";
            panelMCWS.Size = new System.Drawing.Size(434, 111);
            panelMCWS.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(22, 67);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 15);
            label6.TabIndex = 15;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(22, 41);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(63, 15);
            label7.TabIndex = 15;
            label7.Text = "Username:";
            // 
            // lblServer
            // 
            lblServer.Image = Properties.Resources.help;
            lblServer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblServer.Location = new System.Drawing.Point(22, 12);
            lblServer.Name = "lblServer";
            lblServer.Size = new System.Drawing.Size(67, 15);
            lblServer.TabIndex = 15;
            lblServer.Text = "Server:";
            toolTip1.SetToolTip(lblServer, resources.GetString("lblServer.ToolTip"));
            lblServer.Click += lblServer_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(91, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(150, 23);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += connection_Changed;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(91, 67);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(150, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += connection_Changed;
            // 
            // txtServer
            // 
            txtServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtServer.Location = new System.Drawing.Point(91, 9);
            txtServer.Name = "txtServer";
            txtServer.Size = new System.Drawing.Size(331, 23);
            txtServer.TabIndex = 3;
            txtServer.Text = "http://localhost:52199";
            txtServer.TextChanged += connection_Changed;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnTestConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnTestConnection.Location = new System.Drawing.Point(16, 206);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new System.Drawing.Size(112, 27);
            btnTestConnection.TabIndex = 6;
            btnTestConnection.Text = "Test connection";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // optAutomation
            // 
            optAutomation.AutoSize = true;
            optAutomation.Checked = true;
            optAutomation.Location = new System.Drawing.Point(16, 45);
            optAutomation.Name = "optAutomation";
            optAutomation.Size = new System.Drawing.Size(110, 19);
            optAutomation.TabIndex = 1;
            optAutomation.TabStop = true;
            optAutomation.Text = "Automation API";
            toolTip1.SetToolTip(optAutomation, "MC must be installed in this computer");
            optAutomation.UseVisualStyleBackColor = true;
            optAutomation.CheckedChanged += connectionOptionChanged;
            // 
            // optMCWS
            // 
            optMCWS.AutoSize = true;
            optMCWS.Location = new System.Drawing.Point(16, 70);
            optMCWS.Name = "optMCWS";
            optMCWS.Size = new System.Drawing.Size(61, 19);
            optMCWS.TabIndex = 2;
            optMCWS.Text = "MCWS";
            toolTip1.SetToolTip(optMCWS, "Connect to Network or Local MC server");
            optMCWS.UseVisualStyleBackColor = true;
            optMCWS.CheckedChanged += connectionOptionChanged;
            // 
            // tabPrefs
            // 
            tabPrefs.Controls.Add(delaySlide);
            tabPrefs.Controls.Add(lblDelay);
            tabPrefs.Controls.Add(label17);
            tabPrefs.Controls.Add(txtPlaylistFilter);
            tabPrefs.Controls.Add(txtTooltip);
            tabPrefs.Controls.Add(chkPlaylistFilter);
            tabPrefs.Controls.Add(chkTooltip);
            tabPrefs.Controls.Add(chkSaveTabs);
            tabPrefs.Controls.Add(chkFastStart);
            tabPrefs.Controls.Add(chkSafeMode);
            tabPrefs.Controls.Add(chkMaximize);
            tabPrefs.Controls.Add(chkTabs);
            tabPrefs.Controls.Add(chkAPITime);
            tabPrefs.Controls.Add(chkIndent);
            tabPrefs.Controls.Add(chkLines);
            tabPrefs.Controls.Add(chkSaveView);
            tabPrefs.Controls.Add(chkLoadPlaylist);
            tabPrefs.Location = new System.Drawing.Point(4, 24);
            tabPrefs.Name = "tabPrefs";
            tabPrefs.Padding = new System.Windows.Forms.Padding(3);
            tabPrefs.Size = new System.Drawing.Size(457, 247);
            tabPrefs.TabIndex = 0;
            tabPrefs.Text = "Preferences";
            tabPrefs.UseVisualStyleBackColor = true;
            // 
            // delaySlide
            // 
            delaySlide.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            delaySlide.AutoSize = false;
            delaySlide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            delaySlide.LargeChange = 200;
            delaySlide.Location = new System.Drawing.Point(114, 213);
            delaySlide.Maximum = 2000;
            delaySlide.Minimum = 100;
            delaySlide.Name = "delaySlide";
            delaySlide.Size = new System.Drawing.Size(289, 25);
            delaySlide.SmallChange = 50;
            delaySlide.TabIndex = 10;
            delaySlide.TickFrequency = 50;
            delaySlide.TickStyle = System.Windows.Forms.TickStyle.None;
            toolTip1.SetToolTip(delaySlide, "Delay after typing stops before recalculating the expression result");
            delaySlide.Value = 500;
            delaySlide.ValueChanged += delaySlide_ValueChanged;
            // 
            // lblDelay
            // 
            lblDelay.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblDelay.AutoSize = true;
            lblDelay.Location = new System.Drawing.Point(403, 214);
            lblDelay.Name = "lblDelay";
            lblDelay.Size = new System.Drawing.Size(44, 15);
            lblDelay.TabIndex = 29;
            lblDelay.Text = "500 ms";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(13, 213);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(96, 15);
            label17.TabIndex = 30;
            label17.Text = "Evaluation delay:";
            // 
            // txtPlaylistFilter
            // 
            txtPlaylistFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPlaylistFilter.Enabled = false;
            txtPlaylistFilter.Location = new System.Drawing.Point(124, 144);
            txtPlaylistFilter.Name = "txtPlaylistFilter";
            txtPlaylistFilter.Size = new System.Drawing.Size(323, 23);
            txtPlaylistFilter.TabIndex = 7;
            txtPlaylistFilter.TextChanged += connection_Changed;
            // 
            // txtTooltip
            // 
            txtTooltip.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTooltip.Enabled = false;
            txtTooltip.Location = new System.Drawing.Point(124, 173);
            txtTooltip.Name = "txtTooltip";
            txtTooltip.Size = new System.Drawing.Size(323, 23);
            txtTooltip.TabIndex = 9;
            // 
            // chkPlaylistFilter
            // 
            chkPlaylistFilter.AutoSize = true;
            chkPlaylistFilter.Location = new System.Drawing.Point(14, 146);
            chkPlaylistFilter.Name = "chkPlaylistFilter";
            chkPlaylistFilter.Size = new System.Drawing.Size(95, 19);
            chkPlaylistFilter.TabIndex = 6;
            chkPlaylistFilter.Text = "Playlist Filter:";
            toolTip1.SetToolTip(chkPlaylistFilter, resources.GetString("chkPlaylistFilter.ToolTip"));
            chkPlaylistFilter.UseVisualStyleBackColor = true;
            chkPlaylistFilter.CheckedChanged += connectionOptionChanged;
            chkPlaylistFilter.TextChanged += connection_Changed;
            // 
            // chkTooltip
            // 
            chkTooltip.AutoSize = true;
            chkTooltip.Location = new System.Drawing.Point(14, 175);
            chkTooltip.Name = "chkTooltip";
            chkTooltip.Size = new System.Drawing.Size(101, 19);
            chkTooltip.TabIndex = 8;
            chkTooltip.Text = "Tooltip Folder:";
            toolTip1.SetToolTip(chkTooltip, "Set this path in case Zelda doesn't detect the Tooltip: location correctly.\r\nLeave blank to autodetect the Tooltip folder.");
            chkTooltip.UseVisualStyleBackColor = true;
            chkTooltip.CheckedChanged += chkbox_CheckedChanged;
            // 
            // chkSaveTabs
            // 
            chkSaveTabs.AutoSize = true;
            chkSaveTabs.Checked = true;
            chkSaveTabs.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSaveTabs.Location = new System.Drawing.Point(14, 16);
            chkSaveTabs.Name = "chkSaveTabs";
            chkSaveTabs.Size = new System.Drawing.Size(185, 19);
            chkSaveTabs.TabIndex = 1;
            chkSaveTabs.Text = "Auto-save/restore expressions";
            chkSaveTabs.UseVisualStyleBackColor = true;
            // 
            // chkFastStart
            // 
            chkFastStart.AutoSize = true;
            chkFastStart.Location = new System.Drawing.Point(14, 91);
            chkFastStart.Name = "chkFastStart";
            chkFastStart.Size = new System.Drawing.Size(73, 19);
            chkFastStart.TabIndex = 5;
            chkFastStart.Text = "Fast start";
            toolTip1.SetToolTip(chkFastStart, "Enable this option to get just the Playlist names without the file count for each one.\r\nGetting the filecount for many playlists can be slow, specially for Smartlists.");
            chkFastStart.UseVisualStyleBackColor = true;
            // 
            // chkSafeMode
            // 
            chkSafeMode.AutoSize = true;
            chkSafeMode.Checked = true;
            chkSafeMode.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSafeMode.Location = new System.Drawing.Point(224, 116);
            chkSafeMode.Name = "chkSafeMode";
            chkSafeMode.Size = new System.Drawing.Size(176, 19);
            chkSafeMode.TabIndex = 4;
            chkSafeMode.Text = "ShellRun/SetField safe mode";
            toolTip1.SetToolTip(chkSafeMode, resources.GetString("chkSafeMode.ToolTip"));
            chkSafeMode.UseVisualStyleBackColor = true;
            // 
            // chkMaximize
            // 
            chkMaximize.AutoSize = true;
            chkMaximize.Checked = true;
            chkMaximize.CheckState = System.Windows.Forms.CheckState.Checked;
            chkMaximize.Location = new System.Drawing.Point(14, 116);
            chkMaximize.Name = "chkMaximize";
            chkMaximize.Size = new System.Drawing.Size(111, 19);
            chkMaximize.TabIndex = 4;
            chkMaximize.Text = "Start maximized";
            chkMaximize.UseVisualStyleBackColor = true;
            chkMaximize.Visible = false;
            // 
            // chkTabs
            // 
            chkTabs.AutoSize = true;
            chkTabs.Checked = true;
            chkTabs.CheckState = System.Windows.Forms.CheckState.Checked;
            chkTabs.Location = new System.Drawing.Point(224, 66);
            chkTabs.Name = "chkTabs";
            chkTabs.Size = new System.Drawing.Size(169, 19);
            chkTabs.TabIndex = 13;
            chkTabs.Text = "Insert spaces instead of Tab";
            chkTabs.UseVisualStyleBackColor = true;
            // 
            // chkAPITime
            // 
            chkAPITime.AutoSize = true;
            chkAPITime.Checked = true;
            chkAPITime.CheckState = System.Windows.Forms.CheckState.Checked;
            chkAPITime.Location = new System.Drawing.Point(224, 91);
            chkAPITime.Name = "chkAPITime";
            chkAPITime.Size = new System.Drawing.Size(211, 19);
            chkAPITime.TabIndex = 14;
            chkAPITime.Text = "Show API call times in Playlist table";
            chkAPITime.UseVisualStyleBackColor = true;
            // 
            // chkIndent
            // 
            chkIndent.AutoSize = true;
            chkIndent.Checked = true;
            chkIndent.CheckState = System.Windows.Forms.CheckState.Checked;
            chkIndent.Location = new System.Drawing.Point(224, 41);
            chkIndent.Name = "chkIndent";
            chkIndent.Size = new System.Drawing.Size(136, 19);
            chkIndent.TabIndex = 12;
            chkIndent.Text = "Indent wrapped lines";
            chkIndent.UseVisualStyleBackColor = true;
            // 
            // chkLines
            // 
            chkLines.AutoSize = true;
            chkLines.Checked = true;
            chkLines.CheckState = System.Windows.Forms.CheckState.Checked;
            chkLines.Location = new System.Drawing.Point(224, 16);
            chkLines.Name = "chkLines";
            chkLines.Size = new System.Drawing.Size(127, 19);
            chkLines.TabIndex = 11;
            chkLines.Text = "Show line numbers";
            chkLines.UseVisualStyleBackColor = true;
            // 
            // chkSaveView
            // 
            chkSaveView.AutoSize = true;
            chkSaveView.Checked = true;
            chkSaveView.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSaveView.Location = new System.Drawing.Point(14, 41);
            chkSaveView.Name = "chkSaveView";
            chkSaveView.Size = new System.Drawing.Size(155, 19);
            chkSaveView.TabIndex = 2;
            chkSaveView.Text = "Remember view settings";
            chkSaveView.UseVisualStyleBackColor = true;
            // 
            // chkLoadPlaylist
            // 
            chkLoadPlaylist.AutoSize = true;
            chkLoadPlaylist.Location = new System.Drawing.Point(14, 66);
            chkLoadPlaylist.Name = "chkLoadPlaylist";
            chkLoadPlaylist.Size = new System.Drawing.Size(180, 19);
            chkLoadPlaylist.TabIndex = 3;
            chkLoadPlaylist.Text = "Reload last playlist on startup";
            chkLoadPlaylist.UseVisualStyleBackColor = true;
            // 
            // tabColors
            // 
            tabColors.Controls.Add(txtExtraFuncs);
            tabColors.Controls.Add(label20);
            tabColors.Controls.Add(chkSyntaxComments);
            tabColors.Controls.Add(chkSyntaxDelim);
            tabColors.Controls.Add(chkSyntaxFunction);
            tabColors.Controls.Add(chkSyntax);
            tabColors.Controls.Add(radio3);
            tabColors.Controls.Add(radio2);
            tabColors.Controls.Add(radio1);
            tabColors.Controls.Add(groupBox2);
            tabColors.Location = new System.Drawing.Point(4, 24);
            tabColors.Name = "tabColors";
            tabColors.Padding = new System.Windows.Forms.Padding(3);
            tabColors.Size = new System.Drawing.Size(457, 247);
            tabColors.TabIndex = 1;
            tabColors.Text = "Colors";
            tabColors.UseVisualStyleBackColor = true;
            // 
            // txtExtraFuncs
            // 
            txtExtraFuncs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtExtraFuncs.Location = new System.Drawing.Point(239, 34);
            txtExtraFuncs.Multiline = true;
            txtExtraFuncs.Name = "txtExtraFuncs";
            txtExtraFuncs.Size = new System.Drawing.Size(208, 51);
            txtExtraFuncs.TabIndex = 5;
            toolTip1.SetToolTip(txtExtraFuncs, "Add new function names for highlighting, separated by space.\r\nThis allows ZELDA to recognized recently added functions.\r\n\r\nRequires application restart to take effect.");
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(239, 16);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(183, 15);
            label20.TabIndex = 15;
            label20.Text = "Additional functions to highlight:";
            // 
            // chkSyntaxComments
            // 
            chkSyntaxComments.AutoSize = true;
            chkSyntaxComments.Checked = true;
            chkSyntaxComments.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSyntaxComments.Location = new System.Drawing.Point(14, 91);
            chkSyntaxComments.Name = "chkSyntaxComments";
            chkSyntaxComments.Size = new System.Drawing.Size(193, 19);
            chkSyntaxComments.TabIndex = 4;
            chkSyntaxComments.Text = "Comment lines starting with ##";
            chkSyntaxComments.UseVisualStyleBackColor = true;
            // 
            // chkSyntaxDelim
            // 
            chkSyntaxDelim.AutoSize = true;
            chkSyntaxDelim.Checked = true;
            chkSyntaxDelim.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSyntaxDelim.Location = new System.Drawing.Point(14, 66);
            chkSyntaxDelim.Name = "chkSyntaxDelim";
            chkSyntaxDelim.Size = new System.Drawing.Size(179, 19);
            chkSyntaxDelim.TabIndex = 3;
            chkSyntaxDelim.Text = "Highlight function delimiters";
            toolTip1.SetToolTip(chkSyntaxDelim, "Shade the delimiters (commas and parethesis) of the function under the cursor position");
            chkSyntaxDelim.UseVisualStyleBackColor = true;
            // 
            // chkSyntaxFunction
            // 
            chkSyntaxFunction.AutoSize = true;
            chkSyntaxFunction.Checked = true;
            chkSyntaxFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSyntaxFunction.Location = new System.Drawing.Point(14, 41);
            chkSyntaxFunction.Name = "chkSyntaxFunction";
            chkSyntaxFunction.Size = new System.Drawing.Size(165, 19);
            chkSyntaxFunction.TabIndex = 2;
            chkSyntaxFunction.Text = "Highlight current function";
            toolTip1.SetToolTip(chkSyntaxFunction, "Shade the full text of the function under the cursor position");
            chkSyntaxFunction.UseVisualStyleBackColor = true;
            // 
            // chkSyntax
            // 
            chkSyntax.AutoSize = true;
            chkSyntax.Checked = true;
            chkSyntax.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSyntax.Location = new System.Drawing.Point(14, 16);
            chkSyntax.Name = "chkSyntax";
            chkSyntax.Size = new System.Drawing.Size(166, 19);
            chkSyntax.TabIndex = 1;
            chkSyntax.Text = "Enable syntax highlighting";
            toolTip1.SetToolTip(chkSyntax, "Colorize language elements");
            chkSyntax.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            radio3.Appearance = System.Windows.Forms.Appearance.Button;
            radio3.BackColor = System.Drawing.Color.White;
            radio3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            radio3.FlatAppearance.BorderSize = 0;
            radio3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            radio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            radio3.Location = new System.Drawing.Point(167, 127);
            radio3.Name = "radio3";
            radio3.Size = new System.Drawing.Size(73, 22);
            radio3.TabIndex = 8;
            radio3.Text = "Rendered Output";
            radio3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            radio3.UseVisualStyleBackColor = false;
            radio3.CheckedChanged += radio_CheckedChanged;
            // 
            // radio2
            // 
            radio2.Appearance = System.Windows.Forms.Appearance.Button;
            radio2.BackColor = System.Drawing.Color.White;
            radio2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            radio2.FlatAppearance.BorderSize = 0;
            radio2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            radio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            radio2.Location = new System.Drawing.Point(81, 127);
            radio2.Name = "radio2";
            radio2.Size = new System.Drawing.Size(87, 22);
            radio2.TabIndex = 7;
            radio2.Text = "Text Output";
            radio2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            radio2.UseVisualStyleBackColor = false;
            radio2.CheckedChanged += radio_CheckedChanged;
            // 
            // radio1
            // 
            radio1.Appearance = System.Windows.Forms.Appearance.Button;
            radio1.BackColor = System.Drawing.Color.White;
            radio1.Checked = true;
            radio1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            radio1.FlatAppearance.BorderSize = 0;
            radio1.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            radio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            radio1.Location = new System.Drawing.Point(27, 127);
            radio1.Name = "radio1";
            radio1.Size = new System.Drawing.Size(54, 22);
            radio1.TabIndex = 6;
            radio1.TabStop = true;
            radio1.Text = "Editor";
            radio1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            radio1.UseVisualStyleBackColor = false;
            radio1.CheckedChanged += radio_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(btnBackColor);
            groupBox2.Controls.Add(btnFont);
            groupBox2.Controls.Add(btnTextColor);
            groupBox2.Controls.Add(lblSampleColor);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.Location = new System.Drawing.Point(14, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(433, 110);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // btnBackColor
            // 
            btnBackColor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnBackColor.AutoSize = true;
            btnBackColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBackColor.LinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnBackColor.Location = new System.Drawing.Point(355, 79);
            btnBackColor.Name = "btnBackColor";
            btnBackColor.Size = new System.Drawing.Size(71, 15);
            btnBackColor.TabIndex = 12;
            btnBackColor.TabStop = true;
            btnBackColor.Text = "background";
            btnBackColor.LinkClicked += btnBackColor_LinkClicked;
            // 
            // btnFont
            // 
            btnFont.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFont.AutoSize = true;
            btnFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnFont.LinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFont.Location = new System.Drawing.Point(355, 29);
            btnFont.Name = "btnFont";
            btnFont.Size = new System.Drawing.Size(29, 15);
            btnFont.TabIndex = 10;
            btnFont.TabStop = true;
            btnFont.Text = "font";
            btnFont.LinkClicked += btnFont_LinkClicked;
            // 
            // btnTextColor
            // 
            btnTextColor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnTextColor.AutoSize = true;
            btnTextColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnTextColor.LinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnTextColor.Location = new System.Drawing.Point(355, 54);
            btnTextColor.Name = "btnTextColor";
            btnTextColor.Size = new System.Drawing.Size(57, 15);
            btnTextColor.TabIndex = 11;
            btnTextColor.TabStop = true;
            btnTextColor.Text = "text color";
            btnTextColor.LinkClicked += btnTextColor_LinkClicked;
            // 
            // lblSampleColor
            // 
            lblSampleColor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSampleColor.BackColor = System.Drawing.Color.FromArgb(64, 64, 0);
            lblSampleColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblSampleColor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSampleColor.ForeColor = System.Drawing.Color.White;
            lblSampleColor.Location = new System.Drawing.Point(13, 29);
            lblSampleColor.Name = "lblSampleColor";
            lblSampleColor.Padding = new System.Windows.Forms.Padding(3);
            lblSampleColor.Size = new System.Drawing.Size(337, 70);
            lblSampleColor.TabIndex = 9;
            lblSampleColor.Text = resources.GetString("lblSampleColor.Text");
            // 
            // tabCustomize
            // 
            tabCustomize.Controls.Add(label3);
            tabCustomize.Controls.Add(comboBox1);
            tabCustomize.Controls.Add(label2);
            tabCustomize.Controls.Add(dgSyntax);
            tabCustomize.Location = new System.Drawing.Point(4, 24);
            tabCustomize.Name = "tabCustomize";
            tabCustomize.Padding = new System.Windows.Forms.Padding(3);
            tabCustomize.Size = new System.Drawing.Size(457, 247);
            tabCustomize.TabIndex = 2;
            tabCustomize.Text = "Customize";
            tabCustomize.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(333, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 15;
            label3.Text = "Preset:";
            label3.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Default", "Default - Dark", "Custom", "Custom - Dark" });
            comboBox1.Location = new System.Drawing.Point(381, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(66, 23);
            comboBox1.TabIndex = 18;
            comboBox1.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(8, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(311, 21);
            label2.TabIndex = 19;
            label2.Text = "Custom colors are not yet implemented";
            // 
            // dgSyntax
            // 
            dgSyntax.AllowUserToAddRows = false;
            dgSyntax.AllowUserToDeleteRows = false;
            dgSyntax.AllowUserToResizeColumns = false;
            dgSyntax.AllowUserToResizeRows = false;
            dgSyntax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgSyntax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgSyntax.BackgroundColor = System.Drawing.SystemColors.Window;
            dgSyntax.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgSyntax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSyntax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgSyntax.Enabled = false;
            dgSyntax.Location = new System.Drawing.Point(8, 55);
            dgSyntax.Name = "dgSyntax";
            dgSyntax.RowHeadersVisible = false;
            dgSyntax.RowHeadersWidth = 51;
            dgSyntax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            dgSyntax.Size = new System.Drawing.Size(439, 173);
            dgSyntax.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Element";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.HeaderText = "Text";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 34;
            // 
            // Column3
            // 
            Column3.HeaderText = "Text Color";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 85;
            // 
            // Column4
            // 
            Column4.HeaderText = "Back";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 38;
            // 
            // Column5
            // 
            Column5.HeaderText = "Back Color";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 89;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Sample";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // fontDialog
            // 
            fontDialog.AllowScriptChange = false;
            fontDialog.AllowVerticalFonts = false;
            fontDialog.FontMustExist = true;
            fontDialog.MaxSize = 48;
            fontDialog.MinSize = 6;
            fontDialog.ShowEffects = false;
            // 
            // colorDialog
            // 
            colorDialog.AnyColor = true;
            colorDialog.FullOpen = true;
            colorDialog.SolidColorOnly = true;
            // 
            // SettingsUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(465, 313);
            Controls.Add(tabControl1);
            Controls.Add(btnSave);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsUI";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "ZELDA Settings";
            Load += SettingsUI_Load;
            KeyPress += SettingsUI_KeyPress;
            tabControl1.ResumeLayout(false);
            tabConnection.ResumeLayout(false);
            tabConnection.PerformLayout();
            panelMCWS.ResumeLayout(false);
            panelMCWS.PerformLayout();
            tabPrefs.ResumeLayout(false);
            tabPrefs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)delaySlide).EndInit();
            tabColors.ResumeLayout(false);
            tabColors.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabCustomize.ResumeLayout(false);
            tabCustomize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSyntax).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chkSafeMode;
    }
}