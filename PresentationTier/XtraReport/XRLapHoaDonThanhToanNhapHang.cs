using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DataTransferObject;

namespace QL_Ban_DienThoai.XtraReport
{
    public partial class XRLapHoaDonThanhToanNhapHang : DevExpress.XtraReports.UI.XtraReport
    {
        public XRLapHoaDonThanhToanNhapHang(HoaDonNhapHang hd)
        {
            InitializeComponent();
            xlNgayGiaoHang.Text = hd.NgayGiaoHang;
            xlNhaCungCap.Text = hd.NhaCungCap;
            xlHoTenNhanVien.Text = hd.TenNhanVien;
            xlNguoiLap.Text = hd.TenNhanVien;
            DateTime ngaylap = Convert.ToDateTime(hd.NgayGiaoHang);
            xlNgayLap.Text = "Ngày " + ngaylap.Day + " Tháng " + ngaylap.Month + " Năm " + ngaylap.Year;
            xlTongTien.Text = "Tổng Tiền:  " + hd.TongTien + "  VND";
            if (hd.DanhSachSanPham != null)
            {
                int cellsInRow = 4;
                int rowsCount = hd.DanhSachSanPham.Rows.Count;
                //do cao cua mot o trong table
                float rowHeight = 20f;
                for (int i = 0; i < rowsCount; i++)
                {
                    XRTableRow row = new XRTableRow();
                    row.HeightF = rowHeight;
                    for (int j = 0; j < cellsInRow; j++)
                    {
                        XRTableCell cell = new XRTableCell();
                        if (j == 0)
                        {
                            //them so thu tu
                            cell.Text = "  " + i.ToString();
                        }
                        else
                            cell.Text = "  " + hd.DanhSachSanPham.Rows[i].ItemArray[j - 1].ToString();

                        //chinh lai kich thuoc cua moi o
                        switch (j)
                        {
                            case 0:
                                cell.WidthF = 65;
                                break;
                            case 1:
                                cell.WidthF = 270;
                                break;
                            case 2:
                                cell.WidthF = 60;
                                break;
                            case 3:
                                cell.WidthF = 155;
                                cell.Text += "  VND";
                                break;
                        }
                        row.Cells.Add(cell);
                    }
                    xtDanhSachMatHang.Rows.Add(row);

                }
            }
        }

    }
}
