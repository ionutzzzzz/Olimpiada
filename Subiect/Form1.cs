using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Subiect
{
	public partial class Form1 : Form
	{
		public static string path = Application.ExecutablePath;
		public static string root = Application.StartupPath;
		public static string bazadedate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + root + @"FreeBook.mdf" + @";Integrated Security=True";
		SqlConnection conn = new SqlConnection(bazadedate);

		public Form1()
		{
			InitializeComponent();
			Remove();
			Update();
		}

		void Update()
		{
			conn.Open();
			SqlCommand cmd = new SqlCommand();
			StreamReader utilizatori = new StreamReader(root + @"\utilizatori.txt");
			StreamReader carti = new StreamReader(root + @"carti.txt");
			StreamReader imprumuturi = new StreamReader(root + @"imprumuturi.txt");
			DateTime dt = new DateTime();
			string data;
			string? line;

			cmd.Connection = conn;
			while((line = utilizatori.ReadLine()) != null)
			{
				string[] siruri = line.Split('*');
				cmd.CommandText = @"INSERT INTO utilizatori(email, parola, nume, prenume) VALUES(@1, @2, @3, @4)";
				cmd.Parameters.AddWithValue("1", siruri[0]);
				cmd.Parameters.AddWithValue("2", siruri[1]);
				cmd.Parameters.AddWithValue("3", siruri[2]);
				cmd.Parameters.AddWithValue("4", siruri[3]);
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				cmd.Parameters.Clear();
			}
			while((line = carti.ReadLine()) != null)
			{
				string[] siruri = line.Split('*');
				cmd.CommandText = @"INSERT INTO carti(titlu, autor, gen) VALUES(@1, @2, @3)";
				cmd.Parameters.AddWithValue("1", siruri[0]);
				cmd.Parameters.AddWithValue("2", siruri[1]);
				cmd.Parameters.AddWithValue("3", siruri[2]);
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				cmd.Parameters.Clear();
			}

			// TODO: FIX TABLE INPUT
			/*while ((line = imprumuturi.ReadLine()) != null)
			{
				string[] siruri = line.Split('*');
				data = siruri[2].Trim();
				dt = DateTime.Parse(data.Trim(), System.Globalization.CultureInfo.InvariantCulture);

				SqlDataAdapter sda = new SqlDataAdapter(@"Select id_carte from carti where titlu ='" + siruri[0].Trim() + "'", conn);
				DataTable d = new DataTable();
				sda.Fill(d);
				DataRow dr = d.Rows[0];
				cmd = new SqlCommand(@"INSERT INTO imprumut(id_carte,email,data_imprumut) values (@1,@2,@3)", conn);
				cmd.Parameters.AddWithValue("1", int.Parse(dr["id_carte"].ToString()));
				cmd.Parameters.AddWithValue("2", siruri[1].Trim());
				cmd.Parameters.AddWithValue("3", dt);
				cmd.ExecuteNonQuery();
				cmd.Dispose();

			}*/

			conn.Close();
		}

		void Remove()
		{
			conn.Open();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = @"TRUNCATE TABLE utilizatori";
			cmd.ExecuteNonQuery();
			cmd.Dispose();

			cmd.CommandText = @"TRUNCATE TABLE carti";
			cmd.ExecuteNonQuery();
			cmd.Dispose();

			cmd.CommandText = @"TRUNCATE TABLE imprumut";
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			conn.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e) // Logare
		{
			Form3 f = new Form3();
			f.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e) // Inregistrare
		{
			Form2 f = new Form2();
			f.Show();
			this.Hide();
		}
	}
}