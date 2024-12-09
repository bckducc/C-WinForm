using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    public partial class Form1 : Form
    {
        List<string> listGioiTinh = new List<string>() { "Nam", "Nữ", "Không xác định" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGioiTinh.DataSource = listGioiTinh;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("wdwqdwd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TestNhap())
            {
                txtInfo.Text = "Họ và tên: " + txtName.Text + Environment.NewLine
                             + "Ngày sinh: " + dtime.Text + Environment.NewLine
                             + "Số điện thoại" + txtNumPhone.Text + Environment.NewLine
                             + "Gioi tinh: " + cboGioiTinh.SelectedItem
                             + "Địa chỉ: " + txtAdd.Text + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool TestNhap()
        {
            if (txtAdd.Text == "" || txtName.Text == "" || txtNumPhone.Text == "")
            {
                if (txtName.Text == "")
                {
                    txtName.Focus();
                    return false;
                }

                if (txtNumPhone.Text == "")
                {
                    txtNumPhone.Focus();
                    return false;
                }

                if (txtAdd.Text == "")
                {
                    txtAdd.Focus();
                    return false;
                }

                MessageBox.Show("Địt mẹ mày đã nhập hết đâu!" + "\n" + "Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            return false;
        }
    }
}
