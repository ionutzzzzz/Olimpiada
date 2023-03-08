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

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = conn;
            cmd.CommandText = @"SELECT * FROM imprumut";

            SqlDataReader reader = cmd.ExecuteReader();

            int id = 1;
            while (reader.Read())
            {
                
            }
        }
    }
}
