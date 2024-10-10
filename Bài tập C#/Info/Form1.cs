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
        List<string> ListSex = new List<string>() {"Nam", "Nữ", "Không xác định"};
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboSex.DataSource = ListSex;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TestCheck())
            {
                txbOutPut.Text = "Họ tên: " + txbName.Text + Environment.NewLine
                            + "CCCD: " + txbCCCD.Text + Environment.NewLine
                            + "Giới tính: " + cboSex.SelectedItem + Environment.NewLine
                            + "Năm sinh:" + dTime.Value + Environment.NewLine
                            + "SDT: " + txbNumPhone.Text + Environment.NewLine
                            + "Địa chỉ: " + txbAddress.Text + Environment.NewLine;
            }
        }

        bool TestCheck()
        {
            if (txbName.Text == "" || txbCCCD.Text == "" || txbNumPhone.Text == "" || txbAddress.Text == "")
            {
                if (txbName.Text == "")
                {
                    MessageBox.Show("Địt mẹ mày nhập thiếu" + "\n" + "Vui lòng nhập hết", "Thông báo");
                    txbName.Focus();
                    return false;
                }

                if (txbCCCD.Text == "")
                {
                    MessageBox.Show("Địt mẹ mày nhập thiếu" + "\n" + "Vui lòng nhập hết", "Thông báo");
                    txbCCCD.Focus();
                    return false;
                }

                if (txbNumPhone.Text == "")
                {
                    MessageBox.Show("Địt mẹ mày nhập thiếu" + "\n" + "Vui lòng nhập hết", "Thông báo");
                    txbNumPhone.Focus();
                    return false;
                }

                if (txbAddress.Text == "")
                {
                    MessageBox.Show("Địt mẹ mày nhập thiếu" + "\n" + "Vui lòng nhập hết", "Thông báo");
                    txbAddress.Focus();
                    return false;
                }

                //MessageBox.Show("Địt mẹ mày nhập thiếu" + "\n" + "Vui lòng nhập hết", "Thông báo");
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSex.DataSource = ListSex;
        }

        private void txbOutPut_TextChanged(object sender, EventArgs e)
        {
            /*if (TestCheck())
            {
                txbOutPut.Text = "Họ tên: " + txbName + Environment.NewLine
                            + "CCCD: " + txbCCCD + Environment.NewLine
                            + "Giới tính: " + cboSex.SelectedItem + Environment.NewLine;
            }*/
        }
    }
}
