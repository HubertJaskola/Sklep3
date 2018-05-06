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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
           var context = new SklepEntities();
            var dbRow = context.Uzytkownicy.Where(a => a.LOGIN == textBox1.Text && a.PASSWORD == textBox2.Text).FirstOrDefault();
            
            if (dbRow == null)
            {
                MessageBox.Show("Błędny login lub hasło.");
            }
            else
            {
                new Form2(textBox1.Text).Show();
                this.Hide();
                
                //MessageBox.Show("Login to: " + dbRow.LOGIN + "oraz hasło to:" + dbRow.PASSWORD);
            }
            

        }

            private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();

        }
    }
}
