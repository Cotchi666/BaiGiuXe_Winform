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
    public partial class danhsachvethang : Form
    {
        public danhsachvethang()
        {
            InitializeComponent();

            tongxe.Text = tkvethangDAO.Instance.tongvethang().ToString();
            tongoto.Text = tkvethangDAO.Instance.tongoto().ToString();
            tongxemay.Text = tkvethangDAO.Instance.tongxemay().ToString();
           
            this.dataGridViewvethang.DataSource = tkvethangDAO.Instance.hienthivethang();
            dataGridViewvethang.Columns[0].HeaderText = "Biển số";
            dataGridViewvethang.Columns[1].HeaderText = "Loại xe";
            dataGridViewvethang.Columns[2].HeaderText = "Tên xe";
            dataGridViewvethang.Columns[3].HeaderText = "Màu xe";
            dataGridViewvethang.Columns[4].HeaderText = "Loại vé";
            dataGridViewvethang.Columns[5].HeaderText = "TG đăng ký";
            dataGridViewvethang.Columns[6].HeaderText = "TG hết hạn";
        }

        private void danhsachvethang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridViewvethang.DataSource=tkvethangDAO.Instance.timkiemtheobien(txttimkiemadmim.Text);
        }
    }
}
