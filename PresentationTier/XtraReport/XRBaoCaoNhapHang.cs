using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DataTransferObject;

namespace QL_Ban_DienThoai.XtraReport
{
    public partial class XRBaoCaoNhapHang : DevExpress.XtraReports.UI.XtraReport
    {
        public XRBaoCaoNhapHang(BaoCaoNhapHang bc)
        {
            InitializeComponent();
            xlNgayLap.Text = bc.ThoiGian;

            if (bc.ChiTietBaoCao != null)
            {
                int cellsInRow = 7;
                int rowsCount = bc.ChiTietBaoCao.Rows.Count;
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
                            cell.Text = bc.ChiTietBaoCao.Rows[i].ItemArray[j - 1].ToString();

                        //chinh lai kich thuoc cua moi o
                        switch (j)
                        {
                            case 0:
                                cell.WidthF = 30;
                                break;
                            case 1:
                                cell.WidthF = 110;
                                break;
                            case 2:
                                cell.WidthF = 115;
                                break;
                            case 3:
                                cell.WidthF = 200;
                                break;
                            case 4:
                                cell.WidthF = 190;
                                break;
                            case 5:
                                cell.WidthF = 60;
                                break;
                            case 6:
                                cell.WidthF = 90;
                                cell.Text = ((DateTime)bc.ChiTietBaoCao.Rows[i].ItemArray[j - 1]).ToString("MM/dd/yyyy");
                                break;
                        }
                        cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                        row.Cells.Add(cell);
                    }
                    xtDanhSachMatHang.Rows.Add(row);

                }
            }
        }
    }
}
