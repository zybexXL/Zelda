using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelda
{
    public partial class InsertFunction : Form
    {
        public ELFunction selected = null;
        bool loading;

        public InsertFunction()
        {
            InitializeComponent();
            Icon = Properties.Resources.ZeldaIcon;
            DataTable dt = new DataTable();
            dt.Columns.Add("obj", typeof(ELFunction));
            dt.Columns.Add("function");
            dt.Columns.Add("blurb");
            dt.Columns.Add("category");
            dt.Columns.Add("filter");
            foreach (var f in ELConstants.ELFunctionWiki)
                dt.Rows.Add(f, f.function, f.blurb, f.category, f.filter);

            loading = true;
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            gridFunc.DataSource = bs;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (gridFunc.SelectedRows.Count == 1)
            {
                selected = gridFunc.SelectedRows[0].Cells[0].Value as ELFunction;
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var bs = gridFunc.DataSource as BindingSource;
            if (string.IsNullOrEmpty(txtFilter.Text))
                bs.RemoveFilter();
            else
            {
                string[] parts = txtFilter.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                try { bs.Filter = string.Join(" AND ", parts.Select(p => $"[filter] like '%{p}%'")); } catch { }
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridFunc.SelectedRows.Count > 0)
            {
                e.SuppressKeyPress = true;
                int currentRow = gridFunc.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Down && currentRow < gridFunc.RowCount - 1)
                {
                    gridFunc.Rows[++currentRow].Selected = true;
                    gridFunc.CurrentCell = gridFunc.Rows[currentRow].Cells[1];
                }
                else if (e.KeyCode == Keys.Up && currentRow > 0)
                {
                    gridFunc.Rows[--currentRow].Selected = true;
                    gridFunc.CurrentCell = gridFunc.Rows[currentRow].Cells[1];
                }
                else
                    e.SuppressKeyPress = false;
            }
        }

        private void gridFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnOK_Click(null, EventArgs.Empty);
            }
        }

        private void gridFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnOK_Click(null, EventArgs.Empty);
        }

        private void gridFunc_SelectionChanged(object sender, EventArgs e)
        {          
            if (!loading && gridFunc.SelectedRows.Count == 1)
            {
                var func = gridFunc.SelectedRows[0].Cells[0].Value as ELFunction;
                LoadWiki(func);
            }
        }

        void LoadWiki(ELFunction func)
        {
            webBrowser.Stop();
            if (string.IsNullOrEmpty(func?.wikiUrl))
                webBrowser.DocumentText = $"<b>{func?.function}():</b> Wiki not available for this function";
            else
                webBrowser.Navigate(func?.wikiUrl);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var node = webBrowser.Document.GetElementById("column-one");
            if (node != null) node.OuterHtml = "";
            node = webBrowser.Document.GetElementById("footer");
            if (node != null) node.OuterHtml = "";
            node = webBrowser.Document.GetElementById("catlinks");
            if (node != null) node.OuterHtml = "";

            node = webBrowser.Document.GetElementById("content");
            node.Style = "margin: 0 0 0 0; border:0; padding: 0;";

            Match m = Regex.Match(e.Url.ToString(), "([^#]+)#?(.+)?");
            if (m.Success && !string.IsNullOrEmpty(m.Groups[2].Value))
            {
                node = webBrowser.Document.GetElementById(m.Groups[2].Value);
                node?.ScrollIntoView(true);
            }
        }

        private void InsertFunction_Load(object sender, EventArgs e)
        {
            gridFunc.ClearSelection();
            loading = false;
            gridFunc.Rows[0].Selected = true;
        }
    }
}
