using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

		private DataGridViewButtonColumn collumn = new DataGridViewButtonColumn();
		private void Form4_Load(object sender, EventArgs e)
		{
			label1.Text = "Email utilizator: " + Form3.email;

			// TABLE 1:

			DataTable table = new DataTable();

			collumn.HeaderText = "Imprumuta cartea";

			table.Columns.Add("Id_Carte", typeof(int));
			table.Columns.Add("Titlu", typeof(string));
			table.Columns.Add("Autor", typeof(string));
			table.Columns.Add("Gen", typeof(string));

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


			// TABLE 2

			DataTable dt = new DataTable();
			dt.Columns.Add("Index", typeof(int));
			dt.Columns.Add("Titlu", typeof(string));
			dt.Columns.Add("Autor", typeof(string));
			dt.Columns.Add("Data imprumut", typeof(string));
			dt.Columns.Add("Data disponibila", typeof(string));

			conn.Open();
			cmd.CommandText = @"SELECT * FROM imprumut";

			reader = cmd.ExecuteReader();

			id = 1;
			while (reader.Read())
			{
				string titlu = reader.GetString(1);
				string autor = reader.GetString(2);
				string data1 = reader.GetString(3).ToString();
				string data2 = DateTime.Now.ToString();

				dt.Rows.Add(id, titlu, autor, data1, data2);
				id++;
			}


			adapter = new SqlDataAdapter(cmd);
			dataGridView2.DataSource = dt;
			dataGridView2.DataMember = dt.TableName;

			conn.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int x = collumn.Index;
			SqlConnection conn = new SqlConnection(Form1.bazadedate);
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter sda = new SqlDataAdapter();
			DateTime now = DateTime.Now;

			SqlDateTime Data = new SqlDateTime(now.Year, now.Month, now.Day);

			conn.Open();

			cmd.Connection = conn;
			cmd.CommandText = @"INSERT INTO imprumut(id_carte, email, data_imprumut) VALUES(@1, @2, @3)";
			cmd.Parameters.Add("1", ); // int
			cmd.Parameters.Add("2", ); // nchar(30)
			// cmd.Parameters.Add("3", ); // datetime
			cmd.Parameters.Clear();
			cmd.ExecuteNonQuery();

			if (x != -1)
			{

			}

			conn.Close();
		}
	}
}
