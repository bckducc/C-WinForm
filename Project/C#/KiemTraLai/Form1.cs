using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;

namespace KiemTraLai
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbMKH.Text != "")
            {
                if (txbName.Text != "")
                {
                    if (dtBirthday.Text != "")
                    {
                        if (txbAddress.Text != "")
                        {
                            if ((rbCaoVoi.Checked = true ) || (rbTayTrang.Checked = true ) || (rbTramRang.Checked = true))
                            {
                                //dataGridViewNhakhoa.Rows.Add(txbMKH.Text, txbName.Text, dtBirthday.Text, txbAddress.Text);
                                if (rbCaoVoi.Checked = true)
                                {
                                    dataGridViewNhakhoa.Rows.Add(txbMKH.Text, txbName.Text, dtBirthday.Text, txbAddress.Text,rbCaoVoi.Text);
                                }    
                                else if (rbTayTrang.Checked = true)
                                {
                                    dataGridViewNhakhoa.Rows.Add(txbMKH.Text, txbName.Text, dtBirthday.Text, txbAddress.Text,rbTayTrang.Text);
                                } 
                                else if (rbTramRang.Checked = true)
                                {
                                    dataGridViewNhakhoa.Rows.Add(txbMKH.Text, txbName.Text, dtBirthday.Text, txbAddress.Text,rbTramRang.Text);
                                }    
                            }
                            else
                            {
                                MessageBox.Show("Chưa nhập đủ thông tin!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chưa nhập đủ thông tin!");
                        }
                    }    
                    else
                    {
                        MessageBox.Show("Chưa nhập đủ thông tin!");
                    }    
                }    
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin!");
                }    
            }    
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridViewNhakhoa.SelectedRows.Count > 0)
            {
                int ViTri = dataGridViewNhakhoa.CurrentCell.RowIndex;
                dataGridViewNhakhoa[0, ViTri].Value = txbMKH.Text;
                dataGridViewNhakhoa[1, ViTri].Value = txbName.Text;
                dataGridViewNhakhoa[2, ViTri].Value = dtBirthday.Text;
                dataGridViewNhakhoa[3, ViTri].Value = txbAddress.Text;
            }    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbMKH.ResetText();
            txbName.ResetText();
            dtBirthday.ResetText();
            txbAddress.ResetText();
            txbMKH.Focus();
        }

        private void dataGridViewNhakhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNhakhoa.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewNhakhoa.Rows[dataGridViewNhakhoa.CurrentCell.RowIndex];
                txbMKH.Text = row.Cells[0].Value.ToString();
                txbName.Text = row.Cells[1].Value.ToString();
                dtBirthday.Text = row.Cells[2].Value.ToString();
                txbAddress.Text = row.Cells[3].Value.ToString();
            }    
        }
    }
}
