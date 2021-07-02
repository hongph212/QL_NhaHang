using QuanLyNhaHang.DAO;
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
    public partial class frm_KetNoi : Form 
    {
        KetNoiCSDL kncsdl = new KetNoiCSDL();
        public frm_KetNoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kncsdl.KiemTraKN(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text))
            {
                MessageBox.Show("Thành công");
                frm_Login frm = new frm_Login();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                Close();
        }
    }
}
