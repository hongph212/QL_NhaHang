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
    public partial class UserControlNhapHang : UserControl
    {
        XuLy dt = new XuLy();
        Form frm;

        public static string mapn = "";

        public UserControlNhapHang()
        {
            InitializeComponent();
        }

        private void UserControlNhapHang_Load(object sender, EventArgs e)
        {
            cbbNCC.DataSource = dt.loadNCC();
            cbbNCC.DisplayMember = "TENNCC";
            cbbNCC.ValueMember = "MANCC";

            cbbMaSP.DataSource = dt.loadSP();
            cbbMaSP.DisplayMember = "TENSP";
            cbbMaSP.ValueMember = "MASP";

            cbbMaPN.DataSource = dt.Load_DSPN();
            cbbMaPN.DisplayMember = "MAPN";
            cbbMaPN.ValueMember = "MAPN";

            mapn = cbbMaPN.Text;

            if (grid_CT.Rows.Count > 0)
            {
                ((DataTable)grid_CT.DataSource).Rows.Clear();
                grid_CT.DataSource = dt.Load_DSCTPN(mapn);
            }
            else
                grid_CT.DataSource = dt.Load_DSCTPN(mapn);



        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            txtMaPN.Text = dt.TaoPN();
            txtNgay.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text != string.Empty && txtNgay.Text != string.Empty)
            {
                if (dt.ThemPN(txtMaPN.Text, txtNgay.Text, cbbNCC.SelectedValue.ToString()) == true)
                {
                    ((DataTable)cbbMaPN.DataSource).Rows.Clear();
                    cbbMaPN.DataSource = dt.Load_DSPN();
                    txtMaPN.Clear();
                    txtNgay.Clear();

                }
            }
            else
            {
                MessageBox.Show("Không được để trống!");
            }
        }

        private void cbbMaSP_SelectedValueChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = dt.laygia(cbbMaSP.SelectedValue.ToString());


        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtSL.Text != string.Empty)
            {
                string mapn = cbbMaPN.SelectedValue.ToString();

                dt.ThemCTPN(cbbMaPN.SelectedValue.ToString(), cbbMaSP.SelectedValue.ToString(), txtDonGia.Text, txtSL.Text);

                if (grid_CT.Rows.Count > 0)
                {
                    ((DataTable)grid_CT.DataSource).Rows.Clear();
                    grid_CT.DataSource = dt.Load_DSCTPN(mapn);
                }
                else
                    grid_CT.DataSource = dt.Load_DSCTPN(mapn);

            }
            else
                MessageBox.Show("Nhập số lượng !");
        }

        private void btnInPN_Click(object sender, EventArgs e)
        {
            frm = new frm_PhieuNhapHang();
            frm.Visible = true;
        }

        private void cbbMaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapn = cbbMaPN.SelectedValue.ToString();

            if (grid_CT.Rows.Count > 0)
            {
                ((DataTable)grid_CT.DataSource).Rows.Clear();
                grid_CT.DataSource = dt.Load_DSCTPN(mapn);
            }
            else
                grid_CT.DataSource = dt.Load_DSCTPN(mapn);
        }


    }
}
