using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.kattit
{
    public partial class two_teo : Form
    {
        public two_teo()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            int user_input = int.Parse(textBox1.Text);
            if (user_input % 2 == 0)
            {
                MessageBox.Show("boat");
            }
            else
            {
                MessageBox.Show("enermy");
            }
        }

  
    }
}
