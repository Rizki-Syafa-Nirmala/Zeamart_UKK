using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zeamart_UKK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=zeamart";
            string query = "INSERT INTO tbl_produk(KodeBarang,NamaBarang,StokBarang,HargaBarang)VALUES('" + this.txtkode.Text + "','" + this.txtnama.Text + "','" + this.txtstok.Text + "','" + this.txtharga.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved");
            conn.Close(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=zeamart";
            string query = "UPDATE tbl_produk SET KodeBarang='" + this.txtkode.Text + "',NamaBarang='" + this.txtnama.Text + "',StokBarang='" + this.txtstok.Text + "',HargaBarang='" + this.txtharga.Text + "' WHERE KodeBarang='"+ this.txtkode.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated successfully");
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=zeamart";
            string query = "DELETE FROM tbl_produk WHERE KodeBarang='"+ this.txtkode.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been succesfully deleted!");
            conn.Close();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=zeamart";
            string query = "SELECT * FROM tbl_produk";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }
    }
}
