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

namespace library
{
    public partial class tambahbuku : Form
    {
        public tambahbuku()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tambahbuku_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                String bnama = textBox1.Text;
                String bpenulis = textBox2.Text;
                String bpenerbit = textBox3.Text;
                String tpembelian = dateTimePicker1.Text;
                Int64 harga = Int64.Parse(textBox4.Text);
                Int64 jumlah = Int64.Parse(textBox5.Text);

                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;

                koneksi.Open();
                cmd.CommandText = "insert into NewBook (bNama,bPenulis,bPenerbit,bTanggal,bHarga,bJumlah) values('" + bnama + "','" + bpenulis + "','" + bpenerbit + "','" + tpembelian + "','" + harga + "','" + jumlah + "')";
                cmd.ExecuteNonQuery();
                koneksi.Close();

                MessageBox.Show("Data Disimpan !!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This Will delete your unsaved DATA.","Are You sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
