using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frm_PhieuNhapHang : Form
    {
        XuLy dt = new XuLy();
        public frm_PhieuNhapHang()
        {
            InitializeComponent();
        }

        private void frm_PhieuNhapHang_Load(object sender, EventArgs e)
        {
            PhieuNhapHang rpt = new PhieuNhapHang();

            rpt.SetDataSource(dt.Load_DSCTPN(UserControlNhapHang.mapn));

            rpt_nhaphang.ReportSource = rpt;
        }
    }
}
