using HTQuanLyXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTQuanLyXe.DAO
{
    class tkxedaguiDAO
    {
        private static tkxedaguiDAO instance;
        public static int tongtien = 0;
        internal static tkxedaguiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new tkxedaguiDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public List<thongkeDTO> hienthi()
        {
            String Query = "select * from THONGKE where maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<thongkeDTO> listadmin = new List<thongkeDTO>();
            foreach (DataRow item in data.Rows)
            {
                thongkeDTO dt = new thongkeDTO(item);
                listadmin.Add(dt);
            }
            return listadmin;
        }
        //kiểm tra tổng số xe đã gửi từ trước đến giờ
        public int tongxe()
        {
            String Query = "select * from THONGKE where maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //kiểm tra tổng số xe ô tô đã gửi từ trước đến giờ
        public int tongxeoto()
        {
            String Query = "select * from THONGKE where loaiXe='Ô tô' and maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //kiểm tra tổng số xe ô tô đã gửi từ trước đến giờ
        public int tongxemay()
        {
            String Query = "select * from THONGKE where loaiXe='Xe máy'and maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //reset thống kê
        public void datlai()
        {
            String Query = "delete from THONGKE";
            string querytien = "update BAIXE set soTienThuVe=0";
            string datlai = "DBCC CHECKIDENT('THONGKE',RESEED,0)";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            dataprovider.Instance.ExcuteNonQuery(querytien);
            //dataprovider.Instance.ExcuteNonQuery(Query2);
            data = dataprovider.Instance.ExcuteQuery(datlai);
            
        }
        //lấy ra ngày bắt đầu thống kê
        public DateTime ngaybatdau()
        {
            DateTime ngay = DateTime.Now;
            String Query = "select * from THONGKE where id=1";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                thongkeDTO b = new thongkeDTO(item);
                ngay = b.Tgvaoben;
            }
            return ngay;
        }
        //tìm xe
        public List<thongkeDTO> timkiem(string ma)
        {
            String Query = "select * from THONGKE where bienSo like'%" + ma + "%'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<thongkeDTO> listadmin = new List<thongkeDTO>();
            foreach (DataRow item in data.Rows)
            {
                thongkeDTO dt = new thongkeDTO(item);
                listadmin.Add(dt);
            }
            return listadmin;
        }
        //tổng số lượt xe gửi theo lượt
        public int tongxeguitheoluot()
        {
            String Query = "select * from THONGKE where loaiVe=N'Vé lượt'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //tổng số lượt xe gửi thheo tháng
        public int tongxeguitheothang()
        {
            String Query = "select * from THONGKE where loaiVe=N'Vé tháng' and maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //số xe máy gửi theo lượt
        public int soxemayguitheoluot()
        {
            String Query = "select * from THONGKE where loaiXe=N'Xe máy' and loaiVe=N'Vé lượt'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //số ô tô gửi theo lượt
        public int sootoguitheoluot()
        {
            String Query = "select * from THONGKE where loaiXe=N'Ô tô' and loaiVe=N'Vé lượt'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //tổng xe máy gửi theo tháng
        public int soxemayguitheothang()
        {
            String Query = "select * from THONGKE where loaiXe=N'Xe máy' and loaiVe=N'Vé tháng' and maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //tổng ô tô gửi theo thang
        public int sootoguitheothang()
        {
            String Query = "select * from THONGKE where loaiXe='Ô tô' and loaiVe='Vé tháng' and maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
    }
}
