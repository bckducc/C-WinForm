using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Id;
        string Name;
        string Class;
        string Hometown;
        string Khoa;
        DateTime Born;
        string Sex;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Thanh Hoas");
            comboBox1.Items.Add("New York");
            comboBox1.Items.Add("Washington DC");
            
            comboBox2.Items.Add("CNTT1");
            comboBox2.Items.Add("KTPM2");
            comboBox2.Items.Add("CK2");

            comboBox3.Items.Add("CNTT");
            comboBox3.Items.Add("Co Khi");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              Id = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void label7_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Name = textBox2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Born = dateTimePicker1.Value ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
