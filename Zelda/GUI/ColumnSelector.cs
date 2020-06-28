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
    public partial class ColumnSelector : Form
    {
        public List<string> SelectedFields;
        public List<string> SelectedExpressions;
        public bool showAll;

        public ColumnSelector(List<string> allFields, List<string> selectedFields, bool allExpr)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            chkAllExpressions.Checked = allExpr;

            foreach (var f in selectedFields)
                if (allFields.Contains(f, StringComparer.InvariantCultureIgnoreCase))
                    listFields.Items.Add(f, true);
            foreach (var f in allFields)
                if (!selectedFields.Contains(f, StringComparer.InvariantCultureIgnoreCase))
                    listFields.Items.Add(f, false);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            showAll = chkAllExpressions.Checked;

            SelectedFields = new List<string>();
            SelectedExpressions = new List<string>();
            for (int i = 0; i < listFields.Items.Count; i++)
                if (listFields.GetItemChecked(i))
                    SelectedFields.Add(listFields.Items[i].ToString());

            this.Close();
        }
    }
}
