namespace QL_Ban_DienThoai.UserControl
{
    partial class ucDonGia
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvDanhSachMatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDanhSachMatHang = new DevExpress.XtraGrid.GridControl();
            this.sbLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.sbXoa = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gcChiTietDonGia = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietDonGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gcDanhSachNhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachNhaCungCap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sbTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.teTenMatHang = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbLuuDonGia = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.teGiaNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teGiaXuat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sbThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachMatHang)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDonGia)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachNhaCungCap)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenMatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teGiaNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGiaXuat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDanhSachMatHang
            // 
            this.gvDanhSachMatHang.GridControl = this.gcDanhSachMatHang;
            this.gvDanhSachMatHang.Name = "gvDanhSachMatHang";
            this.gvDanhSachMatHang.OptionsBehavior.Editable = false;
            this.gvDanhSachMatHang.OptionsView.ShowGroupPanel = false;
            this.gvDanhSachMatHang.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDanhSachMatHang_RowClick);
            // 
            // gcDanhSachMatHang
            // 
            this.gcDanhSachMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhSachMatHang.Location = new System.Drawing.Point(1, 66);
            this.gcDanhSachMatHang.MainView = this.gvDanhSachMatHang;
            this.gcDanhSachMatHang.Name = "gcDanhSachMatHang";
            this.gcDanhSachMatHang.Size = new System.Drawing.Size(303, 440);
            this.gcDanhSachMatHang.TabIndex = 3;
            this.gcDanhSachMatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachMatHang});
            // 
            // sbLamMoi
            // 
            this.sbLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sbLamMoi.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLamMoi.Appearance.Options.UseFont = true;
            this.sbLamMoi.Location = new System.Drawing.Point(284, 268);
            this.sbLamMoi.Name = "sbLamMoi";
            this.sbLamMoi.Size = new System.Drawing.Size(115, 23);
            this.sbLamMoi.TabIndex = 9;
            this.sbLamMoi.Text = "Làm Mới";
            this.sbLamMoi.Click += new System.EventHandler(this.sbLamMoi_Click);
            // 
            // sbXoa
            // 
            this.sbXoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sbXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoa.Appearance.Options.UseFont = true;
            this.sbXoa.Location = new System.Drawing.Point(284, 205);
            this.sbXoa.Name = "sbXoa";
            this.sbXoa.Size = new System.Drawing.Size(115, 23);
            this.sbXoa.TabIndex = 8;
            this.sbXoa.Text = "Xóa >>";
            this.sbXoa.Click += new System.EventHandler(this.sbXoa_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gcChiTietDonGia);
            this.groupBox4.Location = new System.Drawing.Point(418, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 441);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết nhà cung cấp và đơn giá";
            // 
            // gcChiTietDonGia
            // 
            this.gcChiTietDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcChiTietDonGia.Location = new System.Drawing.Point(6, 19);
            this.gcChiTietDonGia.MainView = this.gvChiTietDonGia;
            this.gcChiTietDonGia.Name = "gcChiTietDonGia";
            this.gcChiTietDonGia.Size = new System.Drawing.Size(408, 416);
            this.gcChiTietDonGia.TabIndex = 10;
            this.gcChiTietDonGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietDonGia});
            // 
            // gvChiTietDonGia
            // 
            this.gvChiTietDonGia.GridControl = this.gcChiTietDonGia;
            this.gvChiTietDonGia.Name = "gvChiTietDonGia";
            this.gvChiTietDonGia.OptionsBehavior.Editable = false;
            this.gvChiTietDonGia.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(4, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(112, 17);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Tìm Kiếm Theo Tên";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.gcDanhSachNhaCungCap);
            this.groupBox3.Location = new System.Drawing.Point(3, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 441);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhà cung cấp";
            // 
            // gcDanhSachNhaCungCap
            // 
            this.gcDanhSachNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhSachNhaCungCap.Location = new System.Drawing.Point(6, 19);
            this.gcDanhSachNhaCungCap.MainView = this.gvDanhSachNhaCungCap;
            this.gcDanhSachNhaCungCap.Name = "gcDanhSachNhaCungCap";
            this.gcDanhSachNhaCungCap.Size = new System.Drawing.Size(254, 416);
            this.gcDanhSachNhaCungCap.TabIndex = 5;
            this.gcDanhSachNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachNhaCungCap});
            // 
            // gvDanhSachNhaCungCap
            // 
            this.gvDanhSachNhaCungCap.GridControl = this.gcDanhSachNhaCungCap;
            this.gvDanhSachNhaCungCap.Name = "gvDanhSachNhaCungCap";
            this.gvDanhSachNhaCungCap.OptionsBehavior.Editable = false;
            this.gvDanhSachNhaCungCap.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sbTimKiem);
            this.groupBox5.Controls.Add(this.teTenMatHang);
            this.groupBox5.Controls.Add(this.labelControl5);
            this.groupBox5.Controls.Add(this.gcDanhSachMatHang);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(4, 40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 532);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh Sách Mặt Hàng";
            // 
            // sbTimKiem
            // 
            this.sbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbTimKiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiem.Appearance.Options.UseFont = true;
            this.sbTimKiem.Location = new System.Drawing.Point(232, 39);
            this.sbTimKiem.Name = "sbTimKiem";
            this.sbTimKiem.Size = new System.Drawing.Size(71, 23);
            this.sbTimKiem.TabIndex = 27;
            this.sbTimKiem.Text = "Tìm Kiếm";
            this.sbTimKiem.Click += new System.EventHandler(this.sbTimKiem_Click);
            // 
            // teTenMatHang
            // 
            this.teTenMatHang.Location = new System.Drawing.Point(3, 39);
            this.teTenMatHang.Name = "teTenMatHang";
            this.teTenMatHang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenMatHang.Properties.Appearance.Options.UseFont = true;
            this.teTenMatHang.Size = new System.Drawing.Size(223, 24);
            this.teTenMatHang.TabIndex = 26;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.groupBox5);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1169, 553);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Quản Lý Đơn Giá";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sbLuuDonGia);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(320, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn giá";
            // 
            // sbLuuDonGia
            // 
            this.sbLuuDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbLuuDonGia.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLuuDonGia.Appearance.Options.UseFont = true;
            this.sbLuuDonGia.Location = new System.Drawing.Point(716, 16);
            this.sbLuuDonGia.Name = "sbLuuDonGia";
            this.sbLuuDonGia.Size = new System.Drawing.Size(122, 23);
            this.sbLuuDonGia.TabIndex = 11;
            this.sbLuuDonGia.Text = "Lưu Đơn Giá";
            this.sbLuuDonGia.Click += new System.EventHandler(this.sbLuuDonGia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.sbLamMoi);
            this.groupBox2.Controls.Add(this.sbXoa);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.sbThem);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 465);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.teGiaNhap);
            this.groupBox6.Controls.Add(this.labelControl1);
            this.groupBox6.Controls.Add(this.teGiaXuat);
            this.groupBox6.Controls.Add(this.labelControl4);
            this.groupBox6.Location = new System.Drawing.Point(272, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(144, 81);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Đơn giá";
            // 
            // teGiaNhap
            // 
            this.teGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teGiaNhap.EditValue = "1";
            this.teGiaNhap.Location = new System.Drawing.Point(35, 21);
            this.teGiaNhap.Name = "teGiaNhap";
            this.teGiaNhap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teGiaNhap.Properties.Appearance.Options.UseFont = true;
            this.teGiaNhap.Properties.Mask.EditMask = "d";
            this.teGiaNhap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teGiaNhap.Properties.MaxLength = 17;
            this.teGiaNhap.Size = new System.Drawing.Size(109, 24);
            this.teGiaNhap.TabIndex = 20;
            this.teGiaNhap.TextChanged += new System.EventHandler(this.teGiaNhap_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(2, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 17);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Nhập";
            // 
            // teGiaXuat
            // 
            this.teGiaXuat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teGiaXuat.EditValue = "1";
            this.teGiaXuat.Location = new System.Drawing.Point(37, 51);
            this.teGiaXuat.Name = "teGiaXuat";
            this.teGiaXuat.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teGiaXuat.Properties.Appearance.Options.UseFont = true;
            this.teGiaXuat.Properties.Mask.EditMask = "d";
            this.teGiaXuat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teGiaXuat.Properties.MaxLength = 17;
            this.teGiaXuat.Size = new System.Drawing.Size(107, 24);
            this.teGiaXuat.TabIndex = 6;
            this.teGiaXuat.EditValueChanged += new System.EventHandler(this.teGiaXuat_EditValueChanged);
            this.teGiaXuat.TextChanged += new System.EventHandler(this.teGiaXuat_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(4, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 17);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Xuất";
            // 
            // sbThem
            // 
            this.sbThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sbThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThem.Appearance.Options.UseFont = true;
            this.sbThem.Location = new System.Drawing.Point(284, 178);
            this.sbThem.Name = "sbThem";
            this.sbThem.Size = new System.Drawing.Size(115, 23);
            this.sbThem.TabIndex = 7;
            this.sbThem.Text = "Thêm >>";
            this.sbThem.Click += new System.EventHandler(this.sbThem_Click);
            // 
            // ucDonGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucDonGia";
            this.Size = new System.Drawing.Size(1169, 553);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachMatHang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDonGia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachNhaCungCap)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenMatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teGiaNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGiaXuat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachMatHang;
        private DevExpress.XtraGrid.GridControl gcDanhSachMatHang;
        private DevExpress.XtraEditors.SimpleButton sbLamMoi;
        private DevExpress.XtraEditors.SimpleButton sbXoa;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gcChiTietDonGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gcDanhSachNhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachNhaCungCap;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.TextEdit teTenMatHang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton sbLuuDonGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit teGiaXuat;
        private DevExpress.XtraEditors.SimpleButton sbThem;
        private DevExpress.XtraEditors.SimpleButton sbTimKiem;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraEditors.TextEdit teGiaNhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;

    }
}
