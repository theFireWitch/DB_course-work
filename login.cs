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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void button_login_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click_1(object sender, EventArgs e)
        {
            Form1 frmLogin1 = new Form1();
            frmLogin1.ShowDialog();
        }
    }
}
