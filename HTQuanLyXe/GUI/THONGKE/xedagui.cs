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
    public partial class xedagui : Form
    {
        public xedagui()
        {
            InitializeComponent();
            if (!taikhoan.quyenadmin)
                button4.Enabled = false;
            if (!taikhoan.quyenddangnhap)
                this.Enabled = false;
            tinh();
            hienthi();
            dataGridViewtk.Columns[0].HeaderText = "Mã số";
            dataGridViewtk.Columns[1].HeaderText = "Biển số";
            dataGridViewtk.Columns[2].HeaderText = "Loại xe";
            dataGridViewtk.Columns[3].HeaderText = "Tên xe";
            dataGridViewtk.Columns[4].HeaderText = "Màu xe";
            dataGridViewtk.Columns[5].HeaderText = "Loại vé";
            dataGridViewtk.Columns[6].HeaderText = "Giá vé";
            dataGridViewtk.Columns[7].HeaderText = "TG vào bến";
            dataGridViewtk.Columns[8].HeaderText = "TG xuất bến";
            
            
        }
        public void tinh()
        {
            tbtongtien.Text = (baixeDAO.Instance.tienveoto() + baixeDAO.Instance.tienvexemay()).ToString();
            tienoto.Text = baixeDAO.Instance.tienveoto().ToString();
            tienxm.Text = baixeDAO.Instance.tienvexemay().ToString();
            tongtienveluot.Text = (tkxedaguiDAO.Instance.soxemayguitheoluot() * 5000 + tkxedaguiDAO.Instance.sootoguitheoluot() * 50000).ToString();
            tienotoveluot.Text = (tkxedaguiDAO.Instance.sootoguitheoluot() * 50000).ToString();
            tienxemayveluot.Text = (tkxedaguiDAO.Instance.soxemayguitheoluot() * 5000).ToString();
            tongtienvethang.Text = (tkxedaguiDAO.Instance.sootoguitheothang() * 1200000 + tkxedaguiDAO.Instance.soxemayguitheothang() * 120000).ToString();
            tienotovethang.Text = (tkxedaguiDAO.Instance.sootoguitheothang() * 1200000).ToString();
            tienxemaycethang.Text = (tkxedaguiDAO.Instance.soxemayguitheothang() * 120000).ToString();
            tongxe.Text = tkxedaguiDAO.Instance.tongxe().ToString();
            tongoto.Text = tkxedaguiDAO.Instance.tongxeoto().ToString();
            tongxemay.Text = tkxedaguiDAO.Instance.tongxemay().ToString();
            tongluot.Text = tkxedaguiDAO.Instance.tongxeguitheoluot().ToString();
            otoluot.Text = tkxedaguiDAO.Instance.sootoguitheoluot().ToString();
            xemayluot.Text = tkxedaguiDAO.Instance.soxemayguitheoluot().ToString();
            tongthang.Text = tkxedaguiDAO.Instance.tongxeguitheothang().ToString();
            otothang.Text = tkxedaguiDAO.Instance.sootoguitheothang().ToString();
            xemaythang.Text = tkxedaguiDAO.Instance.soxemayguitheothang().ToString();
            batdau.Text = tkxedaguiDAO.Instance.ngaybatdau().ToString();
            nay.Text = DateTime.Now.ToString();
        }
        public void hienthi()
        {
            dataGridViewtk.DataSource = tkxedaguiDAO.Instance.hienthi();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                tkxedaguiDAO.Instance.datlai();
                tkxedaguiDAO.tongtien = 0;
                MessageBox.Show("bạn đã đặt lại thành công!");
                tinh();
                hienthi();
            }
            catch
            {
                MessageBox.Show("Không thành công!")
;            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewtk.DataSource = tkxedaguiDAO.Instance.timkiem(txttimkiemadmim.Text);
        }

        private void tongxemay_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tongxe_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void xedagui_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void otothang_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void otoluot_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tienoto_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void nay_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
