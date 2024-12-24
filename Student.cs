using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсова_робота
{
    public partial class Student : Form
    {
        int StudentID;
        string connectionString = "Server=127.0.0.1;Port=3306;Database=coursework;Uid=root;Pwd=root-pw;SslMode=none;";
        public Student(string id)
        {
            InitializeComponent();
            init(id);
        }
        private void init(string input)
        {
            string lastTwoChars = input.Substring(input.Length - 2);

            if (int.TryParse(lastTwoChars, out int result))
            {
                StudentID = result;
            }
            else
            {
                //textBox1.Text = "AAAAAA";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("GetStudentMarks", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@student_id_in", StudentID);
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
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("CalculateScholarship", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@st_id", StudentID);
                    cmd.Parameters["@st_id"].Direction = ParameterDirection.Input;

                    MySqlParameter statusParam = new MySqlParameter("@status_m", MySqlDbType.VarChar);
                    statusParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(statusParam);

                    cmd.ExecuteNonQuery();

                    string statusMessage = statusParam.Value.ToString();
                    statusTextBox.Text = statusMessage;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("GetStudParam", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@st_id", StudentID);
                    // Виконання процедури та отримання даних
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Відображення даних у DataGridView
                    dataGridView1.DataSource = table;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string act = textBox1.Text;
            string dorm = textBox2.Text; 
            if (act == "" || dorm == "")
            {
                ERROR frmLogin1 = new ERROR("Введіть дані!");
                frmLogin1.ShowDialog();
            }
            else if ((act != "0" && act != "1") || (dorm != "0" && dorm != "1"))
            {
                ERROR frmLogin1 = new ERROR("Введіть правильні дані!");
                frmLogin1.ShowDialog();
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UpdateStudentActivityAndDorm", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@student_id_in", StudentID);
                        command.Parameters.AddWithValue("@social_activity_in", act);
                        command.Parameters.AddWithValue("@dormitory_in", dorm);
                    }
                }
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("GetStudParam", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@st_id", StudentID);
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
