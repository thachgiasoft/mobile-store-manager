namespace QL_Ban_DienThoai.UserControl
{
    partial class ucLapPhieuBaoHanh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.meNoiDungBaoHanh = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbeLoaiBaoHanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.teTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.deThoiGianLap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.teTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.teMaKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.teMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.teMaBaoHanh = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbIn = new DevExpress.XtraEditors.SimpleButton();
            this.sbDong = new DevExpress.XtraEditors.SimpleButton();
            this.sbLuu = new DevExpress.XtraEditors.SimpleButton();
            this.sbXoaPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.sbThemPhieu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meNoiDungBaoHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiBaoHanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaBaoHanh.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.groupControl1.Size = new System.Drawing.Size(1092, 611);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Lập Phiếu Bảo Hành";
            // 
            // gcKetQua
            // 
            this.gcKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKetQua.Location = new System.Drawing.Point(5, 227);
            this.gcKetQua.MainView = this.gridView1;
            this.gcKetQua.Name = "gcKetQua";
            this.gcKetQua.Size = new System.Drawing.Size(1082, 381);
            this.gcKetQua.TabIndex = 1;
            this.gcKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcKetQua;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.meNoiDungBaoHanh);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.cbeLoaiBaoHanh);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.teTenKhachHang);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.deThoiGianLap);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.teTenNhanVien);
            this.groupBox1.Controls.Add(this.teMaKhachHang);
            this.groupBox1.Controls.Add(this.teMaNhanVien);
            this.groupBox1.Controls.Add(this.teMaBaoHanh);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu bảo hành";
            // 
            // meNoiDungBaoHanh
            // 
            this.meNoiDungBaoHanh.Location = new System.Drawing.Point(126, 123);
            this.meNoiDungBaoHanh.Name = "meNoiDungBaoHanh";
            this.meNoiDungBaoHanh.Size = new System.Drawing.Size(186, 51);
            this.meNoiDungBaoHanh.TabIndex = 35;
            this.meNoiDungBaoHanh.UseOptimizedRendering = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(6, 123);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 17);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Nội dung bảo hành";
            // 
            // cbeLoaiBaoHanh
            // 
            this.cbeLoaiBaoHanh.Location = new System.Drawing.Point(126, 97);
            this.cbeLoaiBaoHanh.Name = "cbeLoaiBaoHanh";
            this.cbeLoaiBaoHanh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeLoaiBaoHanh.Properties.Appearance.Options.UseFont = true;
            this.cbeLoaiBaoHanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeLoaiBaoHanh.Size = new System.Drawing.Size(186, 24);
            this.cbeLoaiBaoHanh.TabIndex = 17;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(328, 75);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 17);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Tên khách hàng";
            // 
            // teTenKhachHang
            // 
            this.teTenKhachHang.Location = new System.Drawing.Point(425, 72);
            this.teTenKhachHang.Name = "teTenKhachHang";
            this.teTenKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenKhachHang.Properties.Appearance.Options.UseFont = true;
            this.teTenKhachHang.Size = new System.Drawing.Size(188, 24);
            this.teTenKhachHang.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(328, 49);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 17);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Tên nhân viên";
            // 
            // deThoiGianLap
            // 
            this.deThoiGianLap.EditValue = null;
            this.deThoiGianLap.Location = new System.Drawing.Point(425, 20);
            this.deThoiGianLap.Name = "deThoiGianLap";
            this.deThoiGianLap.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deThoiGianLap.Properties.Appearance.Options.UseFont = true;
            this.deThoiGianLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianLap.Size = new System.Drawing.Size(188, 24);
            this.deThoiGianLap.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(328, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 17);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Thời gian lập";
            // 
            // teTenNhanVien
            // 
            this.teTenNhanVien.Location = new System.Drawing.Point(425, 46);
            this.teTenNhanVien.Name = "teTenNhanVien";
            this.teTenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teTenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.teTenNhanVien.Size = new System.Drawing.Size(188, 24);
            this.teTenNhanVien.TabIndex = 11;
            this.teTenNhanVien.EditValueChanged += new System.EventHandler(this.teTenNhanVien_EditValueChanged);
            // 
            // teMaKhachHang
            // 
            this.teMaKhachHang.Location = new System.Drawing.Point(126, 71);
            this.teMaKhachHang.Name = "teMaKhachHang";
            this.teMaKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaKhachHang.Properties.Appearance.Options.UseFont = true;
            this.teMaKhachHang.Size = new System.Drawing.Size(186, 24);
            this.teMaKhachHang.TabIndex = 9;
            // 
            // teMaNhanVien
            // 
            this.teMaNhanVien.Location = new System.Drawing.Point(126, 46);
            this.teMaNhanVien.Name = "teMaNhanVien";
            this.teMaNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaNhanVien.Properties.Appearance.Options.UseFont = true;
            this.teMaNhanVien.Size = new System.Drawing.Size(186, 24);
            this.teMaNhanVien.TabIndex = 8;
            // 
            // teMaBaoHanh
            // 
            this.teMaBaoHanh.Location = new System.Drawing.Point(126, 20);
            this.teMaBaoHanh.Name = "teMaBaoHanh";
            this.teMaBaoHanh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaBaoHanh.Properties.Appearance.Options.UseFont = true;
            this.teMaBaoHanh.Size = new System.Drawing.Size(186, 24);
            this.teMaBaoHanh.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(7, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 17);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Loại bảo hành";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(6, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mã khách hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(7, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mã nhân viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(7, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã bảo hành";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.sbIn);
            this.groupBox2.Controls.Add(this.sbDong);
            this.groupBox2.Controls.Add(this.sbLuu);
            this.groupBox2.Controls.Add(this.sbXoaPhieu);
            this.groupBox2.Controls.Add(this.sbThemPhieu);
            this.groupBox2.Location = new System.Drawing.Point(619, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // sbIn
            // 
            this.sbIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbIn.Appearance.Options.UseFont = true;
            this.sbIn.Location = new System.Drawing.Point(287, 26);
            this.sbIn.Name = "sbIn";
            this.sbIn.Size = new System.Drawing.Size(81, 23);
            this.sbIn.TabIndex = 4;
            this.sbIn.Text = "In";
            // 
            // sbDong
            // 
            this.sbDong.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbDong.Appearance.Options.UseFont = true;
            this.sbDong.Location = new System.Drawing.Point(374, 26);
            this.sbDong.Name = "sbDong";
            this.sbDong.Size = new System.Drawing.Size(83, 23);
            this.sbDong.TabIndex = 3;
            this.sbDong.Text = "Đóng";
            // 
            // sbLuu
            // 
            this.sbLuu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLuu.Appearance.Options.UseFont = true;
            this.sbLuu.Location = new System.Drawing.Point(201, 26);
            this.sbLuu.Name = "sbLuu";
            this.sbLuu.Size = new System.Drawing.Size(80, 23);
            this.sbLuu.TabIndex = 2;
            this.sbLuu.Text = "Lưu";
            // 
            // sbXoaPhieu
            // 
            this.sbXoaPhieu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoaPhieu.Appearance.Options.UseFont = true;
            this.sbXoaPhieu.Location = new System.Drawing.Point(104, 26);
            this.sbXoaPhieu.Name = "sbXoaPhieu";
            this.sbXoaPhieu.Size = new System.Drawing.Size(91, 23);
            this.sbXoaPhieu.TabIndex = 1;
            this.sbXoaPhieu.Text = "Xóa phiếu";
            // 
            // sbThemPhieu
            // 
            this.sbThemPhieu.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThemPhieu.Appearance.Options.UseFont = true;
            this.sbThemPhieu.Location = new System.Drawing.Point(6, 26);
            this.sbThemPhieu.Name = "sbThemPhieu";
            this.sbThemPhieu.Size = new System.Drawing.Size(92, 23);
            this.sbThemPhieu.TabIndex = 0;
            this.sbThemPhieu.Text = "Thêm phiếu";
            // 
            // ucLapPhieuBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucLapPhieuBaoHanh";
            this.Size = new System.Drawing.Size(1092, 611);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meNoiDungBaoHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiBaoHanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaBaoHanh.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeLoaiBaoHanh;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit teTenKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit deThoiGianLap;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit teTenNhanVien;
        private DevExpress.XtraEditors.TextEdit teMaKhachHang;
        private DevExpress.XtraEditors.TextEdit teMaNhanVien;
        private DevExpress.XtraEditors.TextEdit teMaBaoHanh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbDong;
        private DevExpress.XtraEditors.SimpleButton sbLuu;
        private DevExpress.XtraEditors.SimpleButton sbXoaPhieu;
        private DevExpress.XtraEditors.SimpleButton sbThemPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton sbIn;
        private DevExpress.XtraEditors.MemoEdit meNoiDungBaoHanh;
    }
}
