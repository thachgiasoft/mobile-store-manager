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
using QL_Ban_DienThoai.XtraReport;
using DevExpress.XtraReports.UI;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucBaoCaoTonKho : DevExpress.XtraEditors.XtraUserControl
    {
        private BaoCaoTonKhoBLT _BaoCaoTonKhoBLT;
        private ChiTietBaoCaoTonKhoBLT _ChiTietBaoCaoTonKhoBLT;

        private string thoigianbaocao;
        public ucBaoCaoTonKho()
        {
            InitializeComponent();

            _BaoCaoTonKhoBLT = new BaoCaoTonKhoBLT();
            _ChiTietBaoCaoTonKhoBLT = new ChiTietBaoCaoTonKhoBLT();
            thoigianbaocao  = Convert.ToString(DateTime.Now);
        }

        private void ucBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            LayDanhSachBaoCao();
        }

        private void LayDanhSachBaoCao()
        {
            DataTable dt = _BaoCaoTonKhoBLT.LayDanhSachBaoCao();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataTable resulttable = new DataTable();
                resulttable.Columns.Add("Mã Báo Cáo", typeof(string));
                resulttable.Columns.Add("Thời Gian Lập Báo Cáo", typeof(string));
                if (deThoiGianBatDau.Text == "" && deThoiGianKetThuc.Text == "")
                {
                    resulttable = dt;
                }
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DateTime date = deThoiGianBatDau.DateTime;
                        DateTime date2 = deThoiGianKetThuc.DateTime;
                        DateTime tempday = Convert.ToDateTime(dt.Rows[i].ItemArray[1]);
                        DateTime comparedate = new DateTime(tempday.Year,  tempday.Month, tempday.Day);
                        int r1 = DateTime.Compare(date, comparedate);
                        int r2 = DateTime.Compare(date2, comparedate);
                        if (r1 <= 0 && r2 >= 0)
                        {
                            resulttable.Rows.Add(dt.Rows[i].ItemArray[0], dt.Rows[i].ItemArray[1]);
                        }
                    }
                }
                gcDanhSachBaoCao.DataSource = null;
                gvDanhSachBaoCao.Columns.Clear();
                gcDanhSachBaoCao.DataSource = resulttable;
            }
        }

        private void sbLapBaoCao_Click(object sender, EventArgs e)
        {
            string thoigian = DateTime.Now.ToString("MM/dd/yyyy");
            DataTable dt = gcDanhSachBaoCao.DataSource as DataTable;
            bool isExist = false;
            int samerow = 0;
            if (dt != null)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    DateTime thoigiandalap = Convert.ToDateTime(dt.Rows[j].ItemArray[1].ToString());
                    if (thoigiandalap.ToString("MM/dd/yyyy") == thoigian)
                    {
                        isExist = true;
                        samerow = j;
                        break;
                    }
                }
            }
            if (!isExist)
            {
                //truong hop bao cao chua lap
                string mabaocao = _BaoCaoTonKhoBLT.LapBaoCao(thoigian).ToString();

                DataTable cttonkho = _ChiTietBaoCaoTonKhoBLT.LayThongTinTonKho();
                if (cttonkho != null && cttonkho.Rows.Count > 0)
                {
                    for (int i = 0; i < cttonkho.Rows.Count; i++)
                    {
                        ChiTietBaoCaoTonKho ct = new ChiTietBaoCaoTonKho();
                        ct.MaBCTK = mabaocao;
                        ct.MaMatHang = cttonkho.Rows[i].ItemArray[0].ToString();
                        ct.SoLuongTon = Convert.ToInt16(cttonkho.Rows[i].ItemArray[3].ToString());
                        _ChiTietBaoCaoTonKhoBLT.ThemChiTietBaoCaoTonKho(ct);
                    }
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Có Báo Cáo Đã Được Lập Trong Hôm Nay\n Bạn Có muốn Lập Lại Báo Cáo?\n Mọi Thông Tin Của Báo Cáo Này Sẽ Được Làm Lại",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string mabaocao = dt.Rows[samerow].ItemArray[0].ToString();
                    _ChiTietBaoCaoTonKhoBLT.XoaChiTietBaoCaoTonKho(mabaocao);
                    //them lai chi tiet bao cao ton kho
                    DataTable cttonkho = _ChiTietBaoCaoTonKhoBLT.LayThongTinTonKho();
                    if (cttonkho != null && cttonkho.Rows.Count > 0)
                    {
                        for (int i = 0; i < cttonkho.Rows.Count; i++)
                        {
                            ChiTietBaoCaoTonKho ct = new ChiTietBaoCaoTonKho();
                            ct.MaBCTK = mabaocao;
                            ct.MaMatHang = cttonkho.Rows[i].ItemArray[0].ToString();
                            ct.TenMatHang = cttonkho.Rows[i].ItemArray[1].ToString();
                            ct.NhaCungCap = cttonkho.Rows[i].ItemArray[2].ToString();
                            ct.SoLuongTon = Convert.ToInt32(cttonkho.Rows[i].ItemArray[3].ToString());
                            _ChiTietBaoCaoTonKhoBLT.ThemChiTietBaoCaoTonKho(ct);
                        }
                    }
                }
            }
            LayDanhSachBaoCao();
        }

        private void gvDanhSachBaoCao_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataTable dt = gcDanhSachBaoCao.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                int selection = gvDanhSachBaoCao.GetSelectedRows()[0];
                string mabaocao = dt.Rows[selection].ItemArray[0].ToString();
                thoigianbaocao = dt.Rows[selection].ItemArray[1].ToString();
                gcChiTietBaoCao.DataSource = null;
                gvChiTietBaoCao.Columns.Clear();
                gcChiTietBaoCao.DataSource = _ChiTietBaoCaoTonKhoBLT.LayChiTietTonKho(mabaocao);
                gvChiTietBaoCao.Columns[0].Width = 100;
                gvChiTietBaoCao.Columns[1].Width = 250;
                gvChiTietBaoCao.Columns[2].Width = 250;
                gvChiTietBaoCao.Columns[3].Width = 50;
            }
        }

        private void deThoiGianBatDau_TextChanged(object sender, EventArgs e)
        {
            if (deThoiGianBatDau.Text == "")
            {
                deThoiGianKetThuc.Text = "";
            }
            else
                if (deThoiGianKetThuc.Text == "")
                    deThoiGianKetThuc.EditValue = DateTime.Now;
            LayDanhSachBaoCao();
        }

        private void deThoiGianKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            if (deThoiGianKetThuc.Text == "")
            {
                deThoiGianBatDau.Text = "";
            }
            else
                if (deThoiGianBatDau.Text == "")
                    deThoiGianBatDau.EditValue = DateTime.Now;
            LayDanhSachBaoCao();
        }

        private void sbChiTietBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoTonKho bc = new BaoCaoTonKho();
            DataTable dt = gcDanhSachBaoCao.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                bc.DanhSachSanPham = gcChiTietBaoCao.DataSource as DataTable;
                bc.ThoiGian = thoigianbaocao;
                XRBaoCaoTonKho BCTonKho = new XRBaoCaoTonKho(bc);
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
    }
}
