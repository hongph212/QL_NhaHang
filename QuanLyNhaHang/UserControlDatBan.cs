using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.DAO;

namespace QuanLyNhaHang
{
    public partial class UserControlDatBan : UserControl
    {
        Form frm;
        List<Button> lstbutton;
        XuLy dt = new XuLy();
        public static string ban = null;
        public static string makh = null;
        public static string mahd = null;
        private int trangthai = 0;

        public UserControlDatBan()
        {
            InitializeComponent();
            lstbutton = new List<Button>();

        }

        private void btn_DatBan_Click(object sender, EventArgs e)
        {
            dt = new XuLy();

            makh = dt.LayMaKH_TheoSDT(txt_SDT.Text);

            if (makh == null) //Nếu chưa có KH, thêm mới
            {
                frm = new frm_ThemKH();
                frm.ShowDialog();
            }
            else
            {
                if (dt.laytrangthaiban(ban) == false)
                {
                    if (dt.ThemHD(frm_Login.manv, makh, ban, null, DateTime.Now.Date.ToString()))
                    {
                        UserControlDatBan.mahd = dt.LayMaHD(ban);
                        MessageBox.Show("Đặt bàn thành công");

                        //Cập nhật trạng thái bàn thành 1
                        dt.UpdateTrangThaiBan(ban);

                        //Đổi màu bàn
                        DoiMauBanAn();

                        //Hiện form đặt món
                        frm = new ThongTinDatBan();
                        frm.Visible = true;
                        this.Visible = false;
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
                else
                {
                    frm = new ThongTinDatBan();
                    frm.Visible = true;
                    this.Visible = false;
                }
                    
            }
        }
        private void btn_ChonBan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor != Color.Orange)
            {
                if (btn.BackColor == Color.Lavender)
                {
                    lstbutton.Remove(btn);
                    btn.BackColor = Color.Aqua;
                    lstbutton.Add(btn);
                }
                else if (btn.BackColor == Color.Aqua)
                {
                    lstbutton.Remove(btn);
                    btn.BackColor = Color.Lavender;
                    lstbutton.Add(btn);
                }
            }

            ban = btn.Text;

            if (dt.laytrangthaiban(btn.Text))
            {
                UserControlDatBan.mahd = dt.LayMaHD(ban);
                frm = new ThongTinDatBan();
                frm.Visible = true;
            }
            else
            {
                txt_TenBan.Text = ban;
            }
        }

        private void UserControlDatBan_Load(object sender, EventArgs e)
        {
            DoiMauBanAn();

            txt_TenBan.Enabled = false;
            txt_NgayHD.Enabled = false;
            txt_NhanVien.Enabled = false;

            txt_NgayHD.Text = DateTime.Now.ToShortDateString();
            txt_NhanVien.Text = Login.User;
        }
        public void DoiMauBanAn()
        {
            foreach (Control item in group_SanVuon.Controls)
            {
                if (item is Button)
                {
                    if (dt.laytrangthaiban(item.Text) == true)
                        item.BackColor = Color.Orange;
                    else
                        item.BackColor = Color.Lavender;
                }
            }

            foreach (Control item in group_PhongLanh.Controls)
            {
                if (item is Button)
                {
                    if (dt.laytrangthaiban(item.Text) == true)
                        item.BackColor = Color.Orange;
                    else
                        item.BackColor = Color.Lavender;
                }
            }
        }

        private void btn_DoiBan_Click(object sender, EventArgs e)
        {
            if (dt.DoiBan(txt_BanCanChuyen.Text, mahd, txt_BanDich.Text))
            {
                MessageBox.Show("Bạn đã đổi thành công từ bàn '" + txt_BanCanChuyen.Text + "' sang bàn '" + txt_BanDich.Text + "'");
                dt.UpdateTrangThaiBan(txt_BanCanChuyen.Text);
                dt.UpdateTrangThaiBan(txt_BanDich.Text);
                DoiMauBanAn();
            }
        }





    }
}
