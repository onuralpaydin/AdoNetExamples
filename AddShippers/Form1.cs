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

namespace AddShippers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Shippers (CompanyName,Phone) VALUES (@companyName,@phone)", con);
            cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                int etkilenenSatirSayisi = cmd.ExecuteNonQuery();
                MessageBox.Show(etkilenenSatirSayisi+" row(s) affected.");
                dataGridDoldur();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Server =ANK3-YZLMORT-08\SQLEXPRESS;Database =Northwind; User Id =sa; Password =sa;");

            dataGridDoldur();
        }

        private void dataGridDoldur()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Shippers", con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
                
            }
            SqlCommand command = new SqlCommand("UPDATE Shippers SET CompanyName=@companyName,Phone=@phone WHERE ShipperID=@id", con);
            command.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
            command.Parameters.AddWithValue("@phone", txtPhone.Text);
            command.Parameters.AddWithValue("@id", txtId.Text);
            command.ExecuteNonQuery();
            dataGridDoldur();

            con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            SqlCommand command = new SqlCommand("DELETE from Shippers WHERE ShipperID=@id",con);
            command.Parameters.AddWithValue("@id", txtId.Text);
            int satirSayisi = command.ExecuteNonQuery();
            MessageBox.Show(satirSayisi + " row(s) affected.");
            dataGridDoldur();
            con.Close();
           

        }
    }
}
