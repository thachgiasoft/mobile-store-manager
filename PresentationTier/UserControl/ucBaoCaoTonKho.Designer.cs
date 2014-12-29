namespace QL_Ban_DienThoai.UserControl
{
    partial class ucBaoCaoTonKho
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
            this.gcBaocaoTonKho = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbChiTietBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.sbLapBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.gcChiTietBaoCao = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietBaoCao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deThoiGianKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDanhSachBaoCao = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachBaoCao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deThoiGianBatDau = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBaocaoTonKho)).BeginInit();
            this.gcBaocaoTonKho.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietBaoCao)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianBatDau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBaocaoTonKho
            // 
            this.gcBaocaoTonKho.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcBaocaoTonKho.AppearanceCaption.Options.UseFont = true;
            this.gcBaocaoTonKho.AppearanceCaption.Options.UseTextOptions = true;
            this.gcBaocaoTonKho.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcBaocaoTonKho.Controls.Add(this.groupBox2);
            this.gcBaocaoTonKho.Controls.Add(this.groupBox3);
            this.gcBaocaoTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBaocaoTonKho.Location = new System.Drawing.Point(0, 0);
            this.gcBaocaoTonKho.Name = "gcBaocaoTonKho";
            this.gcBaocaoTonKho.Size = new System.Drawing.Size(1150, 500);
            this.gcBaocaoTonKho.TabIndex = 0;
            this.gcBaocaoTonKho.Text = "Báo Cáo Tồn Kho";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sbChiTietBaoCao);
            this.groupBox2.Controls.Add(this.sbLapBaoCao);
            this.groupBox2.Controls.Add(this.gcChiTietBaoCao);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(266, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 454);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Tồn Kho";
            // 
            // sbChiTietBaoCao
            // 
            this.sbChiTietBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbChiTietBaoCao.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbChiTietBaoCao.Appearance.Options.UseFont = true;
            this.sbChiTietBaoCao.Location = new System.Drawing.Point(709, 17);
            this.sbChiTietBaoCao.Name = "sbChiTietBaoCao";
            this.sbChiTietBaoCao.Size = new System.Drawing.Size(167, 23);
            this.sbChiTietBaoCao.TabIndex = 4;
            this.sbChiTietBaoCao.Text = "Chi Tiết Báo Cáo Tồn Kho";
            this.sbChiTietBaoCao.Click += new System.EventHandler(this.sbChiTietBaoCao_Click);
            // 
            // sbLapBaoCao
            // 
            this.sbLapBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbLapBaoCao.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLapBaoCao.Appearance.Options.UseFont = true;
            this.sbLapBaoCao.Location = new System.Drawing.Point(498, 17);
            this.sbLapBaoCao.Name = "sbLapBaoCao";
            this.sbLapBaoCao.Size = new System.Drawing.Size(205, 23);
            this.sbLapBaoCao.TabIndex = 3;
            this.sbLapBaoCao.Text = "Lập Báo Cáo Tồn Kho Hôm Nay";
            this.sbLapBaoCao.Click += new System.EventHandler(this.sbLapBaoCao_Click);
            // 
            // gcChiTietBaoCao
            // 
            this.gcChiTietBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcChiTietBaoCao.Location = new System.Drawing.Point(4, 43);
            this.gcChiTietBaoCao.MainView = this.gvChiTietBaoCao;
            this.gcChiTietBaoCao.Name = "gcChiTietBaoCao";
            this.gcChiTietBaoCao.Size = new System.Drawing.Size(875, 406);
            this.gcChiTietBaoCao.TabIndex = 5;
            this.gcChiTietBaoCao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietBaoCao});
            // 
            // gvChiTietBaoCao
            // 
            this.gvChiTietBaoCao.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvChiTietBaoCao.Appearance.Row.Options.UseFont = true;
            this.gvChiTietBaoCao.GridControl = this.gcChiTietBaoCao;
            this.gvChiTietBaoCao.Name = "gvChiTietBaoCao";
            this.gvChiTietBaoCao.OptionsBehavior.Editable = false;
            this.gvChiTietBaoCao.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.deThoiGianKetThuc);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.gcDanhSachBaoCao);
            this.groupBox3.Controls.Add(this.deThoiGianBatDau);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 454);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Báo Cáo Tồn Kho Đã Lập";
            // 
            // deThoiGianKetThuc
            // 
            this.deThoiGianKetThuc.EditValue = null;
            this.deThoiGianKetThuc.Location = new System.Drawing.Point(145, 40);
            this.deThoiGianKetThuc.Name = "deThoiGianKetThuc";
            this.deThoiGianKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deThoiGianKetThuc.Properties.Appearance.Options.UseFont = true;
            this.deThoiGianKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianKetThuc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deThoiGianKetThuc.Size = new System.Drawing.Size(105, 24);
            this.deThoiGianKetThuc.TabIndex = 1;
            this.deThoiGianKetThuc.EditValueChanged += new System.EventHandler(this.deThoiGianKetThuc_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lọc Theo Thời Gian";
            // 
            // gcDanhSachBaoCao
            // 
            this.gcDanhSachBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhSachBaoCao.Location = new System.Drawing.Point(4, 69);
            this.gcDanhSachBaoCao.MainView = this.gvDanhSachBaoCao;
            this.gcDanhSachBaoCao.Name = "gcDanhSachBaoCao";
            this.gcDanhSachBaoCao.Size = new System.Drawing.Size(253, 378);
            this.gcDanhSachBaoCao.TabIndex = 2;
            this.gcDanhSachBaoCao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachBaoCao});
            // 
            // gvDanhSachBaoCao
            // 
            this.gvDanhSachBaoCao.Appearance.FooterPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhSachBaoCao.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDanhSachBaoCao.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhSachBaoCao.Appearance.Row.Options.UseFont = true;
            this.gvDanhSachBaoCao.GridControl = this.gcDanhSachBaoCao;
            this.gvDanhSachBaoCao.Name = "gvDanhSachBaoCao";
            this.gvDanhSachBaoCao.OptionsBehavior.Editable = false;
            this.gvDanhSachBaoCao.OptionsView.ShowGroupPanel = false;
            this.gvDanhSachBaoCao.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDanhSachBaoCao_RowClick);
            // 
            // deThoiGianBatDau
            // 
            this.deThoiGianBatDau.EditValue = null;
            this.deThoiGianBatDau.Location = new System.Drawing.Point(5, 40);
            this.deThoiGianBatDau.Name = "deThoiGianBatDau";
            this.deThoiGianBatDau.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deThoiGianBatDau.Properties.Appearance.Options.UseFont = true;
            this.deThoiGianBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGianBatDau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deThoiGianBatDau.Size = new System.Drawing.Size(105, 24);
            this.deThoiGianBatDau.TabIndex = 0;
            this.deThoiGianBatDau.TextChanged += new System.EventHandler(this.deThoiGianBatDau_TextChanged);
            // 
            // ucBaoCaoTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcBaocaoTonKho);
            this.Name = "ucBaoCaoTonKho";
            this.Size = new System.Drawing.Size(1150, 500);
            this.Load += new System.EventHandler(this.ucBaoCaoTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcBaocaoTonKho)).EndInit();
            this.gcBaocaoTonKho.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietBaoCao)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGianBatDau.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcBaocaoTonKho;
        private DevExpress.XtraGrid.GridControl gcChiTietBaoCao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietBaoCao;
        private DevExpress.XtraEditors.DateEdit deThoiGianBatDau;
        private DevExpress.XtraGrid.GridControl gcDanhSachBaoCao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachBaoCao;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbChiTietBaoCao;
        private DevExpress.XtraEditors.SimpleButton sbLapBaoCao;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.DateEdit deThoiGianKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
