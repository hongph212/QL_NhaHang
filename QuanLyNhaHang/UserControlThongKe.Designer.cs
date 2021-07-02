namespace QuanLyNhaHang
{
    partial class UserControlThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.bt_new = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_dt = new System.Windows.Forms.ComboBox();
            this.cb_tt = new System.Windows.Forms.ComboBox();
            this.cb_tn = new System.Windows.Forms.ComboBox();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_err = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart_DoanhThuNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_MonAn = new System.Windows.Forms.TextBox();
            this.txt_ThongKeNgay = new System.Windows.Forms.TextBox();
            this.txt_NgayLap = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_TKmonan = new System.Windows.Forms.Button();
            this.btn_DTNgay = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_DTNgay = new System.Windows.Forms.Label();
            this.group_DTNgay = new System.Windows.Forms.GroupBox();
            this.group_DTThang = new System.Windows.Forms.GroupBox();
            this.lb_DTThang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThuNam)).BeginInit();
            this.panel17.SuspendLayout();
            this.group_DTNgay.SuspendLayout();
            this.group_DTThang.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_new
            // 
            this.bt_new.BackColor = System.Drawing.Color.LightGreen;
            this.bt_new.Enabled = false;
            this.bt_new.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_new.Location = new System.Drawing.Point(11, 466);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(133, 52);
            this.bt_new.TabIndex = 42;
            this.bt_new.Text = "Làm Lại";
            this.bt_new.UseVisualStyleBackColor = false;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 41;
            this.label6.Text = "Đến Tháng:";
            // 
            // cb_dt
            // 
            this.cb_dt.Enabled = false;
            this.cb_dt.FormattingEnabled = true;
            this.cb_dt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_dt.Location = new System.Drawing.Point(183, 233);
            this.cb_dt.Name = "cb_dt";
            this.cb_dt.Size = new System.Drawing.Size(155, 21);
            this.cb_dt.TabIndex = 40;
            // 
            // cb_tt
            // 
            this.cb_tt.Enabled = false;
            this.cb_tt.FormattingEnabled = true;
            this.cb_tt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_tt.Location = new System.Drawing.Point(254, 181);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(83, 21);
            this.cb_tt.TabIndex = 39;
            // 
            // cb_tn
            // 
            this.cb_tn.Enabled = false;
            this.cb_tn.FormattingEnabled = true;
            this.cb_tn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cb_tn.Location = new System.Drawing.Point(163, 179);
            this.cb_tn.Name = "cb_tn";
            this.cb_tn.Size = new System.Drawing.Size(64, 21);
            this.cb_tn.TabIndex = 38;
            // 
            // cb_thang
            // 
            this.cb_thang.Enabled = false;
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_thang.Location = new System.Drawing.Point(238, 130);
            this.cb_thang.Margin = new System.Windows.Forms.Padding(4);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(80, 21);
            this.cb_thang.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Từ Ngày: ";
            // 
            // lb_err
            // 
            this.lb_err.AutoSize = true;
            this.lb_err.BackColor = System.Drawing.Color.DarkCyan;
            this.lb_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_err.ForeColor = System.Drawing.Color.Red;
            this.lb_err.Location = new System.Drawing.Point(30, 548);
            this.lb_err.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_err.Name = "lb_err";
            this.lb_err.Size = new System.Drawing.Size(24, 16);
            this.lb_err.TabIndex = 34;
            this.lb_err.Text = "err";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LawnGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(2, 532);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(972, 42);
            this.label8.TabIndex = 30;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thống Kê Theo Tháng: ";
            // 
            // chart_DoanhThuNam
            // 
            this.chart_DoanhThuNam.BackColor = System.Drawing.Color.FloralWhite;
            this.chart_DoanhThuNam.BorderlineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.Maximum = 12D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Tháng";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Interval = 1000000D;
            chartArea1.AxisY.Title = "Triệu VNĐ";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chart_DoanhThuNam.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_DoanhThuNam.Legends.Add(legend1);
            this.chart_DoanhThuNam.Location = new System.Drawing.Point(389, 71);
            this.chart_DoanhThuNam.Name = "chart_DoanhThuNam";
            this.chart_DoanhThuNam.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series1.Name = "Tổng tiền";
            series1.XValueMember = "Tháng";
            series1.YValueMembers = "Tổng Tiền";
            this.chart_DoanhThuNam.Series.Add(series1);
            this.chart_DoanhThuNam.Size = new System.Drawing.Size(581, 447);
            this.chart_DoanhThuNam.TabIndex = 44;
            this.chart_DoanhThuNam.Text = "THỐNG KÊ THEO MÓN";
            title1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DarkGreen;
            title1.Name = "Title1";
            title1.Text = "BIỂU ĐỒ DOANH THU THEO NĂM";
            this.chart_DoanhThuNam.Titles.Add(title1);
            // 
            // txt_MonAn
            // 
            this.txt_MonAn.Location = new System.Drawing.Point(7, 304);
            this.txt_MonAn.Name = "txt_MonAn";
            this.txt_MonAn.Size = new System.Drawing.Size(100, 20);
            this.txt_MonAn.TabIndex = 48;
            // 
            // txt_ThongKeNgay
            // 
            this.txt_ThongKeNgay.Enabled = false;
            this.txt_ThongKeNgay.Location = new System.Drawing.Point(7, 356);
            this.txt_ThongKeNgay.Name = "txt_ThongKeNgay";
            this.txt_ThongKeNgay.Size = new System.Drawing.Size(100, 20);
            this.txt_ThongKeNgay.TabIndex = 49;
            // 
            // txt_NgayLap
            // 
            this.txt_NgayLap.Enabled = false;
            this.txt_NgayLap.Location = new System.Drawing.Point(7, 387);
            this.txt_NgayLap.Mask = "00/00/0000";
            this.txt_NgayLap.Name = "txt_NgayLap";
            this.txt_NgayLap.Size = new System.Drawing.Size(152, 20);
            this.txt_NgayLap.TabIndex = 50;
            this.txt_NgayLap.ValidatingType = typeof(System.DateTime);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(220, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 52);
            this.button2.TabIndex = 51;
            this.button2.Text = " Xóa Dữ Liệu";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_TKmonan
            // 
            this.btn_TKmonan.BackColor = System.Drawing.Color.LightGreen;
            this.btn_TKmonan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TKmonan.Location = new System.Drawing.Point(126, 294);
            this.btn_TKmonan.Name = "btn_TKmonan";
            this.btn_TKmonan.Size = new System.Drawing.Size(238, 35);
            this.btn_TKmonan.TabIndex = 52;
            this.btn_TKmonan.Text = "Doanh Thu Theo Món Ăn";
            this.btn_TKmonan.UseVisualStyleBackColor = false;
            // 
            // btn_DTNgay
            // 
            this.btn_DTNgay.BackColor = System.Drawing.Color.LightGreen;
            this.btn_DTNgay.Enabled = false;
            this.btn_DTNgay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DTNgay.Location = new System.Drawing.Point(126, 346);
            this.btn_DTNgay.Name = "btn_DTNgay";
            this.btn_DTNgay.Size = new System.Drawing.Size(238, 35);
            this.btn_DTNgay.TabIndex = 53;
            this.btn_DTNgay.Text = "Doanh Thu Theo Ngày";
            this.btn_DTNgay.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Moccasin;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel17.Controls.Add(this.label9);
            this.panel17.Location = new System.Drawing.Point(11, 5);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(950, 60);
            this.panel17.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(312, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 47);
            this.label9.TabIndex = 0;
            this.label9.Text = "revenue statistics";
            // 
            // lb_DTNgay
            // 
            this.lb_DTNgay.AutoSize = true;
            this.lb_DTNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DTNgay.Location = new System.Drawing.Point(33, 16);
            this.lb_DTNgay.Name = "lb_DTNgay";
            this.lb_DTNgay.Size = new System.Drawing.Size(50, 24);
            this.lb_DTNgay.TabIndex = 55;
            this.lb_DTNgay.Text = "VNĐ";
            // 
            // group_DTNgay
            // 
            this.group_DTNgay.Controls.Add(this.lb_DTNgay);
            this.group_DTNgay.Location = new System.Drawing.Point(11, 71);
            this.group_DTNgay.Name = "group_DTNgay";
            this.group_DTNgay.Size = new System.Drawing.Size(194, 56);
            this.group_DTNgay.TabIndex = 56;
            this.group_DTNgay.TabStop = false;
            this.group_DTNgay.Text = "groupBox1";
            // 
            // group_DTThang
            // 
            this.group_DTThang.Controls.Add(this.lb_DTThang);
            this.group_DTThang.Location = new System.Drawing.Point(211, 71);
            this.group_DTThang.Name = "group_DTThang";
            this.group_DTThang.Size = new System.Drawing.Size(194, 52);
            this.group_DTThang.TabIndex = 57;
            this.group_DTThang.TabStop = false;
            this.group_DTThang.Text = "groupBox1";
            // 
            // lb_DTThang
            // 
            this.lb_DTThang.AutoSize = true;
            this.lb_DTThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DTThang.Location = new System.Drawing.Point(31, 16);
            this.lb_DTThang.Name = "lb_DTThang";
            this.lb_DTThang.Size = new System.Drawing.Size(50, 24);
            this.lb_DTThang.TabIndex = 55;
            this.lb_DTThang.Text = "VNĐ";
            // 
            // UserControlThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.Controls.Add(this.group_DTThang);
            this.Controls.Add(this.group_DTNgay);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.btn_DTNgay);
            this.Controls.Add(this.btn_TKmonan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_NgayLap);
            this.Controls.Add(this.txt_ThongKeNgay);
            this.Controls.Add(this.txt_MonAn);
            this.Controls.Add(this.chart_DoanhThuNam);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_dt);
            this.Controls.Add(this.cb_tt);
            this.Controls.Add(this.cb_tn);
            this.Controls.Add(this.cb_thang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_err);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "UserControlThongKe";
            this.Size = new System.Drawing.Size(973, 575);
            this.Load += new System.EventHandler(this.UserControlThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThuNam)).EndInit();
            this.panel17.ResumeLayout(false);
            this.group_DTNgay.ResumeLayout(false);
            this.group_DTNgay.PerformLayout();
            this.group_DTThang.ResumeLayout(false);
            this.group_DTThang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_dt;
        private System.Windows.Forms.ComboBox cb_tt;
        private System.Windows.Forms.ComboBox cb_tn;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_err;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThuNam;
        private System.Windows.Forms.TextBox txt_MonAn;
        private System.Windows.Forms.TextBox txt_ThongKeNgay;
        private System.Windows.Forms.MaskedTextBox txt_NgayLap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_TKmonan;
        private System.Windows.Forms.Button btn_DTNgay;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_DTNgay;
        private System.Windows.Forms.GroupBox group_DTNgay;
        private System.Windows.Forms.GroupBox group_DTThang;
        private System.Windows.Forms.Label lb_DTThang;
    }
}
