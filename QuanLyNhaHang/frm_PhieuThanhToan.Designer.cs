namespace QuanLyNhaHang
{
    partial class frm_PhieuThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PhieuThanhToan));
            this.rpt_ThanhToan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.phieuThanhToan1 = new QuanLyNhaHang.PhieuThanhToan();
            this.SuspendLayout();
            // 
            // rpt_ThanhToan
            // 
            this.rpt_ThanhToan.ActiveViewIndex = -1;
            this.rpt_ThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_ThanhToan.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_ThanhToan.Location = new System.Drawing.Point(1, 0);
            this.rpt_ThanhToan.Name = "rpt_ThanhToan";
            this.rpt_ThanhToan.Size = new System.Drawing.Size(1191, 601);
            this.rpt_ThanhToan.TabIndex = 90;
            this.rpt_ThanhToan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_PhieuThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1191, 602);
            this.Controls.Add(this.rpt_ThanhToan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_PhieuThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PhieuThanhToan";
            this.Load += new System.EventHandler(this.frm_PhieuThanhToan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_ThanhToan;
        private PhieuThanhToan phieuThanhToan1;

    }
}