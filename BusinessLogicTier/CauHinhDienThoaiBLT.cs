using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class CauHinhDienThoaiBLT
    {
        private CauHinhDienThoaiDAT cauHinhDienThoaiDAT;

        public CauHinhDienThoaiBLT()
        {
            this.cauHinhDienThoaiDAT = new CauHinhDienThoaiDAT();
        }

        public CauHinhDienThoai LayCauHinhByMaMatHang(string maMatHang)
        {
            CauHinhDienThoai chdt = new CauHinhDienThoai();
            DataTable table ;

            try
            {
                table = this.cauHinhDienThoaiDAT.LayCauHinhByMaMatHang(maMatHang);

                foreach (DataRow row in table.Rows)
                {
                    chdt.MaCauHinh = row["MaCauHinh"].ToString();
                    chdt.TenCauHinh = row["TenCauHinh"].ToString();
                    chdt.MaMatHang = row["MaMatHang"].ToString();
                    chdt.KichThuocManHinh = Convert.ToInt32(row["KichThuocManHinh"].ToString());

                    chdt.HeDieuHanh = row["HeDieuHanh"].ToString();
                    chdt.Ram = Convert.ToInt32(row["RAM"].ToString());
                    chdt.MaMauSac = row["MaMau"].ToString();
                    chdt.DungLuongPin = Convert.ToInt32(row["DungLuongPin"].ToString());
                    chdt.MaCPU = row["MaCPU"].ToString();
                    chdt.BoNho = Convert.ToInt32(row["BoNho"].ToString());
                    chdt.SoSim = Convert.ToInt32(row["SoKheSim"].ToString());
                }

                return chdt;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
