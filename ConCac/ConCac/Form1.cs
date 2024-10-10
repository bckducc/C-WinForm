using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ConCac
{
    public partial class Form1 : Form
    {

        List<string> listMaKhoa = new List<string>() { "CNTT", "KT", "TNMT", "Khác" };
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection dc;
        SqlDataAdapter da;

        /*public SinhVienDT()
        {
            dc = new SqlConnection();
        }
        public DataTable getAllSinhVien()
        {
            string sql = "select * from DSSV";

            SqlConnection conn = dc.getConnect();

            da = new SqlDataAdapter(sql, conn);

            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.DSSV' table. You can move, or remove it, as needed.
            //this.dSSVTableAdapter.Fill(this.qLSVDataSet.DSSV);

            cboMaKhoa.DataSource = listMaKhoa;

            /*SqlCommand command = new SqlCommand("INSERT INTO DSSV (MaSV, HoSV, TenSV, NgaySinh, GioiTinh, MaKhoa) VALUES (@MaSV, @HoSv, @TenSV, @NgaySinh, @GioiTinh, @MaKhoa)", conn);
            command.Parameters.AddWithValue("@MaSV", txbMSV.Text);
            command.Parameters.AddWithValue("@HoSV", txbHoSV.Text);
            // Thêm các tham số cho các trường dữ liệu khác
            command.ExecuteNonQuery();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //DataRow row = dt.NewRow();
            //row("fld");
        }
    }

    /*class DataConnection
    {
        string conStr;

        public DataConnection()
        {
            {
                conStr = "Data Source ";
            } 
        }
    }*/

    class DSSV
    {
        //public string MaSV (Set ,get)
    } 
}
