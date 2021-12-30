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
    public partial class hientai : Form
    {
        public hientai()
        {
            InitializeComponent();
            dataGridViewtkht.DataSource = quanlyxeDAO.Instance.hienthixeluot();
            dataGridViewtkht.Columns[0].HeaderText = "Mã số";
            dataGridViewtkht.Columns[1].HeaderText = "Biển số";
            dataGridViewtkht.Columns[2].HeaderText = "Loại xe";
            dataGridViewtkht.Columns[3].HeaderText = "Tên xe";
            dataGridViewtkht.Columns[4].HeaderText = "Màu xe";
            dataGridViewtkht.Columns[5].HeaderText = "TG vào bến";
            dataGridViewtkht.Columns[6].HeaderText = "Loại vé";
            tongxemaytrong.Text = baixeDAO.Instance.tongxemaytrong().ToString();
            tongototrong.Text = baixeDAO.Instance.tongototrong().ToString();
            tongtong.Text = (baixeDAO.Instance.tongototrong()+ baixeDAO.Instance.tongxemaytrong()).ToString();
            tongxemayht.Text = quanlyxeDAO.Instance.tongxemay().ToString();
            tongotoht.Text = quanlyxeDAO.Instance.tongoto().ToString();
            tongxeht.Text = (quanlyxeDAO.Instance.tongoto() + quanlyxeDAO.Instance.tongxemay()).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewtkht.DataSource = quanlyxeDAO.Instance.timkiemtheobien(txttimkiemadmim.Text);
        }

        private void dataGridViewtkht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
