using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DataTransferObject;

namespace QL_Ban_DienThoai.XtraReport
{
    public partial class XRLapBaoCaoBanHang : DevExpress.XtraReports.UI.XtraReport
    {
        public XRLapBaoCaoBanHang(BaoCaoBangHang bc)
        {
            InitializeComponent();

            xlTuNgay.Text = bc.TuNgay;
            xrLDenNgay.Text = bc.DenNgay;
            xrTenNhanVien.Text = bc.TenNhanVien;
            xrlMaNhanVien.Text = bc.MaNhanVien;
            int TongTien = 0;
            if (bc.Data != null)
            {
                int cellsInRow = 5;
                int rowsCount = bc.Data.Rows.Count;
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
                            cell.Text = i.ToString();
                        }
                        else
                        {
                            cell.Text = bc.Data.Rows[i].ItemArray[j - 1].ToString();
                            if (j == 4)
                                TongTien += Convert.ToInt32(bc.Data.Rows[i].ItemArray[j - 1]);
                        }

                        //chinh lai kich thuoc cua moi o
                        switch (j)
                        {
                            case 0:
                                cell.WidthF = 60;
                                break;
                            case 1:
                                cell.WidthF = 195;
                                break;
                            case 2:
                                cell.WidthF = 250;
                                break;
                            case 3:
                                cell.WidthF = 90;
                                break;
                            case 4:
                                cell.WidthF = 200;
                                break;
                        }
                        row.Cells.Add(cell);
                    }
                    xtDanhSachMatHang.Rows.Add(row);
                }
            }

            xrLTongTien.Text = TongTien.ToString();
        }

    }
}
