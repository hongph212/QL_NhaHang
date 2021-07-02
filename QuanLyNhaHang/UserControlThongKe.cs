using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class UserControlThongKe : UserControl
    {
        XuLy dt = new XuLy();

        public UserControlThongKe()
        {
            InitializeComponent();
        }

        private void btn_DTMonAn_Click(object sender, EventArgs e)
        {

        }

        private void UserControlThongKe_Load(object sender, EventArgs e)
        {
            txt_MonAn.Text = dt.ThongKeTheoMonAn();
            txt_MonAn.Enabled = false;

            //Hiển thị text trên groupbox
            group_DTNgay.Text = "Ngày " + DateTime.Now.ToShortDateString();
            group_DTThang.Text = "Tháng" + DateTime.Now.Month;

            //Hiển thị doanh thu trong ngày
            lb_DTNgay.Text = dt.ThongKeTheoNgay(DateTime.Now.ToShortDateString());
            lb_DTThang.Text = dt.ThongKeTheoThang();

            //Hiển thị biểu đồ
            chart_DoanhThuNam.DataSource = dt.ThongKeTheoNam();
            chart_DoanhThuNam.DataBind();
        }

        private void btn_DTNgay_Click(object sender, EventArgs e)
        {
            txt_ThongKeNgay.Text = dt.ThongKeTheoNgay(txt_NgayLap.Text);
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            

        }

    }
}
