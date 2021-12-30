using HTQuanLyXe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTQuanLyXe.DAO
{
    class tkxedangtrongbenDAO
    {
        private static tkxedangtrongbenDAO instance;

        internal static tkxedangtrongbenDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new tkxedangtrongbenDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public List<xeluotDTO> hienthi()
        {
            String Query = "select * from XE";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            List<xeluotDTO> listadmin = new List<xeluotDTO>();
            foreach (DataRow item in data.Rows)
            {
                xeluotDTO dt = new xeluotDTO(item);
                listadmin.Add(dt);
            }
            return listadmin;
        }
        //kiểm tra tổng số xe ô tô đang trong bến
        public int tongxeoto()
        {
            String Query = "select * from XE where loaiXe='Ô tô'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
        //kiểm tra tổng số xe mays đang trong bến
        public int tongxemay()
        {
            String Query = "select * from XE where loaiXe='Xe máy'";
            DataTable data = new DataTable();
            data = dataprovider.Instance.ExcuteQuery(Query);
            return data.Rows.Count;
        }
    }
}
