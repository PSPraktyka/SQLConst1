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
    public partial class CSGenerator : Form
    {
        TextBox TB = null;
        public CSGenerator(TextBox Textbox)
        {
            InitializeComponent();
            TB = Textbox;
        }

        private void GenerateButton_Click(object sender , EventArgs e)
        {
            if (this.ServerTextBox.Text.Trim() != "" && this.dbTextBox.Text.Trim() != "" && this.ServerTextBox.ForeColor != Color.Red && this.dbTextBox.ForeColor != Color.Red)
            {
                string ConnectionString = "Data Source=" + this.ServerTextBox.Text.Trim() + ";Initial Catalog=" + this.dbTextBox.Text.Trim() + ";Integrated Security=True;";
                this.ConnectionStringTextBox.Text = ConnectionString;
                this.dbTextBox.Clear();
                this.ServerTextBox.Clear();
                this.CopyButton.Enabled = true;
            }
            else
            {
                if (this.ServerTextBox.Text.Trim() == "")
                {
                    this.ServerTextBox.Text = "Pole musi być uzupełnione!";
                    this.ServerTextBox.ForeColor = Color.Red;
                }
                if (this.dbTextBox.Text.Trim() == "")
                {
                    this.dbTextBox.Text = "Pole musi być uzupełnione!";
                    this.dbTextBox.ForeColor = Color.Red;
                }
            }
        }

        private void ServerTextBox_Enter(object sender , EventArgs e)
        {
            if (this.ServerTextBox.Text == "Pole musi być uzupełnione!")
            {
                this.ServerTextBox.Clear();
                this.ServerTextBox.ForeColor = Color.Black;
            }
        }

        private void dbTextBox_Enter(object sender , EventArgs e)
        {
            if (this.dbTextBox.Text == "Pole musi być uzupełnione!")
            {
                this.dbTextBox.Clear();
                this.dbTextBox.ForeColor = Color.Black;
            }
        }

        private void CopyButton_Click(object sender , EventArgs e)
        {
            TB.Text = this.ConnectionStringTextBox.Text.Trim();
            this.Dispose();
        }
    }
}
