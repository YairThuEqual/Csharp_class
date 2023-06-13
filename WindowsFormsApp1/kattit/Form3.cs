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
    public partial class frm_three : Form
    {
        public frm_three()
        {
            InitializeComponent();
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a + b;

            MessageBox.Show($"{c}");
        }

        private void btn_one_click_Click(object sender, EventArgs e)
        {
            int i = 0;
            label1.Text = "";

            //while (i < 5)
            //{
            //    label1.Text += $"{i} \n";
            //    i++; // 0r i += 1;
            //}

            //{
            //    for(int i = 0; i < 5; i++)
            //    {
            //        label1.Text += $"{i} \n";
            //    }
            //}


            do
            {
                label1.Text += $"{i} \n";
                i++;
            } while (i < 5);
        }

        private void btn_input_click_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int i = 1;
            string output;
            int x = int.Parse(txt_x.Text);
            int y = int.Parse(txt_y.Text);
            int z = int.Parse(txt_z.Text);


            while (i <= z)
            {
                if (i % x == 0 && i % y == 0)
                {
                    output = "fizzbuzz";
                }
                else if (i % y == 0)
                {
                    output = "buzz";
                }
                else
                {
                    output = i.ToString();
                }
                label2.Text += $"{output} \n";
                i++;

            }


            //label2.Text = "";
            //int i = 1;
            //string output;
            //int x;
            //int y;
            //int n;
            //x = int.Parse(txt_x.Text);
            //y = int.Parse(txt_y.Text);
            //n = int.Parse(txt_z.Text);



            //while (i <= n)
            //{
            //    if (i % x == 0 && i % y == 0)
            //    {
            //        output = "fizzbuzz";
            //    }
            //    else if (i % x == 0)
            //    {
            //        output = "fizz";
            //    }
            //    else if (i % y == 0)
            //    {
            //        output = "buzz";
            //    }
            //    else
            //    {
            //        output = i.ToString();
            //    }
            //    label2.Text += $"{output}\n";
            //    i += 1;
            //}
        }
    }
}
