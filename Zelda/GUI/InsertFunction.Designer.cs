namespace Zelda
{
    partial class InsertFunction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridFunc = new System.Windows.Forms.DataGridView();
            this.cObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBlurb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFunc
            // 
            this.gridFunc.AllowUserToAddRows = false;
            this.gridFunc.AllowUserToDeleteRows = false;
            this.gridFunc.AllowUserToResizeRows = false;
            this.gridFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFunc.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cObj,
            this.cFunction,
            this.cBlurb,
            this.cCategory,
            this.filter});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFunc.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridFunc.Location = new System.Drawing.Point(12, 39);
            this.gridFunc.MultiSelect = false;
            this.gridFunc.Name = "gridFunc";
            this.gridFunc.ReadOnly = true;
            this.gridFunc.RowHeadersVisible = false;
            this.gridFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFunc.Size = new System.Drawing.Size(789, 232);
            this.gridFunc.TabIndex = 1;
            this.gridFunc.SelectionChanged += new System.EventHandler(this.gridFunc_SelectionChanged);
            this.gridFunc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridFunc_KeyDown);
            this.gridFunc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridFunc_MouseDoubleClick);
            // 
            // cObj
            // 
            this.cObj.DataPropertyName = "obj";
            this.cObj.HeaderText = "funcObj";
            this.cObj.Name = "cObj";
            this.cObj.ReadOnly = true;
            this.cObj.Visible = false;
            // 
            // cFunction
            // 
            this.cFunction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cFunction.DataPropertyName = "function";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFunction.DefaultCellStyle = dataGridViewCellStyle5;
            this.cFunction.HeaderText = "Function";
            this.cFunction.Name = "cFunction";
            this.cFunction.ReadOnly = true;
            this.cFunction.Width = 79;
            // 
            // cBlurb
            // 
            this.cBlurb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cBlurb.DataPropertyName = "blurb";
            this.cBlurb.HeaderText = "Description";
            this.cBlurb.Name = "cBlurb";
            this.cBlurb.ReadOnly = true;
            // 
            // cCategory
            // 
            this.cCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCategory.DataPropertyName = "category";
            this.cCategory.HeaderText = "Category";
            this.cCategory.Name = "cCategory";
            this.cCategory.ReadOnly = true;
            this.cCategory.Width = 80;
            // 
            // filter
            // 
            this.filter.DataPropertyName = "filter";
            this.filter.HeaderText = "filter";
            this.filter.Name = "filter";
            this.filter.ReadOnly = true;
            this.filter.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(55, 10);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(177, 21);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(752, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(49, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(12, 281);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(789, 242);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.TabStop = false;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // comboCat
            // 
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(248, 9);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(137, 23);
            this.comboCat.TabIndex = 9;
            this.comboCat.SelectedIndexChanged += new System.EventHandler(this.comboCat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter:";
            // 
            // InsertFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gridFunc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertFunction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert function";
            this.Load += new System.EventHandler(this.InsertFunction_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridFunc;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.DataGridViewTextBoxColumn cObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBlurb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn filter;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.Label label1;
    }
}