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

        private void bSave_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*|Structured Query Language file (*.sql)|*.sql";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.AppendAllText(saveFileDialog1.FileName, Environment.NewLine + Environment.NewLine + this.richTextBoxSQL.Text.Trim());

                }
        }

    }
}
