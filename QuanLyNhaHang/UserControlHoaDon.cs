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
    public partial class UserControlHoaDon : UserControl
    {
        XuLy dt = new XuLy();
        frm_PhieuThanhToan frm;
        string mahd = "";
        public UserControlHoaDon()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            frm = new frm_PhieuThanhToan();

            frm.Visible = true;
        }

        private void Clear()
        {
            txt_SoHD.Text = "";
            cbo_BanAn.Text = "";
            cbo_KhachHang.Text = "";
            cbo_NhanVien.Text = "";
        }
        private void UserControlHoaDon_Load(object sender, EventArgs e)
        {
            if (grid_HoaDon.Rows.Count > 0)
            {
                ((DataTable)grid_HoaDon.DataSource).Rows.Clear();
                grid_HoaDon.DataSource = dt.Load_DSHD();

                contextMenuStrip1.Visible = true;
            }
            else
                grid_HoaDon.DataSource = dt.Load_DSHD();

            
        }

        private void grid_HoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (grid_HoaDon.Rows.Count > 0)
            {
                mahd = dt.LayMaHD(grid_HoaDon.CurrentRow.Cells[3].Value.ToString());
                grid_ChiTietHoaDon.DataSource = dt.Load_DSCTHD(mahd);
                    
                Clear();
                txt_SoHD.Text = grid_HoaDon.CurrentRow.Cells[0].Value.ToString();
                dtp_NgayHD.Value = (DateTime)grid_HoaDon.CurrentRow.Cells[5].Value;
                cbo_BanAn.SelectedText = grid_HoaDon.CurrentRow.Cells[3].Value.ToString();
                cbo_KhachHang.SelectedText = grid_HoaDon.CurrentRow.Cells[2].Value.ToString();
                cbo_NhanVien.SelectedText = grid_HoaDon.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void XemInToolMenuTrip_Click(object sender, EventArgs e)
        {
            frm = new frm_PhieuThanhToan();
            frm.Visible = true;
        }
    }
}
