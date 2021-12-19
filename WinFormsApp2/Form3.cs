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
    public partial class Form3 : Form
    {
        HospContext ctx = new HospContext();
   
        Form f = new Form();
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel6.Visible = false;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doctor Doc = new Doctor();
           
            Doc.DocName = textBox10.Text;
            Doc.DocPassword = textBox11.Text;
            Doc.DocLocation = textBox12.Text;
            Doc.DocSpciality = textBox13.Text;
            ctx.Doctors.Add(Doc);
            ctx.SaveChanges();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Sec = ctx.sections.Where(x => x.SecID == Convert.ToInt32(textBox15.Text)).Single();
          Sec.SecName = textBox5.Text;
            Sec.patient_capacity = textBox9.Text;
            Sec.patients_gender = textBox14.Text;
           
            ctx.SaveChanges();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hospital Hos = new Hospital();
            Hos.HospName = textBox2.Text;
            Hos.HospLocation = textBox3.Text;
            Hos.HospType = textBox4.Text;
            ctx.Hospitals.Add(Hos);
            ctx.SaveChanges();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Section sec = new Section();
           
            sec.SecName = textBox6.Text;
            sec.patients_gender = textBox7.Text;
            sec.patients_gender = textBox8.Text;
            ctx.sections.Add(sec);
            ctx.SaveChanges();

          
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var s = ctx.sections.Where(s => s.SecID == Convert.ToInt32(textBox6.Text)).Single();

            ctx.sections.Remove(s);
            ctx.SaveChanges();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var a = ctx.sections.OrderByDescending(x => x.SecName == textBox6.Text).Take(1);
            dataGridView1.DataSource = a; 
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
           // var Dname = ctx.sections.Where(s => s.SecID == Convert.ToInt32(textBox16.Text)).Select(s2 => s2.).ToList();
            ctx.SaveChanges();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var Dname =  ctx.Doctors.Where(s => s.DocID == Convert.ToInt32(textBox17.Text)).Select(s2 => s2.DocName).ToList();

            dataGridView1.DataSource = Dname;
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
          

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
