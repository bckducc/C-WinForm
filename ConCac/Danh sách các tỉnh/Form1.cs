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

namespace Danh_sách_các_tỉnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtTinh;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtTinh = new DataTable();
            dtTinh.Columns.Add("STT");
            dtTinh.Columns.Add("Tên tỉnh");
            dtTinh.Columns.Add("Miền");

            try
            {
                StreamReader reader = new StreamReader(@"bcktinh.json");
                string jsonstr = reader.ReadToEnd();
                dtTinh = JsonConvert.DeserializeObject<DataTable>(jsonstr);
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc file!", "Lỗi đọc file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvTinh.DataSource = dtTinh;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
