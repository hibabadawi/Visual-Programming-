using HospitalManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox4.Text;
            string password = textBox3.Text;

            if (username == "Hiba" && password == "pass")
            {
                this.Hide();
                Form2 f = new Form2();
                f.Show();

            }
            else
            {
                MessageBox.Show("You have entered wrong user name or passord");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "Hiba" && password == "pass")
            {
                this.Hide();
                Form3 f = new Form3();
                f.Show();

            }
            else
            {
                MessageBox.Show("You have entered wrong user name or passord");
            }
        }
    }
}
