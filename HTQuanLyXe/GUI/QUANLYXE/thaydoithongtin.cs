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
    public partial class thaydoithongtin : Form
    {
        public thaydoithongtin()
        {
            InitializeComponent();
            lboto.Text = "";
            lbxemay.Text = "";
            txtoto.Text = quanlyxeDAO.Instance.tongoto().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lboto.Text = "";
            lbxemay.Text = "";
            if(!taikhoan.mahoaso(txtoto.Text)||!taikhoan.mahoaso(txtxemay.Text)||txtoto.Text == "" || txtoto.Text.Length >7|| txtxemay.Text == "" || txtxemay.Text.Length > 7)
            {
                if (!taikhoan.mahoaso(txtoto.Text)|| txtoto.Text==""|| txtoto.Text.Length > 7)
                    lboto.Text = "phài là số nguyên lớn hơn 0 và nhỏ hơn 10000000";
                if (!taikhoan.mahoaso(txtxemay.Text)|| txtxemay.Text=="" || txtxemay.Text.Length>7)
                    lbxemay.Text = "phải là số nguyên lớn hơn 0 và nhỏ hơn 10000000";  
                return;
            }
            if(quanlyxeDAO.Instance.tongoto() > int.Parse(txtoto.Text) || quanlyxeDAO.Instance.tongxemay() > int.Parse(txtxemay.Text))
            {
                if (quanlyxeDAO.Instance.tongoto() > int.Parse(txtoto.Text))
                    lboto.Text = "phải lớn hơn hoặc bằng số ô tô đang trong bến.";
                if (quanlyxeDAO.Instance.tongxemay() > int.Parse(txtxemay.Text))
                    lbxemay.Text = "phải lớn hơn hoặc bằng số xe máy đang trong bến.";
                return;
            }

            try
            {
                
                baixeDAO.Instance.thaydoiben(int.Parse(txtoto.Text), int.Parse(txtxemay.Text));
                MessageBox.Show("thay đổi thành công bến hiện tại có thể chứa " + txtoto.Text + " xe ô tô và " + txtxemay.Text + " xe máy.");
            }
            catch
            {
                MessageBox.Show("Lỗi! \n Không thể tahy đổi!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
