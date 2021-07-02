namespace QuanLyNhaHang
{
    partial class frm_Home_NhanVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home_NhanVien));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_BanAn = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DoiMatKhau = new System.Windows.Forms.Label();
            this.lbl_ThongTin = new System.Windows.Forms.Label();
            this.lbl_TrangChu = new System.Windows.Forms.Label();
            this.panel_Center = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.Bisque;
            this.btn_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangXuat.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Image")));
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(12, 348);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(233, 65);
            this.btn_DangXuat.TabIndex = 45;
            this.btn_DangXuat.Text = "   ĐĂNG XUẤT";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.BackColor = System.Drawing.Color.Bisque;
            this.btn_KhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KhachHang.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.Image")));
            this.btn_KhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhachHang.Location = new System.Drawing.Point(12, 64);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(233, 65);
            this.btn_KhachHang.TabIndex = 43;
            this.btn_KhachHang.Text = "KHÁCH HÀNG";
            this.btn_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_KhachHang.UseVisualStyleBackColor = false;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_BanAn
            // 
            this.btn_BanAn.BackColor = System.Drawing.Color.Bisque;
            this.btn_BanAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BanAn.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BanAn.Image = ((System.Drawing.Image)(resources.GetObject("btn_BanAn.Image")));
            this.btn_BanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanAn.Location = new System.Drawing.Point(12, 135);
            this.btn_BanAn.Name = "btn_BanAn";
            this.btn_BanAn.Size = new System.Drawing.Size(233, 65);
            this.btn_BanAn.TabIndex = 42;
            this.btn_BanAn.Text = "ĐẶT BÀN";
            this.btn_BanAn.UseVisualStyleBackColor = false;
            this.btn_BanAn.Click += new System.EventHandler(this.btn_BanAn_Click);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.Bisque;
            this.btn_HoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HoaDon.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.Image")));
            this.btn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.Location = new System.Drawing.Point(12, 206);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(233, 65);
            this.btn_HoaDon.TabIndex = 41;
            this.btn_HoaDon.Text = "   HÓA ĐƠN";
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.Bisque;
            this.btn_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThongKe.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.Image")));
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(12, 277);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(233, 65);
            this.btn_ThongKe.TabIndex = 39;
            this.btn_ThongKe.Text = "   THỐNG KÊ";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.lbl_DoiMatKhau);
            this.panel1.Controls.Add(this.lbl_ThongTin);
            this.panel1.Controls.Add(this.lbl_TrangChu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 46);
            this.panel1.TabIndex = 46;
            // 
            // lbl_DoiMatKhau
            // 
            this.lbl_DoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_DoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("lbl_DoiMatKhau.Image")));
            this.lbl_DoiMatKhau.Location = new System.Drawing.Point(131, 7);
            this.lbl_DoiMatKhau.Name = "lbl_DoiMatKhau";
            this.lbl_DoiMatKhau.Size = new System.Drawing.Size(32, 32);
            this.lbl_DoiMatKhau.TabIndex = 37;
            // 
            // lbl_ThongTin
            // 
            this.lbl_ThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ThongTin.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ThongTin.Image")));
            this.lbl_ThongTin.Location = new System.Drawing.Point(65, 7);
            this.lbl_ThongTin.Name = "lbl_ThongTin";
            this.lbl_ThongTin.Size = new System.Drawing.Size(32, 32);
            this.lbl_ThongTin.TabIndex = 36;
            // 
            // lbl_TrangChu
            // 
            this.lbl_TrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("lbl_TrangChu.Image")));
            this.lbl_TrangChu.Location = new System.Drawing.Point(3, 7);
            this.lbl_TrangChu.Name = "lbl_TrangChu";
            this.lbl_TrangChu.Size = new System.Drawing.Size(32, 32);
            this.lbl_TrangChu.TabIndex = 35;
            // 
            // panel_Center
            // 
            this.panel_Center.Controls.Add(this.pictureBox1);
            this.panel_Center.Location = new System.Drawing.Point(265, 64);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(973, 575);
            this.panel_Center.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 261);
            this.label1.TabIndex = 48;
            // 
            // frm_Home_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1250, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Center);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_DangXuat);
            this.Controls.Add(this.btn_KhachHang);
            this.Controls.Add(this.btn_BanAn);
            this.Controls.Add(this.btn_HoaDon);
            this.Controls.Add(this.btn_ThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Home_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TrangChu";
            this.Load += new System.EventHandler(this.frm_TrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Button btn_BanAn;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_DoiMatKhau;
        private System.Windows.Forms.Label lbl_ThongTin;
        private System.Windows.Forms.Label lbl_TrangChu;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}