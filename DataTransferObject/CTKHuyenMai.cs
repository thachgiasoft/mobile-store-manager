using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
   public class CTKHuyenMai
    {
       public CTKHuyenMai()
       {
           this.khuyenMai = new KhuyenMai();
           this.matHang = new MatHang();
       }
       
       private String maCTKhuyenMai;
       public String MaCTKhuyenMai
       {
           get { return maCTKhuyenMai; }
           set { maCTKhuyenMai = value; }
       }

       private KhuyenMai khuyenMai;
       public KhuyenMai KhuyenMai
       {
           get { return khuyenMai; }
           set { khuyenMai = value; }
       }

       private MatHang matHang;
       public MatHang MatHang
        {
            get { return matHang; }
            set { matHang = value; }
        }

       private int soLuong;
       public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

       private Decimal giaKhuyenMai;
       public Decimal GiaKhuyenMai
        {
            get { return giaKhuyenMai; }
            set { giaKhuyenMai = value; }
        }
    }
}
