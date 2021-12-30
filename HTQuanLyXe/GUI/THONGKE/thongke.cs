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

namespace HTQuanLyXe.GUI.THONGKE
{
    public partial class thongke : Form
    {
        public thongke()
        {
            InitializeComponent();
            hienthi();
            chao.Text = "Chào " + taikhoan.ten.ToString();
            loainv.Text = "Chức vụ: " + taikhoan.loainv.ToString();
        }
        void hienthi()
        {
            this.pnthongke.Controls.Clear();
            xedagui x = new xedagui();
            x.TopLevel = false;
            this.pnthongke.Controls.Add(x);
            x.Show();
            
        }
        private void btdanhsachnhanvien_Click(object sender, EventArgs e)
        {
            this.pnthongke.Controls.Clear();
            hientai h = new hientai();
            h.TopLevel = false;
            this.pnthongke.Controls.Add(h);
            h.Show();
        }

        private void pnadmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btdsxedagui_Click(object sender, EventArgs e)
        {
            this.pnthongke.Controls.Clear();
            xedagui x = new xedagui();
            x.TopLevel = false;
            this.pnthongke.Controls.Add(x);
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnthongke.Controls.Clear();
            danhsachvethang x = new danhsachvethang();
            x.TopLevel = false;
            this.pnthongke.Controls.Add(x);
            x.Show();
        }
    }
}
