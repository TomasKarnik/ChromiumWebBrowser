using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chromium3
{
    public partial class settings : MaterialSkin.Controls.MaterialForm
    {
        public settings()
        {
            InitializeComponent();
            

    }
        


        public static string searchengine;

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //unused button now use meterial button
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                Properties.Settings.Default["searchengine"] = textBox1.Text;
            }
            if (textBox2.Text == "")
            {

            }
            else
            {
                Properties.Settings.Default["fav1"] = textBox2.Text;
            }
            
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            MessageBox.Show("Saved your settings");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = searchengine;
            MessageBox.Show($"{searchengine}");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) //save button
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                Properties.Settings.Default["searchengine"] = textBox1.Text;
            }
            if (textBox2.Text == "")
            {

            }
            else
            {
                Properties.Settings.Default["fav1"] = textBox2.Text;
            }

            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            MessageBox.Show("Saved your settings");
        }
    }
}
