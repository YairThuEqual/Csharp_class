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
    public partial class frm_customers_login : Form
    {
        public frm_customers_login()
        {
            InitializeComponent();
        }

        Connect connect = new Connect();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;

        public string profile_name;

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name_emil, password;

            bool check = false;

            name_emil = txt_user_name_email.Text;
            password = txt_password.Text;

            profile_name = name_emil;

            cmd = connect.conn.CreateCommand();
            cmd.CommandText = "select name, email, password from user_info " +
                "where (name = '" + name_emil + "' or email = '" + name_emil + "') and password = '" + password + "' ";

            reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                //MessageBox.Show($"{reader.GetValue(0)}{reader.GetValue(1)}{reader.GetValue(2)}");
                check = true;
            }

            if(check)
            {
                //MessageBox.Show("login success");

                this.Hide();

                frm_dash_board fdb = new frm_dash_board();
                fdb.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid");
            }

            reader.Close();


            //if(name_emil == frm_customer_register.name || name_emil == frm_customer_register.email)
            //{
            //    if (password == frm_customer_register.password)
            //    {
            //    MessageBox.Show("Login access");
            //    }
            //    else
            //    {
            //        MessageBox.Show("invalid user");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("invalid user");
            //}





            //MessageBox.Show($"{frm_customer_register.name} \n" +
            //    $"{frm_customer_register.email} \n" +
            //    $"{frm_customer_register.password} \n" +
            //    $"{frm_customer_register.confirm_password} \n");
        }
    }
}
