using System;
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

namespace QL_Ban_DienThoai
{
    public partial class mainform : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public mainform()
        {          
            InitializeComponent();
            Assist.xtabMainForm = this.xtabMainForm;
        }

        private void mainform_Load(object sender, EventArgs e)
        {
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {

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

        private void ribbon_Click(object sender, EventArgs e)
        {

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
                this.addNewTab(new ucPhieuBanHangTimKiem(), Name);
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            String name = "Thêm Phiếu Giao Hàng";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucThemPhieuGiaoHang(), name);
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
            String name = "Hóa Đơn Nhập Kho";
            if (!this.isTabExist(name))
            {
                this.addNewTab(new ucHoaDonNhapKho(), name);
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
            DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
        }
    }
}