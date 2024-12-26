using System.Drawing;

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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZeldaUI));
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            tabsLeft = new System.Windows.Forms.DraggableTabControl();
            tabsRight = new System.Windows.Forms.TabControl();
            tabText = new System.Windows.Forms.TabPage();
            txtOutput = new ScintillaNET.Scintilla();
            tabRendered = new System.Windows.Forms.TabPage();
            renderBrowser = new System.Windows.Forms.WebBrowser();
            tabDatagrid = new System.Windows.Forms.TabPage();
            gridFiles = new System.Windows.Forms.DataGridView();
            cFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cExpr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cCalltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabPage5 = new System.Windows.Forms.TabPage();
            tabPage6 = new System.Windows.Forms.TabPage();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btnNew = new System.Windows.Forms.ToolStripButton();
            btnLink = new System.Windows.Forms.ToolStripButton();
            btnSave = new System.Windows.Forms.ToolStripButton();
            btnRevert = new System.Windows.Forms.ToolStripButton();
            btnClose = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btnUndo = new System.Windows.Forms.ToolStripButton();
            btnRedo = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            btnInsertField = new System.Windows.Forms.ToolStripButton();
            btnInsertFunction = new System.Windows.Forms.ToolStripButton();
            btnFunctionHelp = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            btnBold = new System.Windows.Forms.ToolStripButton();
            btnUnderline = new System.Windows.Forms.ToolStripButton();
            btnItalic = new System.Windows.Forms.ToolStripButton();
            btnFont = new System.Windows.Forms.ToolStripButton();
            btnImage = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            btnRename = new System.Windows.Forms.ToolStripButton();
            chkWrap = new System.Windows.Forms.ToolStripButton();
            chkWhitespace = new System.Windows.Forms.ToolStripButton();
            btnZoomUp = new System.Windows.Forms.ToolStripButton();
            btnZoomDown = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            btnColumns = new System.Windows.Forms.ToolStripButton();
            btnAutorun = new System.Windows.Forms.ToolStripButton();
            btnRun = new System.Windows.Forms.ToolStripButton();
            lblChanged = new System.Windows.Forms.ToolStripLabel();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            lblReadOnly = new System.Windows.Forms.ToolStripStatusLabel();
            lblUpgrade = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            lblZoom = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            lblCalltime = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            lblLatency = new System.Windows.Forms.ToolStripStatusLabel();
            btnSettings = new System.Windows.Forms.ToolStripDropDownButton();
            btnAbout = new System.Windows.Forms.ToolStripDropDownButton();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            btnPrevFile = new System.Windows.Forms.Button();
            btnNextFile = new System.Windows.Forms.Button();
            btnReconnect = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            comboFiles = new System.Windows.Forms.ComboBox();
            comboLists = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            menuFieldList = new System.Windows.Forms.ContextMenuStrip(components);
            field1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            field2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            field3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            webWiki = new WikiView2();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tabsLeft.SuspendLayout();
            tabsRight.SuspendLayout();
            tabText.SuspendLayout();
            tabRendered.SuspendLayout();
            tabDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridFiles).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            menuFieldList.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new Point(0, 40);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            splitContainer1.Panel1MinSize = 400;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabsRight);
            splitContainer1.Panel2MinSize = 300;
            splitContainer1.Size = new Size(1184, 554);
            splitContainer1.SplitterDistance = 688;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(tabsLeft);
            splitContainer3.Panel1MinSize = 200;
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(webWiki);
            splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 6);
            splitContainer3.Panel2MinSize = 50;
            splitContainer3.Size = new Size(688, 554);
            splitContainer3.SplitterDistance = 350;
            splitContainer3.TabIndex = 2;
            // 
            // tabsLeft
            // 
            tabsLeft.AllowDrop = true;
            tabsLeft.Controls.Add(tabPage5);
            tabsLeft.Controls.Add(tabPage6);
            tabsLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            tabsLeft.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabsLeft.Location = new Point(0, 0);
            tabsLeft.Margin = new System.Windows.Forms.Padding(2);
            tabsLeft.Name = "tabsLeft";
            tabsLeft.Padding = new Point(6, 4);
            tabsLeft.SelectedIndex = 0;
            tabsLeft.Size = new Size(688, 350);
            tabsLeft.TabIndex = 1;
            tabsLeft.DrawItem += tabsLeft_DrawItem;
            tabsLeft.SelectedIndexChanged += tabsLeft_SelectedIndexChanged;
            tabsLeft.DoubleClick += tabsLeft_DoubleClick;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 28);
            tabPage5.Margin = new System.Windows.Forms.Padding(2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(2);
            tabPage5.Size = new Size(680, 318);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "expr1";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 28);
            tabPage6.Margin = new System.Windows.Forms.Padding(2);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new System.Windows.Forms.Padding(2);
            tabPage6.Size = new Size(680, 318);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "🔗 [expr2] ❎";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabsRight
            // 
            tabsRight.Controls.Add(tabText);
            tabsRight.Controls.Add(tabRendered);
            tabsRight.Controls.Add(tabDatagrid);
            tabsRight.Dock = System.Windows.Forms.DockStyle.Fill;
            tabsRight.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabsRight.Location = new Point(0, 0);
            tabsRight.Margin = new System.Windows.Forms.Padding(2);
            tabsRight.Name = "tabsRight";
            tabsRight.Padding = new Point(6, 4);
            tabsRight.SelectedIndex = 0;
            tabsRight.Size = new Size(492, 554);
            tabsRight.TabIndex = 2;
            tabsRight.SelectedIndexChanged += tabsRight_SelectedIndexChanged;
            // 
            // tabText
            // 
            tabText.Controls.Add(txtOutput);
            tabText.Location = new Point(4, 28);
            tabText.Margin = new System.Windows.Forms.Padding(2);
            tabText.Name = "tabText";
            tabText.Padding = new System.Windows.Forms.Padding(2);
            tabText.Size = new Size(484, 522);
            tabText.TabIndex = 1;
            tabText.Text = "Text output";
            tabText.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            txtOutput.AutocompleteListSelectedBackColor = Color.FromArgb(0, 120, 215);
            txtOutput.BorderStyle = ScintillaNET.BorderStyle.FixedSingle;
            txtOutput.CaretStyle = ScintillaNET.CaretStyle.Invisible;
            txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            txtOutput.LexerName = null;
            txtOutput.Location = new Point(2, 2);
            txtOutput.Margin = new System.Windows.Forms.Padding(2);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(480, 518);
            txtOutput.TabIndex = 0;
            txtOutput.WhitespaceSize = 2;
            txtOutput.ZoomChanged += txtOutput_ZoomChanged;
            // 
            // tabRendered
            // 
            tabRendered.Controls.Add(renderBrowser);
            tabRendered.Location = new Point(4, 28);
            tabRendered.Margin = new System.Windows.Forms.Padding(2);
            tabRendered.Name = "tabRendered";
            tabRendered.Padding = new System.Windows.Forms.Padding(2);
            tabRendered.Size = new Size(484, 522);
            tabRendered.TabIndex = 0;
            tabRendered.Text = "Rendered output";
            tabRendered.UseVisualStyleBackColor = true;
            // 
            // renderBrowser
            // 
            renderBrowser.AllowWebBrowserDrop = false;
            renderBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            renderBrowser.Location = new Point(2, 2);
            renderBrowser.Margin = new System.Windows.Forms.Padding(2);
            renderBrowser.MinimumSize = new Size(15, 15);
            renderBrowser.Name = "renderBrowser";
            renderBrowser.Size = new Size(480, 518);
            renderBrowser.TabIndex = 0;
            renderBrowser.WebBrowserShortcutsEnabled = false;
            renderBrowser.PreviewKeyDown += browser_PreviewKeyDown;
            // 
            // tabDatagrid
            // 
            tabDatagrid.Controls.Add(gridFiles);
            tabDatagrid.Location = new Point(4, 28);
            tabDatagrid.Margin = new System.Windows.Forms.Padding(2);
            tabDatagrid.Name = "tabDatagrid";
            tabDatagrid.Padding = new System.Windows.Forms.Padding(2);
            tabDatagrid.Size = new Size(484, 522);
            tabDatagrid.TabIndex = 3;
            tabDatagrid.Text = "Playlist";
            tabDatagrid.UseVisualStyleBackColor = true;
            tabDatagrid.ClientSizeChanged += tabDatagrid_ClientSizeChanged;
            // 
            // gridFiles
            // 
            gridFiles.AllowUserToAddRows = false;
            gridFiles.AllowUserToDeleteRows = false;
            gridFiles.AllowUserToOrderColumns = true;
            gridFiles.AllowUserToResizeRows = false;
            gridFiles.BackgroundColor = SystemColors.Window;
            gridFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gridFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            gridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { cFile, cExpr1, cCalltime });
            gridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            gridFiles.Location = new Point(2, 2);
            gridFiles.Margin = new System.Windows.Forms.Padding(2);
            gridFiles.Name = "gridFiles";
            gridFiles.ReadOnly = true;
            gridFiles.RowHeadersVisible = false;
            gridFiles.RowHeadersWidth = 51;
            gridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            gridFiles.Size = new Size(480, 518);
            gridFiles.TabIndex = 0;
            // 
            // cFile
            // 
            cFile.HeaderText = "File";
            cFile.MinimumWidth = 6;
            cFile.Name = "cFile";
            cFile.ReadOnly = true;
            cFile.Width = 200;
            // 
            // cExpr1
            // 
            cExpr1.FillWeight = 50F;
            cExpr1.HeaderText = "expr1";
            cExpr1.MinimumWidth = 6;
            cExpr1.Name = "cExpr1";
            cExpr1.ReadOnly = true;
            cExpr1.Width = 125;
            // 
            // cCalltime
            // 
            cCalltime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            cCalltime.HeaderText = "call time";
            cCalltime.MinimumWidth = 6;
            cCalltime.Name = "cCalltime";
            cCalltime.ReadOnly = true;
            cCalltime.Width = 75;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnNew, btnLink, btnSave, btnRevert, btnClose, toolStripSeparator1, btnUndo, btnRedo, toolStripSeparator5, btnInsertField, btnInsertFunction, btnFunctionHelp, toolStripSeparator2, btnBold, btnUnderline, btnItalic, btnFont, btnImage, toolStripSeparator3, btnRename, chkWrap, chkWhitespace, btnZoomUp, btnZoomDown, toolStripSeparator4, btnColumns, btnAutorun, btnRun, lblChanged });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            toolStrip1.Size = new Size(1184, 40);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnNew.Image = Properties.Resources.script_add;
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(36, 37);
            btnNew.Text = "&New tab";
            btnNew.ToolTipText = "New tab (Ctrl+N)";
            btnNew.Click += btnNew_Click;
            // 
            // btnLink
            // 
            btnLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnLink.Image = Properties.Resources.link_add;
            btnLink.ImageTransparentColor = Color.Magenta;
            btnLink.Name = "btnLink";
            btnLink.Size = new Size(36, 37);
            btnLink.Text = "New Linked tab";
            btnLink.ToolTipText = "Open new tab linked to an MC field (Ctrl+L)\r\nUse CTRL+Click on a field name to allow duplicate field tabs.\r\n\r\n[Requires MC v32.0.18 or above with MCWS connection]";
            btnLink.Click += btnLink_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSave.Image = Properties.Resources.disk;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(36, 37);
            btnSave.Text = "Save";
            btnSave.ToolTipText = "Save to linked MC field (Ctrl+S)";
            btnSave.Click += btnSave_Click;
            // 
            // btnRevert
            // 
            btnRevert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnRevert.Image = Properties.Resources.reset_red_32;
            btnRevert.ImageTransparentColor = Color.Magenta;
            btnRevert.Name = "btnRevert";
            btnRevert.Size = new Size(36, 37);
            btnRevert.Text = "Revert";
            btnRevert.ToolTipText = "Reload expression from linked MC field (discard changes)";
            btnRevert.Click += btnRevert_Click;
            // 
            // btnClose
            // 
            btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnClose.Image = Properties.Resources.cross1;
            btnClose.ImageTransparentColor = Color.Magenta;
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 37);
            btnClose.Text = "Close tab";
            btnClose.ToolTipText = "Close tab (Ctrl+W)";
            btnClose.Click += btnClose_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 40);
            // 
            // btnUndo
            // 
            btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnUndo.Image = Properties.Resources.undo_2a2b2c_32;
            btnUndo.ImageTransparentColor = Color.Magenta;
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(36, 37);
            btnUndo.Text = "Undo";
            btnUndo.ToolTipText = "Undo (Ctrl+Z)";
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnRedo.Image = Properties.Resources.redo_2a2b2c_32;
            btnRedo.ImageTransparentColor = Color.Magenta;
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(36, 37);
            btnRedo.Text = "Redo";
            btnRedo.ToolTipText = "Redo (Ctrl+Y)";
            btnRedo.Click += btnRedo_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 40);
            // 
            // btnInsertField
            // 
            btnInsertField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnInsertField.Font = new Font("Lucida Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsertField.ForeColor = Color.Green;
            btnInsertField.Image = Properties.Resources.Field32;
            btnInsertField.ImageTransparentColor = Color.Magenta;
            btnInsertField.Margin = new System.Windows.Forms.Padding(0);
            btnInsertField.Name = "btnInsertField";
            btnInsertField.Size = new Size(36, 40);
            btnInsertField.Text = "[x]";
            btnInsertField.TextAlign = ContentAlignment.TopLeft;
            btnInsertField.ToolTipText = "Insert Field (F3)";
            btnInsertField.Click += btnInsertField_Click;
            // 
            // btnInsertFunction
            // 
            btnInsertFunction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnInsertFunction.Font = new Font("Segoe Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsertFunction.ForeColor = Color.Blue;
            btnInsertFunction.Image = Properties.Resources.Function32;
            btnInsertFunction.ImageTransparentColor = Color.Magenta;
            btnInsertFunction.Margin = new System.Windows.Forms.Padding(0);
            btnInsertFunction.Name = "btnInsertFunction";
            btnInsertFunction.Size = new Size(36, 40);
            btnInsertFunction.Text = "f(x)";
            btnInsertFunction.TextAlign = ContentAlignment.MiddleLeft;
            btnInsertFunction.ToolTipText = "Insert Function (F4)";
            btnInsertFunction.Click += btnInsertFunction_Click;
            // 
            // btnFunctionHelp
            // 
            btnFunctionHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnFunctionHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnFunctionHelp.Image = Properties.Resources.book_open;
            btnFunctionHelp.ImageTransparentColor = Color.Magenta;
            btnFunctionHelp.Margin = new System.Windows.Forms.Padding(0);
            btnFunctionHelp.Name = "btnFunctionHelp";
            btnFunctionHelp.Size = new Size(36, 40);
            btnFunctionHelp.Text = "Function syntax helper";
            btnFunctionHelp.ToolTipText = "Toggle the Function syntax helper panel";
            btnFunctionHelp.Click += btnFunctionHelp_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 40);
            // 
            // btnBold
            // 
            btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnBold.Font = new Font("Lucida Sans", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBold.Image = Properties.Resources.Bold32d;
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Margin = new System.Windows.Forms.Padding(0);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(36, 40);
            btnBold.Text = "B";
            btnBold.ToolTipText = "Bold tag (Ctrl+B)";
            btnBold.Click += btnBold_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnUnderline.Font = new Font("Lucida Sans Typewriter", 18.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnUnderline.Image = Properties.Resources.Underline32;
            btnUnderline.ImageTransparentColor = Color.Magenta;
            btnUnderline.Margin = new System.Windows.Forms.Padding(0);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(36, 40);
            btnUnderline.Text = "U";
            btnUnderline.ToolTipText = "Underline tag (Ctr+U)";
            btnUnderline.Click += btnUnderline_Click;
            // 
            // btnItalic
            // 
            btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnItalic.Font = new Font("Lucida Sans Typewriter", 18.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnItalic.Image = Properties.Resources.Italic32b;
            btnItalic.ImageTransparentColor = Color.Magenta;
            btnItalic.Margin = new System.Windows.Forms.Padding(0);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(36, 40);
            btnItalic.Text = "I";
            btnItalic.ToolTipText = "Italic tag (Ctrl+I)";
            btnItalic.Click += btnItalic_Click;
            // 
            // btnFont
            // 
            btnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnFont.Font = new Font("Lucida Sans Typewriter", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFont.ForeColor = Color.Maroon;
            btnFont.Image = Properties.Resources.Font32b;
            btnFont.ImageTransparentColor = Color.Magenta;
            btnFont.Margin = new System.Windows.Forms.Padding(0);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(36, 40);
            btnFont.Text = "Aa";
            btnFont.ToolTipText = "Font tag";
            btnFont.Click += btnFont_Click;
            // 
            // btnImage
            // 
            btnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnImage.Image = Properties.Resources.picture;
            btnImage.ImageTransparentColor = Color.Magenta;
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(36, 37);
            btnImage.Text = "Img";
            btnImage.ToolTipText = "Image tag";
            btnImage.Click += btnImage_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 40);
            // 
            // btnRename
            // 
            btnRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnRename.Image = Properties.Resources.rename_32_clear;
            btnRename.ImageTransparentColor = Color.Magenta;
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(36, 37);
            btnRename.Text = "&Rename tab";
            btnRename.ToolTipText = "Rename tab (F2)";
            btnRename.Click += btnRename_Click;
            // 
            // chkWrap
            // 
            chkWrap.CheckOnClick = true;
            chkWrap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            chkWrap.Image = Properties.Resources.text_wrap_32;
            chkWrap.ImageTransparentColor = Color.Magenta;
            chkWrap.Name = "chkWrap";
            chkWrap.Size = new Size(36, 37);
            chkWrap.Text = "Line wrap";
            chkWrap.ToolTipText = "Toggle line wrap";
            chkWrap.CheckedChanged += btnWrap_CheckedChanged;
            // 
            // chkWhitespace
            // 
            chkWhitespace.CheckOnClick = true;
            chkWhitespace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            chkWhitespace.Font = new Font("Lucida Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkWhitespace.Image = Properties.Resources.Pilcrow32;
            chkWhitespace.ImageTransparentColor = Color.Magenta;
            chkWhitespace.Margin = new System.Windows.Forms.Padding(0);
            chkWhitespace.Name = "chkWhitespace";
            chkWhitespace.Size = new Size(36, 40);
            chkWhitespace.Text = "¶";
            chkWhitespace.ToolTipText = "Show/hide whitespace";
            chkWhitespace.CheckedChanged += btnWhitespace_CheckedChanged;
            // 
            // btnZoomUp
            // 
            btnZoomUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnZoomUp.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZoomUp.Image = Properties.Resources.zoom_in_2a2b2c_32;
            btnZoomUp.ImageTransparentColor = Color.Magenta;
            btnZoomUp.Name = "btnZoomUp";
            btnZoomUp.Size = new Size(36, 37);
            btnZoomUp.Text = "Increase zoom";
            btnZoomUp.Click += btnZoomUp_Click;
            // 
            // btnZoomDown
            // 
            btnZoomDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnZoomDown.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZoomDown.Image = Properties.Resources.zoom_out_2a2b2c_32;
            btnZoomDown.ImageTransparentColor = Color.Magenta;
            btnZoomDown.Name = "btnZoomDown";
            btnZoomDown.Size = new Size(36, 37);
            btnZoomDown.Text = "Decrease zoom";
            btnZoomDown.Click += btnZoomDown_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 40);
            // 
            // btnColumns
            // 
            btnColumns.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnColumns.Image = Properties.Resources.table;
            btnColumns.ImageTransparentColor = Color.Magenta;
            btnColumns.Name = "btnColumns";
            btnColumns.Size = new Size(36, 37);
            btnColumns.Text = "Columns";
            btnColumns.ToolTipText = "Select datagrid columns and fields";
            btnColumns.Visible = false;
            btnColumns.Click += btnColumns_Click;
            // 
            // btnAutorun
            // 
            btnAutorun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnAutorun.Image = Properties.Resources.autoplayON32Red;
            btnAutorun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            btnAutorun.ImageTransparentColor = Color.Magenta;
            btnAutorun.Name = "btnAutorun";
            btnAutorun.Size = new Size(64, 37);
            btnAutorun.Text = "Automatic execution";
            btnAutorun.ToolTipText = "Toggle automatic execution (F6)";
            btnAutorun.Click += btnAutorun_Click;
            // 
            // btnRun
            // 
            btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnRun.Image = Properties.Resources.Play32;
            btnRun.ImageTransparentColor = Color.Magenta;
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(36, 37);
            btnRun.Text = "Automatic execution";
            btnRun.ToolTipText = "[Re]execute the current expression (F5)";
            btnRun.Click += btnRun_Click;
            // 
            // lblChanged
            // 
            lblChanged.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblChanged.ForeColor = Color.Red;
            lblChanged.Name = "lblChanged";
            lblChanged.Size = new Size(68, 37);
            lblChanged.Text = "modified!";
            lblChanged.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatus, lblReadOnly, lblUpgrade, toolStripStatusLabel3, lblZoom, toolStripStatusLabel2, lblCalltime, toolStripStatusLabel1, lblLatency, btnSettings, btnAbout });
            statusStrip1.Location = new Point(0, 631);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            statusStrip1.ShowItemToolTips = true;
            statusStrip1.Size = new Size(1184, 30);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.DarkSlateGray;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 25);
            lblStatus.Text = "Disconnected";
            // 
            // lblReadOnly
            // 
            lblReadOnly.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReadOnly.ForeColor = Color.FromArgb(192, 64, 0);
            lblReadOnly.Margin = new System.Windows.Forms.Padding(10, 3, 20, 2);
            lblReadOnly.Name = "lblReadOnly";
            lblReadOnly.Size = new Size(65, 25);
            lblReadOnly.Text = "Read-Only";
            lblReadOnly.TextAlign = ContentAlignment.MiddleLeft;
            lblReadOnly.Visible = false;
            // 
            // lblUpgrade
            // 
            lblUpgrade.ForeColor = Color.Red;
            lblUpgrade.Name = "lblUpgrade";
            lblUpgrade.Size = new Size(257, 25);
            lblUpgrade.Text = "ZELDA v1.0.0 is now available - click to upgrade";
            lblUpgrade.Visible = false;
            lblUpgrade.Click += lblUpgrade_Click;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.ForeColor = Color.FromArgb(0, 64, 64);
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(537, 25);
            toolStripStatusLabel3.Spring = true;
            // 
            // lblZoom
            // 
            lblZoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZoom.ForeColor = Color.FromArgb(0, 64, 64);
            lblZoom.Margin = new System.Windows.Forms.Padding(0, 3, 70, 2);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(57, 25);
            lblZoom.Text = "Zoom +1";
            lblZoom.ToolTipText = "click to reset zoom";
            lblZoom.Click += lblZoom_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel2.ForeColor = Color.FromArgb(0, 64, 64);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(82, 25);
            toolStripStatusLabel2.Text = "Last call time:";
            toolStripStatusLabel2.ToolTipText = "Call duration for last expression, including API overhead";
            // 
            // lblCalltime
            // 
            lblCalltime.AutoSize = false;
            lblCalltime.AutoToolTip = true;
            lblCalltime.ForeColor = Color.FromArgb(0, 64, 64);
            lblCalltime.Name = "lblCalltime";
            lblCalltime.Size = new Size(100, 25);
            lblCalltime.Text = "---";
            lblCalltime.TextAlign = ContentAlignment.MiddleLeft;
            lblCalltime.ToolTipText = "Call duration for last expression, including API overhead";
            lblCalltime.Click += lblLatency_Click;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.ForeColor = Color.FromArgb(0, 64, 64);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(85, 25);
            toolStripStatusLabel1.Text = "API overhead:";
            toolStripStatusLabel1.ToolTipText = resources.GetString("toolStripStatusLabel1.ToolTipText");
            // 
            // lblLatency
            // 
            lblLatency.AutoSize = false;
            lblLatency.AutoToolTip = true;
            lblLatency.ForeColor = Color.FromArgb(0, 64, 64);
            lblLatency.Name = "lblLatency";
            lblLatency.Size = new Size(100, 25);
            lblLatency.Text = "---";
            lblLatency.TextAlign = ContentAlignment.MiddleLeft;
            lblLatency.ToolTipText = "click to recalculate";
            lblLatency.Click += lblLatency_Click;
            // 
            // btnSettings
            // 
            btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnSettings.Image = Properties.Resources.cog24;
            btnSettings.ImageTransparentColor = Color.Magenta;
            btnSettings.Margin = new System.Windows.Forms.Padding(0, 2, 5, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.ShowDropDownArrow = false;
            btnSettings.Size = new Size(24, 28);
            btnSettings.ToolTipText = "Settings (F10)";
            btnSettings.Click += btnSettings_Click;
            // 
            // btnAbout
            // 
            btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            btnAbout.Image = Properties.Resources.help32;
            btnAbout.ImageTransparentColor = Color.Magenta;
            btnAbout.Margin = new System.Windows.Forms.Padding(0, 2, 10, 0);
            btnAbout.Name = "btnAbout";
            btnAbout.ShowDropDownArrow = false;
            btnAbout.Size = new Size(24, 28);
            btnAbout.ToolTipText = "About (F1)";
            btnAbout.Click += btnAbout_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnPrevFile);
            splitContainer2.Panel1.Controls.Add(btnNextFile);
            splitContainer2.Panel1.Controls.Add(btnReconnect);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Controls.Add(comboFiles);
            splitContainer2.Panel1.Controls.Add(comboLists);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer1);
            splitContainer2.Panel2.Controls.Add(toolStrip1);
            splitContainer2.Size = new Size(1184, 631);
            splitContainer2.SplitterDistance = 35;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 3;
            // 
            // btnPrevFile
            // 
            btnPrevFile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPrevFile.BackColor = Color.Transparent;
            btnPrevFile.FlatAppearance.BorderSize = 0;
            btnPrevFile.FlatAppearance.MouseOverBackColor = Color.PowderBlue;
            btnPrevFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrevFile.Image = Properties.Resources.ArrowLeft;
            btnPrevFile.Location = new Point(1148, 9);
            btnPrevFile.Margin = new System.Windows.Forms.Padding(2);
            btnPrevFile.Name = "btnPrevFile";
            btnPrevFile.Size = new Size(15, 15);
            btnPrevFile.TabIndex = 12;
            toolTip1.SetToolTip(btnPrevFile, "Previous file (Alt+Left)");
            btnPrevFile.UseVisualStyleBackColor = true;
            btnPrevFile.Click += btnPrevFile_Click;
            // 
            // btnNextFile
            // 
            btnNextFile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnNextFile.BackColor = Color.Transparent;
            btnNextFile.FlatAppearance.BorderSize = 0;
            btnNextFile.FlatAppearance.MouseOverBackColor = Color.PowderBlue;
            btnNextFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextFile.Image = Properties.Resources.ArrowRight;
            btnNextFile.Location = new Point(1165, 9);
            btnNextFile.Margin = new System.Windows.Forms.Padding(2);
            btnNextFile.Name = "btnNextFile";
            btnNextFile.Size = new Size(14, 15);
            btnNextFile.TabIndex = 12;
            toolTip1.SetToolTip(btnNextFile, "Next File (Alt+Right)");
            btnNextFile.UseVisualStyleBackColor = true;
            btnNextFile.Click += btnNextFile_Click;
            // 
            // btnReconnect
            // 
            btnReconnect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnReconnect.BackColor = Color.Transparent;
            btnReconnect.FlatAppearance.BorderSize = 0;
            btnReconnect.FlatAppearance.MouseOverBackColor = Color.PowderBlue;
            btnReconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReconnect.Image = Properties.Resources.refresh_2a2b2c;
            btnReconnect.Location = new Point(640, 5);
            btnReconnect.Margin = new System.Windows.Forms.Padding(2);
            btnReconnect.Name = "btnReconnect";
            btnReconnect.Size = new Size(24, 24);
            btnReconnect.TabIndex = 12;
            toolTip1.SetToolTip(btnReconnect, "Reload playlist");
            btnReconnect.UseVisualStyleBackColor = true;
            btnReconnect.Click += btnReconnect_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(848, 10);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 11;
            label2.Text = "File:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 10);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 11;
            label1.Text = "Playlist:";
            // 
            // comboFiles
            // 
            comboFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            comboFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboFiles.FormattingEnabled = true;
            comboFiles.Location = new Point(880, 7);
            comboFiles.Margin = new System.Windows.Forms.Padding(2);
            comboFiles.Name = "comboFiles";
            comboFiles.Size = new Size(265, 21);
            comboFiles.TabIndex = 2;
            comboFiles.SelectedIndexChanged += comboFiles_SelectedIndexChanged;
            // 
            // comboLists
            // 
            comboLists.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboLists.FormattingEnabled = true;
            comboLists.Location = new Point(60, 7);
            comboLists.Margin = new System.Windows.Forms.Padding(2);
            comboLists.Name = "comboLists";
            comboLists.Size = new Size(579, 21);
            comboLists.TabIndex = 1;
            comboLists.SelectedIndexChanged += comboLists_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(83, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // menuFieldList
            // 
            menuFieldList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { field1ToolStripMenuItem, field2ToolStripMenuItem, field3ToolStripMenuItem });
            menuFieldList.Name = "menuFieldList";
            menuFieldList.ShowImageMargin = false;
            menuFieldList.Size = new Size(81, 70);
            menuFieldList.ItemClicked += menuFieldList_ItemClicked;
            // 
            // field1ToolStripMenuItem
            // 
            field1ToolStripMenuItem.Name = "field1ToolStripMenuItem";
            field1ToolStripMenuItem.Size = new Size(80, 22);
            field1ToolStripMenuItem.Text = "Field1";
            // 
            // field2ToolStripMenuItem
            // 
            field2ToolStripMenuItem.Name = "field2ToolStripMenuItem";
            field2ToolStripMenuItem.Size = new Size(80, 22);
            field2ToolStripMenuItem.Text = "Field2";
            // 
            // field3ToolStripMenuItem
            // 
            field3ToolStripMenuItem.Name = "field3ToolStripMenuItem";
            field3ToolStripMenuItem.Size = new Size(80, 22);
            field3ToolStripMenuItem.Text = "Field3";
            // 
            // wikiView21
            // 
            webWiki.Dock = System.Windows.Forms.DockStyle.Fill;
            webWiki.Location = new Point(0, 5);
            webWiki.Name = "webWiki";
            webWiki.Size = new Size(688, 189);
            webWiki.TabIndex = 0;
            webWiki.OnInitializationCompleted += WebWiki_OnInitializationCompleted;
            // 
            // ZeldaUI
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(splitContainer2);
            Controls.Add(statusStrip1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new Size(800, 500);
            Name = "ZeldaUI";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ZELDA";
            FormClosing += ZeldaUI_FormClosing;
            Load += ZeldaUI_Load;
            Shown += ZeldaUI_Shown;
            KeyDown += ZeldaUI_KeyDown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tabsLeft.ResumeLayout(false);
            tabsRight.ResumeLayout(false);
            tabText.ResumeLayout(false);
            tabRendered.ResumeLayout(false);
            tabDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridFiles).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            menuFieldList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel lblZoom;
        private System.Windows.Forms.ToolStripStatusLabel lblUpgrade;
        private System.Windows.Forms.ToolStripButton btnRevert;
        private System.Windows.Forms.ContextMenuStrip menuFieldList;
        private System.Windows.Forms.ToolStripMenuItem field1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem field2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem field3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblReadOnly;
        private System.Windows.Forms.ToolStripButton btnRun;
        private WikiView2 webWiki;
    }
}

