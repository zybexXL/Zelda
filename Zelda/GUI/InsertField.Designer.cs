namespace Zelda
{
    partial class InsertField
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
            this.button1 = new System.Windows.Forms.Button();
            this.gridFields = new System.Windows.Forms.DataGridView();
            this.cField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.chkUnformatted = new System.Windows.Forms.CheckBox();
            this.chkValue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(465, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gridFields
            // 
            this.gridFields.AllowUserToAddRows = false;
            this.gridFields.AllowUserToDeleteRows = false;
            this.gridFields.AllowUserToResizeRows = false;
            this.gridFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFields.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gridFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cField,
            this.cValue});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFields.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridFields.Location = new System.Drawing.Point(12, 35);
            this.gridFields.MultiSelect = false;
            this.gridFields.Name = "gridFields";
            this.gridFields.ReadOnly = true;
            this.gridFields.RowHeadersVisible = false;
            this.gridFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFields.Size = new System.Drawing.Size(502, 260);
            this.gridFields.TabIndex = 2;
            this.gridFields.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridFields_KeyDown);
            this.gridFields.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridFields_MouseDoubleClick);
            // 
            // cField
            // 
            this.cField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cField.DataPropertyName = "field";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cField.DefaultCellStyle = dataGridViewCellStyle3;
            this.cField.HeaderText = "Field Name";
            this.cField.Name = "cField";
            this.cField.ReadOnly = true;
            this.cField.Width = 96;
            // 
            // cValue
            // 
            this.cValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cValue.DataPropertyName = "value";
            this.cValue.HeaderText = "Value";
            this.cValue.Name = "cValue";
            this.cValue.ReadOnly = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 8);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(177, 21);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // chkUnformatted
            // 
            this.chkUnformatted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUnformatted.AutoSize = true;
            this.chkUnformatted.Location = new System.Drawing.Point(367, 8);
            this.chkUnformatted.Name = "chkUnformatted";
            this.chkUnformatted.Size = new System.Drawing.Size(92, 19);
            this.chkUnformatted.TabIndex = 3;
            this.chkUnformatted.Text = "unformatted";
            this.chkUnformatted.UseVisualStyleBackColor = true;
            // 
            // chkValue
            // 
            this.chkValue.AutoSize = true;
            this.chkValue.Location = new System.Drawing.Point(195, 10);
            this.chkValue.Name = "chkValue";
            this.chkValue.Size = new System.Drawing.Size(80, 19);
            this.chkValue.TabIndex = 3;
            this.chkValue.Text = "with value";
            this.chkValue.UseVisualStyleBackColor = true;
            this.chkValue.CheckedChanged += new System.EventHandler(this.chkValue_CheckedChanged);
            // 
            // InsertField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 307);
            this.Controls.Add(this.chkValue);
            this.Controls.Add(this.chkUnformatted);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.gridFields);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertField";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert field";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridFields;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.CheckBox chkUnformatted;
        private System.Windows.Forms.DataGridViewTextBoxColumn cField;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
        private System.Windows.Forms.CheckBox chkValue;
    }
}