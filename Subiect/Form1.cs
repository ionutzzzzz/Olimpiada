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
			Update();
		}

		void Update()
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			conn.Open();

			richTextBox1.Text = bazadedate;
		}

		private void button1_Click(object sender, EventArgs e) // Logare
		{

		}

		private void button2_Click(object sender, EventArgs e) // Inregistrare
		{

		}
	}
}