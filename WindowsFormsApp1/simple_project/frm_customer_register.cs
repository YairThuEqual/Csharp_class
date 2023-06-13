using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.simple_project
{
    public partial class frm_customer_register : Form
    {
        public frm_customer_register()
        {
            InitializeComponent();
        }

        Connect connect = new Connect();
        MySqlCommand cmd = new MySqlCommand();

        //function 
        //1.keyword(public,private,proctected) 2.datatype(void , return(int,string,char,float...))
        //3.function name
        //                            parameter / argument
        public bool strong_password(string password)
        {
            int count = 0;
            string special_char = "!@#$%^&*~|;_-";



            // length of password
            if (password.Length >= 6)
            {
                count += 1;
            }



            //special character
            //             0 < 13       
            for (int i = 0; i < special_char.Length; i++)
            {     //           1 < 4
                for (int j = 0; j < password.Length; j++)
                {
                    //                ! == 2
                    if (special_char[i] == password[j])
                    {
                        count += 1;
                        i = special_char.Length;
                        j = password.Length;
                    }
                }
            }



            //upper case
            for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (char.IsUpper(password[i]))
                {
                    count += 1;
                    break;
                }
            }



            //lowercase
            for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (char.IsLower(password[i]))
                {
                    count += 1;
                    break;
                }
            }



            //digit
            for (int i = 0; i < password.Length; i++)
            {
                //      true islower, isdigit
                if (char.IsDigit(password[i]))
                {
                    count += 1;
                    break;
                }
            }



            if (count == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void test()
        //{
        //    MessageBox.Show("something");
        //}

        //public string test1()
        //{
        //    return "something from test1";
        //}

        //public int test2()
        //{
        //    return 2;
        //}



        //public bool special_character(string password)
        //{
        //    bool check = false;
        //    string special_char = "!@#$%^&*~|;_-";
        //    //             0 < 13      
        //    for (int i = 0; i < special_char.Length; i++)
        //    {     //           1 < 4
        //        for (int j = 0; j < password.Length; j++)
        //        {
        //            //                ! == 2
        //            if (special_char[i] == password[j])
        //            {
        //                check = true;
        //                i = special_char.Length;
        //                j = password.Length;
        //            }
        //            else
        //            {
        //                check = false;
        //            }
        //        }
        //    }
        //    return check;
        //}

        //public bool upper_case(string password)
        //{
        //    bool check = false;
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        //      true
        //        if (char.IsUpper(password[i]))
        //        {
        //            check = true;
        //            break;
        //        }
        //        else
        //        {
        //            check = false;
        //        }
        //    }
        //    return check;
        //}


        //public bool lower_case(string password)
        //{
        //    bool check = false;
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        //      true
        //        if (char.IsLower(password[i]))
        //        {
        //            check = true;
        //            break;
        //        }
        //        else
        //        {
        //            check = false;
        //        }
        //    }
        //    return check;
        //}

        //public bool digit_case(string password)
        //{
        //    bool check = false;
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        //      true
        //        if (char.IsDigit(password[i]))
        //        {
        //            check = true;
        //            break;
        //        }
        //        else
        //        {
        //            check = false;
        //        }
        //    }
        //    return check;
        //}


        public static string name, email, password, confirm_password;

        private void linlbl_alreadyaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_customers_login fcl = new frm_customers_login();
            fcl.ShowDialog();
        }

        // strong password alphanumeric spcial character capital small length > 8
        private void btn_signup_Click_1(object sender, EventArgs e)
        {
            //test();
            //MessageBox.Show(test1());
            //MessageBox.Show($"{test2() + 2}");

            name = txt_user_name.Text;
            email = txt_email.Text;
            password = txt_password.Text;
            confirm_password = txt_confirm_password.Text;

            //MessageBox.Show($"{special_character(password)}");
            //MessageBox.Show($"{upper_case(password)}");
            //MessageBox.Show($"{lower_case(password)}");
            //MessageBox.Show($"{digit_case(password)}");

            //modified function call    
            //MessageBox.Show($"{strong_password(password)}");


            //special_password(password)
            //special characrter


            if (name == "" || email == "" || password == "" || confirm_password == "")
            {
                MessageBox.Show("please enter name or password ");
            }
            else
            {       // modified strong password
                if (password == confirm_password && strong_password(password))
                {

                    cmd = connect.conn.CreateCommand();
                    cmd.CommandText = "insert into user_info(name, email, password, confirm_password)" +
                        " values('"+name+"', '"+email+"', '"+password+"', '"+confirm_password+"') ";
                    cmd.ExecuteNonQuery();
                    connect.conn.Close();


                    this.Hide();

                    frm_customers_login fcl = new frm_customers_login();
                    fcl.ShowDialog();
                }
                else
                {
                    MessageBox.Show("password are invalid");
                }
            }
        }
    }
}
