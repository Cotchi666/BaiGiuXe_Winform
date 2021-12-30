using HTQuanLyXe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQuanLyXe.GUI.QUANLYXE
{
    public partial class quanlyxe : Form
    {
        public quanlyxe()
        {
            InitializeComponent();
            hienthiqlxe();
            chao.Text = "Chào " + taikhoan.ten.ToString();
            loainv.Text = "Chức vụ: " + taikhoan.loainv.ToString();
        }
        void hienthiqlxe()
        {
            this.pnaqlxe.Controls.Clear();
            danhsachxe d = new danhsachxe();
            d.TopLevel = false;
            this.pnaqlxe.Controls.Add(d);
            d.Show();
        }
        private void quanlyxe_Load(object sender, EventArgs e)
        {
           
        }

        private void pnadmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btdanhsachnhanvien_Click(object sender, EventArgs e)
        {
            this.pnaqlxe.Controls.Clear();
            danhsachxe d = new danhsachxe();
            d.TopLevel = false;
            this.pnaqlxe.Controls.Add(d);
            d.Show();
        }

        private void btquanlyve_Click(object sender, EventArgs e)
        {
            this.pnaqlxe.Controls.Clear();
            danhsachve d = new danhsachve();
            d.TopLevel = false;
            this.pnaqlxe.Controls.Add(d);
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnaqlxe.Controls.Clear();
            baixe d = new baixe();
            d.TopLevel = false;
            this.pnaqlxe.Controls.Add(d);
            d.Show();
        }
    }
}
