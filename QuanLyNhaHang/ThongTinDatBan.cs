using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.DAO;

namespace QuanLyNhaHang
{
    public partial class ThongTinDatBan : Form
    {
        XuLy dt = new XuLy();
        Form frm;


        public ThongTinDatBan()
        {
            InitializeComponent();
        }

        private void ThongTinDatBan_Load(object sender, EventArgs e)
        {
            txt_TenBan.Text = UserControlDatBan.ban;
            txt_NhanVien.Text = Login.User;


            tree_Food.Nodes.AddRange(dt.loadTree());
            grid_MonDaChon.DataSource = dt.Load_DSCTHD(UserControlDatBan.mahd);
        }

        private void tree_Food_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txt_MonDangChon.Text = tree_Food.SelectedNode.Text;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            frm = new frm_PhieuThanhToan();
            frm.Visible = true;
            
            dt.UpdateTrangThaiBan(UserControlDatBan.ban);
            this.Close();
        }

        private void btn_ChonMon_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lstMonAn = txt_MonDangChon.Text.Split('-');

                DataTable dtMonAn = dt.LayMon_TheoTen(lstMonAn[0].Substring(0, lstMonAn[0].Length - 1));

                string mamon = dtMonAn.Rows[0]["MaMon"].ToString();
                string tenmon = dtMonAn.Rows[0]["TenMon"].ToString();
                string dongia = dtMonAn.Rows[0]["DonGia"].ToString();

                dt.ThemCTHD(UserControlDatBan.mahd, mamon, tenmon, dongia, SLMon.Value.ToString());

                ((DataTable)grid_MonDaChon.DataSource).Rows.Clear();
                grid_MonDaChon.DataSource = dt.Load_DSCTHD(UserControlDatBan.mahd);

            }

            catch { }
        }

        private void btn_HuyChonMon_Click(object sender, EventArgs e)
        {
            if (dt.XoaCTHD(UserControlDatBan.mahd, grid_MonDaChon.CurrentRow.Cells[1].Value.ToString()))
            {
                ((DataTable)grid_MonDaChon.DataSource).Rows.Clear();
                grid_MonDaChon.DataSource = dt.Load_DSCTHD(UserControlDatBan.mahd);
            }
        }

        private void grid_MonDaChon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = grid_MonDaChon.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Xóa Món"));
                }


                m.Show(grid_MonDaChon, new Point(e.X, e.Y));

            }
        }



    }
}
