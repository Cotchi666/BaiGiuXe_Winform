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
    public partial class thanhtoan : Form
    {
        public static Boolean ok=false;
        public thanhtoan()
        {
            InitializeComponent();
            bien.Text = danhsachxe.bien;
            ma.Text = danhsachxe.mave;
            ten.Text = quanlyxeDAO.Instance.layten(danhsachxe.bien);
            mau.Text = quanlyxeDAO.Instance.laymau(danhsachxe.bien);
            loai.Text = quanlyxeDAO.Instance.layloaixe(danhsachxe.bien);
            tgvao.Text = quanlyxeDAO.Instance.laytgvao(danhsachxe.bien).ToString();
            tgra.Text = DateTime.Now.ToString();
            tien.Text = quanlyxeDAO.Instance.tinhtiengui(danhsachxe.bien).ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Close();
        }

        private void thanhtoan_Load(object sender, EventArgs e)
        {

        }
    }
}
