using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class BaoCaoTonKhoBLT
    {
        BaoCaoTonKhoDAT _BaoCaoTonKhoDAT;
        public BaoCaoTonKhoBLT()
        {
            _BaoCaoTonKhoDAT = new BaoCaoTonKhoDAT();
        }

        public DataTable LayDanhSachBaoCao()
        {
            return _BaoCaoTonKhoDAT.LayDanhSachBaoCao();
        }

        public object LapBaoCao(string thoigian)
        {
            return _BaoCaoTonKhoDAT.LapBaoCao(thoigian );
        }
        public DataTable LayBaoCaoTheoThoiGian(string thoigian)
        {
            return _BaoCaoTonKhoDAT.LayBaoCaoTheoThoiGian(thoigian);
        }
    }
}
