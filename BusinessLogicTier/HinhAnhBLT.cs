using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class HinhAnhBLT
    {
        private HinhAnhDAT _HinhAnhDAT;
        public HinhAnhBLT()
        {
            _HinhAnhDAT = new HinhAnhDAT();
        }
        public bool ThemHinhAnh(HinhAnh hinhanh)
        {
            return _HinhAnhDAT.ThemHinhAnh(hinhanh);
        }
        public bool XoaHinhAnh(HinhAnh hinhanh)
        {
            return _HinhAnhDAT.XoaHinhAnh(hinhanh);
        }
        public DataTable LayHinhAnhMoiNhat()
        {
            return _HinhAnhDAT.LayHinhAnhMoiNhat();
        }
    }
}
