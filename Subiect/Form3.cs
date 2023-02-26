using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Logare
        {
            try
            {
                SqlConnection conn = new SqlConnection(Form1.bazadedate);
                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter(@"Select email,parola from utilizatori where email='" + textBox1.Text + "' and parola ='" + textBox2.Text + "'", conn);
                DataTable dt = new DataTable();
               
                sda.Fill(dt);

                if(dt.Rows.Count > 0 ) 
                {
                    this.Hide();
                    Form4 f = new Form4();
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Eroare autentificare!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
