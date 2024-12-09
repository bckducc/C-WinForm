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

namespace SQL.C__1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoiketnoi = "Data Source=ANHDUC; Initial Catalog = QLSV; Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;

        string sql = "Select * Form DSSV";
        SqlDataAdapter dssv = new SqlDataAdapter();
        DataTable DSSV = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Hien thi";
            dssv.SelectCommand = cmd;
            DSSV.Clear();

            conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            dssv.Fill(DSSV);
            dtSV.DataSource = DSSV;
        }
    }
}
