namespace QL_Ban_DienThoai.UserControl
{
    partial class ucDanhSachKhuyenMai
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
            this.teTenChuongTrinhKhuyenMai = new DevExpress.XtraEditors.MemoEdit();
            this.dateKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.deThoiGianBD = new DevExpress.XtraEditors.DateEdit();
            this.teMaKhuyenMai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbXoaCTKhuyenMai = new DevExpress.XtraEditors.SimpleButton();
            this.sbCapNhatCTKHuyenMai = new DevExpress.XtraEditors.SimpleButton();
            this.sbThemCTKhuyenMai = new DevExpress.XtraEditors.SimpleButton();
            this.sbTimKiemHoaDon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenChuongTrinhKhuyenMai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhuyenMai.Properties)).BeginInit();
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
            this.groupControl1.Size = new System.Drawing.Size(1131, 580);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Danh sách chương trình khuyến mãi";
            // 
            // gcKetQua
            // 
            this.gcKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcKetQua.Location = new System.Drawing.Point(5, 226);
            this.gcKetQua.MainView = this.gridView1;
            this.gcKetQua.Name = "gcKetQua";
            this.gcKetQua.Size = new System.Drawing.Size(1121, 351);
            this.gcKetQua.TabIndex = 1;
            this.gcKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcKetQua.Click += new System.EventHandler(this.gcKetQua_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcKetQua;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.teTenChuongTrinhKhuyenMai);
            this.groupBox1.Controls.Add(this.dateKetThuc);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.deThoiGianBD);
            this.groupBox1.Controls.Add(this.teMaKhuyenMai);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm chương trình khuyên mãi";
            // 
            // teTenChuongTrinhKhuyenMai
            // 
            this.teTenChuongTrinhKhuyenMai.Location = new System.Drawing.Point(194, 56);
            this.teTenChuongTrinhKhuyenMai.Name = "teTenChuongTrinhKhuyenMai";
            this.teTenChuongTrinhKhuyenMai.Properties.MaxLength = 200;
            this.teTenChuongTrinhKhuyenMai.Size = new System.Drawing.Size(417, 29);
            this.teTenChuongTrinhKhuyenMai.TabIndex = 2;
            this.teTenChuongTrinhKhuyenMai.UseOptimizedRendering = true;
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.EditValue = null;
            this.dateKetThuc.Location = new System.Drawing.Point(194, 121);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateKetThuc.Properties.Appearance.Options.UseFont = true;
            this.dateKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.MaxLength = 20;
            this.dateKetThuc.Size = new System.Drawing.Size(280, 24);
            this.dateKetThuc.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(14, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(149, 17);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ngày kết thúc khuyến mãi";
            // 
            // deThoiGianBD
            // 
            this.deThoiGianBD.EditValue = null;
            this.deThoiGianBD.Location = new System.Drawing.Point(194, 92);
            this.deThoiGianBD.Name = "deThoiGianBD";
            this.deThoiGianBD.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deThoiGianBD.Properties.Appearance.Options.UseFont = true;
            this.deThoiGianBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianBD.Properties.MaxLength = 20;
            this.deThoiGianBD.Size = new System.Drawing.Size(280, 24);
            this.deThoiGianBD.TabIndex = 3;
            // 
            // teMaKhuyenMai
            // 
            this.teMaKhuyenMai.EditValue = "";
            this.teMaKhuyenMai.Location = new System.Drawing.Point(194, 26);
            this.teMaKhuyenMai.Name = "teMaKhuyenMai";
            this.teMaKhuyenMai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMaKhuyenMai.Properties.Appearance.Options.UseFont = true;
            this.teMaKhuyenMai.Properties.MaxLength = 15;
            this.teMaKhuyenMai.Size = new System.Drawing.Size(197, 24);
            this.teMaKhuyenMai.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(14, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(149, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ngày bắt đầu khuyến mãi";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(12, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên chương trình khuyến mãi";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã Chương trình khuyến mãi";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.sbXoaCTKhuyenMai);
            this.groupBox2.Controls.Add(this.sbCapNhatCTKHuyenMai);
            this.groupBox2.Controls.Add(this.sbThemCTKhuyenMai);
            this.groupBox2.Controls.Add(this.sbTimKiemHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(661, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // sbXoaCTKhuyenMai
            // 
            this.sbXoaCTKhuyenMai.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbXoaCTKhuyenMai.Appearance.Options.UseFont = true;
            this.sbXoaCTKhuyenMai.Location = new System.Drawing.Point(337, 27);
            this.sbXoaCTKhuyenMai.Name = "sbXoaCTKhuyenMai";
            this.sbXoaCTKhuyenMai.Size = new System.Drawing.Size(105, 23);
            this.sbXoaCTKhuyenMai.TabIndex = 8;
            this.sbXoaCTKhuyenMai.Text = "Xóa";
            this.sbXoaCTKhuyenMai.Click += new System.EventHandler(this.sbXoaCTKhuyenMai_Click);
            // 
            // sbCapNhatCTKHuyenMai
            // 
            this.sbCapNhatCTKHuyenMai.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbCapNhatCTKHuyenMai.Appearance.Options.UseFont = true;
            this.sbCapNhatCTKHuyenMai.Location = new System.Drawing.Point(227, 27);
            this.sbCapNhatCTKHuyenMai.Name = "sbCapNhatCTKHuyenMai";
            this.sbCapNhatCTKHuyenMai.Size = new System.Drawing.Size(104, 23);
            this.sbCapNhatCTKHuyenMai.TabIndex = 7;
            this.sbCapNhatCTKHuyenMai.Text = "Cập nhật";
            this.sbCapNhatCTKHuyenMai.Click += new System.EventHandler(this.sbCapNhatCTKHuyenMai_Click);
            // 
            // sbThemCTKhuyenMai
            // 
            this.sbThemCTKhuyenMai.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbThemCTKhuyenMai.Appearance.Options.UseFont = true;
            this.sbThemCTKhuyenMai.Location = new System.Drawing.Point(116, 26);
            this.sbThemCTKhuyenMai.Name = "sbThemCTKhuyenMai";
            this.sbThemCTKhuyenMai.Size = new System.Drawing.Size(105, 23);
            this.sbThemCTKhuyenMai.TabIndex = 6;
            this.sbThemCTKhuyenMai.Text = "Thêm";
            this.sbThemCTKhuyenMai.Click += new System.EventHandler(this.sbThemCTKhuyenMai_Click);
            // 
            // sbTimKiemHoaDon
            // 
            this.sbTimKiemHoaDon.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiemHoaDon.Appearance.Options.UseFont = true;
            this.sbTimKiemHoaDon.Location = new System.Drawing.Point(6, 26);
            this.sbTimKiemHoaDon.Name = "sbTimKiemHoaDon";
            this.sbTimKiemHoaDon.Size = new System.Drawing.Size(104, 23);
            this.sbTimKiemHoaDon.TabIndex = 5;
            this.sbTimKiemHoaDon.Text = "Tìm kiếm";
            this.sbTimKiemHoaDon.Click += new System.EventHandler(this.sbTimKiemHoaDon_Click);
            // 
            // ucDanhSachKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucDanhSachKhuyenMai";
            this.Size = new System.Drawing.Size(1131, 580);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTenChuongTrinhKhuyenMai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaKhuyenMai.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit deThoiGianBD;
        private DevExpress.XtraEditors.TextEdit teMaKhuyenMai;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbXoaCTKhuyenMai;
        private DevExpress.XtraEditors.SimpleButton sbCapNhatCTKHuyenMai;
        private DevExpress.XtraEditors.SimpleButton sbThemCTKhuyenMai;
        private DevExpress.XtraEditors.SimpleButton sbTimKiemHoaDon;
        private DevExpress.XtraEditors.DateEdit dateKetThuc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit teTenChuongTrinhKhuyenMai;
    }
}
