namespace QuanLyNhaHang
{
    partial class ThongTinDatBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDatBan));
            this.btn_ChonMon = new System.Windows.Forms.Button();
            this.group_MonDaChon = new System.Windows.Forms.GroupBox();
            this.grid_MonDaChon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.SLMon = new System.Windows.Forms.NumericUpDown();
            this.txt_MonDangChon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.group_Food = new System.Windows.Forms.GroupBox();
            this.tree_Food = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_NgayHD = new System.Windows.Forms.TextBox();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_TenBan = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_HuyChonMon = new System.Windows.Forms.Button();
            this.group_MonDaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MonDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLMon)).BeginInit();
            this.group_Food.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ChonMon
            // 
            this.btn_ChonMon.BackColor = System.Drawing.Color.Bisque;
            this.btn_ChonMon.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChonMon.Image")));
            this.btn_ChonMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChonMon.Location = new System.Drawing.Point(412, 499);
            this.btn_ChonMon.Name = "btn_ChonMon";
            this.btn_ChonMon.Size = new System.Drawing.Size(109, 40);
            this.btn_ChonMon.TabIndex = 114;
            this.btn_ChonMon.Text = "Chọn Món";
            this.btn_ChonMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChonMon.UseVisualStyleBackColor = false;
            this.btn_ChonMon.Click += new System.EventHandler(this.btn_ChonMon_Click);
            // 
            // group_MonDaChon
            // 
            this.group_MonDaChon.BackColor = System.Drawing.Color.Bisque;
            this.group_MonDaChon.Controls.Add(this.grid_MonDaChon);
            this.group_MonDaChon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.group_MonDaChon.Location = new System.Drawing.Point(331, 133);
            this.group_MonDaChon.Name = "group_MonDaChon";
            this.group_MonDaChon.Size = new System.Drawing.Size(357, 358);
            this.group_MonDaChon.TabIndex = 113;
            this.group_MonDaChon.TabStop = false;
            this.group_MonDaChon.Text = "Các Món Đã Chọn";
            // 
            // grid_MonDaChon
            // 
            this.grid_MonDaChon.AllowUserToAddRows = false;
            this.grid_MonDaChon.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.grid_MonDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_MonDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaMon,
            this.TenMon,
            this.Column4,
            this.Column5,
            this.Column6});
            this.grid_MonDaChon.Location = new System.Drawing.Point(6, 21);
            this.grid_MonDaChon.Name = "grid_MonDaChon";
            this.grid_MonDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_MonDaChon.Size = new System.Drawing.Size(345, 331);
            this.grid_MonDaChon.TabIndex = 0;
            this.grid_MonDaChon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_MonDaChon_MouseClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Món";
            this.MaMon.Name = "MaMon";
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.Name = "TenMon";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGia";
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoLuong";
            this.Column5.HeaderText = "Số Lượng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TongMon";
            this.Column6.HeaderText = "Tổng Món";
            this.Column6.Name = "Column6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "CHOOSE FOOD YOU LIKE HERE";
            // 
            // SLMon
            // 
            this.SLMon.Location = new System.Drawing.Point(331, 511);
            this.SLMon.Name = "SLMon";
            this.SLMon.Size = new System.Drawing.Size(43, 20);
            this.SLMon.TabIndex = 112;
            // 
            // txt_MonDangChon
            // 
            this.txt_MonDangChon.Location = new System.Drawing.Point(11, 510);
            this.txt_MonDangChon.Multiline = true;
            this.txt_MonDangChon.Name = "txt_MonDangChon";
            this.txt_MonDangChon.Size = new System.Drawing.Size(308, 21);
            this.txt_MonDangChon.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Có thể chọn";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(14, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 109;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(573, 100);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(61, 13);
            this.label58.TabIndex = 108;
            this.label58.Text = "Món đã gọi";
            // 
            // label59
            // 
            this.label59.BackColor = System.Drawing.Color.Orange;
            this.label59.Location = new System.Drawing.Point(547, 96);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(20, 20);
            this.label59.TabIndex = 107;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(379, 100);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(83, 13);
            this.label60.TabIndex = 106;
            this.label60.Text = "Món đang chọn";
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(46, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 69);
            this.label6.TabIndex = 3;
            // 
            // label61
            // 
            this.label61.BackColor = System.Drawing.Color.Aqua;
            this.label61.Location = new System.Drawing.Point(353, 96);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(20, 20);
            this.label61.TabIndex = 105;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Yellow;
            this.label63.Location = new System.Drawing.Point(174, 96);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(20, 20);
            this.label63.TabIndex = 103;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(199, 100);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(47, 13);
            this.label62.TabIndex = 104;
            this.label62.Text = "Hết món";
            // 
            // group_Food
            // 
            this.group_Food.BackColor = System.Drawing.Color.Bisque;
            this.group_Food.Controls.Add(this.tree_Food);
            this.group_Food.ForeColor = System.Drawing.Color.DodgerBlue;
            this.group_Food.Location = new System.Drawing.Point(11, 133);
            this.group_Food.Name = "group_Food";
            this.group_Food.Size = new System.Drawing.Size(308, 358);
            this.group_Food.TabIndex = 99;
            this.group_Food.TabStop = false;
            this.group_Food.Text = "Món ăn";
            // 
            // tree_Food
            // 
            this.tree_Food.BackColor = System.Drawing.Color.FloralWhite;
            this.tree_Food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tree_Food.Location = new System.Drawing.Point(6, 21);
            this.tree_Food.Name = "tree_Food";
            this.tree_Food.Size = new System.Drawing.Size(289, 331);
            this.tree_Food.TabIndex = 0;
            this.tree_Food.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_Food_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(11, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 73);
            this.panel2.TabIndex = 98;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Bisque;
            this.panel5.Controls.Add(this.txt_SDT);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txt_MaKH);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.txt_NgayHD);
            this.panel5.Controls.Add(this.txt_NhanVien);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.txt_TenBan);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Location = new System.Drawing.Point(694, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 358);
            this.panel5.TabIndex = 115;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(100, 145);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(163, 25);
            this.txt_SDT.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Điện thoại: ";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(100, 112);
            this.txt_MaKH.Multiline = true;
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(163, 25);
            this.txt_MaKH.TabIndex = 68;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Mã KH:";
            // 
            // txt_NgayHD
            // 
            this.txt_NgayHD.Location = new System.Drawing.Point(100, 78);
            this.txt_NgayHD.Multiline = true;
            this.txt_NgayHD.Name = "txt_NgayHD";
            this.txt_NgayHD.Size = new System.Drawing.Size(163, 25);
            this.txt_NgayHD.TabIndex = 47;
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Location = new System.Drawing.Point(100, 45);
            this.txt_NhanVien.Multiline = true;
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(163, 25);
            this.txt_NhanVien.TabIndex = 46;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Ngày:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Nhân viên:";
            // 
            // txt_TenBan
            // 
            this.txt_TenBan.Location = new System.Drawing.Point(100, 12);
            this.txt_TenBan.Multiline = true;
            this.txt_TenBan.Name = "txt_TenBan";
            this.txt_TenBan.Size = new System.Drawing.Size(163, 25);
            this.txt_TenBan.TabIndex = 40;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Tên bàn:";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.Bisque;
            this.btn_XacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btn_XacNhan.Image")));
            this.btn_XacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XacNhan.Location = new System.Drawing.Point(862, 499);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(101, 40);
            this.btn_XacNhan.TabIndex = 101;
            this.btn_XacNhan.Text = "Thanh Toán";
            this.btn_XacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_HuyChonMon
            // 
            this.btn_HuyChonMon.BackColor = System.Drawing.Color.Bisque;
            this.btn_HuyChonMon.Image = ((System.Drawing.Image)(resources.GetObject("btn_HuyChonMon.Image")));
            this.btn_HuyChonMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HuyChonMon.Location = new System.Drawing.Point(527, 501);
            this.btn_HuyChonMon.Name = "btn_HuyChonMon";
            this.btn_HuyChonMon.Size = new System.Drawing.Size(109, 40);
            this.btn_HuyChonMon.TabIndex = 116;
            this.btn_HuyChonMon.Text = "Hủy Món";
            this.btn_HuyChonMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_HuyChonMon.UseVisualStyleBackColor = false;
            this.btn_HuyChonMon.Click += new System.EventHandler(this.btn_HuyChonMon_Click);
            // 
            // ThongTinDatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(970, 553);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.btn_HuyChonMon);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_ChonMon);
            this.Controls.Add(this.group_MonDaChon);
            this.Controls.Add(this.SLMon);
            this.Controls.Add(this.txt_MonDangChon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.group_Food);
            this.Controls.Add(this.panel2);
            this.Name = "ThongTinDatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinDatBan";
            this.Load += new System.EventHandler(this.ThongTinDatBan_Load);
            this.group_MonDaChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_MonDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLMon)).EndInit();
            this.group_Food.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChonMon;
        private System.Windows.Forms.GroupBox group_MonDaChon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SLMon;
        private System.Windows.Forms.TextBox txt_MonDangChon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.GroupBox group_Food;
        private System.Windows.Forms.TreeView tree_Food;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_TenBan;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_HuyChonMon;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.DataGridView grid_MonDaChon;
        private System.Windows.Forms.TextBox txt_NgayHD;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}