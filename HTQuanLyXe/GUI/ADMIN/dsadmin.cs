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

namespace HTQuanLyXe.GUI.ADMIN
{
    public partial class dsadmin : Form
    {
        private GroupBox groupBox1;
        private TextBox txtma;
        private TextBox txtmk;
        private TextBox txtdt;
        private TextBox txtdc;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Panel panel6;
        private Button btthem;
        private Button buttonbttimkiemtheoma;
        private TextBox txttimkiemadmim;
        private DataGridView dataGridViewadmin;
        private Button btthaydoithongtin;
        private Button btxoa;
        private DateTimePicker txtngay;
        private Label lbma;
        private Label lbmk;
        private Label lbten;
        private Label lbgt;
        private Label lbloainv;
        private Label lbdc;
        private Label lbdt;
        private ComboBox txtgt;
        private ComboBox txtloainv;
        private TextBox txtten;
        private Label label1;

        public dsadmin()
        {
            InitializeComponent();
            hienthi();
            if (!taikhoan.quyenadmin)
            {
                this.btthem.Enabled = false;
                this.btxoa.Enabled = false;
            }
            dataGridViewadmin.Columns[0].HeaderText = "Mã NV";
            dataGridViewadmin.Columns[1].HeaderText = "Họ và tên";
            dataGridViewadmin.Columns[2].HeaderText = "Loại nhân viên";
            dataGridViewadmin.Columns[3].HeaderText = "Ngày sinh";
            dataGridViewadmin.Columns[4].HeaderText = "Giới tính";
            dataGridViewadmin.Columns[5].HeaderText = "Địa chỉ";
            dataGridViewadmin.Columns[6].HeaderText = "Điện thoại";
            dataGridViewadmin.Columns[7].HeaderText = "Mật Khẩu";



        }
        public void hienthi()
        {
            dataGridViewadmin.DataSource = adminDAO.Instance.hienthiadmin();
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtloainv = new System.Windows.Forms.ComboBox();
            this.txtgt = new System.Windows.Forms.ComboBox();
            this.lbmk = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.lbgt = new System.Windows.Forms.Label();
            this.lbloainv = new System.Windows.Forms.Label();
            this.lbdc = new System.Windows.Forms.Label();
            this.lbdt = new System.Windows.Forms.Label();
            this.lbma = new System.Windows.Forms.Label();
            this.txtngay = new System.Windows.Forms.DateTimePicker();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btthaydoithongtin = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.buttonbttimkiemtheoma = new System.Windows.Forms.Button();
            this.txttimkiemadmim = new System.Windows.Forms.TextBox();
            this.dataGridViewadmin = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtloainv);
            this.groupBox1.Controls.Add(this.txtgt);
            this.groupBox1.Controls.Add(this.lbmk);
            this.groupBox1.Controls.Add(this.lbten);
            this.groupBox1.Controls.Add(this.lbgt);
            this.groupBox1.Controls.Add(this.lbloainv);
            this.groupBox1.Controls.Add(this.lbdc);
            this.groupBox1.Controls.Add(this.lbdt);
            this.groupBox1.Controls.Add(this.lbma);
            this.groupBox1.Controls.Add(this.txtngay);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txtdt);
            this.groupBox1.Controls.Add(this.txtdc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtloainv
            // 
            this.txtloainv.FormattingEnabled = true;
            this.txtloainv.Items.AddRange(new object[] {
            "Nhân viên thường",
            "Nhân viên quản lý"});
            this.txtloainv.Location = new System.Drawing.Point(568, 18);
            this.txtloainv.Name = "txtloainv";
            this.txtloainv.Size = new System.Drawing.Size(145, 26);
            this.txtloainv.TabIndex = 29;
            // 
            // txtgt
            // 
            this.txtgt.DropDownWidth = 64;
            this.txtgt.FormattingEnabled = true;
            this.txtgt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtgt.Location = new System.Drawing.Point(127, 148);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(145, 26);
            this.txtgt.TabIndex = 28;
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk.ForeColor = System.Drawing.Color.Red;
            this.lbmk.Location = new System.Drawing.Point(565, 180);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(0, 13);
            this.lbmk.TabIndex = 27;
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.ForeColor = System.Drawing.Color.Red;
            this.lbten.Location = new System.Drawing.Point(124, 84);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(0, 13);
            this.lbten.TabIndex = 26;
            // 
            // lbgt
            // 
            this.lbgt.AutoSize = true;
            this.lbgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgt.ForeColor = System.Drawing.Color.Red;
            this.lbgt.Location = new System.Drawing.Point(124, 174);
            this.lbgt.Name = "lbgt";
            this.lbgt.Size = new System.Drawing.Size(0, 13);
            this.lbgt.TabIndex = 23;
            // 
            // lbloainv
            // 
            this.lbloainv.AutoSize = true;
            this.lbloainv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloainv.ForeColor = System.Drawing.Color.Red;
            this.lbloainv.Location = new System.Drawing.Point(439, 46);
            this.lbloainv.Name = "lbloainv";
            this.lbloainv.Size = new System.Drawing.Size(0, 13);
            this.lbloainv.TabIndex = 22;
            // 
            // lbdc
            // 
            this.lbdc.AutoSize = true;
            this.lbdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdc.ForeColor = System.Drawing.Color.Red;
            this.lbdc.Location = new System.Drawing.Point(565, 90);
            this.lbdc.Name = "lbdc";
            this.lbdc.Size = new System.Drawing.Size(0, 13);
            this.lbdc.TabIndex = 21;
            // 
            // lbdt
            // 
            this.lbdt.AutoSize = true;
            this.lbdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdt.ForeColor = System.Drawing.Color.Red;
            this.lbdt.Location = new System.Drawing.Point(565, 133);
            this.lbdt.Name = "lbdt";
            this.lbdt.Size = new System.Drawing.Size(0, 13);
            this.lbdt.TabIndex = 20;
            // 
            // lbma
            // 
            this.lbma.AutoSize = true;
            this.lbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbma.ForeColor = System.Drawing.Color.Red;
            this.lbma.Location = new System.Drawing.Point(124, 46);
            this.lbma.Name = "lbma";
            this.lbma.Size = new System.Drawing.Size(0, 13);
            this.lbma.TabIndex = 19;
            // 
            // txtngay
            // 
            this.txtngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngay.Location = new System.Drawing.Point(127, 106);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(145, 24);
            this.txtngay.TabIndex = 18;
            // 
            // txtmk
            // 
            this.txtmk.ForeColor = System.Drawing.Color.Black;
            this.txtmk.Location = new System.Drawing.Point(568, 153);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(145, 24);
            this.txtmk.TabIndex = 17;
            // 
            // txtdt
            // 
            this.txtdt.ForeColor = System.Drawing.Color.Black;
            this.txtdt.Location = new System.Drawing.Point(568, 106);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(145, 24);
            this.txtdt.TabIndex = 16;
            // 
            // txtdc
            // 
            this.txtdc.ForeColor = System.Drawing.Color.Black;
            this.txtdc.Location = new System.Drawing.Point(568, 64);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(145, 24);
            this.txtdc.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(429, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mật khẩu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(429, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(429, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(429, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loại nhân viên:";
            // 
            // txtten
            // 
            this.txtten.ForeColor = System.Drawing.Color.Black;
            this.txtten.Location = new System.Drawing.Point(127, 61);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(145, 24);
            this.txtten.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên:";
            // 
            // txtma
            // 
            this.txtma.ForeColor = System.Drawing.Color.Black;
            this.txtma.Location = new System.Drawing.Point(127, 19);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(145, 24);
            this.txtma.TabIndex = 1;
            this.txtma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btthaydoithongtin);
            this.panel6.Controls.Add(this.btxoa);
            this.panel6.Controls.Add(this.btthem);
            this.panel6.Controls.Add(this.buttonbttimkiemtheoma);
            this.panel6.Controls.Add(this.txttimkiemadmim);
            this.panel6.Location = new System.Drawing.Point(12, 219);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(735, 48);
            this.panel6.TabIndex = 4;
            // 
            // btthaydoithongtin
            // 
            this.btthaydoithongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthaydoithongtin.Location = new System.Drawing.Point(583, 9);
            this.btthaydoithongtin.Name = "btthaydoithongtin";
            this.btthaydoithongtin.Size = new System.Drawing.Size(149, 35);
            this.btthaydoithongtin.TabIndex = 4;
            this.btthaydoithongtin.Text = "Thay đổi thông tin";
            this.btthaydoithongtin.UseVisualStyleBackColor = true;
            this.btthaydoithongtin.Click += new System.EventHandler(this.button4_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(469, 9);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(85, 35);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(345, 9);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(85, 35);
            this.btthem.TabIndex = 2;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonbttimkiemtheoma
            // 
            this.buttonbttimkiemtheoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbttimkiemtheoma.Location = new System.Drawing.Point(148, 9);
            this.buttonbttimkiemtheoma.Name = "buttonbttimkiemtheoma";
            this.buttonbttimkiemtheoma.Size = new System.Drawing.Size(165, 35);
            this.buttonbttimkiemtheoma.TabIndex = 1;
            this.buttonbttimkiemtheoma.Text = "Tìm kiếm theo mã";
            this.buttonbttimkiemtheoma.UseVisualStyleBackColor = true;
            this.buttonbttimkiemtheoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttimkiemadmim
            // 
            this.txttimkiemadmim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiemadmim.Location = new System.Drawing.Point(9, 14);
            this.txttimkiemadmim.Name = "txttimkiemadmim";
            this.txttimkiemadmim.Size = new System.Drawing.Size(133, 24);
            this.txttimkiemadmim.TabIndex = 0;
            // 
            // dataGridViewadmin
            // 
            this.dataGridViewadmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewadmin.GridColor = System.Drawing.Color.Black;
            this.dataGridViewadmin.Location = new System.Drawing.Point(0, 269);
            this.dataGridViewadmin.Name = "dataGridViewadmin";
            this.dataGridViewadmin.Size = new System.Drawing.Size(762, 166);
            this.dataGridViewadmin.TabIndex = 5;
            this.dataGridViewadmin.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewadmin_CellMouseClick);
            // 
            // dsadmin
            // 
            this.ClientSize = new System.Drawing.Size(762, 435);
            this.Controls.Add(this.dataGridViewadmin);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dsadmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewadmin)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewadmin_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int index = dataGridViewadmin.CurrentRow.Index;
            txtma.Text = dataGridViewadmin.Rows[index].Cells[0].Value.ToString();
            txtten.Text = dataGridViewadmin.Rows[index].Cells[1].Value.ToString();
            if (dataGridViewadmin.Rows[index].Cells[2].Value.ToString() == "Nhân viên thường")
                txtloainv.SelectedIndex = 0;
            else if (dataGridViewadmin.Rows[index].Cells[2].Value.ToString() == "Nhân viên quản lý" )
                txtloainv.SelectedIndex = 1;
            txtngay.Value = (DateTime.Parse(dataGridViewadmin.Rows[index].Cells[3].Value.ToString())).Date;
            if (dataGridViewadmin.Rows[index].Cells[4].Value.ToString() == "Nam")
                txtgt.SelectedIndex = 0;
            else if (dataGridViewadmin.Rows[index].Cells[4].Value.ToString() == "Nữ")
                txtgt.SelectedIndex=1;
            txtdc.Text = dataGridViewadmin.Rows[index].Cells[5].Value.ToString();
            txtdt.Text = dataGridViewadmin.Rows[index].Cells[6].Value.ToString();

            

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string a = txttimkiemadmim.Text;
            dataGridViewadmin.DataSource = adminDAO.Instance.timkiem(a);

            dataGridViewadmin.Columns[0].HeaderText = "Mã NV";
            dataGridViewadmin.Columns[1].HeaderText = "Họ và tên";
            dataGridViewadmin.Columns[2].HeaderText = "Loại nhân viên";
            dataGridViewadmin.Columns[3].HeaderText = "Ngày sinh";
            dataGridViewadmin.Columns[4].HeaderText = "Giới tính";
            dataGridViewadmin.Columns[5].HeaderText = "Địa chỉ";
            dataGridViewadmin.Columns[6].HeaderText = "Điện thoại";
            dataGridViewadmin.Columns[7].HeaderText = "Mật Khẩu";

        }
        //thêm
        private void button2_Click(object sender, EventArgs e)
        {
            Boolean Tgt = false;
            Boolean Tloai = false;
            if (txtloainv.Text == "Nhân viên quản lý")
            {
                Tloai = true;
            }
            if (txtloainv.Text == "Nhân viên thường")
            {
                Tloai = true;
            }
            if (txtgt.Text == "Nam")
            {
                Tgt = true;
            }
            if (txtgt.Text == "Nữ")
            {
                Tgt = true;
            }
            lbdc.Text = ""; lbdt.Text = ""; lbgt.Text = ""; lbloainv.Text = ""; lbma.Text = ""; lbmk.Text = ""; lbten.Text = "";
            //kiểm tra xem các textbox có đúng hay không
            lbdc.Text = ""; lbdt.Text = ""; lbgt.Text = ""; lbloainv.Text = ""; lbma.Text = ""; lbmk.Text = ""; lbten.Text = "";
            if (!taikhoan.mahoasodt(txtdt.Text)|| txtma.Text.Length>20|| txtdc.Text.Length > 200 || txtten.Text.Length > 100 || txtten.Text.Length > 100 || adminDAO.Instance.tontai(txtma.Text)|| txtma.Text == "" || txtten.Text == "" || txtdc.Text == "" || txtdt.Text == "" || txtmk.Text == "" || Tgt==false||Tloai==false)
            {
                if (adminDAO.Instance.tontai(txtma.Text))
                    lbma.Text = "nhân viên có mã "+txtma.Text+" đã tồn tại";
                if (txtma.Text == "")
                    lbma.Text = "Mã không được để trống!";
                if (txtten.Text == "")
                    lbten.Text = "Tên không được để trống!";
                if (txtdc.Text == "")
                    lbdc.Text = "Địa chỉ không được để trống!";
                if (Tgt==false)
                    lbgt.Text = "Chọn giới tính là nam hoặc nữ!";
                if (Tloai==false)
                    lbloainv.Text = "chọn loại nhân viên là nhân viên thường hoặc quản lý!";
                if (txtdt.Text == "")
                    lbdt.Text = "Điện thoại không được để trống!";
                if (!taikhoan.mahoasodt(txtdt.Text))
                    lbdt.Text = "số điện thoại không đúng.";
                if (txtmk.Text == "")
                    lbmk.Text = "Mật khẩu không được để trống!";
                if (txtma.Text.Length > 20)
                    lbma.Text = "Mã không vượt quá 20 ký tự.";
                if (txtten.Text.Length > 100)
                    lbten.Text = "tên không đc vượt quá 100 ký tự.";
                if (txtdc.Text.Length > 200)
                    lbdc.Text = "tên không đc vượt quá 200 ký tự.";
                return;
            }
           

            try
            {
                
                if (adminDAO.Instance.them(txtma.Text, txtten.Text, txtloainv.Text, txtngay.Value, txtgt.Text, txtdc.Text, int.Parse(txtdt.Text), txtmk.Text))
                {
                    MessageBox.Show("thêm thành công nhân viên "+txtten.Text+" với mã NV: "+txtma.Text+".");
                    hienthi();
                }
            }
            catch
            {
                MessageBox.Show("không thể thêm!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            lbdc.Text = ""; lbdt.Text = ""; lbgt.Text = ""; lbloainv.Text = ""; lbma.Text = ""; lbmk.Text = ""; lbten.Text = "";
            try
            {
                if (txtma.Text == "")
                {
                    lbma.Text = "Vui lòng nhập mã nhân viên cần xóa";
                    return;
                }
                if (adminDAO.Instance.xoa(txtma.Text))
                {
                    MessageBox.Show("Xóa thành công nhân viên có mã " + txtma.Text + ".");
                    hienthi();
                }
            }
            catch
            {
                MessageBox.Show("Không thế xóa nhân viên có mã " + txtma.Text + ".");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thaydoithongtin f = new Thaydoithongtin();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}
