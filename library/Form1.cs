using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bukuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            peminjaman pinjam = new peminjaman();
            pinjam.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda ingin keluar?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tambahBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahbuku ntb = new tambahbuku();
            ntb.Show();
        }

        private void lihatBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lihatbuku nlb = new lihatbuku();
            nlb.Show();
        }

        private void tambahSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahsiswa ts = new tambahsiswa();
            ts.Show();
        }

        private void infoSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lihatsiswa ls = new lihatsiswa();
            ls.Show();
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pengembalian kembali = new pengembalian();
            kembali.Show();
        }

        private void detailBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailbuku db = new detailbuku();
            db.Show();
        }
    }
}
