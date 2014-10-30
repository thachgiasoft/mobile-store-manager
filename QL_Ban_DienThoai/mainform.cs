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

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            ucThemNhanVien baocaobanhang = new ucThemNhanVien();
            baocaobanhang.Dock = DockStyle.Fill;
            XtraTabPage Page = new XtraTabPage();
            Page.Name = baocaobanhang.Name;
            Page.Text = baocaobanhang.Name;
            Page.Controls.Add(baocaobanhang);
            xtabMainForm.TabPages.Add(Page);
            xtabMainForm.SelectedTabPageIndex = xtabMainForm.TabPages.IndexOf(Page) + 1;
        }
    }
}