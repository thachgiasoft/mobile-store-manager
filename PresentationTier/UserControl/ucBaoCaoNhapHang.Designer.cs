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
            this.sbChiTietBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.deThang = new DevExpress.XtraEditors.DateEdit();
            this.gcChiTietBaoCao = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietBaoCao = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deThang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThang.Properties)).BeginInit();
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
            this.groupBox2.Controls.Add(this.sbChiTietBaoCao);
            this.groupBox2.Controls.Add(this.deThang);
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
            this.labelControl1.Size = new System.Drawing.Size(43, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tháng: ";
            // 
            // sbChiTietBaoCao
            // 
            this.sbChiTietBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbChiTietBaoCao.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbChiTietBaoCao.Appearance.Options.UseFont = true;
            this.sbChiTietBaoCao.Location = new System.Drawing.Point(818, 17);
            this.sbChiTietBaoCao.Name = "sbChiTietBaoCao";
            this.sbChiTietBaoCao.Size = new System.Drawing.Size(145, 23);
            this.sbChiTietBaoCao.TabIndex = 1;
            this.sbChiTietBaoCao.Text = "Chi Tiết Báo Cáo";
            this.sbChiTietBaoCao.Click += new System.EventHandler(this.sbChiTietBaoCao_Click);
            // 
            // deThang
            // 
            this.deThang.EditValue = null;
            this.deThang.Location = new System.Drawing.Point(55, 20);
            this.deThang.Name = "deThang";
            this.deThang.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deThang.Properties.Appearance.Options.UseFont = true;
            this.deThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThang.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.deThang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deThang.Properties.CalendarTimeProperties.Mask.EditMask = "y";
            this.deThang.Properties.Mask.EditMask = "y";
            this.deThang.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deThang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deThang.Size = new System.Drawing.Size(280, 24);
            this.deThang.TabIndex = 0;
            this.deThang.Popup += new System.EventHandler(this.deThang_Popup);
            this.deThang.TextChanged += new System.EventHandler(this.deThang_TextChanged);
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
            this.gcChiTietBaoCao.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.deThang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbChiTietBaoCao;
        private DevExpress.XtraEditors.DateEdit deThang;
        private DevExpress.XtraGrid.GridControl gcChiTietBaoCao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietBaoCao;
    }
}
