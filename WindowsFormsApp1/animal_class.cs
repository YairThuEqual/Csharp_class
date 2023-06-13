using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class animal_class
    {
        // default constructor
        public animal_class()
        {
            MessageBox.Show("default constructor");
        }

        public animal_class(string bird)
        {
            MessageBox.Show(bird);
        }

        public animal_class(string name, int age, string nrc, string dob, string address)
        {
            MessageBox.Show($"{name} {age} {nrc} {dob} {address}");
        }


        // class block
        // class member
        // insecure direct object
        // +1 cat encryption( dbu )         decryption ( cat ) -1
        // bit coin     wallet seed ( 1111 ) 24 * 38
        string cat = "myou"; // cat is class member;
        string dog = "wote";
        string cow = "moo";

        // encapsulation include - get, set;
        // get method in web
        public string cat_getter()
        {
            return cat;
        }
        public string dog_getter()
        {
            return dog;
        }
        public string cow_getter() // () is function
        {
            return cow;
        }
        //                     parameter / argument
        // course method in web
        public void cat_setter(string sound)
        {
            cat = sound;
            // cat = textbox1.text;
        }
        public string Dog
        {
            get { return dog; }
            set { dog = value; } // value is keyword
        }
        public string Cow
        {
            get { return cow; }
            set { cow = value; }
        }
    
    }
}
