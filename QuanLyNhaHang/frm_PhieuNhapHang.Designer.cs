namespace QuanLyNhaHang
{
    partial class frm_PhieuNhapHang
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
            this.rpt_nhaphang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpt_nhaphang
            // 
            this.rpt_nhaphang.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.rpt_nhaphang.ActiveViewIndex = -1;
            this.rpt_nhaphang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_nhaphang.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_nhaphang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_nhaphang.Location = new System.Drawing.Point(0, 0);
            this.rpt_nhaphang.Name = "rpt_nhaphang";
            this.rpt_nhaphang.Size = new System.Drawing.Size(1111, 602);
            this.rpt_nhaphang.TabIndex = 0;
            this.rpt_nhaphang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_PhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1111, 602);
            this.Controls.Add(this.rpt_nhaphang);
            this.Name = "frm_PhieuNhapHang";
            this.Text = "frm_PhieuNhapHang";
            this.Load += new System.EventHandler(this.frm_PhieuNhapHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_nhaphang;
    }
}