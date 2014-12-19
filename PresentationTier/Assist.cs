using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;

namespace QL_Ban_DienThoai
{
   public static class Assist
    {
       public static NhanVien nhanVien;
       public static DevExpress.XtraTab.XtraTabControl xtabMainForm;
       public static void addNewTab(DevExpress.XtraEditors.XtraUserControl uc, String title)
        {
            uc.Dock = DockStyle.Fill;
            XtraTabPage Page = new XtraTabPage();
            Page.Name = uc.Name;

            Page.Text = title;
            Page.Controls.Add(uc);
            xtabMainForm.TabPages.Add(Page);
            xtabMainForm.SelectedTabPageIndex = xtabMainForm.TabPages.IndexOf(Page) + 1;
        }
       public static bool isTabExist(String name)
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

       #region Luu cac doi tuong static
       public static NhanVien gNhanVien     = null;
       public static HoaDonBan gHoaDonBan   = null;
       public static KhuyenMai gKhuyenMai   = null;
	   public static MatHang gMatHang       = null;
       public static KhachHang gKhachHang   = null;
       public static HoaDonBaoHanh gHoaDonBaoHanh = null;
       public static NhaCungCap gNhaCungCap = null;
       public static NhaSanXuat gNhaSanXuat = null;

       #endregion
    }
}
