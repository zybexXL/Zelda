using System;
using System.Data;
using System.Linq;
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

            var cats = Enum.GetNames(typeof(ELCategory)).OrderBy(a => a).ToList();
            cats.Insert(0, "All categories");
            comboCat.DataSource = cats;
            comboCat.SelectedIndex = 0;
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

        private void Filter()
        {
            if (loading) return;
            bool catAll = comboCat.SelectedIndex == 0;

            var bs = gridFunc.DataSource as BindingSource;
            if (catAll && string.IsNullOrWhiteSpace(txtFilter.Text))
                bs.RemoveFilter();
            else
            {
                string[] parts = txtFilter.Text.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string cat = catAll ? "" : $"category='{comboCat.Text}'";
                if (parts.Length > 0 && !string.IsNullOrEmpty(cat)) cat = $"{cat} AND ";
                string filter = cat + string.Join(" AND ", parts.Select(p => $"[filter] like '%{p}%'"));
                try { bs.Filter = filter; } catch { }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
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
            LoadWiki();
        }

        private void LoadWiki()
        {
            if (!loading && gridFunc.SelectedRows.Count == 1)
            {
                var func = gridFunc.SelectedRows[0].Cells[0].Value as ELFunction;
                wikiView.LoadWiki(func);
            }
        }

        private void InsertFunction_Load(object sender, EventArgs e)
        {
            gridFunc.ClearSelection();
            loading = false;
            gridFunc.Rows[0].Selected = true;
        }

        private void wikiView_OnInitializationCompleted(object sender, EventArgs e)
        {
            if (!wikiView.Initialized)
            {
                lblWikiError.Visible = true;
                wikiView.Visible = false;
            }
            else
                LoadWiki();
        }
    }
}
