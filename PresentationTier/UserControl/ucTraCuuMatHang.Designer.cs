namespace QL_Ban_DienThoai.UserControl
{
    partial class ucTraCuuMatHang
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
            this.sbTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.lueLoaiSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.lueNhaSX = new DevExpress.XtraEditors.LookUpEdit();
            this.teTenSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tcKetQua = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenSanPham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.sbTimKiem);
            this.groupControl1.Controls.Add(this.lueLoaiSanPham);
            this.groupControl1.Controls.Add(this.lueNhaSX);
            this.groupControl1.Controls.Add(this.teTenSanPham);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.tcKetQua);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1001, 603);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Tìm Kiếm Mặt Hàng";
            // 
            // sbTimKiem
            // 
            this.sbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbTimKiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbTimKiem.Appearance.Options.UseFont = true;
            this.sbTimKiem.Location = new System.Drawing.Point(912, 5);
            this.sbTimKiem.Name = "sbTimKiem";
            this.sbTimKiem.Size = new System.Drawing.Size(86, 25);
            this.sbTimKiem.TabIndex = 4;
            this.sbTimKiem.Text = "Tìm Kiếm";
            this.sbTimKiem.Click += new System.EventHandler(this.sbTimKiem_Click);
            // 
            // lueLoaiSanPham
            // 
            this.lueLoaiSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lueLoaiSanPham.Location = new System.Drawing.Point(762, 6);
            this.lueLoaiSanPham.Name = "lueLoaiSanPham";
            this.lueLoaiSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lueLoaiSanPham.Properties.Appearance.Options.UseFont = true;
            this.lueLoaiSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLoaiSanPham.Size = new System.Drawing.Size(147, 24);
            this.lueLoaiSanPham.TabIndex = 3;
            this.lueLoaiSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lueLoaiSanPham_KeyPress);
            // 
            // lueNhaSX
            // 
            this.lueNhaSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lueNhaSX.Location = new System.Drawing.Point(517, 7);
            this.lueNhaSX.Name = "lueNhaSX";
            this.lueNhaSX.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lueNhaSX.Properties.Appearance.Options.UseFont = true;
            this.lueNhaSX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNhaSX.Size = new System.Drawing.Size(147, 24);
            this.lueNhaSX.TabIndex = 2;
            this.lueNhaSX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lueNhaSX_KeyPress);
            // 
            // teTenSanPham
            // 
            this.teTenSanPham.Location = new System.Drawing.Point(94, 6);
            this.teTenSanPham.Name = "teTenSanPham";
            this.teTenSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teTenSanPham.Properties.Appearance.Options.UseFont = true;
            this.teTenSanPham.Size = new System.Drawing.Size(376, 24);
            this.teTenSanPham.TabIndex = 1;
            this.teTenSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teTenSanPham_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(6, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 17);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "Tên Sản Phẩm";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(436, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 17);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Nhà Sản Xuất";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(674, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 17);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Loại Sản Phẩm";
            // 
            // tcKetQua
            // 
            this.tcKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcKetQua.AppearanceItem.Hovered.BackColor = System.Drawing.Color.White;
            this.tcKetQua.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tcKetQua.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tcKetQua.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tcKetQua.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcKetQua.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tcKetQua.AppearanceItem.Normal.Image = global::QL_Ban_DienThoai.Properties.Resources.blackboard;
            this.tcKetQua.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tcKetQua.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tcKetQua.AppearanceItem.Normal.Options.UseFont = true;
            this.tcKetQua.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tcKetQua.AppearanceItem.Normal.Options.UseImage = true;
            this.tcKetQua.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.tcKetQua.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tcKetQua.AppearanceItem.Selected.BackColor = System.Drawing.Color.Transparent;
            this.tcKetQua.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tcKetQua.AppearanceText.BackColor = System.Drawing.Color.Transparent;
            this.tcKetQua.AppearanceText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcKetQua.AppearanceText.Image = global::QL_Ban_DienThoai.Properties.Resources._12_c3_8bits_pixels;
            this.tcKetQua.AppearanceText.Options.UseBackColor = true;
            this.tcKetQua.AppearanceText.Options.UseFont = true;
            this.tcKetQua.AppearanceText.Options.UseImage = true;
            this.tcKetQua.AppearanceText.Options.UseTextOptions = true;
            this.tcKetQua.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.tcKetQua.Groups.Add(this.tileGroup1);
            this.tcKetQua.Location = new System.Drawing.Point(5, 21);
            this.tcKetQua.MaxId = 8;
            this.tcKetQua.Name = "tcKetQua";
            this.tcKetQua.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollBar;
            this.tcKetQua.Size = new System.Drawing.Size(991, 577);
            this.tcKetQua.TabIndex = 5;
            this.tcKetQua.Text = "Kết Quả Tìm Kiếm";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "tileGroup1";
            // 
            // ucTraCuuMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucTraCuuMatHang";
            this.Size = new System.Drawing.Size(1001, 603);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueLoaiSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhaSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTenSanPham.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TileControl tcKetQua;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.LookUpEdit lueLoaiSanPham;
        private DevExpress.XtraEditors.LookUpEdit lueNhaSX;
        private DevExpress.XtraEditors.TextEdit teTenSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbTimKiem;


    }
}
