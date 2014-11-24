using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Ban_DienThoai
{
   public static class Assist
    {
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
    }
}
