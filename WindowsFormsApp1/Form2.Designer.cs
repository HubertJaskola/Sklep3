namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dvgProdukt = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IloscSztuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Usun = new System.Windows.Forms.Button();
            this.Wprowadz = new System.Windows.Forms.Button();
            this.Wyczysc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pAdmin = new System.Windows.Forms.Button();
            this.Wyloguj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRola = new System.Windows.Forms.Label();
            this.SzukajBox = new System.Windows.Forms.TextBox();
            this.lblSzukaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdukt)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgProdukt
            // 
            this.dvgProdukt.AllowUserToDeleteRows = false;
            this.dvgProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProdukt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Produkt,
            this.IloscSztuk,
            this.Opis});
            this.dvgProdukt.Cursor = System.Windows.Forms.Cursors.Default;
            this.dvgProdukt.Location = new System.Drawing.Point(12, 12);
            this.dvgProdukt.Name = "dvgProdukt";
            this.dvgProdukt.ReadOnly = true;
            this.dvgProdukt.Size = new System.Drawing.Size(444, 249);
            this.dvgProdukt.TabIndex = 0;
            this.dvgProdukt.DoubleClick += new System.EventHandler(this.dvgProdukt_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Produkt
            // 
            this.Produkt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produkt.DataPropertyName = "Produkt";
            this.Produkt.HeaderText = "Produkt";
            this.Produkt.MinimumWidth = 10;
            this.Produkt.Name = "Produkt";
            this.Produkt.ReadOnly = true;
            // 
            // IloscSztuk
            // 
            this.IloscSztuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IloscSztuk.DataPropertyName = "IloscSztuk";
            this.IloscSztuk.HeaderText = "IloscSztuk";
            this.IloscSztuk.Name = "IloscSztuk";
            this.IloscSztuk.ReadOnly = true;
            this.IloscSztuk.Width = 81;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 15;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(570, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 25);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(570, 150);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(570, 194);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 25);
            this.textBox3.TabIndex = 6;
            // 
            // Usun
            // 
            this.Usun.Location = new System.Drawing.Point(12, 267);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(130, 32);
            this.Usun.TabIndex = 11;
            this.Usun.Text = "Usun rekord";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // Wprowadz
            // 
            this.Wprowadz.Location = new System.Drawing.Point(674, 257);
            this.Wprowadz.Name = "Wprowadz";
            this.Wprowadz.Size = new System.Drawing.Size(130, 32);
            this.Wprowadz.TabIndex = 12;
            this.Wprowadz.Text = "Wprowadz";
            this.Wprowadz.UseVisualStyleBackColor = true;
            this.Wprowadz.Click += new System.EventHandler(this.Wprowadz_Click);
            // 
            // Wyczysc
            // 
            this.Wyczysc.Location = new System.Drawing.Point(496, 257);
            this.Wyczysc.Name = "Wyczysc";
            this.Wyczysc.Size = new System.Drawing.Size(130, 32);
            this.Wyczysc.TabIndex = 13;
            this.Wyczysc.Text = "Wyczysc";
            this.Wyczysc.UseVisualStyleBackColor = true;
            this.Wyczysc.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Produkt";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ilość sztuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Opis";
            // 
            // lblLoginName
            // 
            this.lblLoginName.ForeColor = System.Drawing.Color.Red;
            this.lblLoginName.Location = new System.Drawing.Point(621, 11);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(74, 26);
            this.lblLoginName.TabIndex = 17;
            this.lblLoginName.Text = "uzytkownik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Jesteś zalogowany jako:";
            // 
            // pAdmin
            // 
            this.pAdmin.Location = new System.Drawing.Point(724, 53);
            this.pAdmin.Name = "pAdmin";
            this.pAdmin.Size = new System.Drawing.Size(80, 44);
            this.pAdmin.TabIndex = 19;
            this.pAdmin.Text = "Panel administratora";
            this.pAdmin.UseVisualStyleBackColor = true;
            this.pAdmin.Click += new System.EventHandler(this.pAdmin_Click);
            // 
            // Wyloguj
            // 
            this.Wyloguj.Location = new System.Drawing.Point(724, 11);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(80, 36);
            this.Wyloguj.TabIndex = 20;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Twoja rola to:";
            // 
            // lblRola
            // 
            this.lblRola.ForeColor = System.Drawing.Color.Red;
            this.lblRola.Location = new System.Drawing.Point(621, 37);
            this.lblRola.Name = "lblRola";
            this.lblRola.Size = new System.Drawing.Size(74, 26);
            this.lblRola.TabIndex = 22;
            this.lblRola.Text = "rola";
            // 
            // SzukajBox
            // 
            this.SzukajBox.Location = new System.Drawing.Point(311, 268);
            this.SzukajBox.Multiline = true;
            this.SzukajBox.Name = "SzukajBox";
            this.SzukajBox.Size = new System.Drawing.Size(145, 25);
            this.SzukajBox.TabIndex = 23;
            this.SzukajBox.TextChanged += new System.EventHandler(this.SzukajBox_TextChanged);
            // 
            // lblSzukaj
            // 
            this.lblSzukaj.AutoSize = true;
            this.lblSzukaj.Location = new System.Drawing.Point(217, 267);
            this.lblSzukaj.Name = "lblSzukaj";
            this.lblSzukaj.Size = new System.Drawing.Size(88, 26);
            this.lblSzukaj.TabIndex = 24;
            this.lblSzukaj.Text = "Szukaj po \r\nnazwie produktu:";
            // 
            // Form2
            // 
            this.AcceptButton = this.Wprowadz;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(816, 311);
            this.Controls.Add(this.lblSzukaj);
            this.Controls.Add(this.SzukajBox);
            this.Controls.Add(this.lblRola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Wyloguj);
            this.Controls.Add(this.pAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wyczysc);
            this.Controls.Add(this.Wprowadz);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dvgProdukt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdukt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProdukt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.Button Wprowadz;
        private System.Windows.Forms.Button Wyczysc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pAdmin;
        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IloscSztuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRola;
        private System.Windows.Forms.TextBox SzukajBox;
        private System.Windows.Forms.Label lblSzukaj;
    }
}