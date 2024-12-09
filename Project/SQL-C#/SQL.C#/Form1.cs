using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL.C_
{
    public partial class Form1 : Form
    {
        string chuoiketnoi = "DataSource=ANHDUC;" + "Initial Catalog = QLSV;" + "Integrated Security=True";
        SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //con = new SqlConnection(chuoiketnoi);
            //con.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sql = "Select * Form SV";
            SqlDataAdapter dssv = new SqlDataAdapter(sql, conn);
            DataTable DSSV = new DataTable();
            dssv.Fill(DSSV);
            dgSV.DataSource = DSSV;
        }
    }
}
