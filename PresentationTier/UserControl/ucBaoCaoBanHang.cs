using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using DataTransferObject;
using DevExpress.XtraReports.UI;
using QL_Ban_DienThoai.XtraReport;

namespace QL_Ban_DienThoai
{
    public partial class ucBaoCaoBanHang : DevExpress.XtraEditors.XtraUserControl
    {

        public ucBaoCaoBanHang()
        {
            InitializeComponent();
            this.dateTuNgay.DateTime = DateTime.Now;
            this.teNhanVien.Text = "Hồ Xuân Vĩnh";
            this.teMaNhanVien.Text = "NV0000000000001";
            this.dateDienNgay.DateTime = DateTime.Now;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            String TuNgay = "";
            String DenNgay = "";
            TuNgay = this.dateTuNgay.DateTime.ToString("MM/dd/yyyy");
            if (TuNgay.Equals("01-01-0001"))
            {
                TuNgay = "";
                MessageBox.Show("Vui lòng chọn ngày lập báo cáo!", "Cảnh báo", MessageBoxButtons.OK);
                return;
            }


            DenNgay = this.dateDienNgay.DateTime.ToString("MM/dd/yyyy");
            if (DenNgay.Equals("01-01-0001"))
            {
                DenNgay = "";
            }

            this.gcKetQua.DataSource = (new BaoCaoBanHangBLT().BaoCaoBanHang(TuNgay, DenNgay));
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BaoCaoBangHang bc = new BaoCaoBangHang();
            DataTable dt = gcKetQua.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                bc.Data = gcKetQua.DataSource as DataTable;
                bc.MaNhanVien = this.teMaNhanVien.Text;
                bc.TenNhanVien = this.teNhanVien.Text;
                bc.TuNgay = this.dateTuNgay.Text;
                bc.DenNgay = this.dateDienNgay.Text;

                XRLapBaoCaoBanHang BCTonKho = new XRLapBaoCaoBanHang(bc);
                try
                {
                    BCTonKho.CreateDocument();
                }
                catch (Exception ex)
                {

                }
                ReportPrintTool printTool = new ReportPrintTool(BCTonKho);
                printTool.ShowPreviewDialog();
            }
            else
            {
                MessageBox.Show("Danh Sách Báo Cáo Trống",
                   "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

        }

        private void ucBaoCaoBanHang_Load(object sender, EventArgs e)
        {

        }
     
    }
}
