using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTQuanLyXe.DTO
{
    class xethangDTO
    {
        //private string masove;
        private string bienso;
        private string loaixe;
        private string tenxe;
        private string mauxe;
        private string loaive;
        private DateTime ngaydk;
        private DateTime ngayhethan;

        

        public string Bienso
        {
            get
            {
                return bienso;
            }

            set
            {
                bienso = value;
            }
        }

        public string Loaixe
        {
            get
            {
                return loaixe;
            }

            set
            {
                loaixe = value;
            }
        }

        public string Tenxe
        {
            get
            {
                return tenxe;
            }

            set
            {
                tenxe = value;
            }
        }

        public string Mauxe
        {
            get
            {
                return mauxe;
            }

            set
            {
                mauxe = value;
            }
        }

        public string Loaive
        {
            get
            {
                return loaive;
            }

            set
            {
                loaive = value;
            }
        }

        public DateTime Ngaydk
        {
            get
            {
                return ngaydk;
            }

            set
            {
                ngaydk = value;
            }
        }

        public DateTime Ngayhethan
        {
            get
            {
                return ngayhethan;
            }

            set
            {
                ngayhethan = value;
            }
        }

        public xethangDTO(DataRow row)
        {
            //this.Masove = row["maSoVe"].ToString();
            this.Bienso = row["bienSo"].ToString();
            this.Loaixe = row["loaiXe"].ToString();
            this.Tenxe = row["tenxe"].ToString();
            this.Mauxe = row["mauxe"].ToString();
            this.Loaive = row["loaiVe"].ToString();
            this.Ngaydk = DateTime.Parse(row["ngayDangKy"].ToString());
            this.Ngayhethan= DateTime.Parse(row["ngayHetHan"].ToString());
        }
    }
}
