using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // constructor oop auto
    public class Connect
    {
        public MySqlConnection conn;
        public Connect()
        {
            string db_info = "server=localhost;port=3306;uid=root;pwd=root;database=csharp;SslMode=none;convert zero datetime=True";
            conn = new MySqlConnection(db_info);
            conn.Open();
            //MessageBox.Show("open");
        }     
    }
}
