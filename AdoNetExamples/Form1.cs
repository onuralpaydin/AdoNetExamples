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

namespace AdoNetExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            SqlConnection con;

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Server =ANK3-YZLMORT-08\SQLEXPRESS;Database =Northwind; User Id =sa; Password =sa;");
        }
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(con.State==ConnectionState.Open ? "Bağlantı Açık":"Bağlantı kapalı");
            if (con.State==ConnectionState.Open)
            {
                MessageBox.Show("Bağlantı zaten var.");

            }
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
                MessageBox.Show("Bağlantı Açık.");


            }
            //MessageBox.Show(con.State==ConnectionState.Open ? "Bağlantı Açık":"Bağlantı kapalı");
            //if (con.State==ConnectionState.Open)
            //{
            //    btnBaglan.Enabled = false;
            //}
        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Closed)
            {
                MessageBox.Show("Bağlantı zaten kapalı");
            }
            if (con.State==ConnectionState.Open)
            {
                con.Close();
                MessageBox.Show("Bağlantı Kapatıldı.");
            }
        }

      
        
    }
}
