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
    public partial class denda : Form
    {
        public denda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int days = Int32.Parse(textBox1.Text);
            double fine = 3000;
            double total = fine * days;
            textBox3.Text = total.ToString("Rp####");
        }
    }
}
