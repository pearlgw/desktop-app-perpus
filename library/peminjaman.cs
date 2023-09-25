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
    public partial class peminjaman : Form
    {
        public peminjaman()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void peminjaman_Load(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi;
            koneksi.Open();

            cmd = new SqlCommand("select bNama from NewBook", koneksi);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            koneksi.Close();
        }

        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox7.Text != "")
            {

                String eid = textBox7.Text;
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;

                cmd.CommandText = "select * from NewStudent where enroll = '" + eid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //--------------------------------------------------------------------------------
                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll = '" + eid + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                //--------------------------------------------------------------------------------

                if (ds.Tables[0].Rows.Count != 0)
                {
                    textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0][3].ToString();
                    textBox3.Text = ds.Tables[0].Rows[0][4].ToString();
                    textBox4.Text = ds.Tables[0].Rows[0][5].ToString();
                    textBox5.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    MessageBox.Show("Invallid Enrollement NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if(comboBox1.SelectedIndex != -1 && count <= 2)
                {
                    String enroll = textBox7.Text;
                    String sname = textBox1.Text;
                    String sdep = textBox2.Text;
                    String sem = textBox3.Text;
                    Int64 contact = Int64.Parse(textBox4.Text);
                    String email = textBox5.Text;
                    String bookname = comboBox1.Text;
                    String bookissuedate = dateTimePicker1.Text;

                    String eid = textBox7.Text;
                    SqlConnection koneksi = new SqlConnection();
                    koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=library;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = koneksi;

                    koneksi.Open();
                    cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values ('"+enroll+ "','" + sname + "','" + sdep + "','" + sem + "','" + contact + "','" + email + "','" + bookname + "','" + bookissuedate + "')";
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book. or Maximum Number of book has been issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter valid enrollement No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if(textBox7.Text == "")
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Keluar?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
