using MySql.Data.MySqlClient;
using System.Data;

namespace Курсова_робота
{
    public partial class professor : Form
    {
        int TeacherID;
        string connectionString = "Server=127.0.0.1;Port=3306;Database=coursework;Uid=root;Pwd=root-pw;SslMode=none;";
        public professor(string id)
        {
            InitializeComponent();
            init(id);
        }
        private void init(string input)
        {
            string lastTwoChars = input.Substring(input.Length - 2);

            if (int.TryParse(lastTwoChars, out int result))
            {
                TeacherID = result;
                //textBox1.Text = input;
            }
            else
            {
                //textBox1.Text = "AAAAAA";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("GetStudentsProf", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@prof_id_in", TeacherID);
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
            groupBox2.Visible = true;
            groupBox3.Visible = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stud = textBox1.Text;
            string clas = textBox2.Text; //class це вбудована назва))
            string grade = textBox3.Text;
            if(stud == "" || clas == "" || grade == "")
            {
                ERROR frmLogin1 = new ERROR("Введіть дані!");
                frmLogin1.ShowDialog();
            }
            else if (!int.TryParse(clas, out int result) || !int.TryParse(stud, out int result2) || !int.TryParse(grade, out int result3))
            {
                ERROR frmLogin1 = new ERROR("Введіть правильні дані!");
                frmLogin1.ShowDialog();
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("updatePerformance", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@in_student_id", stud);
                        command.Parameters.AddWithValue("@in_class_id", clas);
                        command.Parameters.AddWithValue("@new_mark", grade);
                        // Виконання процедури та отримання даних
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Відображення даних у DataGridView
                        dataGridView1.DataSource = table;
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string clas = textBox4.Text;
            if (clas == "")
            {
                ERROR frmLogin1 = new ERROR("Введіть дані!");
                frmLogin1.ShowDialog();
            }
            else if(!int.TryParse(clas, out int result))
            {
                ERROR frmLogin1 = new ERROR("Введіть правильний id класу!");
                frmLogin1.ShowDialog();
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("GetStudentsProfAndClass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@prof_id_in", TeacherID);
                        command.Parameters.AddWithValue("@class_id_in", clas);
                        // Виконання процедури та отримання даних
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Відображення даних у DataGridView
                        dataGridView1.DataSource = table;
                    }
                }
            }
        }
    }
}
