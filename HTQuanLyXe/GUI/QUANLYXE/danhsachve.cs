using HTQuanLyXe.DAO;
using HTQuanLyXe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTQuanLyXe.GUI.QUANLYXE
{
    public partial class danhsachve : Form
    {
        public danhsachve()
        {
            InitializeComponent();
            if (!taikhoan.quyenadmin)
                button4.Enabled = false;
            if (!taikhoan.quyenddangnhap)
                this.Enabled = false;
            dataGridViewve.DataSource = quanlyveDAO.Instance.hienthi();
            tonsove.Text = (quanlyveDAO.Instance.sovedangdung()+quanlyveDAO.Instance.sovetrong()-2).ToString();
            vetrong.Text = (quanlyveDAO.Instance.sovetrong()-2).ToString();
            dataGridViewve.Columns[0].HeaderText = "loại xe";
            dataGridViewve.Columns[1].HeaderText = "mã số vé";
            dataGridViewve.Columns[2].HeaderText = "Biển số";

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            themve t = new themve();
            t.ShowDialog();
        }

        private void dataGridViewve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewve.DataSource = quanlyveDAO.Instance.hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewve.DataSource = quanlyveDAO.Instance.hienthivedangdung();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridViewve.DataSource = quanlyveDAO.Instance.hienthivetrong();
        }
    }
}
