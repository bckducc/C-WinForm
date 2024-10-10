using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;

        private void txtn_TextChanged(object sender, EventArgs e)
        {
            //if ()
            //{
//
            //}
        }

        private void txtn_Leave(object sender, EventArgs e)
        {
            if (a > 0 && a < 1000)
            {
                
            }    
            else
            {
                Application.Exit();
            }    

        }

        private void butShow_Click(object sender, EventArgs e)
        {

        }
    }
}
