using Microsoft.VisualBasic.ApplicationServices;
using MySqlX.XDevAPI;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсова_робота
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public async Task login_metod()
        {
            var uri = "bolt://localhost:7687";
            var user = "neo4j";
            var password = "neo4j4545";
            var example = new Neo4jExample(uri, user, password);
            string nodelogin = login_textbox.Text;
            string nodepassword = password_box.Text;
            bool sucses = true;
            bool sucses2 = false;
            if (nodelogin != "" && nodepassword != "")
            {
                var nodeLabels = await example.LogInId(nodelogin, nodepassword, sucses);
                if(sucses)
                {
                    foreach (var label in nodeLabels)
                    {
                        if (label != null)
                        {
                            if (label == "Teacher")
                            {
                                professor frmLogin1 = new professor(nodelogin);
                                frmLogin1.ShowDialog();
                                sucses2 = true;
                            }
                            else if (label == "Student")
                            {
                                Student frmLogin1 = new Student(nodelogin);
                                frmLogin1.ShowDialog();
                                sucses2 = true;
                            }
                            else if (label == "Admin")
                            {
                                Admin frmLogin1 = new Admin();
                                frmLogin1.ShowDialog();
                                sucses2 = true;
                            }
                            else
                            {
                                ERROR frmLogin1 = new ERROR("Неправильний логін або пароль");
                                frmLogin1.ShowDialog();
                            }
                        }
                        else
                        {
                            ERROR frmLogin1 = new ERROR("Неправильний логін або пароль");
                            frmLogin1.ShowDialog();
                        }
                    }
                }
                else
                {
                    ERROR frmLogin1 = new ERROR("Неправильний логін або пароль");
                    frmLogin1.ShowDialog();
                }
                if (!sucses2)
                {
                    ERROR frmLogin1 = new ERROR("Неправильний логін або пароль");
                    frmLogin1.ShowDialog();
                }
            }
            else
            {
                ERROR frmLogin1 = new ERROR("Введіть данні");
                frmLogin1.ShowDialog();
            }
        }
        private void button_login_Click_3(object sender, EventArgs e)
        {
            login_metod();
        }
    }
}
