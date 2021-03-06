﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using QL_Ban_DienThoai.UserControl;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace QL_Ban_DienThoai
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public FormMain(string hoten, string chucvu, string maQuyen)
        {          
            InitializeComponent();
            Assist.xtabMainForm = this.xtabMainForm;
            HoTen.Caption = "Họ và Tên: " + hoten;
            ChucVu.Caption = "Chức Vụ: " + chucvu;
            Ribbon.Minimized = true;

            this.GroupBanHang.Enabled = true;
            this.GroupBaoCaoBanHang.Enabled = true;
            this.GroupBaoCaoKho.Enabled = true;
            this.GroupBaoHanh.Enabled = true;
            this.GroupDatHang.Enabled = true;
            this.GroupDSSP.Enabled = true;
            this.GroupGiaoHang.Enabled = true;
            this.GroupMatHang.Enabled = true;
            this.GroupNhapKho.Enabled = true;
            this.GroupKhachHang.Enabled = true;
            this.GroupNhanVien.Enabled = true;
            this.GroupThongTinMatHang.Enabled = true;

            this.GroupBanHang.Visible = false;
            this.GroupBaoCaoBanHang.Visible = false;
            this.GroupBaoCaoKho.Visible = false;
            this.GroupBaoHanh.Visible = false;
            this.GroupDatHang.Visible = false;
            this.GroupDSSP.Visible = false;
            this.GroupGiaoHang.Visible = false;
            this.GroupMatHang.Visible = false;
            this.GroupNhapKho.Visible = false;
            this.GroupKhachHang.Visible = false;
            this.GroupNhanVien.Visible = false;
            this.GroupThongTinMatHang.Visible = false;

            this.rpQuanLyNhanVien.Visible = false;
            this.rpQuanLyBanHang.Visible = false;
            this.rpQuanLyKho.Visible = false;
            this.rpQuanLyMatHang.Visible = false;
            this.rpBaoCao.Visible = false;

            //Phần quyền đơn giản.
            if (maQuyen == "CV0000000000001")// admin
            {
                this.GroupBanHang.Visible = true;
                this.GroupBaoCaoBanHang.Visible = true;
                this.GroupBaoCaoKho.Visible = true;
                this.GroupBaoHanh.Visible = true;
                this.GroupDatHang.Visible = true;
                this.GroupDSSP.Visible = true;
                this.GroupGiaoHang.Visible = true;
                this.GroupMatHang.Visible = true;
                this.GroupNhapKho.Visible = true;
                this.GroupKhachHang.Visible = true;
                this.GroupNhanVien.Visible = true;
                this.GroupThongTinMatHang.Visible = true;

                this.rpQuanLyNhanVien.Visible = true;
                this.rpQuanLyBanHang.Visible = true;
                this.rpQuanLyKho.Visible = true;
                this.rpQuanLyMatHang.Visible = true;
                this.rpBaoCao.Visible = true;

            }
            else if (maQuyen == "CV0000000000002") // nhân viên kho
            {
                this.GroupDatHang.Visible = true;
                this.GroupBaoCaoKho.Visible = true;
                this.GroupDSSP.Visible = true;
                this.GroupNhapKho.Visible = true;

                this.rpBaoCao.Visible = true;
                this.rpQuanLyKho.Visible = true;

            }
            else if (maQuyen == "CV0000000000003") // Nhân viên bán hàng
            {
                this.GroupBanHang.Visible = true;
                this.GroupBaoCaoBanHang.Visible = true;
                this.GroupKhachHang.Visible = true;

                this.rpQuanLyNhanVien.Visible = true;
                this.rpQuanLyBanHang.Visible = true;
                this.rpBaoCao.Visible = true;
            }
            else if (maQuyen == "CV0000000000004") // Nhân viên giao hàng
            {
                this.GroupGiaoHang.Visible = true;
                this.rpQuanLyBanHang.Visible = true;
            }
            else if (maQuyen == "CV0000000000005") // Nhân viên bảo hành
            {
                this.GroupBaoHanh.Visible = true;
                this.GroupKhachHang.Visible = true;

                this.rpQuanLyNhanVien.Visible = true;
                this.rpQuanLyBanHang.Visible = true;
            }
            else if (maQuyen == "CV0000000000006") // Khách hàng
            {
                this.GroupMatHang.Visible = true;
                this.rpQuanLyMatHang.Visible = true;
            }
        }

        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addNewTab(DevExpress.XtraEditors.XtraUserControl uc, String title)
        {
            uc.Dock = DockStyle.Fill;
            XtraTabPage Page = new XtraTabPage();
            Page.Name = uc.Name;

            Page.Text = title;
            Page.Controls.Add(uc);
            xtabMainForm.TabPages.Add(Page);
            xtabMainForm.SelectedTabPageIndex = xtabMainForm.TabPages.IndexOf(Page) + 1;
        }

        private bool isTabExist(String name)
        {
            bool isexisttab = false;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtabMainForm.TabPages)
            {
                if (tab.Text == name)
                {
                    isexisttab = true;
                    xtabMainForm.SelectedTabPage = tab;
                    break;
                }
            }
            return isexisttab;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Danh Sách Khách Hàng";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucDanhSachKhachHang(), name);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            String Name = "Danh Sách Nhân Viên";
            if (!this.isTabExist(Name))
            {
                this.addNewTab(new ucDanhSachNhanVien(), Name);
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            String Name = "Danh sách phiếu bán Hàng";
            if (!this.isTabExist(Name))
            {
                this.addNewTab(new ucDanhSachHoaDonBan(), Name);
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Danh Sách Phiếu Giao Hàng";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucDanhSachPhieuGiaoHang(), name);
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

            String name = "Lập Phiếu Bảo Hành";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucPhieuBaoHanh(), name);
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Hóa Đơn Đặt Hàng";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucHoaDonDatHang(), name);
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Hóa Đơn Nhập Hàng";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucHoaDonNhapHang(), name);
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Báo Cáo Tồn Kho";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucBaoCaoTonKho(), name);
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Báo Cáo Bán Hàng";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucBaoCaoBanHang(), name);
            }
        }

        private void closeTab(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs closeEvent = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            if (closeEvent.Page.Text == "Hóa Đơn Đặt Hàng" || 
                closeEvent.Page.Text == "Lập hóa đơn bán hàng" || 
                closeEvent.Page.Text == "Thêm chương trình khuyến mãi" || 
                closeEvent.Page.Text == "Chỉnh sửa nhân viên" || 
                closeEvent.Page.Text == "Lệ phí giao hàng" || 
                closeEvent.Page.Text == "Hóa Đơn Nhập Hàng")
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc thoát form này???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
                    DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
                    (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
                }
            }
            else
            {
                DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
                DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
                (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Danh Sách Sản Phẩm";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucDanhSachSanPham(), name);
            }
        }

        private void barButtonItem11_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            String name = "Danh Sách Khách Hàng";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucDanhSachKhachHang(), name);
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Màu Sắc";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucMauSac(), name);
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "CPU";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucCPU(), name);
            }
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Loại Sản Phẩm";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucLoaiSanPham(), name);
            }
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Nhà Sản xuất";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucNhaSanXuat(), name);
            }
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Đơn Giá";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucDonGia(), name);
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            RibbonHitInfo hi = Ribbon.CalcHitInfo(e.Location);
            if (hi.HitTest == RibbonHitTest.PageHeader)
            {
                if (Ribbon.Minimized)
                {
                    Ribbon.Minimized = false;
                }
            }
            else
            {
                if (e.Location.Y > 140)
                    Ribbon.Minimized = true;
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Báo Cáo Nhập Hàng";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucBaoCaoNhapHang(), name);
            }
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Nhà Cung Cấp";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucNhaCungCap(), name);
            }
        }

        private void barButtonCTKM_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Chương trình khuyến mãi";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucDanhSachKhuyenMai(), name);
            }
        }

        private void barButtonLePhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Lệ phí giao hàng";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucLePhiGiaoHang(), name);
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormThayDoiQuyDinh formThayDoiQuyDinh = new FormThayDoiQuyDinh();
            formThayDoiQuyDinh.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Danh Sách Sản Phẩm";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucDanhSachSanPham(), name);
            }
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Tra Cứu Sản Phẩm";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucTraCuuMatHang(), name);
            }
        }
    }
}