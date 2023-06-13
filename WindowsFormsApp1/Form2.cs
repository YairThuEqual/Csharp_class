using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_reset : Form
    {
        public Frm_reset()
        {
            InitializeComponent();
        }
        int te = 0;
        private void btn_increase_Click(object sender, EventArgs e)
        {
            te += 1;
            count.Text = te.ToString();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            if(rbtn_male.Checked == true)
            {
                MessageBox.Show("male");
            } 
            else if(rbtn_famale.Checked == true)
            {
                MessageBox.Show("female");
            } 
            else if(rbtn_other.Checked == true) // (or) else only can write
            {
                MessageBox.Show("other");
            }
        }

    }
}
