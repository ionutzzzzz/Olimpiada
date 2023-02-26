using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
            textBox5.PasswordChar = '*';
        }

        bool Validare()
        {
            if (textBox1.Text == null) return false;
            if (textBox2.Text == null) return false;
            if (textBox3.Text == null) return false;
            if (textBox4.Text == null) return false;
            if (textBox5.Text == null) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e) // Inregistrare
        {
            string password1 = textBox4.Text;
            string password2 = textBox5.Text;

            if(password1 != password2 && Validare()) 
            {
                MessageBox.Show("Datele de inregistrare sunt incorecte!\n" +
                    "Te rugam sa incerci inca o data!");
            }
            else
            {

                SqlConnection conn = new SqlConnection(Form1.bazadedate);
                SqlCommand cmd = new SqlCommand();

                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO utilizatori(email, parola, nume, prenume) VALUES(@1, @2, @3, @4)";
                    cmd.Parameters.AddWithValue("1", textBox1.Text);
                    cmd.Parameters.AddWithValue("2", textBox4.Text);
                    cmd.Parameters.AddWithValue("3", textBox2.Text);
                    cmd.Parameters.AddWithValue("4", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd.Parameters.Clear();
                    conn.Close();
                    MessageBox.Show("Utilizator adaugat cu succes!");
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
