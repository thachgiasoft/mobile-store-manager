using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessLogicTier;
using DevExpress.XtraTab;
using DataTransferObject;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucDanhSachNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private NhanVienBLT nhanVienBLT;

        public ucDanhSachNhanVien()
        {
            InitializeComponent();
            this.nhanVienBLT = new NhanVienBLT();
            //Lấy ds nhân viên nha. doi t xiu
            DataTable data = new DataTable();
            data = this.nhanVienBLT.LayDanhSachNhanVien();     
            this.GridNhanVien.DataSource = data;          
        }

        private void sbThem_Click(object sender, EventArgs e)
        {      
            String Name = "Thêm Nhân Viên";
            if (!Assist.isTabExist(Name))
            {
                Assist.gNhanVien = null;
                Assist.addNewTab(new ucThemNhanVien(), Name);
            }        
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();          
            nv.MaNhanVien = this.teMaNhanVien.Text;
            nv.TenNhanVien = this.teTenNhanVien.Text;
            nv.NgaySinh = this.deNgaySinh.ToString();
            nv.SoDienThoai = Convert.ToInt32(this.teSoDienThoai.Text);
            nv.DiaChi = this.teDiaChi.Text;
            nv.cMND = Convert.ToInt32(this.teCMND.Text);
            nv.ChucVuNhanVien.MaChucVu = this.cbeChucVu.Text;

            this.nhanVienBLT.TimKiemNhanVien(nv);
        }

        private void sbCapNhat_Click(object sender, EventArgs e)
        {
            int indexSelect = -1;

            if (indexSelect != -1)
            {

            }

        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            String message = "";
            if (nhanVienBLT.XoaNhanVien(this.teMaNhanVien.Text))
                message += "Xóa thành công";
            else
                message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
        }      
    }
}
