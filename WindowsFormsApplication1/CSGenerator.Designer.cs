namespace WindowsFormsApplication1
{
    partial class CSGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectionStringTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.dbTextBox = new System.Windows.Forms.TextBox();
            this.dbLabel = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CopyButton);
            this.panel1.Controls.Add(this.ConnectionStringTextBox);
            this.panel1.Controls.Add(this.GenerateButton);
            this.panel1.Controls.Add(this.dbTextBox);
            this.panel1.Controls.Add(this.dbLabel);
            this.panel1.Controls.Add(this.ServerLabel);
            this.panel1.Controls.Add(this.ServerTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 262);
            this.panel1.TabIndex = 0;
            // 
            // ConnectionStringTextBox
            // 
            this.ConnectionStringTextBox.Location = new System.Drawing.Point(16, 116);
            this.ConnectionStringTextBox.Name = "ConnectionStringTextBox";
            this.ConnectionStringTextBox.ReadOnly = true;
            this.ConnectionStringTextBox.Size = new System.Drawing.Size(356, 96);
            this.ConnectionStringTextBox.TabIndex = 5;
            this.ConnectionStringTextBox.Text = "";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(150, 87);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generuj";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // dbTextBox
            // 
            this.dbTextBox.Location = new System.Drawing.Point(90, 49);
            this.dbTextBox.Name = "dbTextBox";
            this.dbTextBox.Size = new System.Drawing.Size(282, 20);
            this.dbTextBox.TabIndex = 3;
            this.dbTextBox.Enter += new System.EventHandler(this.dbTextBox_Enter);
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Location = new System.Drawing.Point(13, 52);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(71, 13);
            this.dbLabel.TabIndex = 2;
            this.dbLabel.Text = "Baza Danych";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(13, 22);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(40, 13);
            this.ServerLabel.TabIndex = 1;
            this.ServerLabel.Text = "Serwer";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(90, 22);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(282, 20);
            this.ServerTextBox.TabIndex = 0;
            this.ServerTextBox.Enter += new System.EventHandler(this.ServerTextBox_Enter);
            // 
            // CopyButton
            // 
            this.CopyButton.Enabled = false;
            this.CopyButton.Location = new System.Drawing.Point(150, 218);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 6;
            this.CopyButton.Text = "Kopiuj";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // CSGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "CSGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CSGenerator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox dbTextBox;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.RichTextBox ConnectionStringTextBox;
        private System.Windows.Forms.Button CopyButton;
    }
}