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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = "Data Source=DESKTOP-638C77F;Initial Catalog=splash;Integrated Security=True";

            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from login where nama_user = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", koneksi);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                splash panggil = new splash();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Mohon di isi dengan benar!!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
