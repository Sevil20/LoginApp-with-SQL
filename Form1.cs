using System.Data;
using System.Data.SqlClient;
namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documents\SQL Server Management Studio\SQL Server Scripts1\SQL Server Scripts1\DBLogin.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from dbo.[Table] where username = '"+ textBox1.Text.Trim()+"' and password = '"+ textBox2.Text.Trim()+"' ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                Form2 dashboard = new Form2();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Check your username or password");
            }
        }

       
    }
}