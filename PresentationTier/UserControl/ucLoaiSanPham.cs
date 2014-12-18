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
using DevExpress.XtraTab;
using DataTransferObject;

namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucLoaiSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private LoaiMatHangBLT loaiMHBLT;
        private LoaiMatHang loaiMH;

        public ucLoaiSanPham()
        {
            InitializeComponent();
            this.loaiMHBLT = new LoaiMatHangBLT();
            //Lấy ds mau sac
            LoadData();

            //Max length of type text
            this.teLoaiMatHang.Properties.MaxLength = 15;
            this.teTenLoaiMatHang.Properties.MaxLength = 100;
            this.teDacDiem.Properties.MaxLength = 100;
            this.teGhiChu.Properties.MaxLength = 200;
        }

        private void LoadData()
        {

            DataTable data = new DataTable();
            data = this.loaiMHBLT.LayDanhSachLoaiMatHang();
            this.GridLoaiMatHang.DataSource = data;//Add data 
        }

        private void sbTimKiem_Click(object sender, EventArgs e)
        {
            loaiMH = new LoaiMatHang();
            loaiMH.MaLoaiMatHang = this.teLoaiMatHang.Text;
            loaiMH.TenLoaiMatHang = this.teTenLoaiMatHang.Text;
            loaiMH.GhiChu = this.teGhiChu.Text;
            loaiMH.DacDiem = this.teDacDiem.Text;

            DataTable data = new DataTable();
            data = this.loaiMHBLT.TimKiemLoaiMatHang(loaiMH);

            gridView1.FocusedRowHandle = 0;

            this.GridLoaiMatHang.DataSource = data; 
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            loaiMH = new LoaiMatHang();

            if (this.teTenLoaiMatHang.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên loại mặt hàng");
                return;
            }
            else
            {
                loaiMH.TenLoaiMatHang = this.teTenLoaiMatHang.Text;

                if (this.teDacDiem.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống Đặc điểm của loại mặt hàng");
                    return;
                }
                else
                {
                    loaiMH.DacDiem = this.teDacDiem.Text;

                    if (this.teGhiChu.Text.Equals(""))
                    {
                        MessageBox.Show("Không được để trống Ghi chú cho loại mặt hàng");
                        return;
                    }
                    else
                    {
                        loaiMH.GhiChu = this.teGhiChu.Text;

                        if (this.loaiMHBLT.ThemLoaiMatHang(loaiMH) == true)
                        {
                            MessageBox.Show("Thêm loại mặt hàng thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Thêm loại mặt hàng thất bại", "Thông báo", MessageBoxButtons.OK);
                        }

                        LoadData();
                    }                  
                }
            }
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            String message = "";
            if (loaiMHBLT.XoaLoaiMatHang(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã loại mặt hàng").ToString()))
            {
                message += "Xóa thành công";
                gridView1.FocusedRowHandle = 0;
            }

            else
                message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            this.LoadData();
        }

        private void sbCapNhat_Click(object sender, EventArgs e)
        {
            loaiMH = new LoaiMatHang();
            loaiMH.MaLoaiMatHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã loại mặt hàng").ToString();

            if (this.teTenLoaiMatHang.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Tên loại mặt hàng");
                return;
            }

            else
            {
                loaiMH.TenLoaiMatHang = this.teTenLoaiMatHang.Text;

                if (this.teDacDiem.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống đặc điểm của loại mặt hàng");
                    return;
                }
                else
                {
                    loaiMH.DacDiem = this.teDacDiem.Text;

                    if (this.teGhiChu.Text.Equals(""))
                    {
                        MessageBox.Show("Không được để trống ghi chú cho loại mặt hàng");
                        return;
                    }
                    else
                    {
                        loaiMH.GhiChu = this.teGhiChu.Text;

                        String message = "";
                        if (loaiMHBLT.CapNhatLoaiMatHang(loaiMH))
                            message += "Cập Nhật thành công";
                        else
                            message += "Cập Nhật lỗi! \nVui lòng kiểm tra lại thông tin trước khi Cập Nhật.";

                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
                        gridView1.FocusedRowHandle = 0;
                        LoadData();
                    }
                   
                }

               
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount != 0)//Get data
            {
                this.teLoaiMatHang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã loại mặt hàng").ToString();
                this.teTenLoaiMatHang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên loại mặt hàng").ToString();
                this.teGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();
                this.teDacDiem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Đặc điểm").ToString();

            }
        }

      
    }
}
