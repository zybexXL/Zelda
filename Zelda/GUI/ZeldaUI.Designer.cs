namespace Zelda
{
    partial class ZeldaUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZeldaUI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.wikiBrowser = new System.Windows.Forms.WebBrowser();
            this.tabsRight = new System.Windows.Forms.TabControl();
            this.tabText = new System.Windows.Forms.TabPage();
            this.txtOutput = new ScintillaNET.Scintilla();
            this.tabRendered = new System.Windows.Forms.TabPage();
            this.renderBrowser = new System.Windows.Forms.WebBrowser();
            this.tabDatagrid = new System.Windows.Forms.TabPage();
            this.gridFiles = new System.Windows.Forms.DataGridView();
            this.cFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExpr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCalltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnLink = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnRevert = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInsertField = new System.Windows.Forms.ToolStripButton();
            this.btnInsertFunction = new System.Windows.Forms.ToolStripButton();
            this.btnFunctionHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnFont = new System.Windows.Forms.ToolStripButton();
            this.btnImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRename = new System.Windows.Forms.ToolStripButton();
            this.chkWrap = new System.Windows.Forms.ToolStripButton();
            this.chkWhitespace = new System.Windows.Forms.ToolStripButton();
            this.btnZoomUp = new System.Windows.Forms.ToolStripButton();
            this.btnZoomDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnColumns = new System.Windows.Forms.ToolStripButton();
            this.btnAutorun = new System.Windows.Forms.ToolStripButton();
            this.lblChanged = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblReadOnly = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUpgrade = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCalltime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLatency = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAbout = new System.Windows.Forms.ToolStripDropDownButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnPrevFile = new System.Windows.Forms.Button();
            this.btnNextFile = new System.Windows.Forms.Button();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFiles = new System.Windows.Forms.ComboBox();
            this.comboLists = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuFieldList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.field1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.field2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.field3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsLeft = new System.Windows.Forms.DraggableTabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabsRight.SuspendLayout();
            this.tabText.SuspendLayout();
            this.tabRendered.SuspendLayout();
            this.tabDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuFieldList.SuspendLayout();
            this.tabsLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabsRight);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(1184, 554);
            this.splitContainer1.SplitterDistance = 688;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabsLeft);
            this.splitContainer3.Panel1MinSize = 200;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.wikiBrowser);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 4);
            this.splitContainer3.Panel2MinSize = 50;
            this.splitContainer3.Size = new System.Drawing.Size(688, 554);
            this.splitContainer3.SplitterDistance = 350;
            this.splitContainer3.TabIndex = 2;
            // 
            // wikiBrowser
            // 
            this.wikiBrowser.AllowWebBrowserDrop = false;
            this.wikiBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wikiBrowser.Location = new System.Drawing.Point(8, 0);
            this.wikiBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.wikiBrowser.MinimumSize = new System.Drawing.Size(15, 15);
            this.wikiBrowser.Name = "wikiBrowser";
            this.wikiBrowser.ScriptErrorsSuppressed = true;
            this.wikiBrowser.Size = new System.Drawing.Size(680, 196);
            this.wikiBrowser.TabIndex = 9;
            this.wikiBrowser.WebBrowserShortcutsEnabled = false;
            this.wikiBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wikiBrowser_DocumentCompleted);
            this.wikiBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.wikiBrowser_NewWindow);
            this.wikiBrowser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.browser_PreviewKeyDown);
            // 
            // tabsRight
            // 
            this.tabsRight.Controls.Add(this.tabText);
            this.tabsRight.Controls.Add(this.tabRendered);
            this.tabsRight.Controls.Add(this.tabDatagrid);
            this.tabsRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsRight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsRight.Location = new System.Drawing.Point(0, 0);
            this.tabsRight.Margin = new System.Windows.Forms.Padding(2);
            this.tabsRight.Name = "tabsRight";
            this.tabsRight.Padding = new System.Drawing.Point(6, 4);
            this.tabsRight.SelectedIndex = 0;
            this.tabsRight.Size = new System.Drawing.Size(492, 554);
            this.tabsRight.TabIndex = 2;
            this.tabsRight.SelectedIndexChanged += new System.EventHandler(this.tabsRight_SelectedIndexChanged);
            // 
            // tabText
            // 
            this.tabText.Controls.Add(this.txtOutput);
            this.tabText.Location = new System.Drawing.Point(4, 28);
            this.tabText.Margin = new System.Windows.Forms.Padding(2);
            this.tabText.Name = "tabText";
            this.tabText.Padding = new System.Windows.Forms.Padding(2);
            this.tabText.Size = new System.Drawing.Size(484, 522);
            this.tabText.TabIndex = 1;
            this.tabText.Text = "Text output";
            this.tabText.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.AutoCMaxHeight = 9;
            this.txtOutput.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.CaretLineBackColor = System.Drawing.Color.White;
            this.txtOutput.CaretLineVisible = true;
            this.txtOutput.CaretStyle = ScintillaNET.CaretStyle.Invisible;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.LexerName = null;
            this.txtOutput.Location = new System.Drawing.Point(2, 2);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollWidth = 1;
            this.txtOutput.Size = new System.Drawing.Size(480, 518);
            this.txtOutput.TabIndents = true;
            this.txtOutput.TabIndex = 0;
            this.txtOutput.UseRightToLeftReadingLayout = false;
            this.txtOutput.WhitespaceSize = 2;
            this.txtOutput.WrapMode = ScintillaNET.WrapMode.None;
            this.txtOutput.ZoomChanged += new System.EventHandler<System.EventArgs>(this.txtOutput_ZoomChanged);
            // 
            // tabRendered
            // 
            this.tabRendered.Controls.Add(this.renderBrowser);
            this.tabRendered.Location = new System.Drawing.Point(4, 28);
            this.tabRendered.Margin = new System.Windows.Forms.Padding(2);
            this.tabRendered.Name = "tabRendered";
            this.tabRendered.Padding = new System.Windows.Forms.Padding(2);
            this.tabRendered.Size = new System.Drawing.Size(484, 522);
            this.tabRendered.TabIndex = 0;
            this.tabRendered.Text = "Rendered output";
            this.tabRendered.UseVisualStyleBackColor = true;
            // 
            // renderBrowser
            // 
            this.renderBrowser.AllowWebBrowserDrop = false;
            this.renderBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderBrowser.Location = new System.Drawing.Point(2, 2);
            this.renderBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.renderBrowser.MinimumSize = new System.Drawing.Size(15, 15);
            this.renderBrowser.Name = "renderBrowser";
            this.renderBrowser.Size = new System.Drawing.Size(480, 518);
            this.renderBrowser.TabIndex = 0;
            this.renderBrowser.WebBrowserShortcutsEnabled = false;
            this.renderBrowser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.browser_PreviewKeyDown);
            // 
            // tabDatagrid
            // 
            this.tabDatagrid.Controls.Add(this.gridFiles);
            this.tabDatagrid.Location = new System.Drawing.Point(4, 28);
            this.tabDatagrid.Margin = new System.Windows.Forms.Padding(2);
            this.tabDatagrid.Name = "tabDatagrid";
            this.tabDatagrid.Padding = new System.Windows.Forms.Padding(2);
            this.tabDatagrid.Size = new System.Drawing.Size(484, 522);
            this.tabDatagrid.TabIndex = 3;
            this.tabDatagrid.Text = "Playlist";
            this.tabDatagrid.UseVisualStyleBackColor = true;
            this.tabDatagrid.ClientSizeChanged += new System.EventHandler(this.tabDatagrid_ClientSizeChanged);
            // 
            // gridFiles
            // 
            this.gridFiles.AllowUserToAddRows = false;
            this.gridFiles.AllowUserToDeleteRows = false;
            this.gridFiles.AllowUserToOrderColumns = true;
            this.gridFiles.AllowUserToResizeRows = false;
            this.gridFiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFile,
            this.cExpr1,
            this.cCalltime});
            this.gridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFiles.Location = new System.Drawing.Point(2, 2);
            this.gridFiles.Margin = new System.Windows.Forms.Padding(2);
            this.gridFiles.Name = "gridFiles";
            this.gridFiles.ReadOnly = true;
            this.gridFiles.RowHeadersVisible = false;
            this.gridFiles.RowHeadersWidth = 51;
            this.gridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFiles.Size = new System.Drawing.Size(480, 518);
            this.gridFiles.TabIndex = 0;
            // 
            // cFile
            // 
            this.cFile.HeaderText = "File";
            this.cFile.MinimumWidth = 6;
            this.cFile.Name = "cFile";
            this.cFile.ReadOnly = true;
            this.cFile.Width = 200;
            // 
            // cExpr1
            // 
            this.cExpr1.FillWeight = 50F;
            this.cExpr1.HeaderText = "expr1";
            this.cExpr1.MinimumWidth = 6;
            this.cExpr1.Name = "cExpr1";
            this.cExpr1.ReadOnly = true;
            this.cExpr1.Width = 125;
            // 
            // cCalltime
            // 
            this.cCalltime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cCalltime.HeaderText = "call time";
            this.cCalltime.MinimumWidth = 6;
            this.cCalltime.Name = "cCalltime";
            this.cCalltime.ReadOnly = true;
            this.cCalltime.Width = 75;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnLink,
            this.btnSave,
            this.btnRevert,
            this.btnClose,
            this.toolStripSeparator1,
            this.btnUndo,
            this.btnRedo,
            this.toolStripSeparator5,
            this.btnInsertField,
            this.btnInsertFunction,
            this.btnFunctionHelp,
            this.toolStripSeparator2,
            this.btnBold,
            this.btnUnderline,
            this.btnItalic,
            this.btnFont,
            this.btnImage,
            this.toolStripSeparator3,
            this.btnRename,
            this.chkWrap,
            this.chkWhitespace,
            this.btnZoomUp,
            this.btnZoomDown,
            this.toolStripSeparator4,
            this.btnColumns,
            this.btnAutorun,
            this.lblChanged});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1184, 40);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::Zelda.Properties.Resources.script_add;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 37);
            this.btnNew.Text = "&New tab";
            this.btnNew.ToolTipText = "New tab (Ctrl+N)";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLink
            // 
            this.btnLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLink.Image = global::Zelda.Properties.Resources.link_add;
            this.btnLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(36, 37);
            this.btnLink.Text = "New Linked tab";
            this.btnLink.ToolTipText = "Open new tab linked to an MC field (Ctrl+L)\r\nUse CTRL+Click on a field name to al" +
    "low duplicate field tabs.\r\n\r\n[Requires MC v32.0.18 or above with MCWS connection" +
    "]";
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Zelda.Properties.Resources.disk;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 37);
            this.btnSave.Text = "Save";
            this.btnSave.ToolTipText = "Save to linked MC field (Ctrl+S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRevert
            // 
            this.btnRevert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRevert.Image = global::Zelda.Properties.Resources.reset_red_32;
            this.btnRevert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(36, 37);
            this.btnRevert.Text = "Revert";
            this.btnRevert.ToolTipText = "Reload expression from linked MC field (discard changes)";
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::Zelda.Properties.Resources.cross1;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 37);
            this.btnClose.Text = "Close tab";
            this.btnClose.ToolTipText = "Close tab (Ctrl+W)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = global::Zelda.Properties.Resources.undo_2a2b2c_32;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(36, 37);
            this.btnUndo.Text = "Undo";
            this.btnUndo.ToolTipText = "Undo (Ctrl+Z)";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = global::Zelda.Properties.Resources.redo_2a2b2c_32;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(36, 37);
            this.btnRedo.Text = "Redo";
            this.btnRedo.ToolTipText = "Redo (Ctrl+Y)";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
            // 
            // btnInsertField
            // 
            this.btnInsertField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInsertField.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertField.ForeColor = System.Drawing.Color.Green;
            this.btnInsertField.Image = global::Zelda.Properties.Resources.Field32;
            this.btnInsertField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsertField.Margin = new System.Windows.Forms.Padding(0);
            this.btnInsertField.Name = "btnInsertField";
            this.btnInsertField.Size = new System.Drawing.Size(36, 40);
            this.btnInsertField.Text = "[x]";
            this.btnInsertField.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInsertField.ToolTipText = "Insert Field (F3)";
            this.btnInsertField.Click += new System.EventHandler(this.btnInsertField_Click);
            // 
            // btnInsertFunction
            // 
            this.btnInsertFunction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInsertFunction.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertFunction.ForeColor = System.Drawing.Color.Blue;
            this.btnInsertFunction.Image = global::Zelda.Properties.Resources.Function32;
            this.btnInsertFunction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsertFunction.Margin = new System.Windows.Forms.Padding(0);
            this.btnInsertFunction.Name = "btnInsertFunction";
            this.btnInsertFunction.Size = new System.Drawing.Size(36, 40);
            this.btnInsertFunction.Text = "f(x)";
            this.btnInsertFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertFunction.ToolTipText = "Insert Function (F4)";
            this.btnInsertFunction.Click += new System.EventHandler(this.btnInsertFunction_Click);
            // 
            // btnFunctionHelp
            // 
            this.btnFunctionHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFunctionHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFunctionHelp.Image = global::Zelda.Properties.Resources.book_open;
            this.btnFunctionHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFunctionHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnFunctionHelp.Name = "btnFunctionHelp";
            this.btnFunctionHelp.Size = new System.Drawing.Size(36, 40);
            this.btnFunctionHelp.Text = "Function syntax helper";
            this.btnFunctionHelp.ToolTipText = "Toggle the Function syntax helper panel";
            this.btnFunctionHelp.Click += new System.EventHandler(this.btnFunctionHelp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Font = new System.Drawing.Font("Lucida Sans", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Image = global::Zelda.Properties.Resources.Bold32d;
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Margin = new System.Windows.Forms.Padding(0);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(36, 40);
            this.btnBold.Text = "B";
            this.btnBold.ToolTipText = "Bold tag (Ctrl+B)";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Image = global::Zelda.Properties.Resources.Underline32;
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(36, 40);
            this.btnUnderline.Text = "U";
            this.btnUnderline.ToolTipText = "Underline tag (Ctr+U)";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Image = global::Zelda.Properties.Resources.Italic32b;
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Margin = new System.Windows.Forms.Padding(0);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(36, 40);
            this.btnItalic.Text = "I";
            this.btnItalic.ToolTipText = "Italic tag (Ctrl+I)";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnFont
            // 
            this.btnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFont.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.ForeColor = System.Drawing.Color.Maroon;
            this.btnFont.Image = global::Zelda.Properties.Resources.Font32b;
            this.btnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFont.Margin = new System.Windows.Forms.Padding(0);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(36, 40);
            this.btnFont.Text = "Aa";
            this.btnFont.ToolTipText = "Font tag";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnImage
            // 
            this.btnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImage.Image = global::Zelda.Properties.Resources.picture;
            this.btnImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(36, 37);
            this.btnImage.Text = "Img";
            this.btnImage.ToolTipText = "Image tag";
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // btnRename
            // 
            this.btnRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRename.Image = global::Zelda.Properties.Resources.rename_32_clear;
            this.btnRename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(36, 37);
            this.btnRename.Text = "&Rename tab";
            this.btnRename.ToolTipText = "Rename tab (F2)";
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // chkWrap
            // 
            this.chkWrap.CheckOnClick = true;
            this.chkWrap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chkWrap.Image = global::Zelda.Properties.Resources.text_wrap_32;
            this.chkWrap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkWrap.Name = "chkWrap";
            this.chkWrap.Size = new System.Drawing.Size(36, 37);
            this.chkWrap.Text = "Line wrap";
            this.chkWrap.ToolTipText = "Toggle line wrap";
            this.chkWrap.CheckedChanged += new System.EventHandler(this.btnWrap_CheckedChanged);
            // 
            // chkWhitespace
            // 
            this.chkWhitespace.CheckOnClick = true;
            this.chkWhitespace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chkWhitespace.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWhitespace.Image = global::Zelda.Properties.Resources.Pilcrow32;
            this.chkWhitespace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chkWhitespace.Margin = new System.Windows.Forms.Padding(0);
            this.chkWhitespace.Name = "chkWhitespace";
            this.chkWhitespace.Size = new System.Drawing.Size(36, 40);
            this.chkWhitespace.Text = "¶";
            this.chkWhitespace.ToolTipText = "Show/hide whitespace";
            this.chkWhitespace.CheckedChanged += new System.EventHandler(this.btnWhitespace_CheckedChanged);
            // 
            // btnZoomUp
            // 
            this.btnZoomUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomUp.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomUp.Image = global::Zelda.Properties.Resources.zoom_in_2a2b2c_32;
            this.btnZoomUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomUp.Name = "btnZoomUp";
            this.btnZoomUp.Size = new System.Drawing.Size(36, 37);
            this.btnZoomUp.Text = "Increase zoom";
            this.btnZoomUp.Click += new System.EventHandler(this.btnZoomUp_Click);
            // 
            // btnZoomDown
            // 
            this.btnZoomDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomDown.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomDown.Image = global::Zelda.Properties.Resources.zoom_out_2a2b2c_32;
            this.btnZoomDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomDown.Name = "btnZoomDown";
            this.btnZoomDown.Size = new System.Drawing.Size(36, 37);
            this.btnZoomDown.Text = "Decrease zoom";
            this.btnZoomDown.Click += new System.EventHandler(this.btnZoomDown_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // btnColumns
            // 
            this.btnColumns.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColumns.Image = global::Zelda.Properties.Resources.table;
            this.btnColumns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColumns.Name = "btnColumns";
            this.btnColumns.Size = new System.Drawing.Size(36, 37);
            this.btnColumns.Text = "Columns";
            this.btnColumns.ToolTipText = "Select datagrid columns and fields";
            this.btnColumns.Visible = false;
            this.btnColumns.Click += new System.EventHandler(this.btnColumns_Click);
            // 
            // btnAutorun
            // 
            this.btnAutorun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAutorun.Image = global::Zelda.Properties.Resources.Play;
            this.btnAutorun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAutorun.Name = "btnAutorun";
            this.btnAutorun.Size = new System.Drawing.Size(36, 37);
            this.btnAutorun.Text = "Automatic execution";
            this.btnAutorun.ToolTipText = "Toggle automatic execution (F5)";
            this.btnAutorun.Click += new System.EventHandler(this.btnAutorun_Click);
            // 
            // lblChanged
            // 
            this.lblChanged.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChanged.ForeColor = System.Drawing.Color.Red;
            this.lblChanged.Name = "lblChanged";
            this.lblChanged.Size = new System.Drawing.Size(68, 37);
            this.lblChanged.Text = "modified!";
            this.lblChanged.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblReadOnly,
            this.lblUpgrade,
            this.toolStripStatusLabel3,
            this.lblZoom,
            this.toolStripStatusLabel2,
            this.lblCalltime,
            this.toolStripStatusLabel1,
            this.lblLatency,
            this.btnSettings,
            this.btnAbout});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(1184, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 25);
            this.lblStatus.Text = "Disconnected";
            // 
            // lblReadOnly
            // 
            this.lblReadOnly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblReadOnly.Margin = new System.Windows.Forms.Padding(10, 3, 20, 2);
            this.lblReadOnly.Name = "lblReadOnly";
            this.lblReadOnly.Size = new System.Drawing.Size(65, 25);
            this.lblReadOnly.Text = "Read-Only";
            this.lblReadOnly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReadOnly.Visible = false;
            // 
            // lblUpgrade
            // 
            this.lblUpgrade.ForeColor = System.Drawing.Color.Red;
            this.lblUpgrade.Name = "lblUpgrade";
            this.lblUpgrade.Size = new System.Drawing.Size(257, 25);
            this.lblUpgrade.Text = "ZELDA v1.0.0 is now available - click to upgrade";
            this.lblUpgrade.Visible = false;
            this.lblUpgrade.Click += new System.EventHandler(this.lblUpgrade_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(537, 25);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // lblZoom
            // 
            this.lblZoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblZoom.Margin = new System.Windows.Forms.Padding(0, 3, 70, 2);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(57, 25);
            this.lblZoom.Text = "Zoom +1";
            this.lblZoom.ToolTipText = "click to reset zoom";
            this.lblZoom.Click += new System.EventHandler(this.lblZoom_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(82, 25);
            this.toolStripStatusLabel2.Text = "Last call time:";
            this.toolStripStatusLabel2.ToolTipText = "Call duration for last expression, including API overhead";
            // 
            // lblCalltime
            // 
            this.lblCalltime.AutoSize = false;
            this.lblCalltime.AutoToolTip = true;
            this.lblCalltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCalltime.Name = "lblCalltime";
            this.lblCalltime.Size = new System.Drawing.Size(100, 25);
            this.lblCalltime.Text = "---";
            this.lblCalltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCalltime.ToolTipText = "Call duration for last expression, including API overhead";
            this.lblCalltime.Click += new System.EventHandler(this.lblLatency_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 25);
            this.toolStripStatusLabel1.Text = "API overhead:";
            this.toolStripStatusLabel1.ToolTipText = resources.GetString("toolStripStatusLabel1.ToolTipText");
            // 
            // lblLatency
            // 
            this.lblLatency.AutoSize = false;
            this.lblLatency.AutoToolTip = true;
            this.lblLatency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLatency.Name = "lblLatency";
            this.lblLatency.Size = new System.Drawing.Size(100, 25);
            this.lblLatency.Text = "---";
            this.lblLatency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLatency.ToolTipText = "click to recalculate";
            this.lblLatency.Click += new System.EventHandler(this.lblLatency_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = global::Zelda.Properties.Resources.cog24;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0, 2, 5, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShowDropDownArrow = false;
            this.btnSettings.Size = new System.Drawing.Size(24, 28);
            this.btnSettings.ToolTipText = "Settings (F10)";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = global::Zelda.Properties.Resources.help32;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0, 2, 10, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShowDropDownArrow = false;
            this.btnAbout.Size = new System.Drawing.Size(24, 28);
            this.btnAbout.ToolTipText = "About (F1)";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnPrevFile);
            this.splitContainer2.Panel1.Controls.Add(this.btnNextFile);
            this.splitContainer2.Panel1.Controls.Add(this.btnReconnect);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.comboFiles);
            this.splitContainer2.Panel1.Controls.Add(this.comboLists);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer2.Size = new System.Drawing.Size(1184, 631);
            this.splitContainer2.SplitterDistance = 35;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 3;
            // 
            // btnPrevFile
            // 
            this.btnPrevFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevFile.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevFile.FlatAppearance.BorderSize = 0;
            this.btnPrevFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnPrevFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevFile.Image = global::Zelda.Properties.Resources.ArrowLeft;
            this.btnPrevFile.Location = new System.Drawing.Point(1148, 9);
            this.btnPrevFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevFile.Name = "btnPrevFile";
            this.btnPrevFile.Size = new System.Drawing.Size(15, 15);
            this.btnPrevFile.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnPrevFile, "Previous file (Alt+Left)");
            this.btnPrevFile.UseVisualStyleBackColor = true;
            this.btnPrevFile.Click += new System.EventHandler(this.btnPrevFile_Click);
            // 
            // btnNextFile
            // 
            this.btnNextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextFile.BackColor = System.Drawing.Color.Transparent;
            this.btnNextFile.FlatAppearance.BorderSize = 0;
            this.btnNextFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnNextFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextFile.Image = global::Zelda.Properties.Resources.ArrowRight;
            this.btnNextFile.Location = new System.Drawing.Point(1165, 9);
            this.btnNextFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextFile.Name = "btnNextFile";
            this.btnNextFile.Size = new System.Drawing.Size(14, 15);
            this.btnNextFile.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnNextFile, "Next File (Alt+Right)");
            this.btnNextFile.UseVisualStyleBackColor = true;
            this.btnNextFile.Click += new System.EventHandler(this.btnNextFile_Click);
            // 
            // btnReconnect
            // 
            this.btnReconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReconnect.BackColor = System.Drawing.Color.Transparent;
            this.btnReconnect.FlatAppearance.BorderSize = 0;
            this.btnReconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnReconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReconnect.Image = global::Zelda.Properties.Resources.refresh_2a2b2c;
            this.btnReconnect.Location = new System.Drawing.Point(640, 5);
            this.btnReconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(24, 24);
            this.btnReconnect.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnReconnect, "Reload playlist");
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(848, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Playlist:";
            // 
            // comboFiles
            // 
            this.comboFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiles.FormattingEnabled = true;
            this.comboFiles.Location = new System.Drawing.Point(880, 7);
            this.comboFiles.Margin = new System.Windows.Forms.Padding(2);
            this.comboFiles.Name = "comboFiles";
            this.comboFiles.Size = new System.Drawing.Size(265, 21);
            this.comboFiles.TabIndex = 2;
            this.comboFiles.SelectedIndexChanged += new System.EventHandler(this.comboFiles_SelectedIndexChanged);
            // 
            // comboLists
            // 
            this.comboLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLists.FormattingEnabled = true;
            this.comboLists.Location = new System.Drawing.Point(60, 7);
            this.comboLists.Margin = new System.Windows.Forms.Padding(2);
            this.comboLists.Name = "comboLists";
            this.comboLists.Size = new System.Drawing.Size(579, 21);
            this.comboLists.TabIndex = 1;
            this.comboLists.SelectedIndexChanged += new System.EventHandler(this.comboLists_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuFieldList
            // 
            this.menuFieldList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.field1ToolStripMenuItem,
            this.field2ToolStripMenuItem,
            this.field3ToolStripMenuItem});
            this.menuFieldList.Name = "menuFieldList";
            this.menuFieldList.ShowImageMargin = false;
            this.menuFieldList.Size = new System.Drawing.Size(81, 70);
            this.menuFieldList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuFieldList_ItemClicked);
            // 
            // field1ToolStripMenuItem
            // 
            this.field1ToolStripMenuItem.Name = "field1ToolStripMenuItem";
            this.field1ToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.field1ToolStripMenuItem.Text = "Field1";
            // 
            // field2ToolStripMenuItem
            // 
            this.field2ToolStripMenuItem.Name = "field2ToolStripMenuItem";
            this.field2ToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.field2ToolStripMenuItem.Text = "Field2";
            // 
            // field3ToolStripMenuItem
            // 
            this.field3ToolStripMenuItem.Name = "field3ToolStripMenuItem";
            this.field3ToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.field3ToolStripMenuItem.Text = "Field3";
            // 
            // tabsLeft
            // 
            this.tabsLeft.AllowDrop = true;
            this.tabsLeft.Controls.Add(this.tabPage5);
            this.tabsLeft.Controls.Add(this.tabPage6);
            this.tabsLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsLeft.Location = new System.Drawing.Point(0, 0);
            this.tabsLeft.Margin = new System.Windows.Forms.Padding(2);
            this.tabsLeft.Name = "tabsLeft";
            this.tabsLeft.Padding = new System.Drawing.Point(6, 4);
            this.tabsLeft.SelectedIndex = 0;
            this.tabsLeft.Size = new System.Drawing.Size(688, 350);
            this.tabsLeft.TabIndex = 1;
            this.tabsLeft.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabsLeft_DrawItem);
            this.tabsLeft.SelectedIndexChanged += new System.EventHandler(this.tabsLeft_SelectedIndexChanged);
            this.tabsLeft.DoubleClick += new System.EventHandler(this.tabsLeft_DoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(680, 318);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "expr1";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(680, 318);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "🔗 [expr2] ❎";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ZeldaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ZeldaUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZELDA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZeldaUI_FormClosing);
            this.Load += new System.EventHandler(this.ZeldaUI_Load);
            this.Shown += new System.EventHandler(this.ZeldaUI_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZeldaUI_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabsRight.ResumeLayout(false);
            this.tabText.ResumeLayout(false);
            this.tabRendered.ResumeLayout(false);
            this.tabDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFiles)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuFieldList.ResumeLayout(false);
            this.tabsLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser renderBrowser;
        private System.Windows.Forms.TabControl tabsRight;
        private System.Windows.Forms.TabPage tabRendered;
        private System.Windows.Forms.TabPage tabText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabPage tabDatagrid;
        private System.Windows.Forms.DataGridView gridFiles;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStripButton btnFont;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton chkWrap;
        private System.Windows.Forms.ComboBox comboFiles;
        private System.Windows.Forms.ComboBox comboLists;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLatency;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripButton btnImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnInsertFunction;
        private System.Windows.Forms.DraggableTabControl tabsLeft;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnLink;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnZoomUp;
        private System.Windows.Forms.ToolStripButton btnZoomDown;
        private System.Windows.Forms.ToolStripButton btnColumns;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ToolStripDropDownButton btnAbout;
        private System.Windows.Forms.ToolStripButton chkWhitespace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private ScintillaNET.Scintilla txtOutput;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblCalltime;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton btnFunctionHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExpr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCalltime;
        private System.Windows.Forms.ToolStripDropDownButton btnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnAutorun;
        private System.Windows.Forms.ToolStripButton btnRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.Button btnPrevFile;
        private System.Windows.Forms.Button btnNextFile;
        private System.Windows.Forms.ToolStripLabel lblChanged;
        private System.Windows.Forms.ToolStripButton btnInsertField;
        private System.Windows.Forms.WebBrowser wikiBrowser;
        private System.Windows.Forms.ToolStripStatusLabel lblZoom;
        private System.Windows.Forms.ToolStripStatusLabel lblUpgrade;
        private System.Windows.Forms.ToolStripButton btnRevert;
        private System.Windows.Forms.ContextMenuStrip menuFieldList;
        private System.Windows.Forms.ToolStripMenuItem field1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem field2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem field3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblReadOnly;
    }
}

