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
            string nodeIdInput = login_textbox.Text;
            if (int.TryParse(nodeIdInput, out int nodeId))
            {
                var nodeLabels = await example.GetNodeLabelsById(nodeId);
                foreach (var label in nodeLabels)
                {
                    if(label != null)
                    {
                        if(label == "Teacher")
                        {
                            professor frmLogin1 = new professor();
                            frmLogin1.ShowDialog();
                        }
                        else if(label == "Student")
                        {
                            Student frmLogin1 = new Student();
                            frmLogin1.ShowDialog();
                        }
                        else if (label == "Admin")
                        {
                            Admin frmLogin1 = new Admin();
                            frmLogin1.ShowDialog();
                        }
                        else
                        {
                            ERROR frmLogin1 = new ERROR("Неправильний логін");
                            frmLogin1.ShowDialog();
                        }
                    }
                    else
                    {
                        ERROR frmLogin1 = new ERROR("Неправильний логін");
                        frmLogin1.ShowDialog();
                    }
                }
            }
            else
            {
                ERROR frmLogin1 = new ERROR("Неправильний логін");
                frmLogin1.ShowDialog();
            }
        }
        private void button_login_Click_3(object sender, EventArgs e)
        {
            login_metod();
        }
    }
}
