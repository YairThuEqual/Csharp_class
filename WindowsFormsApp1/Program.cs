using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.kattit;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_Home());
            // Application.Run(new two_teo());
            //Application.Run(new one_teo());
            //Application.Run(new frm_three());
            //Application.Run(new simple_project.frm_customer_register());
            //Application.Run(new kattit.count_the_vowel());
            //Application.Run(new frm_condition.frm_condition());
            //Application.Run(new month.frm_month());
            //Application.Run(new frm_switch_case());
            //Application.Run(new frm_class_and_object());
            //Application.Run(new kattit.frm_pot());
            //Application.Run(new atm.frm_atm());
            Application.Run(new frm_function());
        }
    }
}
