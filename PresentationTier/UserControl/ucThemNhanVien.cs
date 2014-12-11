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
using DevExpress.XtraEditors.Controls;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucThemNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private NhanVienBLT nhanvienBLT;
        private String maNV = "";

        public ucThemNhanVien()
        {        
            InitializeComponent();
            this.nhanvienBLT = new NhanVienBLT();

            //Load ds chuc vu
           // DataSet dataChucVu = new DataSet();
            //dataChucVu = (new ChucVuBLT().LoadComBoBox());

            this.lueChucVu.Properties.DataSource = (new ChucVuBLT().LoadComBoBox());
            this.lueChucVu.Properties.Columns.Add(new LookUpColumnInfo(this.lueChucVu.Properties.DisplayMember));

         //   this.lueChucVu.Properties.
            this.deNgayTao.DateTime = DateTime.Now;       
        }
  
        private void sbLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();

            if (this.teTenNhanVien.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên nhân viên");
                return;
            }

            nv.TenNhanVien = this.teTenNhanVien.Text;
            nv.NgaySinh = this.deNgaySinh.DateTime.ToString("dd/MM/yyyy");
            nv.SoDienThoai = this.teSoDienThoai.Text;
            nv.TaiKhoan = this.teTaiKhoan.Text;
            nv.MatKhau = this.teMatKhau.Text;
            nv.GhiChu = this.txtGhiChu.Text;
            nv.DiaChi = this.teDiaChi.Text;

            if (this.rdbNam.Checked == true)
                nv.GioiTinh = "Nam";
            else
                nv.GioiTinh = "Nữ";

            nv.CMND = this.teCMND.Text;
            nv.Email = this.teEmail.Text;
            nv.ChucVuNhanVien.MaChucVu = this.lueChucVu.EditValue == null ? "" : this.lueChucVu.EditValue.ToString();

            if (Assist.gNhanVien != null)
            {
                nv.MaNhanVien = this.maNV;
                if(this.nhanvienBLT.CapNhatNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo", MessageBoxButtons.OK);
                }

            }
            else
                if(this.nhanvienBLT.ThemNhanVien(nv))
                  {
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                  }
                 else
                 {
                    MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK);
                 }
        }

        private void groupControl1_Enter(object sender, EventArgs e)
        {
         if (Assist.gNhanVien != null) //# null thi cap nhat nguoc lai thi them
            {
                 this.maNV = Assist.gNhanVien.MaNhanVien;
                 this.teTenNhanVien.Text = Assist.gNhanVien.TenNhanVien;
                 this.deNgaySinh.Text = Assist.gNhanVien.NgaySinh;
                 this.teSoDienThoai.Text = Assist.gNhanVien.SoDienThoai;
                 this.teTaiKhoan.Text = Assist.gNhanVien.TaiKhoan;
                 this.teMatKhau.Text = Assist.gNhanVien.MatKhau;
                 this.txtGhiChu.Text = Assist.gNhanVien.GhiChu;
                 this.teDiaChi.Text = Assist.gNhanVien.DiaChi;

                 if (Assist.gNhanVien.GioiTinh.Contains("Nam"))
                     this.rdbNam.Checked = true;
                 else
                     this.rdbNu.Checked = true;

                this.teCMND.Text = Assist.gNhanVien.CMND.ToString();
                this.teEmail.Text = Assist.gNhanVien.Email;
                this.lueChucVu.Text = Assist.gNhanVien.ChucVuNhanVien.TenChucVu;
            }
            else
             {
               this.resetValue();
              }  
              
        }
    
        private void resetValue()
        {
                 this.teTenNhanVien.Text = "";
                 this.deNgaySinh.Text = "";
                 this.teSoDienThoai.Text = "";
                 this.teTaiKhoan.Text = "";
                 this.teMatKhau.Text = "";
                 this.txtGhiChu.Text = "";
                 this.teDiaChi.Text = "";
                 this.rdbNam.Checked = true;              
                 this.teCMND.Text = "";
                 this.teEmail.Text = "";
                 this.lueChucVu.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.resetValue();
        }
    }
}
