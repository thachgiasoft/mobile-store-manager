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
    public partial class ucNhaSanXuat : DevExpress.XtraEditors.XtraUserControl
    {
        private NhaSanXuatBLT nhaSXBLT;
        private NhaSanXuat nhaSX;

        public ucNhaSanXuat()
        {
            InitializeComponent();
            this.nhaSXBLT = new NhaSanXuatBLT();
            //Lấy ds mau sac
            LoadData();

            //Max length of type text
            this.teMaNhaSX.Properties.MaxLength = 15;
            this.teTenNhaSX.Properties.MaxLength = 100;
            this.teDiaChi.Properties.MaxLength = 200;
            this.teSoDienThoai.Properties.MaxLength = 15;
            this.teEmail.Properties.MaxLength = 100;
            this.teGhiChu.Properties.MaxLength = 200;

            //Only type number
           
            this.teSoDienThoai.Properties.Mask.EditMask = "n0";
            this.teSoDienThoai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            
        }

        private void LoadData()
        {
            DataTable data = new DataTable();
            data = this.nhaSXBLT.LayDanhSachNhaSanXuat();
            this.GridNhaSanXuat.DataSource = data;//Add data 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount != 0)//Get data
            {
                this.teMaNhaSX.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã nhà sản xuất").ToString();
                this.teTenNhaSX.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên nhà sản xuất").ToString();
                this.teDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Địa chỉ").ToString();
                this.teSoDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số điện thoại").ToString();
                this.teEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
                this.teGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ghi chú").ToString();


            }
        }

        private void sbTimKiemNhaSX_Click(object sender, EventArgs e)
        {
            nhaSX = new NhaSanXuat();

            nhaSX.MaNSX = this.teMaNhaSX.Text;
            nhaSX.TenNSX = this.teTenNhaSX.Text;
            nhaSX.DiaChi = this.teDiaChi.Text;
            if (!this.teSoDienThoai.Text.Equals(""))
            {
                nhaSX.SoDienThoai = Convert.ToInt32(this.teSoDienThoai.Text);
            }
            
            nhaSX.Email = this.teEmail.Text;
            nhaSX.GhiChu = this.teGhiChu.Text;

            DataTable data = new DataTable();

            data = this.nhaSXBLT.TimKiemNhaSanXuat(nhaSX);

            gridView1.FocusedRowHandle = 0;

            this.GridNhaSanXuat.DataSource = data;
        }

        private void sbThemNhaSX_Click(object sender, EventArgs e)
        {
            nhaSX = new NhaSanXuat();

            if (this.teTenNhaSX.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên nhà sản xuất");
                return;
            }
            else
            {
                nhaSX.TenNSX = this.teTenNhaSX.Text;

                if (this.teDiaChi.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống địa chỉ");
                    return;
                }
                else
                {
                    nhaSX.DiaChi = this.teDiaChi.Text;

                    if (this.teSoDienThoai.Text.Equals(""))
                    {
                        MessageBox.Show("Không được để trống số điện thoại");
                        return;
                    }
                    else
                    {
                        nhaSX.SoDienThoai = Convert.ToInt32(this.teSoDienThoai.Text);

                        if (this.teEmail.Text.Equals(""))
                        {
                            MessageBox.Show("Không được để trống email");
                            return;
                        }
                        else
                        {
                            nhaSX.Email = this.teEmail.Text;

                            if (this.nhaSXBLT.ThemNhaSanXuat(nhaSX) == true)
                            {
                                MessageBox.Show("Thêm nhà sản xuất thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Thêm nhà sản xuất thất bại", "Thông báo", MessageBoxButtons.OK);
                            }

                            LoadData();
                        }
                    }


                   

                }
            }
        }

        private void sbXoaNhaSX_Click(object sender, EventArgs e)
        {
            String message = "";
            if (nhaSXBLT.XoaNhaSanXuat(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã nhà sản xuất").ToString()))
            {
                message += "Xóa thành công";
                gridView1.FocusedRowHandle = 0;
            }

            else
                message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            this.LoadData();
        }

        private void sbCapNhatNhaSX_Click(object sender, EventArgs e)
        {
            nhaSX = new NhaSanXuat();
            nhaSX.MaNSX = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã nhà sản xuất").ToString();

            if (this.teTenNhaSX.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên nhà sản xuất");
                return;
            }
            else
            {
                nhaSX.TenNSX = this.teTenNhaSX.Text;

                if (this.teDiaChi.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống địa chỉ");
                    return;
                }
                else
                {
                    nhaSX.DiaChi = this.teDiaChi.Text;

                    if (this.teSoDienThoai.Text.Equals(""))
                    {
                        MessageBox.Show("Không được để trống số điện thoại");
                        return;
                    }
                    else
                    {
                         nhaSX.SoDienThoai = Convert.ToInt32(this.teSoDienThoai.Text);

                        if (this.teEmail.Text.Equals(""))
                        {
                            MessageBox.Show("Không được để trống email");
                            return;
                        }
                        else
                        {

                            nhaSX.Email = this.teEmail.Text;
                            nhaSX.GhiChu = this.teGhiChu.Text;

                            String message = "";
                            if (nhaSXBLT.CapNhatNhaSanXuat(nhaSX))
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
        }
    }
}
