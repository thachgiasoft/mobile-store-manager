using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class HinhAnh
    {
        string maSanPham;
        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }
        string noiDungHinhAnh;
        public string NoiDungHinhAnh
        {
            get { return noiDungHinhAnh; }
            set { noiDungHinhAnh = value; }
        }
    }
}
