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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            gridFunc = new System.Windows.Forms.DataGridView();
            cObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cBlurb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            filter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtFilter = new System.Windows.Forms.TextBox();
            btnOK = new System.Windows.Forms.Button();
            comboCat = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            wikiView = new WikiView2();
            lblWikiError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)gridFunc).BeginInit();
            SuspendLayout();
            // 
            // gridFunc
            // 
            gridFunc.AllowUserToAddRows = false;
            gridFunc.AllowUserToDeleteRows = false;
            gridFunc.AllowUserToResizeRows = false;
            gridFunc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridFunc.BackgroundColor = System.Drawing.SystemColors.Info;
            gridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { cObj, cFunction, cBlurb, cCategory, filter });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            gridFunc.DefaultCellStyle = dataGridViewCellStyle4;
            gridFunc.Location = new System.Drawing.Point(12, 39);
            gridFunc.MultiSelect = false;
            gridFunc.Name = "gridFunc";
            gridFunc.ReadOnly = true;
            gridFunc.RowHeadersVisible = false;
            gridFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            gridFunc.Size = new System.Drawing.Size(789, 232);
            gridFunc.TabIndex = 1;
            gridFunc.SelectionChanged += gridFunc_SelectionChanged;
            gridFunc.KeyDown += gridFunc_KeyDown;
            gridFunc.MouseDoubleClick += gridFunc_MouseDoubleClick;
            // 
            // cObj
            // 
            cObj.DataPropertyName = "obj";
            cObj.HeaderText = "funcObj";
            cObj.Name = "cObj";
            cObj.ReadOnly = true;
            cObj.Visible = false;
            // 
            // cFunction
            // 
            cFunction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cFunction.DataPropertyName = "function";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cFunction.DefaultCellStyle = dataGridViewCellStyle3;
            cFunction.HeaderText = "Function";
            cFunction.Name = "cFunction";
            cFunction.ReadOnly = true;
            cFunction.Width = 79;
            // 
            // cBlurb
            // 
            cBlurb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cBlurb.DataPropertyName = "blurb";
            cBlurb.HeaderText = "Description";
            cBlurb.Name = "cBlurb";
            cBlurb.ReadOnly = true;
            // 
            // cCategory
            // 
            cCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            cCategory.DataPropertyName = "category";
            cCategory.HeaderText = "Category";
            cCategory.Name = "cCategory";
            cCategory.ReadOnly = true;
            cCategory.Width = 80;
            // 
            // filter
            // 
            filter.DataPropertyName = "filter";
            filter.HeaderText = "filter";
            filter.Name = "filter";
            filter.ReadOnly = true;
            filter.Visible = false;
            // 
            // txtFilter
            // 
            txtFilter.Location = new System.Drawing.Point(55, 10);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new System.Drawing.Size(177, 21);
            txtFilter.TabIndex = 0;
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.KeyDown += txtFilter_KeyDown;
            // 
            // btnOK
            // 
            btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnOK.Location = new System.Drawing.Point(752, 8);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(49, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // comboCat
            // 
            comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboCat.FormattingEnabled = true;
            comboCat.Location = new System.Drawing.Point(248, 9);
            comboCat.Name = "comboCat";
            comboCat.Size = new System.Drawing.Size(137, 23);
            comboCat.TabIndex = 9;
            comboCat.SelectedIndexChanged += comboCat_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 15);
            label1.TabIndex = 10;
            label1.Text = "Filter:";
            // 
            // wikiView
            // 
            wikiView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            wikiView.Location = new System.Drawing.Point(12, 281);
            wikiView.Name = "wikiView";
            wikiView.Size = new System.Drawing.Size(789, 242);
            wikiView.TabIndex = 11;
            wikiView.OnInitializationCompleted += wikiView_OnInitializationCompleted;
            // 
            // lblWikiError
            // 
            lblWikiError.AutoSize = true;
            lblWikiError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblWikiError.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            lblWikiError.Location = new System.Drawing.Point(12, 281);
            lblWikiError.Name = "lblWikiError";
            lblWikiError.Size = new System.Drawing.Size(314, 17);
            lblWikiError.TabIndex = 12;
            lblWikiError.Text = "Wiki unavailable - failed to initialize WebView control";
            lblWikiError.Visible = false;
            // 
            // InsertFunction
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(813, 535);
            Controls.Add(lblWikiError);
            Controls.Add(wikiView);
            Controls.Add(label1);
            Controls.Add(comboCat);
            Controls.Add(txtFilter);
            Controls.Add(btnOK);
            Controls.Add(gridFunc);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsertFunction";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Insert function";
            Load += InsertFunction_Load;
            KeyPress += form_KeyPress;
            ((System.ComponentModel.ISupportInitialize)gridFunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView gridFunc;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn cObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBlurb;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn filter;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.Label label1;
        private WikiView2 wikiView;
        private System.Windows.Forms.Label lblWikiError;
    }
}