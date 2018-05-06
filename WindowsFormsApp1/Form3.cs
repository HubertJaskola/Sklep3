using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            PrzypiszPartosciDoCB();
        }

        private void PrzypiszPartosciDoCB()
        {
            var context = new SklepEntities();
            var Role = context.RolaUzytkownika.ToList();
            cbRola.DataSource = Role;
            cbRola.ValueMember = "Id";
            cbRola.DisplayMember = "Rola";
        }



        private void Cofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rolaModel = (RolaUzytkownika)cbRola.SelectedItem;
            var rola = rolaModel.Rola;
            if (rola != "Administrator")
                {
                HasloAdminBox.Enabled = false;
                }
            else
            {
                HasloAdminBox.Enabled = true;

            }
        }
        

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            var rolaModel = (RolaUzytkownika)cbRola.SelectedItem;
            var rola = rolaModel.Rola; 

            if (ImieBox.Text == "" || HasloBox.Text == "")
                MessageBox.Show("Musisz uzupełnić puste pola");
            else if (HasloAdminBox.Text == "hubert" || rola == "Uzytkownik" )
            {

                var context = new SklepEntities();
                var Uzytkownicy = new Uzytkownicy
                {
                    IMIE = ImieBox.Text,
                    NAZWISKO = NazwiskoBox.Text,
                    LOGIN = LoginBox.Text,
                    PASSWORD = HasloBox.Text,
                    //IdRola = cbRola.
                    
                };

                if (Uzytkownicy.PASSWORD == Haslo2Box.Text)
                {
                    context.Uzytkownicy.Add(Uzytkownicy);
                    context.SaveChanges();
                    MessageBox.Show("Pomyślnie zarejestrowano konto.");
                    new Form1().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Podane hasła nie są prawidłowe.");
                }
               

            }
            else
            {
                MessageBox.Show("Wprowadz poprawne hasło administratora.");
            }
        }


    }
    }

