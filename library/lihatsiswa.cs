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
    public partial class lihatsiswa : Form
    {
        public lihatsiswa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;

                cmd.CommandText = "select * from NewStudent where enroll LIKE '" + textBox1.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;

                cmd.CommandText = "select * from NewStudent where enroll LIKE '" + textBox1.Text + "% '";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void lihatsiswa_Load(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sname = textBox2.Text;
            String enroll = textBox3.Text;
            String dep = textBox4.Text;
            String sem = textBox5.Text;
            Int64 contact = Int64.Parse(textBox6.Text);
            String semail = textBox7.Text;

            if (MessageBox.Show("data will be updated. confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;

                cmd.CommandText = "update NewStudent set sname = '" + sname + "',enroll = '" + enroll + "',dep = '" + dep + "',sem = '" + sem + "',contact = '" + contact + "',email = '" + semail + "' where stuid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                lihatsiswa_Load(this, null);
            }
        }

        int stuid;
        Int64 rowid;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                stuid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            //panel2.Visible = true;
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi;

            cmd.CommandText = "select * from NewStudent where stuid= " + stuid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox6.Text = ds.Tables[0].Rows[0][5].ToString();
            textBox7.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            //panel2.Visible = false;
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("data will Deleted. confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;;
                cmd.CommandText = "delete from NewStudent where enroll=" + textBox3.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter da1= new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                dataGridView1.DataSource = ds1.Tables[0];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah Yakin Untuk Keluar","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
