using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.month
{
    public partial class frm_month : Form
    {
        public frm_month()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int user_input = int.Parse(textBox1.Text);

            //if (1 == user_input)
            //{
            //    MessageBox.Show("Janauary");
            //}
            //if (2 == user_input)
            //{
            //    MessageBox.Show("Fed");
            //}
            //if (3 == user_input)
            //{
            //    MessageBox.Show("Muc");
            //}
            //if (4 == user_input)
            //{
            //    MessageBox.Show("April");
            //}
            //if (5 == user_input)
            //{
            //    MessageBox.Show("May");
            //}
            //if (6 == user_input)
            //{
            //    MessageBox.Show("June");
            //}
            //if (7 == user_input)
            //{
            //    MessageBox.Show("July");
            //}
            //if (8 == user_input)
            //{
            //    MessageBox.Show("August");
            //}
            //if (9 == user_input)
            //{
            //    MessageBox.Show("Set");
            //}
            //if (10 == user_input)
            //{
            //    MessageBox.Show("Oct");
            //}
            //if (11 == user_input)
            //{
            //    MessageBox.Show("Nov");
            //}
            //if (12 == user_input)
            //{
            //    MessageBox.Show("Dec");
            //}


            //string user_month_input = textBox2.Text;

            //if (user_month_input == "jan")
            //{
            //    MessageBox.Show("1");
            //}
            //if (user_month_input == "fed")
            //{
            //    MessageBox.Show("2");
            //}
            //if (user_month_input == "muc")
            //{
            //    MessageBox.Show("3");
            //}
            //if (user_month_input == "apr")
            //{
            //    MessageBox.Show("4");
            //}
            //if (user_month_input == "may")
            //{
            //    MessageBox.Show("5");
            //}
            //if (user_month_input == "jun")
            //{
            //    MessageBox.Show("6");
            //}
            //if (user_month_input == "jul")
            //{
            //    MessageBox.Show("7");
            //}
            //if (user_month_input == "aug")
            //{
            //    MessageBox.Show("8");
            //}
            //if (user_month_input == "set")
            //{
            //    MessageBox.Show("9");
            //}
            //if (user_month_input == "oct")
            //{
            //    MessageBox.Show("10");
            //}
            //if (user_month_input == "nov")
            //{
            //    MessageBox.Show("11");
            //}
            //if (user_month_input == "dec")
            //{
            //    MessageBox.Show("12");
            //}

            //string user_day = textBox3.Text;

            //if (user_input == 1 && user_day == "31")
            //{
            //    MessageBox.Show("January");
            //}

            //if (user_input == 2 && user_day == "29")
            //{
            //    MessageBox.Show("Feb");
            //}
            //if (user_input == 3 && user_day == "30")
            //{
            //    MessageBox.Show("Muc");
            //}
            //if (user_input == 4 && user_day == "31")
            //{
            //    MessageBox.Show("Apr");
            //}
            //if (user_input == 5 && user_day == "31")
            //{
            //    MessageBox.Show("May");
            //}
            //if (user_input == 6 && user_day == "31")
            //{
            //    MessageBox.Show("Jun");
            //}
            //if (user_input == 7 && user_day == "31")
            //{
            //    MessageBox.Show("Jul");
            //}
            //if (user_input == 8 && user_day == "31")
            //{
            //    MessageBox.Show("Aug");
            //}
            //if (user_input == 9 && user_day == "31")
            //{
            //    MessageBox.Show("Set");
            //}
            //if (user_input == 10 && user_day == "31")
            //{
            //    MessageBox.Show("Oct");
            //}
            //if (user_input == 11 && user_day == "31")
            //{
            //    MessageBox.Show("Nov");
            //}
            //if (user_input == 12 && user_day == "31")
            //{
            //    MessageBox.Show("Dec");
            //}

            //MessageBox.Show($"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}");

            //int c_day = DateTime.Now.Day;
            //int c_month = DateTime.Now.Month;
            //int c_year = DateTime.Now.Year;

            //string[] dob = textBox4.Text.Split('.');

            //int myage;

            //if (int.Parse(dob[1]) < c_day)
            //{
            //    myage = c_year - int.Parse(dob[2]) - 1;
            //}
            //else
            //{
            //    myage = int.Parse(dob[2]);
            //}
            //MessageBox.Show($"{myage}");

            /*
            int user_input = Convert.ToInt32(textBox1.Text);
            string use = "";
            if(user_input == 1)
            {
                use = "january";
            }
            if(user_input == 2)
            {
                use = "february";
            }
            if(user_input == 3)
            {
                use = "muc";
            }
            MessageBox.Show($"{use}");
            */
            /*
            string user_input = textBox1.Text;
            string user = "";

            if(user_input == "january")
            {
                user = "1";
            }
            if(user_input == "february")
            {
                user = "2";
            }
            MessageBox.Show($"{user.ToString()}");
            */



            //int count = 1;
            //bool check = true;

            //while (check)
            //{
            //    MessageBox.Show("hello");
            //    count++;
            //    if (count == 5)
            //    {
            //        MessageBox.Show(count.ToString());
            //        break;
            //    }
            //}

            //int i = 1;
            //label1.Text = "";

            //while (i <= 5)
            //{
            //    label1.Text += "*";
            //    i++;
            //}

            //label1.Text = "";
            //int i = 1;

            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j <= 5)
            //    {
            //        label1.Text += "*";
            //        j++;
            //    }

            //    label1.Text += "\n";
            //    i++;
            //}

            //label1.Text = "";
            //int i = 1;

            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j <= 5)
            //    {
            //        label1.Text += $"{j}";
            //        j++;
            //    }

            //    label1.Text += "\n";
            //    i++;
            //}


            //label1.Text = "";
            //int i = 1;

            //while (i <= 5)
            //{
            //    int j = 5;
            //    while (j >= 1)
            //    {
            //        label1.Text += $"{j}";
            //        j--;
            //    }

            //    label1.Text += "\n";
            //    i++;
            //}

            //label1.Text = "";
            //int i = 1;
            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        label1.Text += $"{j}";
            //        j++;
            //    }
            //    label1.Text += "\n";
            //    i++;
            //}

            //label1.Text = "";
            //int i = 5;

            //while (i >= 1)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        label1.Text += $"{j}";
            //        j++;
            //    }

            //    label1.Text += "\n";
            //    i--;
            //}


            //label1.Text = "";
            //int i = 5;

            //while (i >= 1)
            //{
            //    int j = 5;
            //    while (j >= i)
            //    {
            //        label1.Text += $"{j}";
            //        j--;
            //    }

            //    label1.Text += "\n";
            //    i--;
            //}



            //label1.Text = "";
            //int i = 5;

            //while (i >= 1)
            //{
            //    int j = i;
            //    while (j >= 1)
            //    {
            //        label1.Text += $"{j}";
            //        j--;
            //    }

            //    label1.Text += "\n";
            //    i--;
            //}

            //label1.Text = "";
            //int i = 1;

            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j <= 7 - i)
            //    {
            //        label1.Text += $" ";
            //        j++;
            //    }

            //    int k = 1;
            //    while (k <= 2 * i - 1)
            //    {
            //        label1.Text += $"{k}";
            //        k++;
            //    }
            //    MessageBox.Show($"{i}");

            //    label1.Text += "\n";
            //    i++;
            //}

            //label1.Text = "";
            //int i = 1;
            //int p = 1;
            //while (i <= 5)
            //{
            //    int j = 1;
            //    while (j <= 7 - i)
            //    {
            //        label1.Text += $" ";
            //        j++;
            //    }

            //    int k = 1;
            //    while (k <= 2 * i - 1)
            //    {
            //        label1.Text += $"{p}";
            //        k++;
            //    }

            //    label1.Text += "\n";
            //    p++;
            //    i++;
            //}


            //label1.Text = "";
            //int i = 5;
            //int p = 1;
            //while (i >= 1)
            //{
            //    int k = 1;
            //    while(k <= i)
            //    {
            //        label1.Text += "*";
            //        k++;
            //    }

            //    int j = 1;
            //    while (j <= p)
            //    {
            //        label1.Text += $"{p}";
            //        j++;
            //    }
            //    label1.Text += "\n";
            //    p++;
            //    i--;
            //}
        }
        //int count = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            //if (textBox5.Text != "ggez")
            //{
            //    count++;

            //    MessageBox.Show("reenter");
            //    if (count == 5)
            //    {
            //        MessageBox.Show("wait 5s");
            //        count = 0;
            //    }
            //}

            //string data = textBox5.Text;
            //string output = "";
            //for (int i = 0; i < textBox5.TextLength; i++)
            //{
            //    if (char.IsUpper(data[i]))
            //    {
            //        output += data[i];
            //    }
            //}
            //MessageBox.Show(output);

            //string data = textBox5.Text;
            //int a = 1;
            //int b = 2;
            //int c = 3;
            //int d;

            //c = a;
            //a = b;
            //b = c;

            //for(int i = 0; i < data.Length; i++)
            //{
            //    if(data[i] == 'A')
            //    {
            //        b += c;
            //    }
            //    else if(data[i] == 'B')
            //    {
            //        a += b;
            //    }
            //    else if(data[i] == 'C')
            //    {
            //        c += a;
            //    }
            //    MessageBox.Show(data);
            //}

            
        }

        private void frm_month_Load(object sender, EventArgs e)
        {
        // Listener
        }

        private void frm_month_MouseDown(object sender, MouseEventArgs e)
        {
            //this.MouseDown += new MouseEventHandler(this.frm_month_MouseDown);
            //Random r = new Random();
            //this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void frm_month_MouseMove(object sender, MouseEventArgs e)
        {
            //this.MouseDown += new MouseEventHandler(this.frm_month_MouseMove);
            //Random r = new Random();
            //this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }
    } 
}
