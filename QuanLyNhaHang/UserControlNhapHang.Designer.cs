namespace QuanLyNhaHang
{
    partial class UserControlNhapHang
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grid_CT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInPN = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaPN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuPN = new System.Windows.Forms.Button();
            this.btnTaoPN = new System.Windows.Forms.Button();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grid_CT);
            this.groupBox2.Controls.Add(this.btnInPN);
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.cbbMaSP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbbMaPN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(11, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 325);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // grid_CT
            // 
            this.grid_CT.AllowUserToAddRows = false;
            this.grid_CT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_CT.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.grid_CT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_CT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid_CT.Location = new System.Drawing.Point(24, 107);
            this.grid_CT.Name = "grid_CT";
            this.grid_CT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_CT.Size = new System.Drawing.Size(894, 202);
            this.grid_CT.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPN";
            this.Column1.HeaderText = "Mã Phiếu Nhập";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MASP";
            this.Column2.HeaderText = "Mã Sản Phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DONGIA";
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SOLUONG";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.Name = "Column4";
            // 
            // btnInPN
            // 
            this.btnInPN.BackColor = System.Drawing.Color.Bisque;
            this.btnInPN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPN.Location = new System.Drawing.Point(721, 58);
            this.btnInPN.Name = "btnInPN";
            this.btnInPN.Size = new System.Drawing.Size(197, 27);
            this.btnInPN.TabIndex = 11;
            this.btnInPN.Text = "In phiếu nhập";
            this.btnInPN.UseVisualStyleBackColor = false;
            this.btnInPN.Click += new System.EventHandler(this.btnInPN_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.Bisque;
            this.btnThemSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.Location = new System.Drawing.Point(721, 21);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(197, 29);
            this.btnThemSP.TabIndex = 11;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(503, 59);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(197, 29);
            this.txtSL.TabIndex = 15;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(158, 59);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(197, 29);
            this.txtDonGia.TabIndex = 11;
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(503, 24);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(197, 29);
            this.cbbMaSP.TabIndex = 11;
            this.cbbMaSP.SelectedValueChanged += new System.EventHandler(this.cbbMaSP_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số lượng";
            // 
            // cbbMaPN
            // 
            this.cbbMaPN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaPN.FormattingEnabled = true;
            this.cbbMaPN.Location = new System.Drawing.Point(158, 22);
            this.cbbMaPN.Name = "cbbMaPN";
            this.cbbMaPN.Size = new System.Drawing.Size(197, 29);
            this.cbbMaPN.TabIndex = 11;
            this.cbbMaPN.SelectedIndexChanged += new System.EventHandler(this.cbbMaPN_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã phiếu nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuuPN);
            this.groupBox1.Controls.Add(this.btnTaoPN);
            this.groupBox1.Controls.Add(this.cbbNCC);
            this.groupBox1.Controls.Add(this.txtTT);
            this.groupBox1.Controls.Add(this.txtNgay);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // btnLuuPN
            // 
            this.btnLuuPN.BackColor = System.Drawing.Color.Bisque;
            this.btnLuuPN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPN.Location = new System.Drawing.Point(721, 72);
            this.btnLuuPN.Name = "btnLuuPN";
            this.btnLuuPN.Size = new System.Drawing.Size(197, 31);
            this.btnLuuPN.TabIndex = 10;
            this.btnLuuPN.Text = "Lưu phiếu nhập";
            this.btnLuuPN.UseVisualStyleBackColor = false;
            this.btnLuuPN.Click += new System.EventHandler(this.btnLuuPN_Click);
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.BackColor = System.Drawing.Color.Bisque;
            this.btnTaoPN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPN.Location = new System.Drawing.Point(721, 34);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(197, 29);
            this.btnTaoPN.TabIndex = 9;
            this.btnTaoPN.Text = "Tạo phiếu nhập";
            this.btnTaoPN.UseVisualStyleBackColor = false;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // cbbNCC
            // 
            this.cbbNCC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(503, 34);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(197, 29);
            this.cbbNCC.TabIndex = 8;
            // 
            // txtTT
            // 
            this.txtTT.Enabled = false;
            this.txtTT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTT.Location = new System.Drawing.Point(503, 72);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(197, 29);
            this.txtTT.TabIndex = 7;
            this.txtTT.Text = "0";
            this.txtTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(158, 74);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(197, 29);
            this.txtNgay.TabIndex = 5;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(158, 33);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(197, 29);
            this.txtMaPN.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thành tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel17.Controls.Add(this.label9);
            this.panel17.Location = new System.Drawing.Point(11, 5);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(950, 73);
            this.panel17.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(341, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 47);
            this.label9.TabIndex = 0;
            this.label9.Text = "Import goods";
            // 
            // UserControlNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlNhapHang";
            this.Size = new System.Drawing.Size(971, 573);
            this.Load += new System.EventHandler(this.UserControlNhapHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInPN;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMaPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuuPN;
        private System.Windows.Forms.Button btnTaoPN;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grid_CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
