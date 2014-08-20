using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection Connect = new SqlConnection();
        SqlCommand Query = new SqlCommand();
        List<string> TableElementList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)  // Łączenie z bazą danych
        {
            Connection();
        }

        private void TablesList_SelectedIndexChanged(object sender, EventArgs e) // Wybieranie tabeli
        {
            this.ColumnListBox.Items.Clear();
            try
            {
                string[] table_name = this.TablesList1.SelectedItem.ToString().Split(new string[] { "." }, StringSplitOptions.None);
                Query.CommandText = "SELECT column_name , data_type FROM information_schema.columns WHERE table_name = '" + table_name[1] + "'";
                Connect.Open();
                SqlDataReader Reader = Query.ExecuteReader();
                while (Reader.Read())
                {
                    this.ColumnListBox.Items.Add(Reader.GetValue(0).ToString());
                }
                this.ColumnListBox.Enabled = true;

            }
            catch (Exception error)
            {
                ShowErrorPopup(error.Message);
            }
            finally
            {
                Connect.Close();
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Reset();
            this.Connection_StringTextBox.Clear();

        }

        private void Reset()
        {
            this.ColumnListBox.Enabled = false;
            this.TablesList1.Enabled = false;
            this.TablesList1.Items.Clear();
            TableElementList.Clear();
            this.ColumnListBox2.Enabled = false;
            this.TablesList2.Enabled = false;
            this.TablesList2.Items.Clear();
            this.SearchTextBox.Enabled = false;
            this.SearchTextBox.Clear();
            this.SearchTextBox2.Enabled = false;
            this.SearchTextBox2.Clear();
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            List<string> List = ColumnListBox.Items.OfType<string>().ToList();
            string addon = null;
            int b = 0;
            string queryString = "SELECT ";
            string countQuery = "SELECT COUNT(*) FROM " + this.TablesList1.SelectedItem.ToString();
            string[] table_name = this.TablesList1.SelectedItem.ToString().Split(new string[] { "." }, StringSplitOptions.None);
            string identity = IdentityCheck(table_name[1]);
            Query.CommandText = countQuery;
            Connect.Open();

            int count = System.Int32.Parse(Query.ExecuteScalar().ToString());

            string scriptString = null;
            if (identity != null && List.Contains(identity))
            {
                scriptString += "SET IDENTITY_INSERT " + this.TablesList1.SelectedItem.ToString() + " ON\n\n";
            }
            scriptString += "INSERT INTO " + this.TablesList1.SelectedItem.ToString() + " ";

            scriptString += "(";
            for (int i = 0; i < List.Count(); i++)
            {

                if (i == (List.Count() - 1))
                    addon = null;
                else
                    addon = ", ";

                queryString += ("\"" + List[i] + "\" " + addon);
                scriptString += ("[" + List[i] + "] " + addon);


            }
            queryString += ("FROM " + this.TablesList1.SelectedItem.ToString());
            scriptString += ") VALUES";


            if (count > 1000)
            {
                Popup popup = new Popup();
                popup.SetDesktopLocation((this.Location.X + ((this.Size.Width - 300) / 2)), (this.Location.Y + (this.Size.Height - 200) / 2));
                DialogResult dialogresult = popup.ShowDialog();
                if (dialogresult == DialogResult.Cancel)
                {
                    Connect.Close();
                }
                else if (dialogresult == DialogResult.OK)
                {
                    SaveFileList(queryString, scriptString, List, identity);
                }
                popup.Dispose();
            }

            else
            {
                try
                {

                    Query.CommandText = queryString;

                    SqlDataReader Reader = Query.ExecuteReader();
                    while (Reader.Read())
                    {
                        if (b != 0)
                            scriptString += "),";
                        scriptString += "\n(";
                        for (int i = 0; i < List.Count(); i++)
                        {
                            if (i == (List.Count() - 1))
                                addon = null;
                            else
                                addon = ", ";
                            scriptString += ReadReader(Reader, addon, i);
                        }
                        b++;

                    }
                    if (b != 0)
                    {
                        scriptString += ");";
                        if (identity != null && List.Contains(identity))
                        {
                            scriptString += "\n\nSET IDENTITY_INSERT " + this.TablesList1.SelectedItem.ToString() + " OFF";
                        }
                        this.CountLabel.Text = "Liczba wierszy: " + count.ToString();
                    }

                    Connect.Close();
                }
                catch (Exception error)
                {
                    ShowErrorPopup(error.Message);
                }
                finally
                {
                    Connect.Close();
                }
            }
        }



        private void SaveFile(string text)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|Structured Query Language file (*.sql)|*.sql";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(text);
                }
            }
        }

        /*  private void SelecAllButton_Click(object sender, EventArgs e)
          {
              Boolean check;
              if (this.ColumnList.CheckedItems.Count == 0)
                  check = true;
              else
                  check = false;
              for (int i = 0; i < this.ColumnList.Items.Count; i++)
              {
                  this.ColumnList.SetItemChecked(i, check);
                  this.GenerateButton.Enabled = check;
              }
              SelectAllButtonTextChange();
          }
         */

        private string IdentityCheck(string tableName)
        {
            Query.CommandText = "select c.name from sys.objects o ,sys.columns c ,sys.tables t where o.object_id = c.object_id and c.object_id = t.object_id and c.is_identity = 1 and t.name='" + tableName + "' group by (c.name)";
            Connect.Open();
            try
            {
                return Query.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }
            finally
            {
                Connect.Close();
            }
        }

        private void SaveFileList(string query, string script, List<string> List, string identity)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string local = null, addon = null;
            int b = 0;
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|Structured Query Language file (*.sql)|*.sql";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.WriteLine(script);
                        Query.CommandText = query;
                        SqlDataReader Reader = Query.ExecuteReader();
                        while (Reader.Read())
                        {
                            local = null;
                            if (b != 0)
                                local += "),\n";
                            local += "(";
                            for (int i = 0; i < List.Count(); i++)
                            {
                                if (i == (List.Count() - 1))
                                    addon = null;
                                else
                                    addon = ", ";

                                local += ReadReader(Reader, addon, i);
                            }
                            b++;
                            sw.Write(local);
                        }
                        sw.Write(");");
                        if (identity != null)
                            sw.WriteLine("\n\nSET IDENTITY_INSERT " + this.TablesList1.SelectedItem.ToString() + " OFF");

                    }
                }
                catch (Exception error)
                {
                    ShowErrorPopup(error.Message);
                }
                finally
                {
                    Connect.Close();
                }
            }
        }


        private string ReadReader(SqlDataReader Reader, string addon, int i)
        {
            long ReaderPos = 0;
            string scriptString = null/*, test=null*/;
            if (Reader.GetFieldType(i).ToString() == "System.DateTime") // data
                scriptString += ("convert(datetime, '" + Reader.GetValue(i).ToString().Replace("'", "") + "', 20)" + addon);
            else if (Reader.GetFieldType(i).ToString() == "System.Int32" || Reader.GetFieldType(i).ToString() == "System.Decimal" || Reader.GetFieldType(i).ToString() == "System.Int16" || Reader.GetFieldType(i).ToString() == "System.Byte") //liczbowe
            {
                if (Reader.GetValue(i).ToString() != "")
                    scriptString += (Reader.GetValue(i).ToString() + addon);
                else
                    scriptString += ("NULL" + addon);
            }
            else if (Reader.GetFieldType(i).ToString() == "System.Boolean")
            {
                if (Reader.GetValue(i).ToString() != "")
                {
                    if (Reader.GetValue(i).ToString() == "True")
                        scriptString += ("1" + addon);
                    else
                        scriptString += ("0" + addon);
                }
                else
                    scriptString += ("NULL" + addon);
            }
            else if (Reader.GetFieldType(i).ToString() == "System.Byte[]")
            {
                scriptString += "0x";

                try
                {
                    long length = Reader.GetSqlBytes(i).Stream.Length;
                    while (ReaderPos != length)
                    {
                        int bytestToRead;
                        if (length - ReaderPos > Int32.MaxValue)
                            bytestToRead = Int32.MaxValue;
                        else
                            bytestToRead = Convert.ToInt32(length - ReaderPos);

                        byte[] buff = new byte[bytestToRead];

                        long BytesRead = Reader.GetBytes(i, ReaderPos, buff, 0, bytestToRead);
                        ReaderPos += BytesRead;

                        scriptString += ByteToStr(buff);
                    }
                }
                catch
                {
                    scriptString = "NULL";
                }
                finally
                {
                    scriptString += addon;
                }
            }
            else
            {
                if (Reader.GetValue(i).ToString() != "")
                    scriptString += ("'" + Reader.GetValue(i).ToString().Replace("'", "") + "'" + addon);
                else
                    scriptString += ("NULL" + addon);
            }
            //test += (Reader.GetFieldType(i).ToString() + "\n");
            return scriptString;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.TablesList1.BeginUpdate();
            this.TablesList1.Items.Clear();
            foreach (var item in TableElementList)
            {
                if (item.ToString().ToLower().Contains(this.SearchTextBox.Text.ToLower()))
                    TablesList1.Items.Add(item.ToString());
            }
            this.TablesList1.EndUpdate();
        }

        private string ByteToStr(byte[] tab)
        {
            StringBuilder hex = new StringBuilder(tab.Length * 2);
            foreach (byte b in tab)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {

        }

        private void Connection_StringTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Connection();
            }
        }
        private void Connection()
        {
            Reset();
            string ConnectionString;
            if (this.Connection_StringTextBox.Text.Trim() == "" || this.Connection_StringTextBox.ForeColor == Color.Red)
            {
                this.Connection_StringTextBox.Text = "Nie podano Connection Stringa!";
                this.Connection_StringTextBox.ForeColor = Color.Red;
            }
            else
            {
                ConnectionString = this.Connection_StringTextBox.Text.Trim();
                try
                {

                    Connect.ConnectionString = ConnectionString;
                    Query.Connection = Connect;
                    Query.CommandType = CommandType.Text;
                    Query.CommandText = "SELECT TABLE_SCHEMA, TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_SCHEMA"; // Pobieranie listy tabel
                    Connect.Open();

                    SqlDataReader Reader = Query.ExecuteReader();

                    while (Reader.Read())
                    {
                        this.TablesList1.Items.Add((Reader.GetValue(0).ToString() + "." + Reader.GetValue(1).ToString()));
                        TableElementList.Add((Reader.GetValue(0).ToString() + "." + Reader.GetValue(1).ToString()));
                        this.TablesList2.Items.Add((Reader.GetValue(0).ToString() + "." + Reader.GetValue(1).ToString()));
                        // TableElementList.Add((Reader.GetValue(0).ToString() + "." + Reader.GetValue(1).ToString())); Zakomentowane, ponieważ dane w TableElementList były duplikowane.
                    }
                    this.TablesList1.Enabled = true;
                    this.SearchTextBox.Enabled = true;
                    this.TablesList2.Enabled = true;
                    this.SearchTextBox2.Enabled = true;
                }
                catch (Exception error)
                {
                    ShowErrorPopup(error.Message);
                }
                finally
                {
                    Connect.Close();
                }
            }
        }

        private void Connection_StringTextBox_Enter(object sender, EventArgs e)
        {
            if (this.Connection_StringTextBox.ForeColor == Color.Red)
            {
                this.Connection_StringTextBox.ForeColor = Color.Black;
                this.Connection_StringTextBox.Clear();
            }
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            this.SearchTextBox.Clear();
        }

        private void SearchTextBox2_Enter(object sender, EventArgs e)
        {
            this.SearchTextBox2.Clear();
        }

        private void otwórzPlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            try
            {
                long size;
                byte[] buff;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*|Structured Query Language file (*.sql)|*.sql";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    buff = File.ReadAllBytes(openFileDialog.FileName);
                    size = buff.Length;
                    this.CountLabel.Text = "Ilość bitów: " + size;
                 
                    buff = null;
                }
            }
            catch (Exception error)
            {
                ShowErrorPopup(error.Message);
            }
        }

        private void generujConnectionStringaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            CSGenerator Generator = new CSGenerator(this.Connection_StringTextBox);
            Generator.SetDesktopLocation((this.Location.X + ((this.Size.Width - 400) / 2)), (this.Location.Y + (this.Size.Height - 300) / 2));
            DialogResult dialogresult = Generator.ShowDialog();
        }

        private void ShowErrorPopup(string message)
        {
            ErrorPopup Popup = new ErrorPopup(message);
            Popup.SetDesktopLocation((this.Location.X + ((this.Size.Width - 400) / 2)), (this.Location.Y + (this.Size.Height - 230) / 2));
            DialogResult dialogresult = Popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
                Popup.Dispose();
        }

        private void TablesList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ColumnListBox2.Items.Clear();
            try
            {
                string[] table_name = this.TablesList2.SelectedItem.ToString().Split(new string[] { "." }, StringSplitOptions.None);
                Query.CommandText = "SELECT column_name , data_type FROM information_schema.columns WHERE table_name = '" + table_name[1] + "'";
                Connect.Open();
                SqlDataReader Reader = Query.ExecuteReader();
                while (Reader.Read())
                {
                    this.ColumnListBox2.Items.Add(Reader.GetValue(0).ToString());
                }
                this.ColumnListBox2.Enabled = true;

            }
            catch (Exception error)
            {
                ShowErrorPopup(error.Message);
            }
            finally
            {
                Connect.Close();
            }
        }

        private void SearchTextBox2_TextChanged(object sender, EventArgs e)
        {
            this.TablesList2.BeginUpdate();
            this.TablesList2.Items.Clear();
            foreach (var item in TableElementList)
            {
                if (item.ToString().ToLower().Contains(this.SearchTextBox2.Text.ToLower()))
                    TablesList2.Items.Add(item.ToString());
            }
            this.TablesList2.EndUpdate();
        }

        private void GeneratePrimaryButton_Click(object sender, EventArgs e)
        {
            string table1 = TablesList1.GetItemText(TablesList1.SelectedItem);
            string table2 = TablesList2.GetItemText(TablesList2.SelectedItem);
            string column1 = ColumnListBox.GetItemText(ColumnListBox.SelectedItem);
            string column2 = ColumnListBox2.GetItemText(ColumnListBox2.SelectedItem);
            System.IO.File.AppendAllText(@"C:\Users\kjurusik\Desktop\klucze.sql",  "\n \r" + "if not exists(select 1 from sysobjects where name='" + table2 +
            ")' \n alter table" + table1 + " add constraint " + table2 + " primary key (" + column1 + ") references " + column2 );
        }

        private void GenerateForeignButton_Click(object sender, EventArgs e)
        {
            string table1 = TablesList1.GetItemText(TablesList1.SelectedItem);
            string table2 = TablesList2.GetItemText(TablesList2.SelectedItem);
            string column1 = ColumnListBox.GetItemText(ColumnListBox.SelectedItem);
            string column2 = ColumnListBox2.GetItemText(ColumnListBox2.SelectedItem);
            System.IO.File.AppendAllText(@"C:\Users\kjurusik\Desktop\klucze.sql", "\n \r" + "if not exists(select 1 from sysobjects where name='" + table2 +
            ")' \n alter table" + table1 + " add constraint " + table2 + " foreign key (" + column1 + ") references " + column2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString;
            if (this.Connection_StringTextBox.Text.Trim() == "" || this.Connection_StringTextBox.ForeColor==Color.Red)
            {
                this.Connection_StringTextBox.Text = "Nie podano Connection Stringa!";
                this.Connection_StringTextBox.ForeColor = Color.Red;
            }
            else
            {
                ConnectionString = this.Connection_StringTextBox.Text.Trim();                
                try
                {

                    Connect.ConnectionString = ConnectionString;
                    Query.Connection = Connect;
                    Query.CommandType = CommandType.Text;
                    //Query.CommandText = "SELECT TABLE_SCHEMA, TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_SCHEMA"; // Pobieranie listy tabel
                    //Query.CommandText = "SELECT TABLE_NAME, CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE='FOREIGN KEY'";
                    Query.CommandText = "SELECT o1.name AS FK_table, c1.name AS FK_column, fk.name AS FK_name, o2.name AS PK_table, c2.name AS PK_column, pk.name AS PK_name, fk.delete_referential_action_desc AS Delete_Action, fk.update_referential_action_desc AS Update_Action FROM sys.objects o1 INNER JOIN sys.foreign_keys fk ON o1.object_id = fk.parent_object_id INNER JOIN sys.foreign_key_columns fkc ON fk.object_id = fkc.constraint_object_id INNER JOIN sys.columns c1 ON fkc.parent_object_id = c1.object_id AND fkc.parent_column_id = c1.column_id INNER JOIN sys.columns c2 ON fkc.referenced_object_id = c2.object_id AND fkc.referenced_column_id = c2.column_id INNER JOIN sys.objects o2 ON fk.referenced_object_id = o2.object_id INNER JOIN sys.key_constraints pk ON fk.referenced_object_id = pk.parent_object_id AND fk.key_index_id = pk.unique_index_id ORDER BY o1.name, o2.name, fkc.constraint_column_id";
                   
                    Connect.Open();
                    listBox1.Items.Clear();

                    SqlDataReader Reader = Query.ExecuteReader();

                    while (Reader.Read())
                    {
                        this.listBox1.Items.Add((Reader.GetValue(2).ToString()));
                        //TableElementList.Add((Reader.GetValue(0).ToString() + "." + Reader.GetValue(1).ToString()));
                    }
                    //this.listBox1.Enabled = true;
                    //this.SearchTextBox.Enabled = true;
                }
                catch (Exception error)
                {
                    ShowErrorPopup(error.Message);
                }
                finally
                {
                    Connect.Close();                    
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string table_name = this.listBox1.SelectedItem.ToString();
                Query.CommandText = "SELECT o1.name AS FK_table, c1.name AS FK_column, fk.name AS FK_name, o2.name AS PK_table, c2.name AS PK_column, pk.name AS PK_name, fk.delete_referential_action_desc AS Delete_Action, fk.update_referential_action_desc AS Update_Action FROM sys.objects o1 INNER JOIN sys.foreign_keys fk ON o1.object_id = fk.parent_object_id INNER JOIN sys.foreign_key_columns fkc ON fk.object_id = fkc.constraint_object_id INNER JOIN sys.columns c1 ON fkc.parent_object_id = c1.object_id AND fkc.parent_column_id = c1.column_id INNER JOIN sys.columns c2 ON fkc.referenced_object_id = c2.object_id AND fkc.referenced_column_id = c2.column_id INNER JOIN sys.objects o2 ON fk.referenced_object_id = o2.object_id INNER JOIN sys.key_constraints pk ON fk.referenced_object_id = pk.parent_object_id AND fk.key_index_id = pk.unique_index_id WHERE fk.name = '" + table_name + "'" + "ORDER BY o1.name, o2.name, fkc.constraint_column_id ";
                Connect.Open();
                SqlDataReader Reader = Query.ExecuteReader();
                while (Reader.Read())
                {
                    this.textBoxFKTable.Text = Reader.GetValue(0).ToString();
                    this.textBoxFKColumn.Text = Reader.GetValue(1).ToString();
                    this.textBoxPKTable.Text = Reader.GetValue(3).ToString();
                    this.textBoxPKColumn.Text = Reader.GetValue(4).ToString();
                }
                this.ColumnListBox2.Enabled = true;

            }
            catch (Exception error)
            {
                ShowErrorPopup(error.Message);
            }
            finally
            {
                Connect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelRel  okienko = new DelRel();
            okienko.SetDesktopLocation((this.Location.X + ((this.Size.Width - 400) / 2)), (this.Location.Y + (this.Size.Height - 230) / 2));
            DialogResult dialogresult = okienko.ShowDialog();
            if (dialogresult == DialogResult.OK)
                okienko.Dispose();
            
        }


    }
   
}