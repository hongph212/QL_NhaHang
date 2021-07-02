using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyNhaHang
{
    public partial class UserControlThucDon : UserControl
    {
        //Form frm;
        XuLy dt = new XuLy();

        public UserControlThucDon()
        {
            InitializeComponent();
        }
        private void UserControlThucDon_Load(object sender, EventArgs e)
        {
            tree_Food.Nodes.AddRange(dt.loadTree());

            cbo_NhomMonAn.DataSource = dt.Load_DSNMA();
            cbo_NhomMonAn.DisplayMember = "TenNhom";
            cbo_NhomMonAn.ValueMember = "MaNhom";
        }
        private void tree_Food_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //txt_MonDangChon.Text = tree_Food.SelectedNode.Text;
        }

        private void btn_ThemNhom_Click(object sender, EventArgs e)
        {
            if (dt.ThemNhomMonAn(txt_MaMon.Text, txt_TenNhomMA.Text))
            {
                MessageBox.Show("Thêm nhóm món ăn thành công !!");
                tree_Food.Nodes.Clear();
            }
            else
                MessageBox.Show("Thêm nhóm món ăn thất bại !!");
        }

        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            if (dt.ThemThucDon(txt_MaMon.Text, txt_TenMon.Text, txt_DonGia.Text, cbo_NhomMonAn.SelectedValue.ToString()))
            {
                MessageBox.Show("Thêm món ăn thành công !!");
                tree_Food.Nodes.Clear();
                tree_Food.Nodes.AddRange(dt.loadTree());
            }
            else
                MessageBox.Show("Thêm món ăn thất bại !!");
        }



    }
}
