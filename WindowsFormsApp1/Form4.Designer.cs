namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dvgUzytkownicy = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZWISKO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzytkownicy = new System.Windows.Forms.Label();
            this.dgvOstatnieDzialaniaWbazie = new System.Windows.Forms.DataGridView();
            this.DzialaniaBaza = new System.Windows.Forms.Label();
            this.UsunUzytkownika = new System.Windows.Forms.Button();
            this.Wroc = new System.Windows.Forms.Button();
            this.Odswiez = new System.Windows.Forms.Button();
            this.lbllogin = new System.Windows.Forms.Label();
            this.Zalogowany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUzytkownicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOstatnieDzialaniaWbazie)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgUzytkownicy
            // 
            this.dvgUzytkownicy.AllowUserToDeleteRows = false;
            this.dvgUzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUzytkownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LOGIN,
            this.IMIE,
            this.NAZWISKO,
            this.PASSWORD});
            this.dvgUzytkownicy.Location = new System.Drawing.Point(12, 21);
            this.dvgUzytkownicy.Name = "dvgUzytkownicy";
            this.dvgUzytkownicy.ReadOnly = true;
            this.dvgUzytkownicy.Size = new System.Drawing.Size(365, 318);
            this.dvgUzytkownicy.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 2;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LOGIN.DataPropertyName = "LOGIN";
            this.LOGIN.HeaderText = "LOGIN";
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.ReadOnly = true;
            this.LOGIN.Width = 65;
            // 
            // IMIE
            // 
            this.IMIE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IMIE.DataPropertyName = "IMIE";
            this.IMIE.HeaderText = "IMIE";
            this.IMIE.Name = "IMIE";
            this.IMIE.ReadOnly = true;
            this.IMIE.Width = 54;
            // 
            // NAZWISKO
            // 
            this.NAZWISKO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NAZWISKO.DataPropertyName = "NAZWISKO";
            this.NAZWISKO.HeaderText = "NAZWISKO";
            this.NAZWISKO.Name = "NAZWISKO";
            this.NAZWISKO.ReadOnly = true;
            this.NAZWISKO.Width = 90;
            // 
            // PASSWORD
            // 
            this.PASSWORD.DataPropertyName = "PASSWORD";
            this.PASSWORD.HeaderText = "PASSWORD";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            this.PASSWORD.Visible = false;
            // 
            // uzytkownicy
            // 
            this.uzytkownicy.BackColor = System.Drawing.Color.Transparent;
            this.uzytkownicy.Location = new System.Drawing.Point(83, 2);
            this.uzytkownicy.Name = "uzytkownicy";
            this.uzytkownicy.Size = new System.Drawing.Size(173, 15);
            this.uzytkownicy.TabIndex = 2;
            this.uzytkownicy.Text = "Użytkownicy:";
            this.uzytkownicy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvOstatnieDzialaniaWbazie
            // 
            this.dgvOstatnieDzialaniaWbazie.AllowUserToDeleteRows = false;
            this.dgvOstatnieDzialaniaWbazie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOstatnieDzialaniaWbazie.Location = new System.Drawing.Point(401, 21);
            this.dgvOstatnieDzialaniaWbazie.Name = "dgvOstatnieDzialaniaWbazie";
            this.dgvOstatnieDzialaniaWbazie.ReadOnly = true;
            this.dgvOstatnieDzialaniaWbazie.Size = new System.Drawing.Size(319, 318);
            this.dgvOstatnieDzialaniaWbazie.TabIndex = 3;
            // 
            // DzialaniaBaza
            // 
            this.DzialaniaBaza.AutoSize = true;
            this.DzialaniaBaza.Location = new System.Drawing.Point(496, 2);
            this.DzialaniaBaza.Name = "DzialaniaBaza";
            this.DzialaniaBaza.Size = new System.Drawing.Size(134, 13);
            this.DzialaniaBaza.TabIndex = 4;
            this.DzialaniaBaza.Text = "Ostatnie działania w bazie:";
            // 
            // UsunUzytkownika
            // 
            this.UsunUzytkownika.Location = new System.Drawing.Point(12, 345);
            this.UsunUzytkownika.Name = "UsunUzytkownika";
            this.UsunUzytkownika.Size = new System.Drawing.Size(140, 28);
            this.UsunUzytkownika.TabIndex = 5;
            this.UsunUzytkownika.Text = "Usuń użytkownika";
            this.UsunUzytkownika.UseVisualStyleBackColor = true;
            this.UsunUzytkownika.Click += new System.EventHandler(this.UsunUzytkownika_Click);
            // 
            // Wroc
            // 
            this.Wroc.Location = new System.Drawing.Point(735, 253);
            this.Wroc.Name = "Wroc";
            this.Wroc.Size = new System.Drawing.Size(74, 59);
            this.Wroc.TabIndex = 6;
            this.Wroc.Text = "Wróć";
            this.Wroc.UseVisualStyleBackColor = true;
            this.Wroc.Click += new System.EventHandler(this.Wroc_Click);
            // 
            // Odswiez
            // 
            this.Odswiez.Location = new System.Drawing.Point(735, 32);
            this.Odswiez.Name = "Odswiez";
            this.Odswiez.Size = new System.Drawing.Size(74, 66);
            this.Odswiez.TabIndex = 7;
            this.Odswiez.Text = "Odśwież";
            this.Odswiez.UseVisualStyleBackColor = true;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.lbllogin.ForeColor = System.Drawing.Color.Red;
            this.lbllogin.Location = new System.Drawing.Point(331, 345);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(62, 13);
            this.lbllogin.TabIndex = 8;
            this.lbllogin.Text = "Uzytkownik";
            // 
            // Zalogowany
            // 
            this.Zalogowany.AutoSize = true;
            this.Zalogowany.Location = new System.Drawing.Point(200, 345);
            this.Zalogowany.Name = "Zalogowany";
            this.Zalogowany.Size = new System.Drawing.Size(125, 13);
            this.Zalogowany.TabIndex = 9;
            this.Zalogowany.Text = "Jesteś zalogowany jako: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Twoja rola to: ";
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(821, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zalogowany);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.Odswiez);
            this.Controls.Add(this.Wroc);
            this.Controls.Add(this.UsunUzytkownika);
            this.Controls.Add(this.DzialaniaBaza);
            this.Controls.Add(this.dgvOstatnieDzialaniaWbazie);
            this.Controls.Add(this.uzytkownicy);
            this.Controls.Add(this.dvgUzytkownicy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dvgUzytkownicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOstatnieDzialaniaWbazie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgUzytkownicy;
        private System.Windows.Forms.Label uzytkownicy;
        private System.Windows.Forms.DataGridView dgvOstatnieDzialaniaWbazie;
        private System.Windows.Forms.Label DzialaniaBaza;
        private System.Windows.Forms.Button UsunUzytkownika;
        private System.Windows.Forms.Button Wroc;
        private System.Windows.Forms.Button Odswiez;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label Zalogowany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZWISKO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.Label label1;
    }
}