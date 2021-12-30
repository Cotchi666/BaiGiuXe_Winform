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

namespace HTQuanLyXe.GUI.ADMIN
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            hienthidanhsachad();
            chao.Text = "Chào " + taikhoan.ten.ToString();
            loainv.Text = "Chức vụ: " + taikhoan.loainv.ToString();
        }
        void hienthidanhsachad()
        {
            this.pnadmin.Controls.Clear();
            dsadmin dsad = new dsadmin();
            dsad.TopLevel = false;
            this.pnadmin.Controls.Add(dsad);
            dsad.Show();
        }
        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btdanhsachnhanvien_Click(object sender, EventArgs e)
        {
            this.pnadmin.Controls.Clear();
            dsadmin dsad = new dsadmin();
            dsad.TopLevel = false;
            this.pnadmin.Controls.Add(dsad);
            dsad.Show();
        }
    }
}
