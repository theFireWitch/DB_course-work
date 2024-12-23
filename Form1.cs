using MySql.Data.MySqlClient;
using System.Data;

namespace Курсова_робота
{
    public partial class Form1 : Form
    {

        //string connectionString = "Server=localhost;Port=3306;Database=coursework;Uid=root;Pwd=;";
        string connectionString = "Server=127.0.0.1;Port=3306;Database=coursework;Uid=root;Pwd=root-pw;SslMode=none;";
        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            string query = "SELECT * FROM students";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Виконання запиту
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Відображення даних у DataGridView
                dataGridView1.DataSource = table;
            }

            /*var uri = "bolt://localhost:7687";
            var user = "neo4j";   // Введіть ваш логін
            var password = "neo4j4545";  // Введіть ваш пароль

            var example = new Neo4jExample(uri, user, password);
            try
            {
                // Створення вузлів і зв'язків
                example.CreateNodesAndRelationships();
                Console.WriteLine("Вузли та зв'язки створені успішно.");

                // Виведення всіх ланцюжків для вузлів типу FirstType
                //example.PrintChainsForNodeType("FirstType");

                // Для вузлів другого типу (можна розкоментувати)
                // example.PrintChainsForNodeType("SecondType");

            }
            finally
            {
                // Закриття драйвера після завершення
                example.Close();
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM students";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("GetStudentInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@student_id", 1);
                    // Виконання процедури та отримання даних
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Відображення даних у DataGridView
                    dataGridView1.DataSource = table;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            login frmLogin = new login();
            frmLogin.ShowDialog();
        }
    }
}
