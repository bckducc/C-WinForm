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

namespace Quản_Lý_Sinh_Viên
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtSinhVien;
        int stt;

        private void RemoveData()
        {
            txbMSV.Text = "";
            txbName.Text = "";
            date.Text = "";
            cboSex.Text = "";
            txbClass.Text = "";
            txbNumPhone.Text = "";
            txbCoun.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtSinhVien.Rows.Add(txbMSV.Text, txbName.Text, cboSex.Text, date.Text, txbClass.Text, txbNumPhone.Text, txbCoun.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtSinhVien = new DataTable("SinhVien");
            dtSinhVien.Columns.Add("Mã SV");
            dtSinhVien.Columns.Add("Họ tên SV");
            dtSinhVien.Columns.Add("Ngày sinh");
            dtSinhVien.Columns.Add("Giới tính");
            dtSinhVien.Columns.Add("Lớp");
            dtSinhVien.Columns.Add("Số điện thoại");
            dtSinhVien.Columns.Add("Quê quán");

            try
            {
                StreamReader reader1 = new StreamReader(@"ddd.json");
                string jsonstr1 = reader1.ReadToEnd();
                dtSinhVien = JsonConvert.DeserializeObject<DataTable>(jsonstr1);
                StreamReader reader = new StreamReader(@"tinh.json");
                string jsonstr = reader.ReadToEnd();
                dtSinhVien = JsonConvert.DeserializeObject<DataTable>(jsonstr);
                reader.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể đọc file!", "Lỗi đọc file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridViewSV.DataSource = dtSinhVien;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSV.SelectedRows.Count > 0)
            { 
                int ViTri = dataGridViewSV.CurrentCell.RowIndex;
                dataGridViewSV[0, ViTri].Value = txbMSV.Text;
                dataGridViewSV[1, ViTri].Value = txbName.Text;
                dataGridViewSV[2, ViTri].Value = date.Text;
                dataGridViewSV[3, ViTri].Value = cboSex.Text;
                dataGridViewSV[4, ViTri].Value = txbClass.Text;
                dataGridViewSV[5, ViTri].Value = txbNumPhone.Text;
                dataGridViewSV[6, ViTri].Value = txbCoun.Text;
                RemoveData();
            }
        }

        private void dataGridViewSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSV.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridViewSV.Rows[dataGridViewSV.CurrentCell.RowIndex];
                txbMSV.Text = row.Cells[0].Value.ToString();
                txbName.Text = row.Cells[1].Value.ToString();
                date.Text = row.Cells[2].Value.ToString();
                cboSex.Text = row.Cells[3].Value.ToString();
                txbClass.Text = row.Cells[4].Value.ToString();
                txbNumPhone.Text = row.Cells[5].Value.ToString();
                txbCoun.Text = row.Cells[6].Value.ToString();
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { }
           {
                int Index = dataGridViewSV.CurrentCell.RowIndex;
                dataGridViewSV.Rows.RemoveAt(Index);
                //RemoveData();
           }    
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string jsonstr = JsonConvert.SerializeObject(dtSinhVien);
            File.WriteAllText("tinh.json", jsonstr);
        }
    }
}
