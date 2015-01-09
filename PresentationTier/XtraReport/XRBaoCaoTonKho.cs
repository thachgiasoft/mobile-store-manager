using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DataTransferObject;

namespace QL_Ban_DienThoai.XtraReport
{
    public partial class XRBaoCaoTonKho : DevExpress.XtraReports.UI.XtraReport
    {
        public XRBaoCaoTonKho(BaoCaoTonKho bc)
        {
            InitializeComponent();
            xlNgayLap.Text = bc.ThoiGian;
            xlNhanVien.Text = Assist.nhanVien.TenNhanVien;
            if (bc.DanhSachSanPham != null)
            {
                int cellsInRow = 5;
                int rowsCount = bc.DanhSachSanPham.Rows.Count;
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
                            cell.Text = "  " + bc.DanhSachSanPham.Rows[i].ItemArray[j - 1].ToString();

                        //chinh lai kich thuoc cua moi o
                        switch (j)
                        {
                            case 0:
                                cell.WidthF = 35;
                                break;
                            case 1:
                                cell.WidthF = 120;
                                break;
                            case 2:
                                cell.WidthF = 250;
                                break;
                            case 3:
                                cell.WidthF = 240;
                                break;
                            case 4:
                                cell.WidthF = 85;
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
