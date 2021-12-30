using HTQuanLyXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTQuanLyXe.DAO
{
    class tkvethangDAO
    {
        private static tkvethangDAO instance;

        internal static tkvethangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new tkvethangDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public List<xethangDTO> hienthivethang()
        {
            String Query = "select * from XE where loaiVe='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<xethangDTO> listxe = new List<xethangDTO>();
            foreach (DataRow item in data.Rows)
            {
                xethangDTO dt = new xethangDTO(item);
                string bien = item["bienSo"].ToString();
                string query = "delete from XE where (DATEDIFF(DAY,(SELECT ngayDangky from XE where bienSo=N'" + bien + "'),(SELECT ngayHetHan from XE where bienSo=N'" + bien + "'))=0) and bienSo='" + bien + "'";
                dataprovider.Instance.ExcuteNonQuery(query);
                listxe.Add(dt);
            }
            return listxe;
        }
        public List<xethangDTO> timkiemtheobien(string bien)
        {
            String Query = "select * from XE where bienSo like'%" + bien + "%'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<xethangDTO> listadmin = new List<xethangDTO>();
            foreach (DataRow item in data.Rows)
            {
                xethangDTO dt = new xethangDTO(item);
                listadmin.Add(dt);
            }
            return listadmin;
        }
        // tổng số vé tháng
        public int tongvethang()
        {
            String Query = "select * from XE where loaiVe='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //số ô tô đăng ký vé tháng
        public int tongoto()
        {
            String Query = "select * from XE where loaiXe='Ô tô' and loaiVe='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        // số xe máy đăng ký vé tháng
        public int tongxemay()
        {
            String Query = "select * from XE where loaiXe='Xe máy' and loaiVe='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //số ô tô đăng ký vé tháng ở bảng thống kê dùng để thống kê và có thể đặt lại
        public int tongototk()
        {
            String Query = "select * from THONGKE where loaiXe='Ô tô' and loaiVe='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        // số xe máy đăng ký vé tháng ở bảng thống kê dùng đẻ thống kê và có thể đặt lại
        public int tongxemaytk()
        {
            String Query = "select * from THONGKE where loaiXe='Xe máy' and loaiVe='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
    }
}
