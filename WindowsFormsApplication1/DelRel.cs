using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DelRel : Form
    {
        public DelRel(string Sql)
        {
            InitializeComponent();
            this.richTextBoxSQL.Text = Sql;
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.richTextBoxSQL.Text.ToString());
        }

    }
}
