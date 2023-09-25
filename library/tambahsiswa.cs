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
    public partial class tambahsiswa : Form
    {
        public tambahsiswa()
        {
            InitializeComponent();
        }

        private void tambahsiswa_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            //textBox6.Clear();
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                String name = textBox1.Text;
                String enroll = textBox2.Text;
                String dep = textBox3.Text;
                String sem = textBox4.Text;
                Int64 mobile = Int64.Parse(textBox5.Text);
                String email = textBox6.Text;

                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;

                koneksi.Open();
                cmd.CommandText = "insert into NewStudent(sname,enroll,dep,sem,contact,email) values ('" + name + "','" + enroll + "','" + dep + "','" + sem + "','" + mobile + "','" + email + "')";
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Saved!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("isi sesuai perintah!", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
