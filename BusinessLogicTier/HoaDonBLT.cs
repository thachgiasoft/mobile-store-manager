using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;
using System.Data;

namespace BusinessLogicTier
{
    public class HoaDonBLT
    {
        private HoaDonDAT _HoaDonDAT;
        public HoaDonBLT()
        {
            _HoaDonDAT = new HoaDonDAT();
        }

        public bool ThemHoaDon(HoaDon hd)
        {
            return _HoaDonDAT.ThemHoaDon(hd);
        }
    }
}
