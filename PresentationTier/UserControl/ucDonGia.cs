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
    public partial class ucDonGia : DevExpress.XtraEditors.XtraUserControl
    {
        private DonGiaBLT donGiaBLT;
        private DonGia donGia;

        public ucDonGia()
        {
            InitializeComponent();
            this.donGiaBLT = new DonGiaBLT();
            //Lấy ds mau sac
            LoadData();

            //Max length of type text
            this.teMaDonGia.Properties.MaxLength = 15;
            this.teGiaNhap.Properties.MaxLength = 18;
            this.teGiaXuat.Properties.MaxLength = 18;

            //Only type number
            
            this.teGiaNhap.Properties.Mask.EditMask = "n0";
            this.teGiaNhap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teGiaXuat.Properties.Mask.EditMask = "n0";
            this.teGiaXuat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            
        }

        private void LoadData()
        {
            DataTable data = new DataTable();
            data = this.donGiaBLT.LayDanhSachDonGia();
            this.GridDonGia.DataSource = data;//Add data 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount != 0)//Get data
            {
                this.teMaDonGia.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã đơn giá").ToString();
                this.teGiaNhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Giá nhập").ToString();
                this.teGiaXuat.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Giá xuất").ToString();
               

            }
        }

        private void sbThemDonGia_Click(object sender, EventArgs e)
        {
            donGia = new DonGia();

            if (this.teGiaNhap.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống giá nhập");
                return;
            }
            else
            {
                donGia.GiaNhap = Convert.ToDecimal(this.teGiaNhap.Text);

                if (this.teGiaXuat.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống giá xuất");
                    return;
                }
                else
                {
                    donGia.GiaXuat = Convert.ToDecimal(this.teGiaXuat.Text);

                        if (this.donGiaBLT.ThemDonGia(donGia) == true)
                        {
                            MessageBox.Show("Thêm đơn giá thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Thêm đơn giá thất bại", "Thông báo", MessageBoxButtons.OK);
                        }

                        LoadData();
                    
                }
            }
        }

        private void sbCapNhatDonGia_Click(object sender, EventArgs e)
        {
            donGia = new DonGia();

            donGia.MaDonGia = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã đơn giá").ToString();

            if (this.teGiaNhap.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống giá nhập");
                return;
            }

            else
            {
                donGia.GiaNhap = Convert.ToDecimal(this.teGiaNhap.Text);

                if (this.teGiaXuat.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống giá xuất");
                    return;
                }
                else
                {
                    donGia.GiaXuat = Convert.ToDecimal(this.teGiaXuat.Text);

                        String message = "";
                        if (donGiaBLT.CapNhatDonGia(donGia))
                            message += "Cập Nhật thành công";
                        else
                            message += "Cập Nhật lỗi! \nVui lòng kiểm tra lại thông tin trước khi Cập Nhật.";

                        MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);

                        gridView1.FocusedRowHandle = 0;
                        LoadData();
                    }
                }
        }

        private void sbTimKiemDonGia_Click(object sender, EventArgs e)
        {
            donGia = new DonGia();

            donGia.MaDonGia = this.teMaDonGia.Text;
            donGia.GiaNhap = Convert.ToDecimal(this.teGiaNhap.Text);
            donGia.GiaXuat = Convert.ToDecimal(this.teGiaXuat.Text);

            DataTable data = new DataTable();

            data = this.donGiaBLT.TimKiemDonGia(donGia);

            gridView1.FocusedRowHandle = 0;

            this.GridDonGia.DataSource = data;
        }

        private void sbXoaDonGia_Click(object sender, EventArgs e)
        {
            String message = "";
            if (donGiaBLT.XoaDonGia(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã đơn giá").ToString()))
            {
                message += "Xóa thành công";
                gridView1.FocusedRowHandle = 0;
            }

            else
                message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            this.LoadData();
        }
    }
}
