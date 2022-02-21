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

namespace connection
{
    public partial class Form1 : Form
    {
        string cs = "Server= KCS-PC\\SQLEXPRESS; Database= Session 2;Integrated Security = SSPI;";
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object serder, EventArgs e)
        {

        }
        private void panel_Content_Paint(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //create connection
            cn = new SqlConnection(cs);
            //open connection
            cn.Open();
            if (cn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connect successfull!");
            }
        }
    }
}
