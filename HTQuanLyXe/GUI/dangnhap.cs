using HTQuanLyXe.DAO;
using HTQuanLyXe.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQuanLyXe
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();

        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txttaikhoan.Text;
            string password = txtmatkhau.Text;

            if (dangnhapDAO.Instance.quyenADMIN(username, password))
            {
                taikhoan.ten = taikhoan.layten(txttaikhoan.Text);
                taikhoan.loainv = taikhoan.layloainv(txttaikhoan.Text);
                taikhoan.tk = username;
                taikhoan.quyenadmin = dangnhapDAO.Instance.quyenquanly(username, password);
                taikhoan.quyenddangnhap = dangnhapDAO.Instance.quyenADMIN(username, password);
                //if (taikhoan.loainv == "Nhân viên quản lý")
                  //  MessageBox.Show("đăng nhập thành công với quyền của: NHÂN VIÊN QUẢN LÝ.");
                //if (taikhoan.loainv == "Nhân viên thường")
                //    MessageBox.Show("đăng nhập thành công với quyền của: NhÂN VIÊN THƯỜNG.");
                this.Hide();
                formmain fm = new formmain();
                fm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }

        }
        bool dangnhapb(string username, string password)
        {

            return dangnhapDAO.Instance.quyenADMIN(username,password);
        }
        private void dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
