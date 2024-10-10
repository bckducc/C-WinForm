using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OnThi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        DataTable dtMuonTra = new DataTable("MuonTra");
        int stt = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dtMuonTra.Columns.Add("STT");
            dtMuonTra.Columns.Add("Tên khách hàng");
            dtMuonTra.Columns.Add("Số điện thoại");
            dtMuonTra.Columns.Add("Tên truyện");
            dtMuonTra.Columns.Add("Ngày mượn");
            dtMuonTra.Columns.Add("Ngày trả");
            //dtMuonTra.Columns.Add("Thành tiền");
            dtMuonTra.Columns.Add("Ghi chú");

            dataGridView1.DataSource = dtMuonTra;


        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            string jsonstr = JsonConvert.SerializeObject(dtMuonTra);
            dtMuonTra = JsonConvert.DeserializeObject
                <DataTable>(jsonstr);
            System.IO.File.WriteAllText(@"data.json", jsonstr);

            //DataRow[] rows = dtMuonTra.Select();
            //if (rows != null)
            //    stt = Int32.Parse(rows[rows.Length - 1]["ID"].ToString());
            //stt++;
            dataGridView1.Rows.Add(txbName.Text, txbNumPhone.Text, cboName.Text, dateMuon.Text, dateTra.Text);
        }

        private void txbNumPhone_TextChanged(object sender, EventArgs e)
        {
            string input = txbNumPhone.Text;

            if (!int.TryParse(input, out int num))
            {
                MessageBox.Show("Vui lòng nhập lại");
            }    
        }

        private void txbNumPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cboName_TextChanged(object sender, EventArgs e)
        {
            txbGia.Enabled = true;
            if (cboName.Text == "Eimi Fukada")
            {
                txbGia.Text = "50000";
            }    
            else if (cboName.Text == "Linh hentai")
            {
                txbGia.Text = "49000";
            }
            else
            {
                txbGia.Text = null;
            }
            txbGia.Enabled = false;
        }
    }
}
