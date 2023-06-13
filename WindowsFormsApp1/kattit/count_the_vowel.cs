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
    public partial class count_the_vowel : Form
    {
        public count_the_vowel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string vowel = "aeiou";
            string user_input = textBox1.Text.ToLower();

            for(int i = 0; i< user_input.Length; i++)
            {
                for(int j = 0; j < vowel.Length; j++)
                {
                    if(user_input[i] == vowel[j])
                    {
                        count++;
                        j = vowel.Length;
                    }
                }
            }
            MessageBox.Show(count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);

            if( a > b)
            {
                MessageBox.Show("1");
            }
            else
            {
                MessageBox.Show("0");
            }
        }
    }
}
