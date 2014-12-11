using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
   public class KhuyenMai
    {
       public KhuyenMai()
       {

       }

       private String maKhuyenMai;
       public String MaKhuyenMai
       {
           get { return maKhuyenMai; }
           set { maKhuyenMai = value; }
       }

       private String tenChuongTrinh;
       public String TenChuongTrinh
       {
           get { return tenChuongTrinh; }
           set { tenChuongTrinh = value; }
       }

       private String thoiGianDB;
       public String ThoiGianDB
       {
           get { return thoiGianDB; }
           set { thoiGianDB = value; }
       }

       private String thoiGianKT;
       public String ThoiGianKT
       {
           get { return thoiGianKT; }
           set { thoiGianKT = value; }
       }

       private String ghiChu;
       public String GhiChu
       {
           get { return ghiChu; }
           set { ghiChu = value; }
       }
      
    }
}
