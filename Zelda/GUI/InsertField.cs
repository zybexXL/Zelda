using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelda
{
    public partial class InsertField : Form
    {
        public string selected = null;
        public bool unformatted = false;

        public InsertField(List<string> fields, JRFile file, JRiverAPI api)
        {
            InitializeComponent();

            Icon = Properties.Resources.ZeldaIcon;
            DataTable dt = new DataTable();
            dt.Columns.Add("field");
            dt.Columns.Add("value");
            foreach (var f in fields.OrderBy(f => f))
                dt.Rows.Add(f, file == null ? null : file[f]);

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            gridFields.DataSource = bs;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            unformatted = chkUnformatted.Checked;
            if (gridFields.SelectedRows.Count == 1)
            {
                selected = gridFields.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                Close();
            }
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnOK_Click(null, EventArgs.Empty);
            }
        }

        private void Filter()
        {
            var bs = gridFields.DataSource as BindingSource;
            if (string.IsNullOrWhiteSpace(txtFilter.Text) && !chkValue.Checked)
                bs.RemoveFilter();
            else
            {
                string[] parts = txtFilter.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string exclude = chkValue.Checked ? "value <> ''" : "";
                if (parts.Length > 0 && !string.IsNullOrEmpty(exclude)) exclude = $"{exclude} AND ";
                string filter = exclude + string.Join(" AND ", parts.Select(p => $"field like '%{p}%'"));
                try { bs.Filter = filter; } catch { }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void chkValue_CheckedChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void gridFields_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnOK_Click(null, EventArgs.Empty);
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridFields.SelectedRows.Count > 0)
            {
                e.SuppressKeyPress = true;
                int currentRow = gridFields.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Down && currentRow < gridFields.RowCount - 1)
                {
                    gridFields.Rows[++currentRow].Selected = true;
                    gridFields.CurrentCell = gridFields.Rows[currentRow].Cells[1];
                }
                else if (e.KeyCode == Keys.Up && currentRow > 0)
                {
                    gridFields.Rows[--currentRow].Selected = true;
                    gridFields.CurrentCell = gridFields.Rows[currentRow].Cells[1];
                }
                else
                    e.SuppressKeyPress = false;
            }
        }

        private void gridFields_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnOK_Click(null, EventArgs.Empty);
        }
    }
}
