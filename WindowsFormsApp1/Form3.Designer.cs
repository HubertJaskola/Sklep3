namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Cofnij = new System.Windows.Forms.Button();
            this.ImieBox = new System.Windows.Forms.TextBox();
            this.NazwiskoBox = new System.Windows.Forms.TextBox();
            this.HasloBox = new System.Windows.Forms.TextBox();
            this.Haslo2Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRola = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HasloAdminBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Rejestracja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cofnij
            // 
            this.Cofnij.Location = new System.Drawing.Point(45, 226);
            this.Cofnij.Name = "Cofnij";
            this.Cofnij.Size = new System.Drawing.Size(140, 36);
            this.Cofnij.TabIndex = 0;
            this.Cofnij.Text = "Cofnij";
            this.Cofnij.UseVisualStyleBackColor = true;
            this.Cofnij.Click += new System.EventHandler(this.Cofnij_Click);
            // 
            // ImieBox
            // 
            this.ImieBox.Location = new System.Drawing.Point(112, 44);
            this.ImieBox.Name = "ImieBox";
            this.ImieBox.Size = new System.Drawing.Size(150, 20);
            this.ImieBox.TabIndex = 1;
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Location = new System.Drawing.Point(112, 78);
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.Size = new System.Drawing.Size(150, 20);
            this.NazwiskoBox.TabIndex = 2;
            // 
            // HasloBox
            // 
            this.HasloBox.Location = new System.Drawing.Point(112, 151);
            this.HasloBox.Name = "HasloBox";
            this.HasloBox.PasswordChar = '*';
            this.HasloBox.Size = new System.Drawing.Size(150, 20);
            this.HasloBox.TabIndex = 4;
            // 
            // Haslo2Box
            // 
            this.Haslo2Box.Location = new System.Drawing.Point(112, 187);
            this.Haslo2Box.Name = "Haslo2Box";
            this.Haslo2Box.PasswordChar = '*';
            this.Haslo2Box.Size = new System.Drawing.Size(150, 20);
            this.Haslo2Box.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hasło:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Powtórz hasło:";
            // 
            // cbRola
            // 
            this.cbRola.FormattingEnabled = true;
            this.cbRola.Location = new System.Drawing.Point(433, 41);
            this.cbRola.Name = "cbRola";
            this.cbRola.Size = new System.Drawing.Size(174, 21);
            this.cbRola.TabIndex = 15;
            this.cbRola.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wybierz role:";
            // 
            // HasloAdminBox
            // 
            this.HasloAdminBox.Location = new System.Drawing.Point(433, 82);
            this.HasloAdminBox.Name = "HasloAdminBox";
            this.HasloAdminBox.PasswordChar = '*';
            this.HasloAdminBox.Size = new System.Drawing.Size(174, 20);
            this.HasloAdminBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hasło administratora:";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(112, 114);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(150, 20);
            this.LoginBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Login:";
            // 
            // Rejestracja
            // 
            this.Rejestracja.Location = new System.Drawing.Point(538, 220);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(140, 36);
            this.Rejestracja.TabIndex = 21;
            this.Rejestracja.Text = "Rejestracja";
            this.Rejestracja.UseVisualStyleBackColor = true;
            this.Rejestracja.Click += new System.EventHandler(this.Rejestracja_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.Rejestracja;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(733, 274);
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HasloAdminBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Haslo2Box);
            this.Controls.Add(this.HasloBox);
            this.Controls.Add(this.NazwiskoBox);
            this.Controls.Add(this.ImieBox);
            this.Controls.Add(this.Cofnij);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cofnij;
        private System.Windows.Forms.TextBox ImieBox;
        private System.Windows.Forms.TextBox NazwiskoBox;
        private System.Windows.Forms.TextBox HasloBox;
        private System.Windows.Forms.TextBox Haslo2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HasloAdminBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Rejestracja;
    }
}