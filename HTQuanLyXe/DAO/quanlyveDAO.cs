using HTQuanLyXe.DAO;
using HTQuanLyXe.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTQuanLyXe.DAO
{
    class quanlyveDAO
    {
        public static ArrayList VEXE = new ArrayList();
        private static quanlyveDAO instance;

        internal static quanlyveDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new quanlyveDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public List<veDTO> hienthi()
        {
            String Query = "select * from VE where maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<veDTO> listve = new List<veDTO>();
            foreach (DataRow item in data.Rows)
            {
                //VEXE.Add(item["maSoVe"]);
                veDTO dt = new veDTO(item);
                listve.Add(dt);
            }
            return listve;
        }
        //hiển thị danh sách vé đang dùng 
        public List<veDTO> hienthivedangdung()
        {
            String Query = "select * from VE where bienSo is not null";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<veDTO> listve = new List<veDTO>();
            foreach (DataRow item in data.Rows)
            {
                //VEXE.Add(item["maSoVe"]);
                veDTO dt = new veDTO(item);
                listve.Add(dt);
            }
            return listve;
        }
        //hiển thị danh sách vé chưa phát ra
        public List<veDTO> hienthivetrong()
        {
            String Query = "select * from VE where bienSo is null and maSoVe!='Vé tháng'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<veDTO> listve = new List<veDTO>();
            foreach (DataRow item in data.Rows)
            {
                veDTO dt = new veDTO(item);
                listve.Add(dt);
            }
            return listve;
        }
        //thêm vé xe
        public void themve(string ma)
        {
            String Query = "insert into VE values(null,N'" + ma+ "',null,null)";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
        }
        public int sovedangdung()
        {
            String Query = "select * from VE where bienSo is not null";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        public int sovetrong()
        {
            String Query = "select * from VE where bienSo is null";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //kiểm tra xem vé đã tồn tại hay chưa
        public Boolean tontaive(string ma)
        {
            string query = "select * from VE where maSoVe='" + ma + "'";
            return dataprovider.Instance.ExcuteQuery(query).Rows.Count > 0;
        }
        //kiểm tra xem hết vé chưa
        public Boolean fullve(string ma)
        {            String Query = "select * from VE where loaiXe=(select loaiXe from VE where maSoVe='"+ma+"') and bienSo is null";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return 0 >= data.Rows.Count;
        }
    }
}

