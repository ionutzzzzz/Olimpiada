using System;
using System.Data.SqlClient;

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
			StreamReader reader = new StreamReader(root + @"\utilizatori.txt");
			string line;

			cmd.Connection = conn;
			

			while((line = reader.ReadLine()) != null)
			{
				cmd.CommandText = @"INSERT INTO utilizatori(email, parola, nume, prenume) VALUES(@1, @2, @3, @4)";
				
			}
			conn.Close();
		}

		void Remove()
		{
			conn.Open();
			conn.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e) // Logare
		{

		}

		private void button2_Click(object sender, EventArgs e) // Inregistrare
		{

		}
	}
}