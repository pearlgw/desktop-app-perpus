namespace library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahSiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoSiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukuToolStripMenuItem,
            this.siswaToolStripMenuItem,
            this.bukuToolStripMenuItem1,
            this.pengembalianToolStripMenuItem,
            this.detailBukuToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bukuToolStripMenuItem
            // 
            this.bukuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahBukuToolStripMenuItem,
            this.lihatBukuToolStripMenuItem});
            this.bukuToolStripMenuItem.Name = "bukuToolStripMenuItem";
            this.bukuToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bukuToolStripMenuItem.Text = "Buku";
            // 
            // tambahBukuToolStripMenuItem
            // 
            this.tambahBukuToolStripMenuItem.Name = "tambahBukuToolStripMenuItem";
            this.tambahBukuToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.tambahBukuToolStripMenuItem.Text = "Tambah Buku";
            this.tambahBukuToolStripMenuItem.Click += new System.EventHandler(this.tambahBukuToolStripMenuItem_Click);
            // 
            // lihatBukuToolStripMenuItem
            // 
            this.lihatBukuToolStripMenuItem.Name = "lihatBukuToolStripMenuItem";
            this.lihatBukuToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.lihatBukuToolStripMenuItem.Text = "Lihat Buku";
            this.lihatBukuToolStripMenuItem.Click += new System.EventHandler(this.lihatBukuToolStripMenuItem_Click);
            // 
            // siswaToolStripMenuItem
            // 
            this.siswaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahSiswaToolStripMenuItem,
            this.infoSiswaToolStripMenuItem});
            this.siswaToolStripMenuItem.Name = "siswaToolStripMenuItem";
            this.siswaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.siswaToolStripMenuItem.Text = "Siswa";
            // 
            // tambahSiswaToolStripMenuItem
            // 
            this.tambahSiswaToolStripMenuItem.Name = "tambahSiswaToolStripMenuItem";
            this.tambahSiswaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.tambahSiswaToolStripMenuItem.Text = "tambah siswa";
            this.tambahSiswaToolStripMenuItem.Click += new System.EventHandler(this.tambahSiswaToolStripMenuItem_Click);
            // 
            // infoSiswaToolStripMenuItem
            // 
            this.infoSiswaToolStripMenuItem.Name = "infoSiswaToolStripMenuItem";
            this.infoSiswaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.infoSiswaToolStripMenuItem.Text = "info siswa";
            this.infoSiswaToolStripMenuItem.Click += new System.EventHandler(this.infoSiswaToolStripMenuItem_Click);
            // 
            // bukuToolStripMenuItem1
            // 
            this.bukuToolStripMenuItem1.Name = "bukuToolStripMenuItem1";
            this.bukuToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.bukuToolStripMenuItem1.Text = "Peminjaman";
            this.bukuToolStripMenuItem1.Click += new System.EventHandler(this.bukuToolStripMenuItem1_Click);
            // 
            // pengembalianToolStripMenuItem
            // 
            this.pengembalianToolStripMenuItem.Name = "pengembalianToolStripMenuItem";
            this.pengembalianToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.pengembalianToolStripMenuItem.Text = "Pengembalian";
            this.pengembalianToolStripMenuItem.Click += new System.EventHandler(this.pengembalianToolStripMenuItem_Click);
            // 
            // detailBukuToolStripMenuItem
            // 
            this.detailBukuToolStripMenuItem.Name = "detailBukuToolStripMenuItem";
            this.detailBukuToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.detailBukuToolStripMenuItem.Text = "Detail Buku";
            this.detailBukuToolStripMenuItem.Click += new System.EventHandler(this.detailBukuToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 454);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahSiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoSiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
    }
}

