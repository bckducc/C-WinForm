using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txta.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button3_Click(object sender, EventArgs e)
        {

        }
    }

    public class HoanDoi
    {
        int txta;
        int txtb;
        public void HoanVi()
        {
            int txtc = txta;
            txtb = txta;
            txta = txtc;
        }

        public static void Main()
        {
            Form1 form = new Form1();
            form.button3_Click(null, null);

            HoanDoi hoandoi = new HoanDoi();
            hoandoi.HoanVi();
        }
    }
}
