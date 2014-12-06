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
using System.Collections;
namespace QL_Ban_DienThoai.UserControl
{
    public partial class ucHoaDonDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private NhaCungCapBLT _NhaCungCapBLT;
        private MatHangBLT _MatHangBLT;
        Hashtable htNhaCungCap;
        int QuyDinhSoSanPhamToiThieu;
        int leftselection;
        int rightselection;
        float tongtien;
        public ucHoaDonDatHang()
        {
            InitializeComponent();
            _NhaCungCapBLT = new NhaCungCapBLT();
            _MatHangBLT = new MatHangBLT();
            QuyDinhSoSanPhamToiThieu = 1000;
            leftselection = -1;
            rightselection = -1;
            tongtien = 0;
        }

        private void cbeNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbeNhaCungCap.SelectedItem.ToString() != null)
            {
                string MaNhaCungcap = htNhaCungCap.Keys.OfType<String>().FirstOrDefault(a => htNhaCungCap[a] == cbeNhaCungCap.SelectedItem.ToString());
                gcSanPhamDatHang.DataSource = _MatHangBLT.LayDanhSachTenMatHangTheoNhaCungCap(MaNhaCungcap, QuyDinhSoSanPhamToiThieu);
            }
        }

        private void ucHoaDonDatHang_Load(object sender, EventArgs e)
        {
            DataTable dt = _NhaCungCapBLT.layDanhSachNhaCungCap();
            htNhaCungCap = new Hashtable();
            Object[] cbeNhaCungCapItem = new Object[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbeNhaCungCapItem[i] = dt.Rows[i].ItemArray[0];
                htNhaCungCap.Add(dt.Rows[i].ItemArray[1], dt.Rows[i].ItemArray[0]);
            }
            cbeNhaCungCap.Properties.Items.Clear();
            cbeNhaCungCap.Properties.Items.AddRange(cbeNhaCungCapItem);
            cbeNhaCungCap.SelectedIndex = 0;

            if (cbeNhaCungCap.SelectedItem.ToString() != null)
            {
                string MaNhaCungcap = htNhaCungCap.Keys.OfType<String>().FirstOrDefault(a => htNhaCungCap[a] == cbeNhaCungCap.SelectedItem.ToString());
                gcSanPhamDatHang.DataSource = _MatHangBLT.LayDanhSachTenMatHangTheoNhaCungCap(MaNhaCungcap, QuyDinhSoSanPhamToiThieu);
            }

            deNgayDatHang.EditValue = DateTime.Now;
            deNgayGiaoHang.EditValue = DateTime.Now;
        }

        private void sbThem_Click(object sender, EventArgs e)
        {
            if (leftselection != -1)
            {
                DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
                DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;
                if (dtgr2 != null)
                {
                    bool isAddable = true;
                    for (int i = 0; i < dtgr2.Rows.Count; i++)
                    {
                        if (dtgr2.Rows[i].ItemArray[0] == dtgr3.Rows[leftselection].ItemArray[0])
                        {
                            isAddable = false;
                            dtgr2.Rows[i][1] = teSoLuong.Text;
                            dtgr2.Rows[i][2] = int.Parse(teSoLuong.Text) * float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString());
                            break;
                        }
                    }
                    if (isAddable)
                    {
                        dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, int.Parse(teSoLuong.Text) * float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString()));
                    }
                }
                else 
                {
                    dtgr2 = new DataTable();
                    dtgr2.Columns.Add("Tên hàng hóa", typeof(string));
                    dtgr2.Columns.Add("Số Lượng Đặt", typeof(string));
                    dtgr2.Columns.Add("Tổng Tiền", typeof(string));
                    dtgr2.Rows.Add(dtgr3.Rows[leftselection].ItemArray[0], teSoLuong.Text, int.Parse(teSoLuong.Text) * float.Parse(dtgr3.Rows[leftselection].ItemArray[1].ToString()));
                }
                gcSanPhamTrongHoaDon.DataSource = dtgr2;
                tongtien = 0;
                for (int i = 0; i < dtgr2.Rows.Count; i++) 
                {
                    tongtien += float.Parse(dtgr2.Rows[i].ItemArray[2].ToString());
                }
                lcTongTien.Text = "Tổng Tiền: " + tongtien + " VND";
            }
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            leftselection = gridView3.GetSelectedRows()[0];
            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;
            if (dtgr2 != null)
            {
                for (int i = 0; i < dtgr2.Rows.Count; i++)
                {
                    if( dtgr2.Rows[i].ItemArray[0]== dtgr3.Rows[leftselection].ItemArray[0])
                        gridView2.FocusedRowHandle = i;
                }
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            rightselection = gridView2.GetSelectedRows()[0];
            DataTable dtgr3 = gcSanPhamDatHang.DataSource as DataTable;
            DataTable dtgr2 = gcSanPhamTrongHoaDon.DataSource as DataTable;
            if (dtgr3 != null)
            {
                for (int i = 0; i < dtgr3.Rows.Count; i++)
                {
                    if (dtgr2.Rows[rightselection].ItemArray[0] == dtgr3.Rows[i].ItemArray[0])
                    {
                        gridView3.FocusedRowHandle = i;
                    }
                }
            }
        }

        private void gcSanPhamDatHang_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int soluonghientai = int.Parse(teSoLuong.Text);
            soluonghientai++;
            if (soluonghientai < 1)
                soluonghientai = 1;
            teSoLuong.Text = soluonghientai.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            int soluonghientai = int.Parse(teSoLuong.Text);
            soluonghientai--;
            if (soluonghientai < 1)
                soluonghientai = 1;
            teSoLuong.Text = soluonghientai.ToString();
        }

        private void teSoLuong_TextChanged(object sender, EventArgs e)
        {
            int soluonghientai = int.Parse(teSoLuong.Text);
            if (soluonghientai < 1)
                soluonghientai = 1;
            teSoLuong.Text = soluonghientai.ToString();
        }

        private void sbLamMoi_Click(object sender, EventArgs e)
        {
            teSoLuong.Text = "1";
            gcSanPhamTrongHoaDon.DataSource = new DataTable();
        }

        private void sbXoa_Click(object sender, EventArgs e)
        {
            if (rightselection >= 0)
            {
                DataTable dt = gcSanPhamTrongHoaDon.DataSource as DataTable;
                dt.Rows.RemoveAt(rightselection);
                rightselection--;
                gcSanPhamTrongHoaDon.DataSource = dt;
                if (gcSanPhamTrongHoaDon.CanFocus)
                     gcSanPhamTrongHoaDon.Focus();
                tongtien = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tongtien += float.Parse(dt.Rows[i].ItemArray[2].ToString());
                }
                lcTongTien.Text = "Tổng Tiền: " + tongtien + " VND";
            }
        }

        private void deNgayDatHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void deNgayGiaoHang_TextChanged(object sender, EventArgs e)
        {

            if (DateTime.Compare(deNgayDatHang.DateTime, deNgayGiaoHang.DateTime) > 0)
            {
                deNgayGiaoHang.EditValue = DateTime.Now;
            }
        }

        private void deNgayGiaoHang_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void sbLuu_Click(object sender, EventArgs e)
        {
           
        }
    }
}
