namespace QL_Ban_DienThoai.UserControl
{
    partial class ucDanhSachHoaDonBan
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
            this.gcKetQua = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cluMaHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cluTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cluTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cluTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cluDiaChiGiaoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cluNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lueKhuVu = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.teTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.deThoiGianLap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.teTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.teMaKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.teMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.teMaHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.sbLapHangHoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbTimKiemHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.lueTrangThai = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueKhuVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaHoaDon.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.gcKetQua);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1028, 559);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Tìm Kiếm Phiếu Bán Hàng";
            // 
            // gcKetQua
            // 
            this.gcKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKetQua.Location = new System.Drawing.Point(5, 185);
            this.gcKetQua.MainView = this.gridView1;
            this.gcKetQua.Name = "gcKetQua";
            this.gcKetQua.Size = new System.Drawing.Size(1018, 371);
            this.gcKetQua.TabIndex = 1;
            this.gcKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcKetQua.Click += new System.EventHandler(this.gcKetQua_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cluMaHoaDon,
            this.cluTenNhanVien,
            this.cluTenKhachHang,
            this.cluTongTien,
            this.cluDiaChiGiaoHang,
            this.cluNgayLap});
            this.gridView1.GridControl = this.gcKetQua;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // cluMaHoaDon
            // 
            this.cluMaHoaDon.Caption = "Mã hóa đơn bán";
            this.cluMaHoaDon.FieldName = "Mã hóa đơn bán";
            this.cluMaHoaDon.Name = "cluMaHoaDon";
            this.cluMaHoaDon.Visible = true;
            this.cluMaHoaDon.VisibleIndex = 0;
            // 
            // cluTenNhanVien
            // 
            this.cluTenNhanVien.Caption = "Tên nhân viên";
            this.cluTenNhanVien.FieldName = "Tên nhân viên";
            this.cluTenNhanVien.Name = "cluTenNhanVien";
            this.cluTenNhanVien.Visible = true;
            this.cluTenNhanVien.VisibleIndex = 1;
            // 
            // cluTenKhachHang
            // 
            this.cluTenKhachHang.Caption = "Tên khách hàng";
            this.cluTenKhachHang.FieldName = "Tên khách hàng";
            this.cluTenKhachHang.Name = "cluTenKhachHang";
            this.cluTenKhachHang.Visible = true;
            this.cluTenKhachHang.VisibleIndex = 2;
            // 
            // cluTongTien
            // 
            this.cluTongTien.Caption = "Tổng tiền";
            this.cluTongTien.FieldName = "Tổng tiền";
            this.cluTongTien.Name = "cluTongTien";
            this.cluTongTien.Visible = true;
            this.cluTongTien.VisibleIndex = 3;
            // 
            // cluDiaChiGiaoHang
            // 
            this.cluDiaChiGiaoHang.Caption = "Địa chỉ giao hàng";
            this.cluDiaChiGiaoHang.FieldName = "Địa chỉ giao hàng";
            this.cluDiaChiGiaoHang.Name = "cluDiaChiGiaoHang";
            this.cluDiaChiGiaoHang.Visible = true;
            this.cluDiaChiGiaoHang.VisibleIndex = 4;
            // 
            // cluNgayLap
            // 
            this.cluNgayLap.Caption = "Ngày Lập";
            this.cluNgayLap.FieldName = "Ngày Lập";
            this.cluNgayLap.Name = "cluNgayLap";
            this.cluNgayLap.Visible = true;
            this.cluNgayLap.VisibleIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lueTrangThai);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.lueKhuVu);
            this.groupBox1.Controls.Add(this.labelControl13);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.teTenKhachHang);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.deThoiGianLap);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.teTenNhanVien);
            this.groupBox1.Controls.Add(this.teMaKhachHang);
            this.groupBox1.Controls.Add(this.teMaNhanVien);
            this.groupBox1.Controls.Add(this.teMaHoaDon);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu bán hàng";
            // 
            // lueKhuVu
            // 
            this.lueKhuVu.Location = new System.Drawing.Point(133, 110);
            this.lueKhuVu.Name = "lueKhuVu";
            this.lueKhuVu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lueKhuVu.Properties.Appearance.Options.UseFont = true;
            this.lueKhuVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueKhuVu.Properties.DisplayMember = "Tên khu vực";
            this.lueKhuVu.Properties.NullText = "";
            this.lueKhuVu.Properties.ValueMember = "Mã khu vực";
            this.lueKhuVu.Size = new System.Drawing.Size(133, 24);
            this.lueKhuVu.TabIndex = 32;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(32, 113);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(48, 17);
            this.labelControl13.TabIndex = 33;
            this.labelControl13.Text = "Khu Vực";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(281, 55);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 17);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Tên khách hàng";
            // 
            // teTenKhachHang
            // 
            this.teTenKhachHang.Location = new System.Drawing.Point(384, 53);
            this.teTenKhachHang.Name = "teTenKhachHang";
            this.teTenKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenKhachHang.Properties.Appearance.Options.UseFont = true;
            this.teTenKhachHang.Properties.MaxLength = 50;
            this.teTenKhachHang.Size = new System.Drawing.Size(241, 24);
            this.teTenKhachHang.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(281, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 17);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Tên nhân viên";
            // 
            // deThoiGianLap
            // 
            this.deThoiGianLap.EditValue = null;
            this.deThoiGianLap.Location = new System.Drawing.Point(384, 23);
            this.deThoiGianLap.Name = "deThoiGianLap";
            this.deThoiGianLap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deThoiGianLap.Properties.Appearance.Options.UseFont = true;
            this.deThoiGianLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianLap.Properties.MaxLength = 20;
            this.deThoiGianLap.Size = new System.Drawing.Size(241, 24);
            this.deThoiGianLap.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(281, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 17);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Thời gian lập";
            // 
            // teTenNhanVien
            // 
            this.teTenNhanVien.Location = new System.Drawing.Point(384, 82);
            this.teTenNhanVien.Name = "teTenNhanVien";
            this.teTenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.teTenNhanVien.Properties.MaxLength = 50;
            this.teTenNhanVien.Size = new System.Drawing.Size(241, 24);
            this.teTenNhanVien.TabIndex = 8;
            // 
            // teMaKhachHang
            // 
            this.teMaKhachHang.Location = new System.Drawing.Point(133, 82);
            this.teMaKhachHang.Name = "teMaKhachHang";
            this.teMaKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaKhachHang.Properties.Appearance.Options.UseFont = true;
            this.teMaKhachHang.Properties.MaxLength = 10;
            this.teMaKhachHang.Size = new System.Drawing.Size(133, 24);
            this.teMaKhachHang.TabIndex = 7;
            // 
            // teMaNhanVien
            // 
            this.teMaNhanVien.Location = new System.Drawing.Point(133, 53);
            this.teMaNhanVien.Name = "teMaNhanVien";
            this.teMaNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaNhanVien.Properties.Appearance.Options.UseFont = true;
            this.teMaNhanVien.Properties.MaxLength = 10;
            this.teMaNhanVien.Size = new System.Drawing.Size(133, 24);
            this.teMaNhanVien.TabIndex = 5;
            // 
            // teMaHoaDon
            // 
            this.teMaHoaDon.EditValue = "";
            this.teMaHoaDon.Location = new System.Drawing.Point(133, 23);
            this.teMaHoaDon.Name = "teMaHoaDon";
            this.teMaHoaDon.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaHoaDon.Properties.Appearance.Options.UseFont = true;
            this.teMaHoaDon.Properties.MaxLength = 10;
            this.teMaHoaDon.Size = new System.Drawing.Size(133, 24);
            this.teMaHoaDon.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(32, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mã khách hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(32, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mã nhân viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(32, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.sbXoa);
            this.groupBox2.Controls.Add(this.sbCapNhat);
            this.groupBox2.Controls.Add(this.sbLapHangHoa);
            this.groupBox2.Controls.Add(this.sbTimKiemHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(649, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // sbXoa
            // 
            this.sbXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoa.Appearance.Options.UseFont = true;
            this.sbXoa.Location = new System.Drawing.Point(154, 59);
            this.sbXoa.Name = "sbXoa";
            this.sbXoa.Size = new System.Drawing.Size(105, 23);
            this.sbXoa.TabIndex = 12;
            this.sbXoa.Text = "Xóa phiếu";
            this.sbXoa.Click += new System.EventHandler(this.sbXoa_Click);
            // 
            // sbCapNhat
            // 
            this.sbCapNhat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCapNhat.Appearance.Options.UseFont = true;
            this.sbCapNhat.Location = new System.Drawing.Point(24, 59);
            this.sbCapNhat.Name = "sbCapNhat";
            this.sbCapNhat.Size = new System.Drawing.Size(104, 23);
            this.sbCapNhat.TabIndex = 11;
            this.sbCapNhat.Text = "Cập nhật phiếu";
            this.sbCapNhat.Click += new System.EventHandler(this.sbCapNhat_Click);
            // 
            // sbLapHangHoa
            // 
            this.sbLapHangHoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLapHangHoa.Appearance.Options.UseFont = true;
            this.sbLapHangHoa.Location = new System.Drawing.Point(152, 26);
            this.sbLapHangHoa.Name = "sbLapHangHoa";
            this.sbLapHangHoa.Size = new System.Drawing.Size(105, 23);
            this.sbLapHangHoa.TabIndex = 10;
            this.sbLapHangHoa.Text = "Lập phiếu";
            this.sbLapHangHoa.Click += new System.EventHandler(this.sbLapHangHoa_Click);
            // 
            // sbTimKiemHoaDon
            // 
            this.sbTimKiemHoaDon.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiemHoaDon.Appearance.Options.UseFont = true;
            this.sbTimKiemHoaDon.Location = new System.Drawing.Point(24, 26);
            this.sbTimKiemHoaDon.Name = "sbTimKiemHoaDon";
            this.sbTimKiemHoaDon.Size = new System.Drawing.Size(104, 23);
            this.sbTimKiemHoaDon.TabIndex = 9;
            this.sbTimKiemHoaDon.Text = "Tìm kiếm";
            this.sbTimKiemHoaDon.Click += new System.EventHandler(this.sbTimKiemHoaDon_Click);
            // 
            // lueTrangThai
            // 
            this.lueTrangThai.Location = new System.Drawing.Point(384, 110);
            this.lueTrangThai.Name = "lueTrangThai";
            this.lueTrangThai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lueTrangThai.Properties.Appearance.Options.UseFont = true;
            this.lueTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTrangThai.Properties.DisplayMember = "Tên trạng thái";
            this.lueTrangThai.Properties.NullText = "";
            this.lueTrangThai.Properties.ValueMember = "Mã trạng thái";
            this.lueTrangThai.Size = new System.Drawing.Size(146, 24);
            this.lueTrangThai.TabIndex = 27;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(281, 113);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(62, 17);
            this.labelControl10.TabIndex = 28;
            this.labelControl10.Text = "Trạng Thái";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.Location = new System.Drawing.Point(280, 26);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 23);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm nới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // ucDanhSachHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucDanhSachHoaDonBan";
            this.Size = new System.Drawing.Size(1028, 559);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueKhuVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaHoaDon.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueTrangThai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit teTenKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit deThoiGianLap;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit teTenNhanVien;
        private DevExpress.XtraEditors.TextEdit teMaKhachHang;
        private DevExpress.XtraEditors.TextEdit teMaNhanVien;
        private DevExpress.XtraEditors.TextEdit teMaHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbXoa;
        private DevExpress.XtraEditors.SimpleButton sbCapNhat;
        private DevExpress.XtraEditors.SimpleButton sbLapHangHoa;
        private DevExpress.XtraEditors.SimpleButton sbTimKiemHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn cluMaHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn cluTenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn cluTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn cluTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn cluDiaChiGiaoHang;
        private DevExpress.XtraGrid.Columns.GridColumn cluNgayLap;
        private DevExpress.XtraEditors.LookUpEdit lueKhuVu;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LookUpEdit lueTrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;

    }
}
