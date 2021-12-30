using HTQuanLyXe.DAO;
using HTQuanLyXe.GUI.ADMIN;
using HTQuanLyXe.GUI.QUANLYXE;
using HTQuanLyXe.GUI.THONGKE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQuanLyXe.GUI
{
    public partial class formmain : Form
    {
        public formmain()
        {
            InitializeComponent();
            hienthi();
            if (!taikhoan.quyenddangnhap)
            {
                this.Enabled = false;
            }
        }
        void hienthi()
        {
            this.pnmain.Controls.Clear();
            admin ad = new admin();
            ad.TopLevel = false;
            this.pnmain.Controls.Add(ad);
            ad.Show();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btadmin_Click(object sender, EventArgs e)
        {
            this.pnmain.Controls.Clear();
            admin ad = new admin();
            ad.TopLevel = false;
            this.pnmain.Controls.Add(ad);
            ad.Show();
        }
        
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void formmain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btquanlyxe_Click(object sender, EventArgs e)
        {
            this.pnmain.Controls.Clear();
            quanlyxe q = new quanlyxe();
            q.TopLevel = false;
            this.pnmain.Controls.Add(q);
            q.Show();
        }

        private void btthongke_Click(object sender, EventArgs e)
        {
            this.pnmain.Controls.Clear();
            thongke t = new thongke();
            t.TopLevel = false;
            this.pnmain.Controls.Add(t);
            t.Show(); 
        }

        private void bttrogiup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Ntrinh96");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
