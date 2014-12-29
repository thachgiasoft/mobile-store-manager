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
using DevExpress.XtraEditors.Controls;
using System.IO;


namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucThemSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private MatHangBLT matHangBLT;
        private MatHang matHang;

        public ucThemSanPham()
        {
            InitializeComponent();
            this.groupCauHinhDienThoai.Enabled = true;

            this.matHangBLT = new MatHangBLT();
            LoadData();


            //Max length of type text
            this.teTenSanPham.Properties.MaxLength = 100;
            this.teSoLuongTon.Properties.MaxLength = 5;
            this.teThoiGianBaoHanh.Properties.MaxLength = 5;
            this.memGhiChu.Properties.MaxLength = 200;
            this.memGhiChuNCC.Properties.MaxLength = 200;
            this.memMoTa.Properties.MaxLength = 1000;
           
            this.teKichThuocManHinh.Properties.MaxLength = 5;
            this.teHeDieuHanh.Properties.MaxLength = 50;
            this.teRam.Properties.MaxLength = 5;
            this.tePIN.Properties.MaxLength = 5;

            this.teBoNho.Properties.MaxLength = 5;
            this.teSim.Properties.MaxLength = 5;

            // Only type number
            this.teSoLuongTon.Properties.Mask.EditMask = "n0";
            this.teSoLuongTon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teKichThuocManHinh.Properties.Mask.EditMask = "n0";
            this.teKichThuocManHinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teRam.Properties.Mask.EditMask = "n0";
            this.teRam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.tePIN.Properties.Mask.EditMask = "n0";
            this.tePIN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teBoNho.Properties.Mask.EditMask = "n0";
            this.teBoNho.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teSim.Properties.Mask.EditMask = "n0";
            this.teSim.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teThoiGianBaoHanh.Properties.Mask.EditMask = "n0";
            this.teThoiGianBaoHanh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teGiaNhap.Properties.Mask.EditMask = "n0";
            this.teGiaNhap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            this.teGiaXuat.Properties.Mask.EditMask = "n0";
            this.teGiaXuat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //this.peHinhAnh.Image = Image.FromFile("resource/defaultavatar.png");
        }

        private void LoadData()
        {
            //ConboBox LoaiMatHang
            DataTable table = (new LoaiMatHangBLT().LoadComBoBox());
            this.lueLoaiSanPham.Properties.DataSource = table;
            this.lueLoaiSanPham.Properties.DisplayMember = "TenLoaiMatHang";
            this.lueLoaiSanPham.Properties.ValueMember = "MaLoaiMatHang";
            this.lueLoaiSanPham.Properties.NullText = "Please Select Item";
            this.lueLoaiSanPham.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenLoaiMatHang" });

            //ComboBox NhaSanXuat
            DataTable table1 = (new NhaSanXuatBLT().LoadComBoBox());
            this.lueNhaSanXuat.Properties.DataSource = table1;
            this.lueNhaSanXuat.Properties.DisplayMember = "TenNSX";
            this.lueNhaSanXuat.Properties.ValueMember = "MaNSX";
            this.lueNhaSanXuat.Properties.NullText = "Please Select Item";
            this.lueNhaSanXuat.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenNSX" });

            //ComboBox NhaCC
            DataTable table5 = (new NhaCungCapBLT().LoadComBoBox());
            this.lueNhaCC.Properties.DataSource = table5;
            this.lueNhaCC.Properties.DisplayMember = "TenNhaCungCap";
            this.lueNhaCC.Properties.ValueMember = "MaNhaCungCap";
            this.lueNhaCC.Properties.NullText = "Please Select Item";
            this.lueNhaCC.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenNhaCungCap" });

            //ComboBox CPU
            DataTable table2 = (new CPUBLT().LoadComBoBox());
            this.lueCPU.Properties.DataSource = table2;
            this.lueCPU.Properties.DisplayMember = "TenCPU";
            this.lueCPU.Properties.ValueMember = "MaCPU";
            this.lueCPU.Properties.NullText = "Please Select Item";
            this.lueCPU.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenCPU" });

            //ComboBox CPU
            DataTable table3 = (new MauSacBLT().LoadComBoBox());
            this.lueMaSac.Properties.DataSource = table3;
            this.lueMaSac.Properties.DisplayMember = "TenMau";
            this.lueMaSac.Properties.ValueMember = "MaMau";
            this.lueMaSac.Properties.NullText = "Please Select Item";
            this.lueMaSac.Properties.Columns.Add(
                new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = "TenMau" });

            //Load Data if Update

            if (Assist.gMatHang != null)
            {
                matHang = Assist.gMatHang;

                this.teTenSanPham.Text = matHang.TenMatHang;
                this.lueLoaiSanPham.EditValue = new LoaiMatHangBLT().GetMaLoaiMatHang(matHang.MaLoaiMatHang);
                this.lueNhaSanXuat.EditValue = new NhaSanXuatBLT().GetMaNhaSanXuat(matHang.MaNhaSanXuat);

                this.teSoLuongTon.Text = matHang.SoLuong.ToString();
                this.teThoiGianBaoHanh.Text = matHang.ThoiGianBaoHanh.ToString();
                this.memMoTa.Text = matHang.MoTa;
                this.memGhiChu.Text = matHang.GhiChu;

                CauHinhDienThoai cauHinhDT = new CauHinhDienThoai();
                cauHinhDT = new CauHinhDienThoaiBLT().GetCauHinhByMaMatHang(matHang.MaMatHang);

                this.teKichThuocManHinh.Text = cauHinhDT.KichThuocManHinh.ToString();
                this.teHeDieuHanh.Text = cauHinhDT.HeDieuHanh;
                this.teRam.Text = cauHinhDT.Ram.ToString();
                this.lueMaSac.EditValue = cauHinhDT.MaMauSac;
                this.tePIN.Text = cauHinhDT.DungLuongPin.ToString();
                this.lueCPU.EditValue = cauHinhDT.MaCPU;
                this.teBoNho.Text = cauHinhDT.BoNho.ToString();
                this.teSim.Text = cauHinhDT.SoSim.ToString();

                this.lueNhaCC.EditValue = new NhaCungCapBLT().GetMaCCByMaSanPham(matHang.MaMatHang);
                this.memGhiChuNCC.Text = new NhaCungCapBLT().GetGhiChuByMaSanPham(matHang.MaMatHang);

                DonGia donGia = new DonGia();
                donGia = new DonGiaBLT().GetDonGiaByMaSanPham(matHang.MaMatHang);

                this.teGiaNhap.Text = donGia.GiaNhap.ToString();
                this.teGiaXuat.Text = donGia.GiaXuat.ToString();

                //Load hình
                if (Assist.gMatHang.HinhAnh.NoiDungHinhAnh != "" && Assist.gMatHang.HinhAnh.NoiDungHinhAnh != null)
                {
                    this.peHinhAnh.Image = this.Base64ToImage(Assist.gMatHang.HinhAnh.NoiDungHinhAnh);
                    peHinhAnh.Invalidate();
                }

            }
        }

        private void sbLamMoi_Click(object sender, EventArgs e)
        {
            this.teTenSanPham.Text = "";
            this.lueLoaiSanPham.EditValue = 0;
            this.lueNhaSanXuat.EditValue = 0;

            this.teSoLuongTon.Text = "";
            this.teThoiGianBaoHanh.Text = "";
            this.memMoTa.Text = "";
            this.memGhiChu.Text = "";

            this.teKichThuocManHinh.Text = "";
            this.teHeDieuHanh.Text = "";
            this.teRam.Text = "";
            this.lueMaSac.EditValue = 0;
            this.tePIN.Text = "";
            this.lueCPU.EditValue = 0;
            this.teBoNho.Text = "";
            this.teSim.Text = "";

            this.lueNhaCC.EditValue = 1;
            this.memGhiChuNCC.Text = "";

            this.teGiaNhap.Text = "";
            this.teGiaXuat.Text = "";
        }

        private void sbThemSP_Click(object sender, EventArgs e)
        {          
            //Mat Hang
            HinhAnh hinh = new HinhAnh();
            MatHang mh = new MatHang();

            hinh.NoiDungHinhAnh = ImageToBase64(peHinhAnh.Image,
                     System.Drawing.Imaging.ImageFormat.Png);

            if (this.teTenSanPham.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên sản phẩm");
                return;
            }

            mh.TenMatHang = this.teTenSanPham.Text;
            if (this.lueLoaiSanPham.EditValue == null)
            {
                MessageBox.Show("Không được để trống loại sản phẩm");
                return;
            }

            mh.MaLoaiMatHang = this.lueLoaiSanPham.EditValue == null ? "" : this.lueLoaiSanPham.EditValue.ToString();

            if (this.lueNhaSanXuat.EditValue == null)
            {
                MessageBox.Show("Không được để trống tên nhà sản xuất");
                return;
            }

            mh.MaNhaSanXuat = this.lueNhaSanXuat.EditValue == null ? "" : this.lueNhaSanXuat.EditValue.ToString();

            if (this.teSoLuongTon.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống số lượng");
                return;
            }

            mh.SoLuong = Convert.ToInt32(this.teSoLuongTon.Text);

            if (this.teThoiGianBaoHanh.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống thời gian bảo hành");
                return;
            }

            mh.ThoiGianBaoHanh = Convert.ToInt32(this.teThoiGianBaoHanh.Text);

            mh.MoTa = this.memMoTa.Text;
            mh.GhiChu = this.memGhiChu.Text;


            //Nha Cung cap
            string maNhaCC = "";
            string ghiChuNhaCC = "";

            if (this.lueNhaCC.EditValue == null)
            {
                MessageBox.Show("Không được để trống nhà cung cấp");
                return;
            }

            maNhaCC = this.lueNhaCC.EditValue == null ? "" : this.lueNhaCC.EditValue.ToString();

            ghiChuNhaCC = this.memGhiChuNCC.Text;

            //Don Gia
            DonGia dg = new DonGia();

            if (this.teGiaNhap.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống giá nhập");
                return;
            }

            dg.GiaNhap = Convert.ToDecimal(this.teGiaNhap.Text);

             if (this.teGiaXuat.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống giá xuất");
                return;
            }

            dg.GiaXuat = Convert.ToDecimal(this.teGiaXuat.Text);

            // Cau Hinh Dien Thoai

            CauHinhDienThoai chdt = new CauHinhDienThoai();

            //Mobile
            if( this.groupCauHinhDienThoai.Enabled == true)
            {
                if (this.teKichThuocManHinh.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống kích thước màn hình");
                    return;
                }

                chdt.KichThuocManHinh = Convert.ToInt32(this.teKichThuocManHinh.Text);
                chdt.HeDieuHanh = this.teHeDieuHanh.Text;
                chdt.Ram = this.teRam.Text == "" ?  1 : Convert.ToInt32(this.teRam.Text);

                chdt.MaMauSac = this.lueMaSac.EditValue == null ? "" : this.lueMaSac.EditValue.ToString();

                chdt.DungLuongPin = this.tePIN.Text == "" ? 1 : Convert.ToInt32(this.tePIN.Text);
                chdt.MaCPU = this.lueCPU.EditValue == null ? "" : this.lueCPU.EditValue.ToString();
                chdt.BoNho = this.teBoNho.Text == "" ? 1 : Convert.ToInt32(this.teBoNho.Text);
                chdt.SoSim = this.teSim.Text == "" ? 1 : Convert.ToInt32(this.teSim.Text);
                   
            }
            else// Other SP
            {
                // do nothing
            }


            if (Assist.gMatHang != null)//Update
            {
                mh.MaMatHang = Assist.gMatHang.MaMatHang;
                if (this.matHangBLT.CapNhatMatHang(mh, chdt, maNhaCC, ghiChuNhaCC, dg, hinh))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                }

            }
            else//Add
            {
                if (this.matHangBLT.ThemMatHang(mh, chdt, maNhaCC, ghiChuNhaCC, dg, hinh))
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        
        }

        //enable type ...
        private void lueLoaiSanPham_EditValueChanged(object sender, EventArgs e)
        {
            //Is Dienthoai
            if (this.lueLoaiSanPham.EditValue.ToString().Equals("LMH000000000001"))
            {
                this.groupCauHinhDienThoai.Enabled = true;
              
            }
            else
            {
                this.groupCauHinhDienThoai.Enabled = false;
            }
        }

        private void peHinhAnh_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn Hình";
            openFileDialog1.FileName = "hinhanh.png";
            openFileDialog1.Filter = "Hình Ảnh (*.PNG;)|*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                this.peHinhAnh.Image = img;
            }
        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

    }
}
