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
using DataTransferObject;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucThemNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private NhanVienBLT nhanvienBLT;

        public ucThemNhanVien()
        {        
            InitializeComponent();
            this.nhanvienBLT = new NhanVienBLT();

            //Load ds chuc vu
            DataSet dataChucVu = new DataSet();
            dataChucVu = (new ChucVuBLT().LoadComBoBox());

            this.cbeChucVu.Properties.DataSource = dataChucVu;
            this.cbeChucVu.Properties.DisplayMember = "TenChucVu";
            this.cbeChucVu.Properties.ValueMember = "MaChucVu";
                //) = dataChucVu.Tables[0];

            this.deNgayTao.DateTime = DateTime.Now;
            if (Assist.gNhanVien != null) //# null thi cap nhat nguoc lai thi them
            {

                 this.teMaNhanVien.Text = Assist.gNhanVien.MaNhanVien;
                 this.teTenNhanVien.Text = Assist.gNhanVien.TenNhanVien;
                 this.deNgaySinh.Text = Assist.gNhanVien.NgaySinh;
                 this.teSoDienThoai.Text = Assist.gNhanVien.SoDienThoai.ToString();
                 this.teTaiKhoan.Text = Assist.gNhanVien.TaiKhoan;
                 this.teMatKhau.Text = Assist.gNhanVien.MatKhau;
                 this.txtGhiChu.Text = Assist.gNhanVien.GhiChu;
                 this.teDiaChi.Text = Assist.gNhanVien.DiaChi;

                 if (Assist.gNhanVien.GioiTinh.Equals("1"))
                     this.rdbNam.Checked = true;
                 else
                     this.rdbNu.Checked = true;

                this.teCMND.Text = Assist.gNhanVien.cMND.ToString();
                this.teEmail.Text = Assist.gNhanVien.Email;
                this.cbeChucVu.Text = Assist.gNhanVien.ChucVuNhanVien.MaChucVu;
            }
        }
  
        private void sbLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            if (this.teTenNhanVien.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên nhân viên");
                return;
            }

            nv.MaNhanVien = this.teMaNhanVien.Text;
            nv.TenNhanVien = this.teTenNhanVien.Text;
            nv.NgaySinh = this.deNgaySinh.ToString();
            nv.SoDienThoai = Convert.ToInt32(this.teSoDienThoai.Text);
            nv.TaiKhoan = this.teTaiKhoan.Text;
            nv.MatKhau = this.teMatKhau.Text;
            nv.GhiChu = this.txtGhiChu.Text;
            nv.DiaChi = this.teDiaChi.Text;

            if (this.rdbNam.Checked == true)
                nv.GioiTinh = "1";
            else
                nv.GioiTinh = "0";

            nv.cMND = Convert.ToInt32(this.teCMND.Text);
            nv.Email = this.teEmail.Text;
            nv.ChucVuNhanVien.MaChucVu = this.cbeChucVu.Text;

            if (Assist.gNhanVien != null)
            {
                this.nhanvienBLT.CapNhatNhanVien(nv);

            }
            else
                this.nhanvienBLT.ThemNhanVien(nv);
        }    
    }
}
