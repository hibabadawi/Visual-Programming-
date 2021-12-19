using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Form2 : Form
    {
        HospContext ctx = new HospContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = ctx.sections.Include(s => s).ToListAsync();
            MessageBox.Show(a.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var Dname = ctx.sections.Where(s => s.SecID == Convert.ToInt32(textBox7.Text)).Select(s2 => s2).ToList();
            listBox1.DataSource = Dname;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            var sec = ctx.Patients.Where(s => s.PatID == Convert.ToInt32(textBox4.Text)).Single();
            sec.Perception = textBox6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Patient sec = new Patient();

            sec.PatName = textBox2.Text;
           // sec.gender = typeof(textBox3.Text);
           // sec.Enternace_Time = DateTime(textBox4.Text);
            sec.Sickness = textBox1.Text;
            sec.Perception = textBox5.Text;
            ctx.Patients.Add(sec);
            ctx.SaveChanges();
        }
    }
}
