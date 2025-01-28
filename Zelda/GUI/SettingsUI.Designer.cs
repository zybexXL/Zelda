using System.Windows.Forms;

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
            btnSave = new Button();
            tabControl1 = new TabControl();
            tabConnection = new TabPage();
            groupBox6 = new GroupBox();
            panelMCWS = new Panel();
            label6 = new Label();
            label7 = new Label();
            lblServer = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtServer = new TextBox();
            btnTestConnection = new Button();
            optAutomation = new RadioButton();
            optMCWS = new RadioButton();
            tabPrefs = new TabPage();
            groupBox5 = new GroupBox();
            chkFastStart = new CheckBox();
            txtPlaylistFilter = new TextBox();
            chkSaveTabs = new CheckBox();
            chkAPITime = new CheckBox();
            chkPlaylistFilter = new CheckBox();
            chkSaveView = new CheckBox();
            chkLoadPlaylist = new CheckBox();
            txtTooltip = new TextBox();
            chkTooltip = new CheckBox();
            groupBox4 = new GroupBox();
            chkSafeMode = new CheckBox();
            chkTabs = new CheckBox();
            delaySlide = new TransparentTrackBar();
            chkIndent = new CheckBox();
            lblDelay = new Label();
            chkLines = new CheckBox();
            label17 = new Label();
            tabColors = new TabPage();
            groupBox3 = new GroupBox();
            chkSyntaxComments = new CheckBox();
            chkSyntaxDelim = new CheckBox();
            chkSyntaxFunction = new CheckBox();
            txtExtraFuncs = new TextBox();
            chkSyntax = new CheckBox();
            label20 = new Label();
            boxTheme = new GroupBox();
            btnThemeHelp = new Button();
            optThemeLight = new RadioButton();
            btnThemeEdit = new Button();
            optThemeDark = new RadioButton();
            optThemeAuto = new RadioButton();
            btnThemeReset = new Button();
            boxFonts = new GroupBox();
            lblRenderFont = new Label();
            lblOutputFont = new Label();
            lblEditorFont = new Label();
            btnResetRenderFont = new Button();
            btnResetOutputFont = new Button();
            btnResetEditorFont = new Button();
            btnRenderFont = new Button();
            btnOutputFont = new Button();
            btnEditorFont = new Button();
            toolTip1 = new ToolTip(components);
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            btnCancel = new Button();
            chkMultirowTabs = new CheckBox();
            tabControl1.SuspendLayout();
            tabConnection.SuspendLayout();
            groupBox6.SuspendLayout();
            panelMCWS.SuspendLayout();
            tabPrefs.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delaySlide).BeginInit();
            tabColors.SuspendLayout();
            groupBox3.SuspendLayout();
            boxTheme.SuspendLayout();
            boxFonts.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Location = new System.Drawing.Point(400, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(87, 31);
            btnSave.TabIndex = 20;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabConnection);
            tabControl1.Controls.Add(tabPrefs);
            tabControl1.Controls.Add(tabColors);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(501, 392);
            tabControl1.TabIndex = 0;
            // 
            // tabConnection
            // 
            tabConnection.Controls.Add(groupBox6);
            tabConnection.Location = new System.Drawing.Point(4, 26);
            tabConnection.Name = "tabConnection";
            tabConnection.Padding = new Padding(3);
            tabConnection.Size = new System.Drawing.Size(493, 362);
            tabConnection.TabIndex = 3;
            tabConnection.Text = "Connection";
            tabConnection.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(panelMCWS);
            groupBox6.Controls.Add(btnTestConnection);
            groupBox6.Controls.Add(optAutomation);
            groupBox6.Controls.Add(optMCWS);
            groupBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox6.Location = new System.Drawing.Point(8, 6);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(475, 349);
            groupBox6.TabIndex = 18;
            groupBox6.TabStop = false;
            groupBox6.Text = "MC Connection method";
            // 
            // panelMCWS
            // 
            panelMCWS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMCWS.Controls.Add(label6);
            panelMCWS.Controls.Add(label7);
            panelMCWS.Controls.Add(lblServer);
            panelMCWS.Controls.Add(txtUsername);
            panelMCWS.Controls.Add(txtPassword);
            panelMCWS.Controls.Add(txtServer);
            panelMCWS.Location = new System.Drawing.Point(12, 85);
            panelMCWS.Name = "panelMCWS";
            panelMCWS.Size = new System.Drawing.Size(457, 116);
            panelMCWS.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            label6.Location = new System.Drawing.Point(15, 79);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 17);
            label6.TabIndex = 15;
            label6.Text = "Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            label7.Location = new System.Drawing.Point(15, 46);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 17);
            label7.TabIndex = 15;
            label7.Text = "Username:";
            // 
            // lblServer
            // 
            lblServer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            lblServer.Image = Properties.Resources.help;
            lblServer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblServer.Location = new System.Drawing.Point(15, 13);
            lblServer.Name = "lblServer";
            lblServer.Size = new System.Drawing.Size(67, 17);
            lblServer.TabIndex = 15;
            lblServer.Text = "Server:";
            toolTip1.SetToolTip(lblServer, resources.GetString("lblServer.ToolTip"));
            lblServer.Click += lblServer_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtUsername.Location = new System.Drawing.Point(91, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(150, 25);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += connection_Changed;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtPassword.Location = new System.Drawing.Point(91, 76);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(150, 25);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += connection_Changed;
            // 
            // txtServer
            // 
            txtServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtServer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtServer.Location = new System.Drawing.Point(91, 10);
            txtServer.Name = "txtServer";
            txtServer.Size = new System.Drawing.Size(354, 25);
            txtServer.TabIndex = 3;
            txtServer.Text = "http://localhost:52199";
            txtServer.TextChanged += connection_Changed;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTestConnection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnTestConnection.Location = new System.Drawing.Point(164, 228);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new System.Drawing.Size(143, 37);
            btnTestConnection.TabIndex = 6;
            btnTestConnection.Text = "Test connection";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // optAutomation
            // 
            optAutomation.AutoSize = true;
            optAutomation.Checked = true;
            optAutomation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            optAutomation.Location = new System.Drawing.Point(12, 33);
            optAutomation.Name = "optAutomation";
            optAutomation.Size = new System.Drawing.Size(179, 21);
            optAutomation.TabIndex = 1;
            optAutomation.TabStop = true;
            optAutomation.Text = "Automation API (localhost)";
            toolTip1.SetToolTip(optAutomation, "MC must be installed in this computer");
            optAutomation.UseVisualStyleBackColor = true;
            optAutomation.CheckedChanged += connectionOptionChanged;
            // 
            // optMCWS
            // 
            optMCWS.AutoSize = true;
            optMCWS.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            optMCWS.Location = new System.Drawing.Point(12, 61);
            optMCWS.Name = "optMCWS";
            optMCWS.Size = new System.Drawing.Size(65, 21);
            optMCWS.TabIndex = 2;
            optMCWS.Text = "MCWS";
            toolTip1.SetToolTip(optMCWS, "Connect to Network or Local MC server");
            optMCWS.UseVisualStyleBackColor = true;
            optMCWS.CheckedChanged += connectionOptionChanged;
            // 
            // tabPrefs
            // 
            tabPrefs.Controls.Add(groupBox5);
            tabPrefs.Controls.Add(groupBox4);
            tabPrefs.Location = new System.Drawing.Point(4, 26);
            tabPrefs.Name = "tabPrefs";
            tabPrefs.Padding = new Padding(3);
            tabPrefs.Size = new System.Drawing.Size(493, 362);
            tabPrefs.TabIndex = 0;
            tabPrefs.Text = "Preferences";
            tabPrefs.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(chkFastStart);
            groupBox5.Controls.Add(txtPlaylistFilter);
            groupBox5.Controls.Add(chkSaveTabs);
            groupBox5.Controls.Add(chkAPITime);
            groupBox5.Controls.Add(chkPlaylistFilter);
            groupBox5.Controls.Add(chkSaveView);
            groupBox5.Controls.Add(chkLoadPlaylist);
            groupBox5.Controls.Add(txtTooltip);
            groupBox5.Controls.Add(chkTooltip);
            groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox5.Location = new System.Drawing.Point(8, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(475, 187);
            groupBox5.TabIndex = 32;
            groupBox5.TabStop = false;
            groupBox5.Text = "Application";
            // 
            // chkFastStart
            // 
            chkFastStart.AutoSize = true;
            chkFastStart.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkFastStart.Location = new System.Drawing.Point(10, 24);
            chkFastStart.Name = "chkFastStart";
            chkFastStart.Size = new System.Drawing.Size(80, 21);
            chkFastStart.TabIndex = 5;
            chkFastStart.Text = "Fast start";
            toolTip1.SetToolTip(chkFastStart, "Enable this option to get just the Playlist names without the file count for each one.\r\nGetting the filecount for many playlists can be slow, specially for Smartlists.");
            chkFastStart.UseVisualStyleBackColor = true;
            // 
            // txtPlaylistFilter
            // 
            txtPlaylistFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPlaylistFilter.Enabled = false;
            txtPlaylistFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPlaylistFilter.Location = new System.Drawing.Point(123, 147);
            txtPlaylistFilter.Name = "txtPlaylistFilter";
            txtPlaylistFilter.Size = new System.Drawing.Size(346, 23);
            txtPlaylistFilter.TabIndex = 7;
            txtPlaylistFilter.TextChanged += connection_Changed;
            // 
            // chkSaveTabs
            // 
            chkSaveTabs.AutoSize = true;
            chkSaveTabs.Checked = true;
            chkSaveTabs.CheckState = CheckState.Checked;
            chkSaveTabs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkSaveTabs.Location = new System.Drawing.Point(10, 78);
            chkSaveTabs.Name = "chkSaveTabs";
            chkSaveTabs.Size = new System.Drawing.Size(205, 21);
            chkSaveTabs.TabIndex = 1;
            chkSaveTabs.Text = "Auto-save/restore expressions";
            chkSaveTabs.UseVisualStyleBackColor = true;
            // 
            // chkAPITime
            // 
            chkAPITime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkAPITime.AutoSize = true;
            chkAPITime.Checked = true;
            chkAPITime.CheckState = CheckState.Checked;
            chkAPITime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkAPITime.Location = new System.Drawing.Point(245, 50);
            chkAPITime.Name = "chkAPITime";
            chkAPITime.Size = new System.Drawing.Size(228, 21);
            chkAPITime.TabIndex = 14;
            chkAPITime.Text = "Show API call times in Playlist table";
            chkAPITime.UseVisualStyleBackColor = true;
            // 
            // chkPlaylistFilter
            // 
            chkPlaylistFilter.AutoSize = true;
            chkPlaylistFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkPlaylistFilter.Location = new System.Drawing.Point(10, 149);
            chkPlaylistFilter.Name = "chkPlaylistFilter";
            chkPlaylistFilter.Size = new System.Drawing.Size(101, 21);
            chkPlaylistFilter.TabIndex = 6;
            chkPlaylistFilter.Text = "Playlist Filter:";
            toolTip1.SetToolTip(chkPlaylistFilter, resources.GetString("chkPlaylistFilter.ToolTip"));
            chkPlaylistFilter.UseVisualStyleBackColor = true;
            chkPlaylistFilter.CheckedChanged += connectionOptionChanged;
            chkPlaylistFilter.TextChanged += connection_Changed;
            // 
            // chkSaveView
            // 
            chkSaveView.AutoSize = true;
            chkSaveView.Checked = true;
            chkSaveView.CheckState = CheckState.Checked;
            chkSaveView.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkSaveView.Location = new System.Drawing.Point(10, 51);
            chkSaveView.Name = "chkSaveView";
            chkSaveView.Size = new System.Drawing.Size(169, 21);
            chkSaveView.TabIndex = 2;
            chkSaveView.Text = "Remember view settings";
            toolTip1.SetToolTip(chkSaveView, "Restore window size and position, editor layout and zoom level.");
            chkSaveView.UseVisualStyleBackColor = true;
            // 
            // chkLoadPlaylist
            // 
            chkLoadPlaylist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkLoadPlaylist.AutoSize = true;
            chkLoadPlaylist.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkLoadPlaylist.Location = new System.Drawing.Point(245, 24);
            chkLoadPlaylist.Name = "chkLoadPlaylist";
            chkLoadPlaylist.Size = new System.Drawing.Size(200, 21);
            chkLoadPlaylist.TabIndex = 3;
            chkLoadPlaylist.Text = "Reload last playlist on startup";
            chkLoadPlaylist.UseVisualStyleBackColor = true;
            // 
            // txtTooltip
            // 
            txtTooltip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTooltip.Enabled = false;
            txtTooltip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTooltip.Location = new System.Drawing.Point(123, 116);
            txtTooltip.Margin = new Padding(3, 2, 3, 2);
            txtTooltip.Name = "txtTooltip";
            txtTooltip.Size = new System.Drawing.Size(346, 23);
            txtTooltip.TabIndex = 9;
            // 
            // chkTooltip
            // 
            chkTooltip.AutoSize = true;
            chkTooltip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chkTooltip.Location = new System.Drawing.Point(10, 118);
            chkTooltip.Name = "chkTooltip";
            chkTooltip.Size = new System.Drawing.Size(111, 21);
            chkTooltip.TabIndex = 8;
            chkTooltip.Text = "Tooltip Folder:";
            toolTip1.SetToolTip(chkTooltip, "Used for \"Insert Image\" function.\r\nSet this path in case Zelda doesn't detect the Tooltip: location correctly.\r\nLeave blank to autodetect the Tooltip folder.");
            chkTooltip.UseVisualStyleBackColor = true;
            chkTooltip.CheckedChanged += chkTooltip_CheckChanged;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(chkSafeMode);
            groupBox4.Controls.Add(chkTabs);
            groupBox4.Controls.Add(delaySlide);
            groupBox4.Controls.Add(chkMultirowTabs);
            groupBox4.Controls.Add(chkIndent);
            groupBox4.Controls.Add(lblDelay);
            groupBox4.Controls.Add(chkLines);
            groupBox4.Controls.Add(label17);
            groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox4.Location = new System.Drawing.Point(8, 199);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(475, 146);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "Editor";
            // 
            // chkSafeMode
            // 
            chkSafeMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSafeMode.AutoSize = true;
            chkSafeMode.Checked = true;
            chkSafeMode.CheckState = CheckState.Checked;
            chkSafeMode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkSafeMode.Location = new System.Drawing.Point(245, 50);
            chkSafeMode.Name = "chkSafeMode";
            chkSafeMode.Size = new System.Drawing.Size(192, 21);
            chkSafeMode.TabIndex = 4;
            chkSafeMode.Text = "ShellRun/SetField safe mode";
            toolTip1.SetToolTip(chkSafeMode, resources.GetString("chkSafeMode.ToolTip"));
            chkSafeMode.UseVisualStyleBackColor = true;
            // 
            // chkTabs
            // 
            chkTabs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkTabs.AutoSize = true;
            chkTabs.Checked = true;
            chkTabs.CheckState = CheckState.Checked;
            chkTabs.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkTabs.Location = new System.Drawing.Point(245, 24);
            chkTabs.Name = "chkTabs";
            chkTabs.Size = new System.Drawing.Size(190, 21);
            chkTabs.TabIndex = 13;
            chkTabs.Text = "Insert spaces instead of Tab";
            chkTabs.UseVisualStyleBackColor = true;
            // 
            // delaySlide
            // 
            delaySlide.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            delaySlide.AutoSize = false;
            delaySlide.BackColor = System.Drawing.Color.FromArgb(247, 247, 249);
            delaySlide.LargeChange = 200;
            delaySlide.Location = new System.Drawing.Point(123, 110);
            delaySlide.Maximum = 2000;
            delaySlide.Minimum = 100;
            delaySlide.Name = "delaySlide";
            delaySlide.Size = new System.Drawing.Size(296, 28);
            delaySlide.SmallChange = 50;
            delaySlide.TabIndex = 10;
            delaySlide.TickFrequency = 50;
            delaySlide.TickStyle = TickStyle.None;
            toolTip1.SetToolTip(delaySlide, "Delay after typing stops before recalculating the expression result");
            delaySlide.Value = 500;
            delaySlide.ValueChanged += delaySlide_ValueChanged;
            // 
            // chkIndent
            // 
            chkIndent.AutoSize = true;
            chkIndent.Checked = true;
            chkIndent.CheckState = CheckState.Checked;
            chkIndent.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkIndent.Location = new System.Drawing.Point(10, 50);
            chkIndent.Name = "chkIndent";
            chkIndent.Size = new System.Drawing.Size(149, 21);
            chkIndent.TabIndex = 12;
            chkIndent.Text = "Indent wrapped lines";
            chkIndent.UseVisualStyleBackColor = true;
            // 
            // lblDelay
            // 
            lblDelay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDelay.AutoSize = true;
            lblDelay.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            lblDelay.Location = new System.Drawing.Point(419, 110);
            lblDelay.Name = "lblDelay";
            lblDelay.Size = new System.Drawing.Size(50, 17);
            lblDelay.TabIndex = 29;
            lblDelay.Text = "500 ms";
            // 
            // chkLines
            // 
            chkLines.AutoSize = true;
            chkLines.Checked = true;
            chkLines.CheckState = CheckState.Checked;
            chkLines.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkLines.Location = new System.Drawing.Point(10, 24);
            chkLines.Name = "chkLines";
            chkLines.Size = new System.Drawing.Size(137, 21);
            chkLines.TabIndex = 11;
            chkLines.Text = "Show line numbers";
            chkLines.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            label17.Location = new System.Drawing.Point(10, 110);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(105, 17);
            label17.TabIndex = 30;
            label17.Text = "Evaluation delay:";
            // 
            // tabColors
            // 
            tabColors.Controls.Add(groupBox3);
            tabColors.Controls.Add(boxTheme);
            tabColors.Controls.Add(boxFonts);
            tabColors.Location = new System.Drawing.Point(4, 26);
            tabColors.Name = "tabColors";
            tabColors.Padding = new Padding(3);
            tabColors.Size = new System.Drawing.Size(493, 362);
            tabColors.TabIndex = 1;
            tabColors.Text = "Theme";
            tabColors.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(chkSyntaxComments);
            groupBox3.Controls.Add(chkSyntaxDelim);
            groupBox3.Controls.Add(chkSyntaxFunction);
            groupBox3.Controls.Add(txtExtraFuncs);
            groupBox3.Controls.Add(chkSyntax);
            groupBox3.Controls.Add(label20);
            groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBox3.Location = new System.Drawing.Point(8, 69);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(475, 140);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Syntax highlight";
            // 
            // chkSyntaxComments
            // 
            chkSyntaxComments.AutoSize = true;
            chkSyntaxComments.Checked = true;
            chkSyntaxComments.CheckState = CheckState.Checked;
            chkSyntaxComments.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkSyntaxComments.Location = new System.Drawing.Point(10, 109);
            chkSyntaxComments.Name = "chkSyntaxComments";
            chkSyntaxComments.Size = new System.Drawing.Size(208, 21);
            chkSyntaxComments.TabIndex = 4;
            chkSyntaxComments.Text = "Comment lines starting with ##";
            chkSyntaxComments.UseVisualStyleBackColor = true;
            // 
            // chkSyntaxDelim
            // 
            chkSyntaxDelim.AutoSize = true;
            chkSyntaxDelim.Checked = true;
            chkSyntaxDelim.CheckState = CheckState.Checked;
            chkSyntaxDelim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkSyntaxDelim.Location = new System.Drawing.Point(10, 81);
            chkSyntaxDelim.Name = "chkSyntaxDelim";
            chkSyntaxDelim.Size = new System.Drawing.Size(190, 21);
            chkSyntaxDelim.TabIndex = 3;
            chkSyntaxDelim.Text = "Highlight function delimiters";
            toolTip1.SetToolTip(chkSyntaxDelim, "Shade the delimiters (commas and parethesis) of the function under the cursor position");
            chkSyntaxDelim.UseVisualStyleBackColor = true;
            // 
            // chkSyntaxFunction
            // 
            chkSyntaxFunction.AutoSize = true;
            chkSyntaxFunction.Checked = true;
            chkSyntaxFunction.CheckState = CheckState.Checked;
            chkSyntaxFunction.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkSyntaxFunction.Location = new System.Drawing.Point(10, 52);
            chkSyntaxFunction.Name = "chkSyntaxFunction";
            chkSyntaxFunction.Size = new System.Drawing.Size(174, 21);
            chkSyntaxFunction.TabIndex = 2;
            chkSyntaxFunction.Text = "Highlight current function";
            toolTip1.SetToolTip(chkSyntaxFunction, "Shade the full text of the function under the cursor position");
            chkSyntaxFunction.UseVisualStyleBackColor = true;
            // 
            // txtExtraFuncs
            // 
            txtExtraFuncs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExtraFuncs.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            txtExtraFuncs.Location = new System.Drawing.Point(244, 41);
            txtExtraFuncs.Multiline = true;
            txtExtraFuncs.Name = "txtExtraFuncs";
            txtExtraFuncs.Size = new System.Drawing.Size(221, 84);
            txtExtraFuncs.TabIndex = 5;
            toolTip1.SetToolTip(txtExtraFuncs, "Add new function names for highlighting, separated by space.\r\nThis allows ZELDA to recognized recently added functions.\r\n\r\nRequires application restart to take effect.");
            // 
            // chkSyntax
            // 
            chkSyntax.AutoSize = true;
            chkSyntax.Checked = true;
            chkSyntax.CheckState = CheckState.Checked;
            chkSyntax.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkSyntax.Location = new System.Drawing.Point(10, 24);
            chkSyntax.Name = "chkSyntax";
            chkSyntax.Size = new System.Drawing.Size(178, 21);
            chkSyntax.TabIndex = 1;
            chkSyntax.Text = "Enable syntax highlighting";
            toolTip1.SetToolTip(chkSyntax, "Colorize language elements");
            chkSyntax.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label20.Location = new System.Drawing.Point(244, 21);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(196, 17);
            label20.TabIndex = 15;
            label20.Text = "Additional functions to highlight:";
            // 
            // boxTheme
            // 
            boxTheme.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxTheme.Controls.Add(btnThemeHelp);
            boxTheme.Controls.Add(optThemeLight);
            boxTheme.Controls.Add(btnThemeEdit);
            boxTheme.Controls.Add(optThemeDark);
            boxTheme.Controls.Add(optThemeAuto);
            boxTheme.Controls.Add(btnThemeReset);
            boxTheme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            boxTheme.Location = new System.Drawing.Point(8, 6);
            boxTheme.Name = "boxTheme";
            boxTheme.Size = new System.Drawing.Size(475, 57);
            boxTheme.TabIndex = 24;
            boxTheme.TabStop = false;
            boxTheme.Text = "Color theme";
            // 
            // btnThemeHelp
            // 
            btnThemeHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemeHelp.AutoSize = true;
            btnThemeHelp.FlatAppearance.BorderSize = 0;
            btnThemeHelp.FlatStyle = FlatStyle.Flat;
            btnThemeHelp.Image = Properties.Resources.help;
            btnThemeHelp.Location = new System.Drawing.Point(303, 20);
            btnThemeHelp.Name = "btnThemeHelp";
            btnThemeHelp.Size = new System.Drawing.Size(24, 24);
            btnThemeHelp.TabIndex = 23;
            btnThemeHelp.UseVisualStyleBackColor = true;
            btnThemeHelp.Click += btnThemeHelp_Click;
            // 
            // optThemeLight
            // 
            optThemeLight.AutoSize = true;
            optThemeLight.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            optThemeLight.Location = new System.Drawing.Point(69, 24);
            optThemeLight.Name = "optThemeLight";
            optThemeLight.Size = new System.Drawing.Size(54, 21);
            optThemeLight.TabIndex = 21;
            optThemeLight.Text = "Light";
            optThemeLight.UseVisualStyleBackColor = true;
            // 
            // btnThemeEdit
            // 
            btnThemeEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemeEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnThemeEdit.Location = new System.Drawing.Point(330, 20);
            btnThemeEdit.Name = "btnThemeEdit";
            btnThemeEdit.Size = new System.Drawing.Size(65, 26);
            btnThemeEdit.TabIndex = 22;
            btnThemeEdit.Text = "Edit";
            toolTip1.SetToolTip(btnThemeEdit, "Open selected theme in Notepad");
            btnThemeEdit.UseVisualStyleBackColor = true;
            btnThemeEdit.Click += btnThemeEdit_Click;
            // 
            // optThemeDark
            // 
            optThemeDark.AutoSize = true;
            optThemeDark.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            optThemeDark.Location = new System.Drawing.Point(129, 24);
            optThemeDark.Name = "optThemeDark";
            optThemeDark.Size = new System.Drawing.Size(53, 21);
            optThemeDark.TabIndex = 20;
            optThemeDark.Text = "Dark";
            optThemeDark.UseVisualStyleBackColor = true;
            // 
            // optThemeAuto
            // 
            optThemeAuto.AutoSize = true;
            optThemeAuto.Checked = true;
            optThemeAuto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            optThemeAuto.Location = new System.Drawing.Point(10, 24);
            optThemeAuto.Name = "optThemeAuto";
            optThemeAuto.Size = new System.Drawing.Size(53, 21);
            optThemeAuto.TabIndex = 19;
            optThemeAuto.TabStop = true;
            optThemeAuto.Text = "Auto";
            toolTip1.SetToolTip(optThemeAuto, "Select theme according to System setting");
            optThemeAuto.UseVisualStyleBackColor = true;
            // 
            // btnThemeReset
            // 
            btnThemeReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemeReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnThemeReset.Location = new System.Drawing.Point(401, 20);
            btnThemeReset.Name = "btnThemeReset";
            btnThemeReset.Size = new System.Drawing.Size(65, 26);
            btnThemeReset.TabIndex = 22;
            btnThemeReset.Text = "Reset";
            toolTip1.SetToolTip(btnThemeReset, "Reset selected theme to default");
            btnThemeReset.UseVisualStyleBackColor = true;
            btnThemeReset.Click += btnThemeReset_Click;
            // 
            // boxFonts
            // 
            boxFonts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boxFonts.Controls.Add(lblRenderFont);
            boxFonts.Controls.Add(lblOutputFont);
            boxFonts.Controls.Add(lblEditorFont);
            boxFonts.Controls.Add(btnResetRenderFont);
            boxFonts.Controls.Add(btnResetOutputFont);
            boxFonts.Controls.Add(btnResetEditorFont);
            boxFonts.Controls.Add(btnRenderFont);
            boxFonts.Controls.Add(btnOutputFont);
            boxFonts.Controls.Add(btnEditorFont);
            boxFonts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            boxFonts.Location = new System.Drawing.Point(8, 215);
            boxFonts.Name = "boxFonts";
            boxFonts.Size = new System.Drawing.Size(475, 117);
            boxFonts.TabIndex = 4;
            boxFonts.TabStop = false;
            boxFonts.Text = "Fonts";
            // 
            // lblRenderFont
            // 
            lblRenderFont.AutoSize = true;
            lblRenderFont.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRenderFont.Location = new System.Drawing.Point(140, 85);
            lblRenderFont.Name = "lblRenderFont";
            lblRenderFont.Size = new System.Drawing.Size(139, 17);
            lblRenderFont.TabIndex = 15;
            lblRenderFont.Text = "Consolas, 9pt, Regular";
            // 
            // lblOutputFont
            // 
            lblOutputFont.AutoSize = true;
            lblOutputFont.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOutputFont.Location = new System.Drawing.Point(140, 57);
            lblOutputFont.Name = "lblOutputFont";
            lblOutputFont.Size = new System.Drawing.Size(139, 17);
            lblOutputFont.TabIndex = 15;
            lblOutputFont.Text = "Consolas, 9pt, Regular";
            // 
            // lblEditorFont
            // 
            lblEditorFont.AutoSize = true;
            lblEditorFont.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblEditorFont.Location = new System.Drawing.Point(140, 29);
            lblEditorFont.Name = "lblEditorFont";
            lblEditorFont.Size = new System.Drawing.Size(139, 17);
            lblEditorFont.TabIndex = 15;
            lblEditorFont.Text = "Consolas, 9pt, Regular";
            // 
            // btnResetRenderFont
            // 
            btnResetRenderFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnResetRenderFont.Location = new System.Drawing.Point(10, 80);
            btnResetRenderFont.Name = "btnResetRenderFont";
            btnResetRenderFont.Size = new System.Drawing.Size(27, 27);
            btnResetRenderFont.TabIndex = 23;
            btnResetRenderFont.Text = "X";
            toolTip1.SetToolTip(btnResetRenderFont, "reset to default");
            btnResetRenderFont.UseVisualStyleBackColor = true;
            btnResetRenderFont.Click += btnResetRenderFont_Click;
            // 
            // btnResetOutputFont
            // 
            btnResetOutputFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnResetOutputFont.Location = new System.Drawing.Point(10, 52);
            btnResetOutputFont.Name = "btnResetOutputFont";
            btnResetOutputFont.Size = new System.Drawing.Size(27, 27);
            btnResetOutputFont.TabIndex = 23;
            btnResetOutputFont.Text = "X";
            toolTip1.SetToolTip(btnResetOutputFont, "reset to default");
            btnResetOutputFont.UseVisualStyleBackColor = true;
            btnResetOutputFont.Click += btnResetOutputFont_Click;
            // 
            // btnResetEditorFont
            // 
            btnResetEditorFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnResetEditorFont.Location = new System.Drawing.Point(10, 24);
            btnResetEditorFont.Name = "btnResetEditorFont";
            btnResetEditorFont.Size = new System.Drawing.Size(27, 27);
            btnResetEditorFont.TabIndex = 23;
            btnResetEditorFont.Text = "X";
            toolTip1.SetToolTip(btnResetEditorFont, "reset to default");
            btnResetEditorFont.UseVisualStyleBackColor = true;
            btnResetEditorFont.Click += btnResetEditorFont_Click;
            // 
            // btnRenderFont
            // 
            btnRenderFont.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRenderFont.Location = new System.Drawing.Point(43, 80);
            btnRenderFont.Name = "btnRenderFont";
            btnRenderFont.Size = new System.Drawing.Size(91, 27);
            btnRenderFont.TabIndex = 23;
            btnRenderFont.Text = "Render font";
            btnRenderFont.UseVisualStyleBackColor = true;
            btnRenderFont.Click += btnRenderFont_Click;
            // 
            // btnOutputFont
            // 
            btnOutputFont.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnOutputFont.Location = new System.Drawing.Point(43, 52);
            btnOutputFont.Name = "btnOutputFont";
            btnOutputFont.Size = new System.Drawing.Size(91, 27);
            btnOutputFont.TabIndex = 23;
            btnOutputFont.Text = "Output font";
            btnOutputFont.UseVisualStyleBackColor = true;
            btnOutputFont.Click += btnOutputFont_Click;
            // 
            // btnEditorFont
            // 
            btnEditorFont.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnEditorFont.Location = new System.Drawing.Point(43, 24);
            btnEditorFont.Name = "btnEditorFont";
            btnEditorFont.Size = new System.Drawing.Size(91, 27);
            btnEditorFont.TabIndex = 23;
            btnEditorFont.Text = "Editor font";
            btnEditorFont.UseVisualStyleBackColor = true;
            btnEditorFont.Click += btnEditorFont_Click;
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
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.Location = new System.Drawing.Point(307, 398);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(87, 31);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkMultilineTabs
            // 
            chkMultirowTabs.AutoSize = true;
            chkMultirowTabs.Checked = true;
            chkMultirowTabs.CheckState = CheckState.Checked;
            chkMultirowTabs.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            chkMultirowTabs.Location = new System.Drawing.Point(10, 77);
            chkMultirowTabs.Name = "chkMultilineTabs";
            chkMultirowTabs.Size = new System.Drawing.Size(163, 21);
            chkMultirowTabs.TabIndex = 12;
            chkMultirowTabs.Text = "Show multiple tab rows";
            chkMultirowTabs.UseVisualStyleBackColor = true;
            // 
            // SettingsUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(501, 435);
            Controls.Add(tabControl1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsUI";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZELDA Settings";
            Load += SettingsUI_Load;
            KeyPress += SettingsUI_KeyPress;
            tabControl1.ResumeLayout(false);
            tabConnection.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panelMCWS.ResumeLayout(false);
            panelMCWS.PerformLayout();
            tabPrefs.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)delaySlide).EndInit();
            tabColors.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            boxTheme.ResumeLayout(false);
            boxTheme.PerformLayout();
            boxFonts.ResumeLayout(false);
            boxFonts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrefs;
        private System.Windows.Forms.CheckBox chkLoadPlaylist;
        private System.Windows.Forms.GroupBox boxFonts;
        private System.Windows.Forms.TabPage tabColors;
        private System.Windows.Forms.CheckBox chkSyntax;
        private System.Windows.Forms.CheckBox chkSaveTabs;
        private System.Windows.Forms.CheckBox chkLines;
        private System.Windows.Forms.CheckBox chkIndent;
        private System.Windows.Forms.TextBox txtExtraFuncs;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkTabs;
        private System.Windows.Forms.CheckBox chkSyntaxDelim;
        private System.Windows.Forms.CheckBox chkSyntaxFunction;
        private System.Windows.Forms.CheckBox chkAPITime;
        private System.Windows.Forms.CheckBox chkSaveView;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox chkFastStart;
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
        private TransparentTrackBar delaySlide;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPlaylistFilter;
        private System.Windows.Forms.TextBox txtTooltip;
        private System.Windows.Forms.CheckBox chkPlaylistFilter;
        private System.Windows.Forms.CheckBox chkTooltip;
        private System.Windows.Forms.Panel panelMCWS;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.CheckBox chkSafeMode;
        private System.Windows.Forms.Button btnEditorFont;
        private System.Windows.Forms.Label lblEditorFont;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox boxTheme;
        private System.Windows.Forms.RadioButton optThemeLight;
        private System.Windows.Forms.Button btnThemeEdit;
        private System.Windows.Forms.RadioButton optThemeDark;
        private System.Windows.Forms.RadioButton optThemeAuto;
        private System.Windows.Forms.Button btnThemeReset;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private Button btnThemeHelp;
        private Label lblRenderFont;
        private Label lblOutputFont;
        private Button btnResetRenderFont;
        private Button btnResetOutputFont;
        private Button btnResetEditorFont;
        private Button btnRenderFont;
        private Button btnOutputFont;
        private Button btnCancel;
        private CheckBox chkMultirowTabs;
    }
}