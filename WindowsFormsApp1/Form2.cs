using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        Produkty model = new Produkty();
        private readonly string _userLogin;


        public Form2(string userLogin)
        {
            InitializeComponent();
            _userLogin = userLogin;
            lblLoginName.Text = userLogin;
        }

        void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            Wprowadz.Text = "Wprowadz";
            model.ID = 0;
        }

        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            Wprowadz.Text = "Wprowadz";
            model.ID = 0;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Clear();
            ProduktDataGridView();
        }

        private void Wprowadz_Click(object sender, EventArgs e)
        {

            model.Produkt = textBox1.Text.Trim();
            try
            {
                model.IloscSztuk = Convert.ToInt32(textBox2.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wprowadz poprawne dane. {ex.ToString()}");
                return;
            }

            if (textBox1.Text == "" || textBox3.Text == "")
                MessageBox.Show("Musisz uzupełnić puste pola");
            else
            {



                model.Opis = textBox3.Text.Trim();
                using (SklepEntities db = new SklepEntities())
                {
                    if (model.ID == 0)           //wprowadz 
                        db.Produkty.Add(model);
                    else                        //aktualizuj
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                ProduktDataGridView();
                MessageBox.Show("Wprowadzono pomyślnie");
            }
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            int ID = (int)dvgProdukt.CurrentRow.Cells["ID"].Value;
            {
                if (MessageBox.Show("Jesteś pewien że chcesz usunąć te produkty?", "Usuwanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    using (SklepEntities db = new SklepEntities())
                    {
                        var entry = db.Produkty.SingleOrDefault(p => p.ID == ID);
                        if (entry == null)
                            throw new Exception("Nie znaleziono rekordu w bazie.");

                        db.Produkty.Remove(entry);
                        db.SaveChanges();
                        ProduktDataGridView();
                        Clear();
                        MessageBox.Show("Usunięto");
                    }
            }
        }
        public void ProduktDataGridView()
        {
            using (SklepEntities db = new SklepEntities())
            {
                dvgProdukt.DataSource = db.Produkty.ToList<Produkty>();
            }

        }

        private void dvgProdukt_DoubleClick(object sender, EventArgs e)
        {
            if (dvgProdukt.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dvgProdukt.CurrentRow.Cells["ID"].Value);
                using (SklepEntities DB = new SklepEntities())
                {
                    model = DB.Produkty.Where(x => x.ID == model.ID).FirstOrDefault();
                    textBox1.Text = model.Produkt;
                    textBox2.Text = model.IloscSztuk.ToString();
                    textBox3.Text = model.Opis;

                }
                Wprowadz.Text = "Aktualizuj";

            }
        }
        private void Wyloguj_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pAdmin_Click(object sender, EventArgs e)
        {
            new Form4(lblLoginName.Text).Show();
            this.Hide();
        }

        private void SzukajBox_TextChanged(object sender, EventArgs e)
        {
            using (SklepEntities db = new SklepEntities())
            {
                dvgProdukt.DataSource = db.Produkty.Where(x => x.Produkt.Contains(SzukajBox.Text)).ToList();
            }
        }


    }
}
