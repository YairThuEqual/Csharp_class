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
    public partial class frm_class_and_object : Form
    {
        public frm_class_and_object()
        {
            InitializeComponent();
        }

          //class obj
           

        private void button1_Click_1(object sender, EventArgs e)
        {
                animal_class animal_sound = new animal_class();
                //MessageBox.Show(animal_sound.cat);
                //MessageBox.Show(animal_sound.dog);
                //MessageBox.Show(animal_sound.cow);

                animal_sound.cat_setter("myou myou");
                animal_sound.Dog = "wote wote";
                animal_sound.Cow = "moooooooooooo";

                MessageBox.Show(animal_sound.cat_getter());
                MessageBox.Show(animal_sound.Dog);
                MessageBox.Show(animal_sound.Cow);

                animal_class bird_sound = new animal_class("kyali kyali");
                animal_class animl_info = new animal_class("mo mo", 60, "----", "1-12-1963", "Bahan-Kyouk Tine");

        }
        }
    }
    // user create class
  