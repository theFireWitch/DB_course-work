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

namespace Курсова_робота
{
    public partial class Admin : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=coursework;Uid=root;Pwd=root-pw;SslMode=none;";

        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("GroupListAvgGPA", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@student_id", 1);
                    // Виконання процедури та отримання даних
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Відображення даних у DataGridView
                    dataGridView1.DataSource = table;
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("GetStudentPerformanceAvg", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@student_id", 1);
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
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("allStudentsWithMarksSorted", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@student_id", 1);
                    // Виконання процедури та отримання даних
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Відображення даних у DataGridView
                    dataGridView1.DataSource = table;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string group = textBox1.Text;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("GetStudentMarksByGroup", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@in_group", group);
                    // Виконання процедури та отримання даних
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Відображення даних у DataGridView
                    dataGridView1.DataSource = table;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("GroupExpelledList", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@in_group", group);
                    // Виконання процедури та отримання даних
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Відображення даних у DataGridView
                    dataGridView1.DataSource = table;
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            string group = textBox2.Text;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("finalCalculateScholarship", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@group_code_in", group);
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
