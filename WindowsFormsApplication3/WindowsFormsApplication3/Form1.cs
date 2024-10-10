using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-EJS5PHK\Sinhvien;Initial Catalog=QLOTO55;Persist Security Info=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "SELECT * FROM OTO55";  
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); 
            DataTable dt = new DataTable();
            da.Fill(dt);  
            cnn.Close();  
            dataGridView1.DataSource = dt; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
