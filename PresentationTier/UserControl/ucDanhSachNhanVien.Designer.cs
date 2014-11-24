namespace QL_Ban_DienThoai.UserControl
{
    partial class ucDanhSachNhanVien
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GridNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clGioTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.teSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.deNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.teChucVu = new DevExpress.XtraEditors.TextEdit();
            this.teCMND = new DevExpress.XtraEditors.TextEdit();
            this.teDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.teTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.teMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.sbThem = new DevExpress.XtraEditors.SimpleButton();
            this.sbTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.clSoDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNhanVien.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.GridNhanVien);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(838, 530);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh Sách Nhân Viên";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // GridNhanVien
            // 
            this.GridNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridNhanVien.Location = new System.Drawing.Point(5, 194);
            this.GridNhanVien.MainView = this.gridView1;
            this.GridNhanVien.Name = "GridNhanVien";
            this.GridNhanVien.Size = new System.Drawing.Size(828, 333);
            this.GridNhanVien.TabIndex = 1;
            this.GridNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaNhanVien,
            this.clTenNhanVien,
            this.clCMND,
            this.clGioTinh,
            this.clDiaChi,
            this.clSoDT,
            this.clEmail,
            this.clNgaySinh,
            this.clTaiKhoan,
            this.clGhiChu});
            this.gridView1.GridControl = this.GridNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // clMaNhanVien
            // 
            this.clMaNhanVien.Caption = "Mã nhân viên";
            this.clMaNhanVien.FieldName = "MaNhanVien";
            this.clMaNhanVien.Name = "clMaNhanVien";
            this.clMaNhanVien.Visible = true;
            this.clMaNhanVien.VisibleIndex = 0;
            // 
            // clTenNhanVien
            // 
            this.clTenNhanVien.Caption = "Tên nhân viên";
            this.clTenNhanVien.FieldName = "TenNhanVien";
            this.clTenNhanVien.Name = "clTenNhanVien";
            this.clTenNhanVien.Visible = true;
            this.clTenNhanVien.VisibleIndex = 1;
            // 
            // clCMND
            // 
            this.clCMND.Caption = "CMND";
            this.clCMND.FieldName = "CMND";
            this.clCMND.Name = "clCMND";
            this.clCMND.Visible = true;
            this.clCMND.VisibleIndex = 2;
            // 
            // clGioTinh
            // 
            this.clGioTinh.Caption = "Giới tính";
            this.clGioTinh.FieldName = "GioiTinh";
            this.clGioTinh.Name = "clGioTinh";
            this.clGioTinh.Visible = true;
            this.clGioTinh.VisibleIndex = 3;
            // 
            // clDiaChi
            // 
            this.clDiaChi.Caption = "Địa Chỉ";
            this.clDiaChi.FieldName = "DiaChi";
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.Visible = true;
            this.clDiaChi.VisibleIndex = 4;
            // 
            // clEmail
            // 
            this.clEmail.Caption = "Email";
            this.clEmail.FieldName = "Email";
            this.clEmail.Name = "clEmail";
            this.clEmail.Visible = true;
            this.clEmail.VisibleIndex = 5;
            // 
            // clTaiKhoan
            // 
            this.clTaiKhoan.Caption = "Tài khoản";
            this.clTaiKhoan.FieldName = "TaiKhoan";
            this.clTaiKhoan.Name = "clTaiKhoan";
            this.clTaiKhoan.Visible = true;
            this.clTaiKhoan.VisibleIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.teSoDienThoai);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.deNgaySinh);
            this.groupBox1.Controls.Add(this.teChucVu);
            this.groupBox1.Controls.Add(this.teCMND);
            this.groupBox1.Controls.Add(this.teDiaChi);
            this.groupBox1.Controls.Add(this.teTenNhanVien);
            this.groupBox1.Controls.Add(this.teMaNhanVien);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(260, 55);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 17);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "CMND";
            // 
            // teSoDienThoai
            // 
            this.teSoDienThoai.Location = new System.Drawing.Point(343, 82);
            this.teSoDienThoai.Name = "teSoDienThoai";
            this.teSoDienThoai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teSoDienThoai.Properties.Appearance.Options.UseFont = true;
            this.teSoDienThoai.Size = new System.Drawing.Size(164, 24);
            this.teSoDienThoai.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(7, 115);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 17);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Chức vụ";
            // 
            // deNgaySinh
            // 
            this.deNgaySinh.EditValue = null;
            this.deNgaySinh.Location = new System.Drawing.Point(100, 52);
            this.deNgaySinh.Name = "deNgaySinh";
            this.deNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.deNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySinh.Size = new System.Drawing.Size(140, 24);
            this.deNgaySinh.TabIndex = 12;
            // 
            // teChucVu
            // 
            this.teChucVu.Location = new System.Drawing.Point(100, 112);
            this.teChucVu.Name = "teChucVu";
            this.teChucVu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teChucVu.Properties.Appearance.Options.UseFont = true;
            this.teChucVu.Size = new System.Drawing.Size(140, 24);
            this.teChucVu.TabIndex = 11;
            // 
            // teCMND
            // 
            this.teCMND.Location = new System.Drawing.Point(343, 54);
            this.teCMND.Name = "teCMND";
            this.teCMND.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCMND.Properties.Appearance.Options.UseFont = true;
            this.teCMND.Size = new System.Drawing.Size(164, 24);
            this.teCMND.TabIndex = 10;
            // 
            // teDiaChi
            // 
            this.teDiaChi.Location = new System.Drawing.Point(100, 82);
            this.teDiaChi.Name = "teDiaChi";
            this.teDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teDiaChi.Properties.Appearance.Options.UseFont = true;
            this.teDiaChi.Size = new System.Drawing.Size(140, 24);
            this.teDiaChi.TabIndex = 9;
            // 
            // teTenNhanVien
            // 
            this.teTenNhanVien.Location = new System.Drawing.Point(343, 24);
            this.teTenNhanVien.Name = "teTenNhanVien";
            this.teTenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.teTenNhanVien.Size = new System.Drawing.Size(164, 24);
            this.teTenNhanVien.TabIndex = 8;
            // 
            // teMaNhanVien
            // 
            this.teMaNhanVien.Location = new System.Drawing.Point(100, 24);
            this.teMaNhanVien.Name = "teMaNhanVien";
            this.teMaNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaNhanVien.Properties.Appearance.Options.UseFont = true;
            this.teMaNhanVien.Size = new System.Drawing.Size(140, 24);
            this.teMaNhanVien.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(6, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 17);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Ngày sinh";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(260, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 17);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(7, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(257, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên nhân viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.sbXoa);
            this.groupBox2.Controls.Add(this.sbCapNhat);
            this.groupBox2.Controls.Add(this.sbThem);
            this.groupBox2.Controls.Add(this.sbTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(513, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // sbXoa
            // 
            this.sbXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoa.Appearance.Options.UseFont = true;
            this.sbXoa.Location = new System.Drawing.Point(251, 33);
            this.sbXoa.Name = "sbXoa";
            this.sbXoa.Size = new System.Drawing.Size(75, 23);
            this.sbXoa.TabIndex = 3;
            this.sbXoa.Text = "Xóa";
            // 
            // sbCapNhat
            // 
            this.sbCapNhat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCapNhat.Appearance.Options.UseFont = true;
            this.sbCapNhat.Location = new System.Drawing.Point(170, 33);
            this.sbCapNhat.Name = "sbCapNhat";
            this.sbCapNhat.Size = new System.Drawing.Size(75, 23);
            this.sbCapNhat.TabIndex = 2;
            this.sbCapNhat.Text = "Cập Nhật";
            // 
            // sbThem
            // 
            this.sbThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThem.Appearance.Options.UseFont = true;
            this.sbThem.Location = new System.Drawing.Point(89, 33);
            this.sbThem.Name = "sbThem";
            this.sbThem.Size = new System.Drawing.Size(75, 23);
            this.sbThem.TabIndex = 1;
            this.sbThem.Text = "Thêm";
            // 
            // sbTimKiem
            // 
            this.sbTimKiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiem.Appearance.Options.UseFont = true;
            this.sbTimKiem.Location = new System.Drawing.Point(8, 33);
            this.sbTimKiem.Name = "sbTimKiem";
            this.sbTimKiem.Size = new System.Drawing.Size(75, 23);
            this.sbTimKiem.TabIndex = 0;
            this.sbTimKiem.Text = "Tìm Kiếm";
            // 
            // clSoDT
            // 
            this.clSoDT.Caption = "SoDienThoai";
            this.clSoDT.FieldName = "SoDienThoai";
            this.clSoDT.Name = "clSoDT";
            this.clSoDT.Visible = true;
            this.clSoDT.VisibleIndex = 7;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.Caption = "Ngày sinh";
            this.clNgaySinh.FieldName = "NgaySinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.Visible = true;
            this.clNgaySinh.VisibleIndex = 8;
            // 
            // clGhiChu
            // 
            this.clGhiChu.Caption = "Ghi Chú";
            this.clGhiChu.FieldName = "GhiChu";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.Visible = true;
            this.clGhiChu.VisibleIndex = 11;
            // 
            // ucDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucDanhSachNhanVien";
            this.Size = new System.Drawing.Size(838, 530);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNhanVien.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GridNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit teChucVu;
        private DevExpress.XtraEditors.TextEdit teCMND;
        private DevExpress.XtraEditors.TextEdit teDiaChi;
        private DevExpress.XtraEditors.TextEdit teTenNhanVien;
        private DevExpress.XtraEditors.TextEdit teMaNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbXoa;
        private DevExpress.XtraEditors.SimpleButton sbCapNhat;
        private DevExpress.XtraEditors.SimpleButton sbThem;
        private DevExpress.XtraEditors.SimpleButton sbTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit teSoDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit deNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn clMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn clCMND;
        private DevExpress.XtraGrid.Columns.GridColumn clGioTinh;
        private DevExpress.XtraGrid.Columns.GridColumn clDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn clEmail;
        private DevExpress.XtraGrid.Columns.GridColumn clTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn clSoDT;
        private DevExpress.XtraGrid.Columns.GridColumn clNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn clGhiChu;
    }
}
