using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CTHoaDonBan
    {
        public CTHoaDonBan()
        {
            this.MatHang = new MatHang();
        }

        private string maCTHoaDonBan;
        public string MaCTHoaDonBan
        {
            get { return maCTHoaDonBan; }
            set { maCTHoaDonBan = value; }
        }

        private string maHoaoDon;
        public string MaHoaoDon
        {
            get { return maHoaoDon; }
            set { maHoaoDon = value; }
        }


        private MatHang matHang;
        public MatHang MatHang
        {
            get { return matHang; }
            set { matHang = value; }
        }

        private Decimal giaBan;
        public Decimal GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
   
        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
