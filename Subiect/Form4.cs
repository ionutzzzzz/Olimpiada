using Microsoft.VisualBasic;
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
    
    public partial class Form4 : Form
    {
        private static bool OK;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            label1.Text = "Email utilizator: " + Form3.email;

            DataTable table = new DataTable();
            DataGridViewButtonColumn collumn = new DataGridViewButtonColumn();


            collumn.HeaderText = "Imprumuta cartea";
            dataGridView1.Columns.Add("Titlu", "Titlu");
            dataGridView1.Columns.Add("Autor", "Autor");
            dataGridView1.Columns.Add("Gen", "Gen");
            dataGridView1.Columns.Add(collumn);

            SqlConnection conn = new SqlConnection(Form1.bazadedate);
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT titlu,autor,gen FROM carti", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter sda2 = new SqlDataAdapter(@"SELECT * from utilizatori u JOIN imprumut i ON(u.email = i.email) JOIN carti c ON(c.id_carte = i.id_carte) where u.email='" + Form3.email + "'", conn);
            DataTable dt1 = new DataTable();
            sda2.Fill(dt1);
            


            conn.Close();
        }
    }
}
