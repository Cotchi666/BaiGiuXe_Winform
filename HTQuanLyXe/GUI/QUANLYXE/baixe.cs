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
    public partial class baixe : Form
    {
        public baixe()
        {
            InitializeComponent();
            hienthi();
            if (!taikhoan.quyenadmin)
                this.button2.Enabled = false;
            dataGridViewve.Columns[0].HeaderText = "Loại xe";
            dataGridViewve.Columns[1].HeaderText = "Tổng số chỗ";
            dataGridViewve.Columns[2].HeaderText = "Số chỗ trống";
            ottrong.Text = baixeDAO.Instance.tongototrong().ToString();
            xmtrog.Text = baixeDAO.Instance.tongxemaytrong().ToString();
            ottong.Text = baixeDAO.Instance.tongoto().ToString();
            xmtong.Text = baixeDAO.Instance.tongxemay().ToString();
        }
        void hienthi()
        {
            dataGridViewve.DataSource = baixeDAO.Instance.hienthi();
        }

        private void baixe_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            thaydoithongtin f = new thaydoithongtin();
            f.ShowDialog();
        }
    }
}
