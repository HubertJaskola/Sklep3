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
    
    public partial class Form4 : Form
    {
        Uzytkownicy model = new Uzytkownicy();
        private readonly string _userLogin;

        public Form4(string userLogin)
        {
            InitializeComponent();
            _userLogin = userLogin;
            lbllogin.Text = userLogin;
            UzytkownicyDataGridView();
        }
        public Form4()
        {
            InitializeComponent();
            UzytkownicyDataGridView();
        }

        private void Wroc_Click(object sender, EventArgs e)
        {
            new Form2(_userLogin).Show();
            this.Hide();
        }

        void UzytkownicyDataGridView()
        {
            using (SklepEntities db = new SklepEntities())
            {
                dvgUzytkownicy.DataSource = db.Uzytkownicy.ToList<Uzytkownicy>();
            }
        }

        private void UsunUzytkownika_Click(object sender, EventArgs e)
        {
            int ID = (int)dvgUzytkownicy.CurrentRow.Cells["ID"].Value;
            {
                if (MessageBox.Show("Jesteś pewien że chcesz usunąć użytkownika?", "Usuwanie użytkownika", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    using (SklepEntities db = new SklepEntities())
                    {
                        var entry = db.Uzytkownicy.SingleOrDefault(p => p.ID == ID);
                        if (entry == null)
                            throw new Exception("Nie znaleziono rekordu w bazie.");
                        db.Uzytkownicy.Remove(entry);
                        db.SaveChanges();
                        UzytkownicyDataGridView();
                        MessageBox.Show("Usunięto użytkownika");
                    }

            }
        }



    }
}
