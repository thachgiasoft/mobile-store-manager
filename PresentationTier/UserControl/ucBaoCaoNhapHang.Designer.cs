namespace QL_Ban_DienThoai.UserControl
{
    partial class ucBaoCaoNhapHang
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
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbInBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.deThoiGian = new DevExpress.XtraEditors.DateEdit();
            this.gcChiTietBaoCao = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietBaoCao = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGian.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl.AppearanceCaption.Options.UseFont = true;
            this.groupControl.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl.Controls.Add(this.groupBox2);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(974, 526);
            this.groupControl.TabIndex = 1;
            this.groupControl.Text = "Báo Cáo Nhập Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.sbInBaoCao);
            this.groupBox2.Controls.Add(this.deThoiGian);
            this.groupBox2.Controls.Add(this.gcChiTietBaoCao);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 480);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Báo Cáo Nhập Hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(6, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Thời gian: ";
            // 
            // sbInBaoCao
            // 
            this.sbInBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbInBaoCao.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbInBaoCao.Appearance.Options.UseFont = true;
            this.sbInBaoCao.Location = new System.Drawing.Point(818, 17);
            this.sbInBaoCao.Name = "sbInBaoCao";
            this.sbInBaoCao.Size = new System.Drawing.Size(145, 23);
            this.sbInBaoCao.TabIndex = 1;
            this.sbInBaoCao.Text = "In Báo Cáo";
            this.sbInBaoCao.Click += new System.EventHandler(this.sbChiTietBaoCao_Click);
            // 
            // deThoiGian
            // 
            this.deThoiGian.EditValue = null;
            this.deThoiGian.Location = new System.Drawing.Point(68, 20);
            this.deThoiGian.Name = "deThoiGian";
            this.deThoiGian.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deThoiGian.Properties.Appearance.Options.UseFont = true;
            this.deThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGian.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.deThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThoiGian.Properties.CalendarTimeProperties.Mask.EditMask = "y";
            this.deThoiGian.Properties.Mask.EditMask = "y";
            this.deThoiGian.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deThoiGian.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deThoiGian.Size = new System.Drawing.Size(280, 24);
            this.deThoiGian.TabIndex = 0;
            this.deThoiGian.Popup += new System.EventHandler(this.deThang_Popup);
            this.deThoiGian.TextChanged += new System.EventHandler(this.deThang_TextChanged);
            // 
            // gcChiTietBaoCao
            // 
            this.gcChiTietBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcChiTietBaoCao.Location = new System.Drawing.Point(3, 47);
            this.gcChiTietBaoCao.MainView = this.gvChiTietBaoCao;
            this.gcChiTietBaoCao.Name = "gcChiTietBaoCao";
            this.gcChiTietBaoCao.Size = new System.Drawing.Size(962, 433);
            this.gcChiTietBaoCao.TabIndex = 2;
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
            // ucBaoCaoNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl);
            this.Name = "ucBaoCaoNhapHang";
            this.Size = new System.Drawing.Size(974, 526);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGian.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbInBaoCao;
        private DevExpress.XtraEditors.DateEdit deThoiGian;
        private DevExpress.XtraGrid.GridControl gcChiTietBaoCao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietBaoCao;
    }
}
