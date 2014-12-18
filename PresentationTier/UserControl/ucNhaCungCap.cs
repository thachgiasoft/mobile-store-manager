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
    public partial class ucNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        private NhaCungCapBLT nhaCCBLT;
        private NhaCungCap nhaCC;

        public ucNhaCungCap()
        {
            InitializeComponent();
            this.nhaCCBLT = new NhaCungCapBLT();
            //Lấy ds mau sac
            LoadData();

            //Max length of type text
            this.teMaNhaCC.Properties.MaxLength = 15;
            this.teTenNhaCC.Properties.MaxLength = 100;
            this.teDiaChi.Properties.MaxLength = 100;
            this.teSoDienThoai.Properties.MaxLength = 15;
            this.teWeb.Properties.MaxLength = 50;
            //Only type number

            this.teSoDienThoai.Properties.Mask.EditMask = "n0";
            this.teSoDienThoai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        }
        private void LoadData()
        {
            DataTable data = new DataTable();
            data = this.nhaCCBLT.layDanhSachNhaCungCap();
            this.GridCungCap.DataSource = data;//Add data 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount != 0)//Get data
            {
                this.teMaNhaCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã nhà cung cấp").ToString();
                this.teTenNhaCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên nhà cung cấp").ToString();
                this.teDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Địa chỉ").ToString();
                this.teSoDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số điện thoại").ToString();
                this.teWeb.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Website").ToString();

            }
        }

        private void sbTimKiemNhaCC_Click(object sender, EventArgs e)
        {
            nhaCC = new NhaCungCap();

            nhaCC.MaNhaCungCap = this.teMaNhaCC.Text;
            nhaCC.TenNhaCungCap = this.teTenNhaCC.Text;
            nhaCC.DiaChi = this.teDiaChi.Text;

            if (!this.teSoDienThoai.Text.Equals(""))
            {
                nhaCC.SoDienThoai = Convert.ToInt32(this.teSoDienThoai.Text);
            }

            nhaCC.Web = this.teWeb.Text;
            

            DataTable data = new DataTable();

            data = this.nhaCCBLT.TimKiemNhaCungCap(nhaCC);

            gridView1.FocusedRowHandle = 0;

            this.GridCungCap.DataSource = data;
        }

        private void sbXoaNhaCC_Click(object sender, EventArgs e)
        {
            String message = "";
            if (nhaCCBLT.XoaNhaCungCap(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã nhà cung cấp").ToString()))
            {
                message += "Xóa thành công";
                gridView1.FocusedRowHandle = 0;
            }

            else
                message += "Xóa lỗi! \nVui lòng kiểm tra lại thông tin trước khi xóa.";

            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK);
            this.LoadData();
        }

        private void sbThemNhaCC_Click(object sender, EventArgs e)
        {
            nhaCC = new NhaCungCap();

            if (this.teTenNhaCC.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên nhà cung cấp");
                return;
            }
            else
            {
                nhaCC.TenNhaCungCap = this.teTenNhaCC.Text;

                if (this.teDiaChi.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống địa chỉ");
                    return;
                }
                else
                {
                    nhaCC.DiaChi = this.teDiaChi.Text;

                    if (this.teSoDienThoai.Text.Equals(""))
                    {
                        MessageBox.Show("Không được để trống số điện thoại");
                        return;
                    }
                    else
                    {
                        nhaCC.SoDienThoai = Convert.ToInt32(this.teSoDienThoai.Text);

                        if (this.teWeb.Text.Equals(""))
                        {
                            MessageBox.Show("Không được để trống tên trang Web");
                            return;
                        }
                        else
                        {
                            nhaCC.Web = this.teWeb.Text;

                            if (this.nhaCCBLT.ThemNhaCungCap(nhaCC) == true)
                            {
                                MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Thêm nhà cung cấp thất bại", "Thông báo", MessageBoxButtons.OK);
                            }

                            LoadData();
                        }
                    }
                }
            }
        }

        private void sbCapNhatNhaCC_Click(object sender, EventArgs e)
        {
             nhaCC = new NhaCungCap();
             nhaCC.MaNhaCungCap = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã nhà cung cấp").ToString();

            if (this.teTenNhaCC.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên nhà cung cấp");
                return;
            }
            else
            {
                nhaCC.TenNhaCungCap = this.teTenNhaCC.Text;

                if (this.teDiaChi.Text.Equals(""))
                {
                    MessageBox.Show("Không được để trống địa chỉ");
                    return;
                }
                else
                {
                    nhaCC.DiaChi = this.teDiaChi.Text;

                    if (this.teSoDienThoai.Text.Equals(""))
                    {
                        MessageBox.Show("Không được để trống số điện thoại");
                        return;
                    }
                    else
                    {
                         nhaCC.SoDienThoai = Convert.ToInt32(this.teSoDienThoai.Text);

                        if (this.teWeb.Text.Equals(""))
                        {
                            MessageBox.Show("Không được để trống tên trang Web");
                            return;
                        }
                        else
                        {

                            nhaCC.Web= this.teWeb.Text;
                            

                            String message = "";
                            if (nhaCCBLT.CapNhatNhaCungCap(nhaCC))
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
