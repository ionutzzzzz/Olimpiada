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

			table.Columns.Add("Id_Carte", typeof(int));
			table.Columns.Add("Titlu", typeof (string));
			table.Columns.Add("Autor", typeof (string));
			table.Columns.Add("Gen", typeof (string));
			


			SqlConnection conn = new SqlConnection(Form1.bazadedate);
			conn.Open();

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = @"SELECT * FROM carti";

			SqlDataReader reader = cmd.ExecuteReader();

			int id = 1;
			while (reader.Read())
			{
				string titlu = reader.GetString(1);
				string autor = reader.GetString(2);
				string gen = reader.GetString(3);

				table.Rows.Add(id, titlu, autor, gen);
				id++;
			}

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			dataGridView1.DataSource = table;
			dataGridView1.DataMember = table.TableName;
            dataGridView1.Columns.Add(collumn);
            conn.Close();
		}
	}
}
