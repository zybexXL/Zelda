using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelda
{
    public partial class TextEditor : UserControl
    {
        public event EventHandler<int> ZoomChanged;
        public event EventHandler ContentChanged;

        public TextEditor()
        {
            InitializeComponent();
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {
            ContentChanged?.Invoke(this, EventArgs.Empty);
        }

        private void txtExpression_ZoomChanged(object sender, EventArgs e)
        {
            ZoomChanged?.Invoke(this, txtExpression.Zoom);
        }
    }
}
