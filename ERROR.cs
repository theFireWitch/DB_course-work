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
    public partial class ERROR : Form
    {
        public ERROR(string labelText)
        {
            InitializeComponent();
            
            label.Text = labelText;
        }
        
    }
}
