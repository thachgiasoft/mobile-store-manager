namespace QL_Ban_DienThoai.UserControl
{
    partial class ucThemHinhVaoDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThemHinhVaoDataBase));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.peHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.peTestResult = new DevExpress.XtraEditors.PictureEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peHinhAnh.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peTestResult.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.peHinhAnh);
            this.groupBox4.Location = new System.Drawing.Point(14, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 420);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hình Ảnh";
            // 
            // peHinhAnh
            // 
            this.peHinhAnh.EditValue = ((object)(resources.GetObject("peHinhAnh.EditValue")));
            this.peHinhAnh.Location = new System.Drawing.Point(6, 20);
            this.peHinhAnh.Name = "peHinhAnh";
            this.peHinhAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peHinhAnh.Size = new System.Drawing.Size(273, 394);
            this.peHinhAnh.TabIndex = 0;
            this.peHinhAnh.ToolTip = "Nhấp đúp chuột để thay đổi hình ảnh";
            this.peHinhAnh.DoubleClick += new System.EventHandler(this.peHinhAnh_DoubleClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(305, 27);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 61;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.peTestResult);
            this.groupBox1.Location = new System.Drawing.Point(386, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 420);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ket Hình Ảnh";
            // 
            // peTestResult
            // 
            this.peTestResult.EditValue = ((object)(resources.GetObject("peTestResult.EditValue")));
            this.peTestResult.Location = new System.Drawing.Point(6, 20);
            this.peTestResult.Name = "peTestResult";
            this.peTestResult.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peTestResult.Size = new System.Drawing.Size(273, 394);
            this.peTestResult.TabIndex = 0;
            this.peTestResult.ToolTip = "Nhấp đúp chuột để thay đổi hình ảnh";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucThemHinhVaoDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox4);
            this.Name = "ucThemHinhVaoDataBase";
            this.Size = new System.Drawing.Size(700, 486);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peHinhAnh.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peTestResult.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.PictureEdit peHinhAnh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PictureEdit peTestResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
