using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.frm_condition
{
    public partial class frm_condition : Form
    {
        public frm_condition()
        {
            InitializeComponent();
        }

        private void frm_condition_Load(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        MessageBox.Show(i.ToString());
            //    }
            //}

            //for (int i =1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        MessageBox.Show(i.ToString());
            //    }
            //}

            //for(int i = 0; i <= 100; i++)
            //{
            //    if(i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
            //    {
            //        MessageBox.Show(i.ToString());
            //    }
            //}



            //string prime_not = "";
            //for (int i = 2; i <= 100; i++)
            //{
            //    if (i == 2)
            //    {
            //        MessageBox.Show($"{i} is prime");
            //    }
            //    else
            //    {
            //        //      9   9
            //        for (int j = 2; j < i; j++)
            //        {
            //            // 9 % 3
            //            if (i % j != 0)
            //            {
            //                //prime
            //                prime_not = "prime";
            //            }
            //            else
            //            {
            //                //not prime
            //                prime_not = "not prime";
            //                j = i;
            //            }
            //        }
            //        MessageBox.Show($"{i} is {prime_not}");
            //    }
            //}

            //prime number
            //string prime_not = "";

            //for (int i = 2; i <= 100; i++)
            //{
            //    int n_prime = 0;
            //    if (i == 2)
            //    {
            //        MessageBox.Show($"{i} is prime");
            //    }
            //    else
            //    {
            //        //      2   8
            //        for (int j = 2; j < i; j++)
            //        {
            //            // 8 % 2
            //            if (i % j != 0)
            //            {
            //                //prime
            //                prime_not = "prime";
            //            }
            //            else
            //            {
            //                //not prime
            //                prime_not = "not prime";
            //                j = i; //8
            //                bool check = true;
            //                //     true
            //                while (check)
            //                {
            //                    //              10 < 11
            //                    for (int k = 2; k < j; k++)
            //                    {
            //                        //  11 % 2
            //                        if (j % k != 0)
            //                        {
            //                            //   11 - 10 1==1
            //                            if (j - k == 1)
            //                            {
            //                                n_prime = j;
            //                                check = false;
            //                            }
            //                        }
            //                        else
            //                        {
            //                            k = j;
            //                        }
            //                    }
            //                    j++;
            //                }
            //            }
            //        }
            //        MessageBox.Show($"{i} is {prime_not}");
            //        //     5 > 0
            //        if (n_prime > 0)
            //        {
            //            MessageBox.Show($"{n_prime} is nearest prime");
            //        }
            //    }
            //}


        }
    }
}
