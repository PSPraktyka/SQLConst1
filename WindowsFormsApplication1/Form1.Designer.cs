namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Connection_StringLabel = new System.Windows.Forms.Label();
            this.Connection_StringTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generujConnectionStringaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateForeignButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TablesList1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ColumnListBox = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.TableListLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SearchTextBox2 = new System.Windows.Forms.TextBox();
            this.TableListLabel2 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ColumnListLabel = new System.Windows.Forms.Label();
            this.TablesList2 = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ColumnListLabel2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.GeneratePrimaryButton = new System.Windows.Forms.Button();
            this.ColumnListBox2 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxPKColumn = new System.Windows.Forms.TextBox();
            this.textBoxPKTable = new System.Windows.Forms.TextBox();
            this.textBoxFKColumn = new System.Windows.Forms.TextBox();
            this.textBoxFKTable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectButton.Location = new System.Drawing.Point(1039, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(115, 33);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Połącz";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(914, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Czyść";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Connection_StringLabel
            // 
            this.Connection_StringLabel.AutoSize = true;
            this.Connection_StringLabel.Location = new System.Drawing.Point(5, 7);
            this.Connection_StringLabel.Name = "Connection_StringLabel";
            this.Connection_StringLabel.Size = new System.Drawing.Size(91, 13);
            this.Connection_StringLabel.TabIndex = 2;
            this.Connection_StringLabel.Text = "Connection String";
            // 
            // Connection_StringTextBox
            // 
            this.Connection_StringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Connection_StringTextBox.Location = new System.Drawing.Point(102, 5);
            this.Connection_StringTextBox.Name = "Connection_StringTextBox";
            this.Connection_StringTextBox.Size = new System.Drawing.Size(725, 20);
            this.Connection_StringTextBox.TabIndex = 1;
            this.Connection_StringTextBox.Enter += new System.EventHandler(this.Connection_StringTextBox_Enter);
            this.Connection_StringTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Connection_StringTextBox_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ResetButton);
            this.panel1.Controls.Add(this.Connection_StringLabel);
            this.panel1.Controls.Add(this.Connection_StringTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(88, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 28);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1000F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1171, 34);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1177, 642);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1177, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzPlikToolStripMenuItem,
            this.generujConnectionStringaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // otwórzPlikToolStripMenuItem
            // 
            this.otwórzPlikToolStripMenuItem.Name = "otwórzPlikToolStripMenuItem";
            this.otwórzPlikToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.otwórzPlikToolStripMenuItem.Text = "Otwórz Plik";
            this.otwórzPlikToolStripMenuItem.Click += new System.EventHandler(this.otwórzPlikToolStripMenuItem_Click);
            // 
            // generujConnectionStringaToolStripMenuItem
            // 
            this.generujConnectionStringaToolStripMenuItem.Name = "generujConnectionStringaToolStripMenuItem";
            this.generujConnectionStringaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.generujConnectionStringaToolStripMenuItem.Text = "Generuj Connection Stringa";
            this.generujConnectionStringaToolStripMenuItem.Click += new System.EventHandler(this.generujConnectionStringaToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 571);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1163, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.ConnectButton, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.253886F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.74612F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1157, 539);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99875F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99875F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.Controls.Add(this.GenerateForeignButton, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TablesList2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.ColumnListBox2, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1151, 494);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // GenerateForeignButton
            // 
            this.GenerateForeignButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GenerateForeignButton.Location = new System.Drawing.Point(1031, 45);
            this.GenerateForeignButton.Name = "GenerateForeignButton";
            this.GenerateForeignButton.Size = new System.Drawing.Size(117, 36);
            this.GenerateForeignButton.TabIndex = 0;
            this.GenerateForeignButton.Text = "Foreign Key";
            this.GenerateForeignButton.UseVisualStyleBackColor = true;
            this.GenerateForeignButton.Click += new System.EventHandler(this.GenerateForeignButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TablesList1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 426);
            this.panel2.TabIndex = 1;
            // 
            // TablesList1
            // 
            this.TablesList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesList1.Enabled = false;
            this.TablesList1.FormattingEnabled = true;
            this.TablesList1.IntegralHeight = false;
            this.TablesList1.Location = new System.Drawing.Point(0, 0);
            this.TablesList1.Name = "TablesList1";
            this.TablesList1.Size = new System.Drawing.Size(251, 426);
            this.TablesList1.TabIndex = 3;
            this.TablesList1.SelectedIndexChanged += new System.EventHandler(this.TablesList_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ColumnListBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(260, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 426);
            this.panel3.TabIndex = 2;
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnListBox.FormattingEnabled = true;
            this.ColumnListBox.Location = new System.Drawing.Point(0, 0);
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Size = new System.Drawing.Size(251, 426);
            this.ColumnListBox.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SearchTextBox);
            this.panel4.Controls.Add(this.TableListLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 36);
            this.panel4.TabIndex = 3;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Enabled = false;
            this.SearchTextBox.Location = new System.Drawing.Point(101, 9);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Text = "Szukaj...";
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            // 
            // TableListLabel
            // 
            this.TableListLabel.AutoSize = true;
            this.TableListLabel.Location = new System.Drawing.Point(4, 11);
            this.TableListLabel.Name = "TableListLabel";
            this.TableListLabel.Size = new System.Drawing.Size(59, 13);
            this.TableListLabel.TabIndex = 6;
            this.TableListLabel.Text = "Lista Tabel";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.SearchTextBox2);
            this.panel6.Controls.Add(this.TableListLabel2);
            this.panel6.Controls.Add(this.CountLabel);
            this.panel6.Controls.Add(this.ErrorLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(517, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 36);
            this.panel6.TabIndex = 5;
            // 
            // SearchTextBox2
            // 
            this.SearchTextBox2.Enabled = false;
            this.SearchTextBox2.Location = new System.Drawing.Point(100, 9);
            this.SearchTextBox2.Name = "SearchTextBox2";
            this.SearchTextBox2.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox2.TabIndex = 15;
            this.SearchTextBox2.Text = "Szukaj...";
            this.SearchTextBox2.TextChanged += new System.EventHandler(this.SearchTextBox2_TextChanged);
            // 
            // TableListLabel2
            // 
            this.TableListLabel2.AutoSize = true;
            this.TableListLabel2.Location = new System.Drawing.Point(3, 11);
            this.TableListLabel2.Name = "TableListLabel2";
            this.TableListLabel2.Size = new System.Drawing.Size(59, 13);
            this.TableListLabel2.TabIndex = 14;
            this.TableListLabel2.Text = "Lista Tabel";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(96, 12);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(0, 13);
            this.CountLabel.TabIndex = 13;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(86, 12);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ColumnListLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(260, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 36);
            this.panel5.TabIndex = 6;
            // 
            // ColumnListLabel
            // 
            this.ColumnListLabel.AutoSize = true;
            this.ColumnListLabel.Location = new System.Drawing.Point(6, 12);
            this.ColumnListLabel.Name = "ColumnListLabel";
            this.ColumnListLabel.Size = new System.Drawing.Size(67, 13);
            this.ColumnListLabel.TabIndex = 18;
            this.ColumnListLabel.Text = "Lista Kolumn";
            // 
            // TablesList2
            // 
            this.TablesList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesList2.FormattingEnabled = true;
            this.TablesList2.Location = new System.Drawing.Point(517, 45);
            this.TablesList2.Name = "TablesList2";
            this.TablesList2.Size = new System.Drawing.Size(251, 426);
            this.TablesList2.TabIndex = 7;
            this.TablesList2.SelectedIndexChanged += new System.EventHandler(this.TablesList2_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ColumnListLabel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(774, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(251, 36);
            this.panel7.TabIndex = 22;
            // 
            // ColumnListLabel2
            // 
            this.ColumnListLabel2.AutoSize = true;
            this.ColumnListLabel2.Location = new System.Drawing.Point(3, 11);
            this.ColumnListLabel2.Name = "ColumnListLabel2";
            this.ColumnListLabel2.Size = new System.Drawing.Size(67, 13);
            this.ColumnListLabel2.TabIndex = 20;
            this.ColumnListLabel2.Text = "Lista Kolumn";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.GeneratePrimaryButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1031, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(117, 36);
            this.panel8.TabIndex = 24;
            // 
            // GeneratePrimaryButton
            // 
            this.GeneratePrimaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneratePrimaryButton.Location = new System.Drawing.Point(0, 0);
            this.GeneratePrimaryButton.Name = "GeneratePrimaryButton";
            this.GeneratePrimaryButton.Size = new System.Drawing.Size(117, 36);
            this.GeneratePrimaryButton.TabIndex = 27;
            this.GeneratePrimaryButton.Text = "Primary key";
            this.GeneratePrimaryButton.UseVisualStyleBackColor = true;
            this.GeneratePrimaryButton.Click += new System.EventHandler(this.GeneratePrimaryButton_Click);
            // 
            // ColumnListBox2
            // 
            this.ColumnListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnListBox2.FormattingEnabled = true;
            this.ColumnListBox2.Location = new System.Drawing.Point(774, 45);
            this.ColumnListBox2.Name = "ColumnListBox2";
            this.ColumnListBox2.Size = new System.Drawing.Size(251, 426);
            this.ColumnListBox2.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBoxPKColumn);
            this.tabPage2.Controls.Add(this.textBoxPKTable);
            this.tabPage2.Controls.Add(this.textBoxFKColumn);
            this.tabPage2.Controls.Add(this.textBoxFKTable);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1163, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxPKColumn
            // 
            this.textBoxPKColumn.Location = new System.Drawing.Point(345, 226);
            this.textBoxPKColumn.Name = "textBoxPKColumn";
            this.textBoxPKColumn.Size = new System.Drawing.Size(234, 20);
            this.textBoxPKColumn.TabIndex = 9;
            // 
            // textBoxPKTable
            // 
            this.textBoxPKTable.Location = new System.Drawing.Point(345, 169);
            this.textBoxPKTable.Name = "textBoxPKTable";
            this.textBoxPKTable.Size = new System.Drawing.Size(234, 20);
            this.textBoxPKTable.TabIndex = 8;
            // 
            // textBoxFKColumn
            // 
            this.textBoxFKColumn.Location = new System.Drawing.Point(345, 115);
            this.textBoxFKColumn.Name = "textBoxFKColumn";
            this.textBoxFKColumn.Size = new System.Drawing.Size(234, 20);
            this.textBoxFKColumn.TabIndex = 7;
            // 
            // textBoxFKTable
            // 
            this.textBoxFKTable.Location = new System.Drawing.Point(345, 64);
            this.textBoxFKTable.Name = "textBoxFKTable";
            this.textBoxFKTable.Size = new System.Drawing.Size(234, 20);
            this.textBoxFKTable.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kolumna z kluczem głównym:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwa tabeli w relacji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kolumna z kluczem obcym:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa tabeli z kuczem obcym:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 537);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Połącz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Usuń relację";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1024, 680);
            this.Name = "Form1";
            this.Text = "Generator ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label Connection_StringLabel;
        private System.Windows.Forms.TextBox Connection_StringTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generujConnectionStringaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox TablesList1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label TableListLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ColumnListLabel;
        private System.Windows.Forms.ListBox TablesList2;
        private System.Windows.Forms.TextBox SearchTextBox2;
        private System.Windows.Forms.Label TableListLabel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label ColumnListLabel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListBox ColumnListBox;
        private System.Windows.Forms.ListBox ColumnListBox2;
        private System.Windows.Forms.Button GenerateForeignButton;
        private System.Windows.Forms.Button GeneratePrimaryButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPKColumn;
        private System.Windows.Forms.TextBox textBoxPKTable;
        private System.Windows.Forms.TextBox textBoxFKColumn;
        private System.Windows.Forms.TextBox textBoxFKTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;

    }
}

