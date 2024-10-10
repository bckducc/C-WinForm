using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            btnYes.MouseEnter += btnYes_MouseEnter;
            btnYes.MouseLeave += btnYes_MouseLeave;

            btnYes.Click += btnYes_Click;
            btnNo1.Click += btnNo1_Click;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Câu trả lời hoàn toàn chính xác!", "Thông báo");
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Câu trả lời hoàn toàn chính xác!", "Thông báo");
        }

        private void btnYes_MouseEnter(object sender, EventArgs e)
        {
            btnYes.Visible = false;
            btnNo.Visible = true;
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.Visible = true;
            btnNo.Visible = false;
        }

        private void btnNo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Câu trả lời hoàn toàn chính xác!", "Thông báo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Câu trả lời hoàn toàn chính xác!", "Thông báo");
        }
    }
}
