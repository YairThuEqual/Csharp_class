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
    public partial class one_teo : Form
    {
        public one_teo()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
            if ( a < 0 && b > 0)
            {
                MessageBox.Show("quadrant 2");
            }
            else if (a > 0 && b > 0)
            {
                MessageBox.Show("quadrant 1");
            }
            else if (a < 0 && b < 0)
            {
                MessageBox.Show("quadrant 3");
            }
            else if ( a > 0 && b < 0)
            {
                MessageBox.Show("quadrant 4");
            }

            MessageBox.Show($"{c}");
        }
    }
}
