
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public class XuLy : KetNoiCSDL
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-H8H6LR7;Initial Catalog=QL_NhaHang;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter da_ThemXoaSuaNV;
        SqlDataAdapter da_ThemXoaSuaKH;
        SqlDataAdapter da_ThemXoaSuaHD;
        SqlDataAdapter da_ThemXoaSuaCTHD;
        SqlDataAdapter da_ThemXoaSuaCTPN;
        SqlDataAdapter da_ThemXoaSuaNhomMA;
        SqlDataAdapter da_ThemXoaSuaPN;
        SqlDataAdapter da_ThemXoaSuaMA;
        SqlDataAdapter da_ThemXoaSuaSP;
        SqlDataAdapter da_ThemXoaSuaBA;

        DataColumn[] key = new DataColumn[1];
        public XuLy()
        {
            Load_ThemNV();
            Load_ThemKH();
            Load_ThemHoaDon();
            Load_ThemPhieuNhap();
            Load_ThemCTHD();
            Load_ThemCTPN();
            Load_ThemSanPham();
            Load_DSBanAn();
            Load_ThemThucDon();
            Load_ThemNhomMonAn();

            string sql = "select account.UserName, pass, nhanvien.manv from account,nhanvien where account.MaNV=nhanvien.MaNV";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "LOGIN");


            sql = "select * from chitiet_hd";
            SqlDataAdapter da_CTHD = new SqlDataAdapter(sql, conn);
            da_CTHD.Fill(ds, "DSCTHD");

            // sql = "select * from phieunhap";
            //da_PN = new SqlDataAdapter(sql, conn);
            //da_PN.Fill(ds, "PhieuNhap");
            //key[0] = ds.Tables["PhieuNhap"].Columns[0];
            //ds.Tables["PhieuNhap"].PrimaryKey = key;
            sql = "select * from chitietpn";
            SqlDataAdapter da_CTPN = new SqlDataAdapter(sql, conn);
            da_CTPN.Fill(ds, "DSCTPN");
        }
        //KHÁCH HÀNG
        //
        //Load DSKH
        public DataTable Load_DSKH()
        {
            string sql = "select * from KhachHang";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "DSKH");

            return ds.Tables["DSKH"];
        }
        public bool KiemTraTrung_SDTKH(string pDienThoai)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "select * from KhachHang where DienThoai = '" + pDienThoai + "'";

            da_ThemXoaSuaKH = new SqlDataAdapter(sql, conn);

            int row = Convert.ToInt32(da_ThemXoaSuaKH.SelectCommand.ExecuteScalar());

            if (row > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //KT trùng SĐT KH
        public bool KiemTraTrung_SDTNV(string pDienThoai)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "select * from NhanVien where DienThoai = '" + pDienThoai + "'";

            da_ThemXoaSuaKH = new SqlDataAdapter(sql, conn);

            int row = Convert.ToInt32(da_ThemXoaSuaKH.SelectCommand.ExecuteScalar());

            if (row > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Thêm KH
        public void Load_ThemKH()
        {
            string sql = "select * from KhachHang";

            da_ThemXoaSuaKH = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaKH.Fill(ds, "ThemXoaSuaKH");

            DataColumn[] col_KhoaChinh = new DataColumn[1];

            col_KhoaChinh[0] = ds.Tables["ThemXoaSuaKH"].Columns[0];

            ds.Tables["ThemXoaSuaKH"].PrimaryKey = col_KhoaChinh;
        }
        public bool ThemKH(string pMaKH, string pTenKH, string pGioiTinh, string pDiaChi, string pDienThoai, string pTheTV, int pDiemTL)
        {
            try
            {
                DataRow dr_Them = ds.Tables["ThemXoaSuaKH"].NewRow();

                dr_Them["MaKH"] = pMaKH;
                dr_Them["TenKH"] = pTenKH;
                dr_Them["GioiTinh"] = pGioiTinh;
                dr_Them["DiaChi"] = pDiaChi;
                dr_Them["DienThoai"] = pDienThoai;
                dr_Them["TheTV"] = pTheTV;
                dr_Them["DiemTL"] = pDiemTL;

                ds.Tables["ThemXoaSuaKH"].Rows.Add(dr_Them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaKH);

                da_ThemXoaSuaKH.Update(ds, "ThemXoaSuaKH");

                return true;
            }
            catch { return false; }
        }
        //Xóa KH
        public bool XoaKH(string pMaKH)
        {
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaKH"].Rows.Count; i++)
                {
                    DataRow dr_Xoa = ds.Tables["ThemXoaSuaKH"].Rows[i];

                    if (dr_Xoa["MaKH"].ToString().Equals(pMaKH))
                    {
                        dr_Xoa.Delete();

                        SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaKH);

                        da_ThemXoaSuaKH.Update(ds, "ThemXoaSuaKH");
                    }
                }

                return true;
            }
            catch { return false; }
        }
        //Sửa KH
        public bool SuaKH(string pMaKH, string pTenKH, string pSDT, string pDiaChi, string pGioiTinh, string pTheTV, int pDiemTL)
        {
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaKH"].Rows.Count; i++)
                {
                    DataRow dr_Sua = ds.Tables["ThemXoaSuaKH"].Rows[i];

                    if (dr_Sua["MaKH"].ToString().Equals(pMaKH))
                    {
                        if (!pTenKH.Equals(""))
                        {
                            dr_Sua[1] = pTenKH;
                        }
                        if (!pSDT.Equals(""))
                        {
                            dr_Sua[4] = pSDT;
                        }
                        if (!pDiaChi.Equals(""))
                        {
                            dr_Sua[3] = pDiaChi;
                        }
                        if (!pGioiTinh.Equals(""))
                        {
                            dr_Sua[2] = pGioiTinh;
                        }
                        if (!pTheTV.Equals(""))
                        {
                            dr_Sua[5] = pTheTV;
                        }
                        if (!pDiemTL.Equals(""))
                        {
                            dr_Sua[6] = pDiemTL;
                        }


                        SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaKH);

                        da_ThemXoaSuaKH.Update(ds, "ThemXoaSuaKH");
                    }
                }
                return true;
            }
            catch { return false; }
        }
        //*****************************************************************************

        //Thêm CTHD
        public DataTable Load_DSCTHD(string pMaHD)
        {
            ds.Tables["DSCTHD"].Clear();

            string sql = "select distinct * from ChiTiet_HD where mahd = '" + pMaHD + "' ";

            SqlDataAdapter da_CTHD = new SqlDataAdapter(sql, conn);

            da_CTHD.Fill(ds, "DSCTHD");

            DataColumn[] col_KhoaChinh = new DataColumn[1];

            col_KhoaChinh[0] = ds.Tables["ThemXoaSuaHD"].Columns[0];

            ds.Tables["ThemXoaSuaHD"].PrimaryKey = col_KhoaChinh;

            return ds.Tables["DSCTHD"];
        }

        public DataTable Load_ThemCTHD()
        {
            string sql = "select * from ChiTiet_HD ";

            da_ThemXoaSuaCTHD = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaCTHD.Fill(ds, "ThemXoaSuaCTHD");

            return ds.Tables["ThemXoaSuaCTHD"];

        }

        public int KTTrung_MonTrongCTHD(string pMaHD, string pMaMon)
        {
            int dem = -1;
            for (int i = 0; i < ds.Tables["ThemXoaSuaCTHD"].Rows.Count; i++)
            {
                if (ds.Tables["ThemXoaSuaCTHD"].Rows[i]["MaHD"].ToString() == pMaHD && ds.Tables["ThemXoaSuaCTHD"].Rows[i]["MaMon"].ToString() == pMaMon)
                {
                    dem = i;
                    break;
                }
            }
            return dem; //Nếu trùng
        }
        public void ThemCTHD(string pMaHD, string pMaMon, string pTenMon, string pDonGia, string pSoLuong)
        {

            int row = KTTrung_MonTrongCTHD(pMaHD, pMaMon);
            if (row != -1)
            {
                ds.Tables["ThemXoaSuaCTHD"].Rows[row]["SoLuong"] = double.Parse(ds.Tables["ThemXoaSuaCTHD"].Rows[row]["SoLuong"].ToString()) + double.Parse(pSoLuong);
                ds.Tables["ThemXoaSuaCTHD"].Rows[row]["TongMon"] = double.Parse(ds.Tables["ThemXoaSuaCTHD"].Rows[row]["TongMon"].ToString()) + (double.Parse(pDonGia) * double.Parse(pSoLuong));

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaCTHD);

                da_ThemXoaSuaCTHD.Update(ds, "ThemXoaSuaCTHD");
            }
            else //chưa có
            {
                DataRow dr_Them = ds.Tables["ThemXoaSuaCTHD"].NewRow();

                dr_Them["MaHD"] = pMaHD;
                dr_Them["MaMon"] = pMaMon;
                dr_Them["TenMon"] = pTenMon;
                dr_Them["DonGia"] = pDonGia;
                dr_Them["SoLuong"] = pSoLuong;
                dr_Them["TongMon"] = double.Parse(pDonGia) * double.Parse(pSoLuong);

                ds.Tables["ThemXoaSuaCTHD"].Rows.Add(dr_Them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaCTHD);

                da_ThemXoaSuaCTHD.Update(ds, "ThemXoaSuaCTHD");
            }
        }
        //Xóa hd
        public bool XoaCTHD(string pMaHD, string pMaMon)
        {
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaCTHD"].Rows.Count; i++)
                {
                    DataRow dr_Xoa = ds.Tables["ThemXoaSuaCTHD"].Rows[i];

                    if (dr_Xoa["MaHD"].ToString().Equals(pMaHD) && dr_Xoa["MaMon"].ToString().Equals(pMaMon))
                    {
                        dr_Xoa.Delete();

                        SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaCTHD);

                        da_ThemXoaSuaCTHD.Update(ds, "ThemXoaSuaCTHD");
                    }
                }

                return true;
            }
            catch { return false; }
        }
        //Sửa CThd
        public bool SuaCTHD(string pMaHD, string pMaMon, string pSoLuong)
        {
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaCTHD"].Rows.Count; i++)
                {
                    DataRow dr_Sua = ds.Tables["ThemXoaSuaCTHD"].Rows[i];

                    if (dr_Sua["MaHD"].ToString().Equals(pMaHD))
                    {
                        if (dr_Sua["MaMon"].ToString().Equals(pMaMon))
                        {
                            if (!pSoLuong.Equals(""))
                            {
                                dr_Sua[4] = pSoLuong;
                            }
                        }


                        SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaCTHD);

                        da_ThemXoaSuaCTHD.Update(ds, "ThemXoaSuaCTHD");
                    }
                }
                return true;
            }
            catch { return false; }
        }
        //**************************************************************************************************************//

        //NHÂN VIÊN
        //
        //Load DSNV
        public DataTable Load_DSNV()
        {
            string sql = "select MaNV, tennv, username, dienthoai,diachi,ngaysinh, gioitinh,tenchucvu, ngayvaolam,luongcb  from NHANVIEN, CHUCVU WHERE NHANVIEN.QUYEN = CHUCVU.QUYEN";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "DSNV");

            return ds.Tables["DSNV"];
        }
        //Load combobox Chức Vụ
        public DataTable Load_CboChucVu()
        {
            string sql = "select * from ChucVu";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "ChucVu");

            return ds.Tables["ChucVu"];
        }
        //Lọc Nhân Viên theo Chức Vụ
        public DataTable LayDS_TheoChucVu(string pChucVu)
        {
            string sql = "select * from NhanVien where ChucVu = N'" + pChucVu + "'";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "LocNVTheoChucVu");

            return ds.Tables["LocNVTheoChucVu"];
        }
        //Lọc Nhân Viên theo Tên
        public DataTable LayDS_TheoTen(string pHoTen)
        {
            string sql = "select * from NhanVien where TenNV like N'%" + pHoTen + "%'";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "LocNVTheoTen");

            return ds.Tables["LocNVTheoTen"];
        }
        //KT trùng Mã NV
        public bool KiemTraTrung_MaNV(string pMaNV)
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "select * from NhanVien where manv = '" + pMaNV + "'";

            da_ThemXoaSuaNV = new SqlDataAdapter(sql, conn);

            int row = Convert.ToInt32(da_ThemXoaSuaNV.SelectCommand.ExecuteScalar());

            if (row > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Load Thêm NV
        public void Load_ThemNV()
        {
            string sql = "select * from NhanVien";

            da_ThemXoaSuaNV = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaNV.Fill(ds, "ThemXoaSuaNV");

            DataColumn[] col_KhoaChinh = new DataColumn[1];

            col_KhoaChinh[0] = ds.Tables["ThemXoaSuaNV"].Columns[0];

            ds.Tables["ThemXoaSuaNV"].PrimaryKey = col_KhoaChinh;
        }
        //Thêm NV
        public bool ThemNV(string pMaNV, string pTenNV, string pUser, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh, string pChucVu, string pNgayVL)
        {
            try
            {
                DataRow dr_Them = ds.Tables["ThemXoaSuaNV"].NewRow();

                dr_Them["MaNV"] = pMaNV;
                dr_Them["TenNV"] = pTenNV;
                dr_Them["UserName"] = pUser;
                dr_Them["DienThoai"] = pSDT;
                dr_Them["DiaChi"] = pDiaChi;
                dr_Them["NgaySinh"] = pNgaySinh;
                dr_Them["GioiTinh"] = pGioiTinh;
                dr_Them["quyen"] = int.Parse(pChucVu);
                dr_Them["NgayVaoLam"] = pNgayVL;

                ds.Tables["ThemXoaSuaNV"].Rows.Add(dr_Them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaNV);

                da_ThemXoaSuaNV.Update(ds, "ThemXoaSuaNV");

                return true;
            }
            catch { return false; }
        }
        //Xóa NV
        public bool XoaNV(string pMaNV)
        {
            try
            {
                DataRow dr_Xoa = ds.Tables["ThemXoaSuaNV"].Rows.Find(pMaNV);

                dr_Xoa.Delete();

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaNV);

                da_ThemXoaSuaNV.Update(ds, "ThemXoaSuaNV");

                return true;
            }
            catch { return false; }

        }
        //Sửa NV
        public bool SuaNV(string pMaNV, string pTenNV, string pSDT, string pDiaChi, string pNgaySinh, string pGioiTinh, string pChucVu, string pNgayVL)
        {
            try
            {
                DataRow dr_Sua = ds.Tables["ThemXoaSuaNV"].Rows.Find(pMaNV);

                if (!pTenNV.Equals(""))
                {
                    dr_Sua[1] = pTenNV;
                }
                if (!pSDT.Equals(""))
                {
                    dr_Sua[3] = pSDT;
                }
                if (!pDiaChi.Equals(""))
                {
                    dr_Sua[4] = pDiaChi;
                }
                if (!pNgaySinh.Equals(""))
                {
                    dr_Sua[5] = pNgaySinh;
                }
                if (!pGioiTinh.Equals(""))
                {
                    dr_Sua[6] = pGioiTinh;
                }
                if (!pChucVu.Equals(""))
                {
                    dr_Sua[7] = pChucVu;
                }
                if (!pNgayVL.Equals(""))
                {
                    dr_Sua[8] = pNgayVL;
                }

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaNV);

                da_ThemXoaSuaNV.Update(ds, "ThemXoaSuaNV");
                return true;
            }
            catch { return false; }
        }
        //*********************************************************************************************************************************************8//
        //THỰC ĐƠN
        //Load mon an lên treeview
        public TreeNode[] loadTree()
        {
            TreeNode[] tns;
            string select = "select * from MONAN";
            SqlDataAdapter da = new SqlDataAdapter(select, conn);
            da.Fill(ds, "MonAn");
            select = "select * from NHOMMONAN";
            da = new SqlDataAdapter(select, conn);
            da.Fill(ds, "NhomMonAn");
            tns = new TreeNode[ds.Tables["NhomMonAn"].Rows.Count];

            for (int j = 0; j < ds.Tables["NhomMonAn"].Rows.Count; j++)
            {
                TreeNode tn = new TreeNode();
                tn.Text = ds.Tables["NhomMonAn"].Rows[j]["TenNhom"].ToString();

                for (int i = 0; i < ds.Tables["MonAn"].Rows.Count; i++)
                {
                    if (ds.Tables["MonAn"].Rows[i]["MaNhom"].ToString() == ds.Tables["NhomMonAn"].Rows[j]["MaNhom"].ToString())
                    {
                        TreeNode tn1 = new TreeNode();
                        tn1.Text = ds.Tables["MonAn"].Rows[i]["TenMon"].ToString() + " - " + ds.Tables["MonAn"].Rows[i]["DonGia"].ToString();
                        tn.Nodes.Add(tn1);
                    }
                }
                tns[j] = tn;
            }
            return tns;


        }
        //
        //lay quyen nhan vien
        public int layquyennhanvien(string pMaNV)
        {
            int quyen = 1;
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaNV"].Rows.Count; i++)
                {
                    DataRow dr = ds.Tables["ThemXoaSuaNV"].Rows[i];

                    if (dr["MaNV"].ToString().Equals(pMaNV))
                    {
                        quyen = int.Parse(dr["quyen"].ToString());
                    }

                }
                return quyen;
            }
            catch { return quyen; }
        }
        //public int layquyennhanvien(string pMaNV)
        //{
        //    int quyen = 1;
        //    try
        //    {
        //        for (int i = 0; i < ds.Tables["ThemXoaSuaNV"].Rows.Count; i++)
        //        {
        //            DataRow dr = ds.Tables["ThemXoaSuaNV"].Rows[i];

        //            if (dr["MaNV"].ToString().Equals(pMaNV))
        //            {
        //                quyen = int.Parse(dr["quyen"].ToString());
        //            }

        //        }
        //        return quyen;
        //    }
        //    catch { return quyen; }
        //}   
        //ĐĂNG NHẬP
        //
        public string dangnhap(string user, string pass)
        {
            ds.Tables["LOGIN"].Clear();

            string sql = "select account.UserName, pass, nhanvien.manv from account,nhanvien where account.MaNV=nhanvien.MaNV and account.UserName = '" + user + "'";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "LOGIN");

            for (int i = 0; i < ds.Tables["LOGIN"].Rows.Count; i++)
            {
                if (ds.Tables["LOGIN"].Rows[0]["Pass"].ToString().Equals(pass))
                {
                    return ds.Tables["LOGIN"].Rows[0]["MaNV"].ToString();
                }
                else
                    MessageBox.Show("Ban chua co tai khoan");
            }
            return null;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------
        //lấy mã hóa đơn theo bàn ăn
        //
        public string LayMaHD(string pMaBan)
        {
            DataTable dt = new DataTable();

            string sql = "select top 1 * from HoaDon where MaBan = '" + pMaBan + "' Order By NgayLap desc";

            SqlDataAdapter da_Temp = new SqlDataAdapter(sql, conn);

            da_Temp.Fill(dt);

            return dt.Rows[0]["MaHD"].ToString();
        }


        //ĐẶT BÀN
        //lấy món theo tên
        public DataTable LayMon_TheoTen(string pTenMon)
        {
            DataTable dtb = new DataTable();
            string sql = "select * from MonAn where TenMon = N'" + pTenMon + "'";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(dtb);

            return dtb;
        }
        //------------------------------------------------------------------
        //load danh sách hóa đơn
        public DataTable Load_DSHD()
        {
            string sql = "select * from HoaDon";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "DSHD");

            return ds.Tables["DSHD"];
        }

        //Tự động thêm hđ khi đặt bàn
        public void Load_ThemHoaDon()
        {
            string sql = "select * from HoaDon";

            da_ThemXoaSuaHD = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaHD.Fill(ds, "ThemXoaSuaHD");
        }
        //---------------------------------------------------------
        //thêm hóa đơn
        public bool ThemHD(string pMaNV, string pMaKH, string pMaBan, string pTongTien, string pNgayLap)
        {
            try
            {
                DataRow dr_Them = ds.Tables["ThemXoaSuaHD"].NewRow();

                dr_Them["MaNV"] = pMaNV;
                dr_Them["MaKH"] = pMaKH;
                dr_Them["MaBan"] = pMaBan;
                dr_Them["TongTien"] = System.DBNull.Value;
                dr_Them["NgayLap"] = pNgayLap;

                ds.Tables["ThemXoaSuaHD"].Rows.Add(dr_Them);

                SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaHD);

                da_ThemXoaSuaHD.Update(ds, "ThemXoaSuaHD");

                return true;
            }
            catch { return false; }
        }
        //--------------------------------------------------------------------
        //Cập nhật tình trạng bàn ăn
        public bool UpdateTrangThaiBan(string pMaBan)
        {
            try
            {
                string sql = "select * from BanAn where MaBan = '" + pMaBan + "'";

                SqlDataAdapter da_BanAn = new SqlDataAdapter(sql, conn);

                da_BanAn.Fill(ds, "BanAn");

                DataRow dr = ds.Tables["BanAn"].Rows[0];

                if (dr["TrangThai"].ToString() == "0")
                    dr["TrangThai"] = 1;
                else
                    dr["TrangThai"] = 0;

                SqlCommandBuilder build = new SqlCommandBuilder(da_BanAn);

                da_BanAn.Update(ds, "BanAn");

                ds.Tables["BanAn"].Clear();

                return true;
            }
            catch { return false; }
        }
        //--------------------------------------------------------------------
        //lấy trạng thái bàn
        public bool laytrangthaiban(string pMaBan)
        {
            string sql = "select * from BanAn where MaBan = '" + pMaBan + "'";

            SqlDataAdapter da_TrangThai = new SqlDataAdapter(sql, conn);

            da_TrangThai.Fill(ds, "LayTrangThaiBan");

            DataRow dr = ds.Tables["LayTrangThaiBan"].Rows[0];

            if (dr["TrangThai"].ToString() == "1")
            {
                ds.Tables["LayTrangThaiBan"].Clear();
                return true;
            }
            else
            {
                ds.Tables["LayTrangThaiBan"].Clear();
                return false;
            }
        }
        public DataTable Load_DSBanAn()
        {
            string sql = "select * from BanAn";

            da_ThemXoaSuaBA = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaBA.Fill(ds, "ThemXoaSuaBA");

            DataColumn[] col_KhoaChinh = new DataColumn[1];

            col_KhoaChinh[0] = ds.Tables["ThemXoaSuaBA"].Columns[0];

            ds.Tables["ThemXoaSuaBA"].PrimaryKey = col_KhoaChinh;

            return ds.Tables["ThemXoaSuaBA"];
        }
        //lấy ma khách hàng theo số diện thoại
        public string LayMaKH_TheoSDT(string pSDT)
        {
            string ma = null;
            try
            {
                for (int i = 0; i < ds.Tables["ThemXoaSuaKH"].Rows.Count; i++)
                {
                    DataRow dr = ds.Tables["ThemXoaSuaKH"].Rows[i];

                    if (dr["DienThoai"].ToString().Equals(pSDT))
                    {
                        ma = dr["MaKH"].ToString();
                    }

                }
                return ma;
            }
            catch { return ma; }
        }
        //--------------------------------------------------------------
        // load combobox doi ban
        public DataTable Load_DSTenBanAn()
        {
            string sql = "select * from BanAn where trangthai= 0 ";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(ds, "DSTenBanAn");

            return ds.Tables["DSTenBanAn"];
        }
        //--------------------------------------------------------------
        //Load Đổi Bàn
        public bool DoiBan(string pBanCanChuyen, string pMaHD, string pBanDich)
        {
            try
            {
                DataRow dr = ds.Tables["ThemXoaSuaHD"].Rows[0];

                if (LayMaHD(pBanCanChuyen) != null)
                {
                    if (!pBanDich.Equals(""))
                    {
                        dr[3] = pBanDich;

                        SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaHD);

                        da_ThemXoaSuaHD.Update(ds, "ThemXoaSuaHD");
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                return true;
            }
            catch { return false; }
        }

        //******************************************************************************************************************
        //nhập hàng
        public DataTable loadNCC()
        {
            DataTable dtb = new DataTable();
            string sql = "select * from nhacungcap";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "DSNCC");
            return ds.Tables["DSNCC"];
        }
        public DataTable loadSP()
        {
            string sql = "select * from sanpham";
            SqlDataAdapter da_DSSP = new SqlDataAdapter(sql, conn);
            da_DSSP.Fill(ds, "DSSP");

            DataColumn[] col_KhoaChinh = new DataColumn[1];

            col_KhoaChinh[0] = ds.Tables["ThemXoaSuaSP"].Columns[0];

            ds.Tables["ThemXoaSuaSP"].PrimaryKey = col_KhoaChinh;

            return ds.Tables["DSSP"];
        }

        public void Load_ThemSanPham()
        {
            string sql = "select * from SanPham";

            da_ThemXoaSuaSP = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaSP.Fill(ds, "ThemXoaSuaSP");
        }
        public bool ThemSanPham(string pMaSP, string pTenSP, string pDonGia, string pMaNhom)
        {
            try
            {
                DataRow dr_them = ds.Tables["ThemXoaSuaSP"].NewRow();

                dr_them["MAPN"] = pMaSP;
                dr_them["TENSP"] = pTenSP;
                dr_them["DONGIA"] = pDonGia;
                dr_them["MaNhom"] = pMaNhom;

                ds.Tables["ThemXoaSuaSP"].Rows.Add(dr_them);

                SqlCommandBuilder buil = new SqlCommandBuilder(da_ThemXoaSuaSP);

                da_ThemXoaSuaSP.Update(ds, "ThemXoaSuaSP");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable Load_DSPN()
        {
            DataTable dtb = new DataTable();
            string sql = "select * from phieunhap order by mapn desc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "DSPN");
            return ds.Tables["DSPN"];
        }

        public DataTable Load_DSCTPN(string pMaPN)
        {
            ds.Tables["DSCTPN"].Clear();

            string sql = "select * from ChiTietPN where mapn = '" + pMaPN + "' ";

            SqlDataAdapter da_CTPN = new SqlDataAdapter(sql, conn);

            da_CTPN.Fill(ds, "DSCTPN");

            DataColumn[] col_KhoaChinh = new DataColumn[1];

            col_KhoaChinh[0] = ds.Tables["ThemXoaSuaPN"].Columns[0];

            ds.Tables["ThemXoaSuaPN"].PrimaryKey = col_KhoaChinh;

            return ds.Tables["DSCTPN"];
        }

        public string layMaxPN()
        {
            try
            {
                List<int> stt = new List<int>();
                for (int i = 0; i < ds.Tables["DSPN"].Rows.Count; i++)
                {
                    string s = ds.Tables["DSPN"].Rows[i]["MAPN"].ToString();
                    string so = s.Substring(s.Length - 3, 3);
                    stt.Add(int.Parse(so));
                }
                return (stt.Max() + 1).ToString();
            }
            catch
            {
                return "PN001";
            }
        }

        public string TaoPN()
        {
            try
            {
                if (layMaxPN() != "PN001")
                {
                    string s = "PN" + "00" + layMaxPN();

                    return s;
                }
                else return layMaxPN();
            }
            catch
            {
                return null;
            }
        }
        public void Load_ThemPhieuNhap()
        {
            string sql = "select * from PhieuNhap";

            da_ThemXoaSuaPN = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaPN.Fill(ds, "ThemXoaSuaPN");
        }

        public bool ThemPN(string mapn, string ngay, string mancc)
        {
            try
            {
                DataRow dr_them = ds.Tables["ThemXoaSuaPN"].NewRow();

                dr_them["MAPN"] = mapn;
                dr_them["NGAYNHAP"] = ngay;
                dr_them["THANHTIEN"] = System.DBNull.Value;
                dr_them["MANCC"] = mancc;

                ds.Tables["ThemXoaSuaPN"].Rows.Add(dr_them);

                SqlCommandBuilder buil = new SqlCommandBuilder(da_ThemXoaSuaPN);

                da_ThemXoaSuaPN.Update(ds, "ThemXoaSuaPN");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string laygia(string masp)
        {
            try
            {
                DataTable dtb = new DataTable();
                string sql = "select * from SANPHAM where masp ='" + masp + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dtb);
                return dtb.Rows[0]["DONGIA"].ToString();
            }
            catch
            {
                return null;
            }
        }
        //Load thêm CTPN
        public DataTable Load_ThemCTPN()
        {
            string sql = "select * from ChiTietPN";

            da_ThemXoaSuaCTPN = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaCTPN.Fill(ds, "ThemXoaSuaCTPN");

            return ds.Tables["ThemXoaSuaCTPN"];
        }
        public void ThemCTPN(string pMaPN, string pMaSP, string pDonGia, string pSoLuong)
        {
            try
            {
                int row = KTTrung_MonTrongCTHD(pMaPN, pMaSP);

                if (row != -1)
                {
                    ds.Tables["ThemXoaSuaCTPN"].Rows[row]["SoLuong"] = double.Parse(ds.Tables["ThemXoaSuaCTPN"].Rows[row]["SoLuong"].ToString()) + double.Parse(pSoLuong);

                    SqlCommandBuilder build = new SqlCommandBuilder(da_ThemXoaSuaCTPN);

                    da_ThemXoaSuaCTPN.Update(ds, "ThemXoaSuaCTPN");
                }
                else //chưa có
                {
                    DataRow dr_them = ds.Tables["ThemXoaSuaCTPN"].NewRow();
                    dr_them["MAPN"] = pMaPN;
                    dr_them["MASP"] = pMaSP;
                    dr_them["DONGIA"] = pDonGia;
                    dr_them["SOLUONG"] = pSoLuong;
                    dr_them["TONGTIENSP"] = float.Parse(pSoLuong) * float.Parse(pDonGia);


                    ds.Tables["ThemXoaSuaCTPN"].Rows.Add(dr_them);

                    SqlCommandBuilder buil = new SqlCommandBuilder(da_ThemXoaSuaCTPN);

                    da_ThemXoaSuaCTPN.Update(ds, "ThemXoaSuaCTPN");
                }
            }
            catch { }
        }

        public bool SuaSP(string mapn, string masp, string gia, string soluong)
        {
            try
            {
                int dem = -1;
                for (int i = 0; i < ds.Tables["ThemXoaSuaCTPN"].Rows.Count; i++)
                {
                    if (ds.Tables["ThemXoaSuaCTPN"].Rows[i]["MAPN"].ToString().Equals(mapn) && ds.Tables["ThemXoaSuaCTPN"].Rows[i]["MASP"].ToString().Equals(masp))
                    {
                        dem = i;
                    }
                }
                DataRow drSua = ds.Tables["ThemXoaSuaCTPN"].Rows[dem];
                if (gia == string.Empty)
                    gia = drSua["DONGIA"].ToString();
                if (soluong == string.Empty)
                    soluong = drSua["SOLUONG"].ToString();
                drSua["DONGIA"] = gia;
                drSua["SOLUONG"] = soluong;
                SqlCommandBuilder buil = new SqlCommandBuilder(da_ThemXoaSuaCTPN);
                da_ThemXoaSuaCTPN.Update(ds, "ThemXoaSuaCTPN");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ThongKeTheoMonAn()
        {
            string row = "";

            string sql = "select Top 1 TenMon,Sum(SoLuong)  FROM ChiTiet_HD cthd, HoaDon hd WHERE cthd.mahd = hd.mahd Group By TenMon";
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                row = rd["TenMon"].ToString();
            }
            rd.Close();

            if (conn.State == ConnectionState.Open)
                conn.Close();

            return row;
        }

        public string ThongKeTheoNgay(string pNgayLap)
        {
            string row = "";

            string sql = "select Sum(TongTien) as TongTien FROM HoaDon where NgayLap = '" + pNgayLap + "'";
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                row = rd["TongTien"].ToString();
            }
            rd.Close();

            if (conn.State == ConnectionState.Open)
                conn.Close();

            return row;
        }

        public string ThongKeTheoThang()
        {
            string row = "";

            string sql = "select Sum(TongTien) as TongTien FROM HoaDon where Month(NgayLap) = MONTH(SYSDATETIME())";
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                row = rd["TongTien"].ToString();
            }
            rd.Close();

            if (conn.State == ConnectionState.Open)
                conn.Close();

            return row;
        }

        public DataTable ThongKeTheoNam()
        {
            string sql = "select MONTH(NgayLap) as Tháng, sum(TongTien) as [Tổng Tiền] from HOADON where YEAR(NgayLap) = Year(SYSDATETIME()) Group by MONTH(NgayLap)";

            SqlDataAdapter da_ThongKeTheoNam = new SqlDataAdapter(sql, conn);

            da_ThongKeTheoNam.Fill(ds, "ThongKeTheoNam");

            return ds.Tables["ThongKeTheoNam"];
        }

        public DataTable Load_DSNMA()
        {
            string sql = "select * from NhomMonAn";

            da_ThemXoaSuaNhomMA = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaNhomMA.Fill(ds, "DSNMA");

            return ds.Tables["DSNMA"];
        }
        public void Load_ThemNhomMonAn()
        {
            string sql = "select * from NhomMonAn";

            da_ThemXoaSuaNhomMA = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaNhomMA.Fill(ds, "ThemXoaSuaNhomMA");

            DataColumn[] key = new DataColumn[1];

            key[0] = ds.Tables["ThemXoaSuaNhomMA"].Columns[0];

            ds.Tables["ThemXoaSuaNhomMA"].PrimaryKey = key;
        }
        public bool ThemNhomMonAn(string pMaNhom, string pTenNhom)
        {
            try
            {
                DataRow dr_them = ds.Tables["ThemXoaSuaNhomMA"].NewRow();

                dr_them["MaNhom"] = pMaNhom;
                dr_them["TenNhom"] = pTenNhom;

                ds.Tables["ThemXoaSuaNhomMA"].Rows.Add(dr_them);

                SqlCommandBuilder buil = new SqlCommandBuilder(da_ThemXoaSuaNhomMA);

                da_ThemXoaSuaNhomMA.Update(ds, "ThemXoaSuaNhomMA");

                return true;
            }
            catch
            {
                return false;
            }
        }

        //public DataTable Load_DSMA()
        //{
        //    string sql = "select * from MonAn";

        //    SqlDataAdapter da_ThongKeTheoNam = new SqlDataAdapter(sql, conn);

        //    da_ThongKeTheoNam.Fill(ds, "DSMA");

        //    return ds.Tables["DSMA"];
        //}
        public string layMaxMon()
        {
            try
            {
                List<int> stt = new List<int>();

                for (int i = 0; i < ds.Tables["DSMA"].Rows.Count; i++)
                {
                    string s = ds.Tables["DSMA"].Rows[i]["MaMon"].ToString();
                    string so = s.Substring(s.Length - 2, 4);
                    stt.Add(int.Parse(so));
                }
                return (stt.Max() + 1).ToString();
            }
            catch
            {
                return "M00001";
            }
        }

        public string TaoMon()
        {
            try
            {
                if (layMaxPN() != "M00001")
                {
                    string s = "M" + "000" + layMaxPN();

                    return s;
                }
                else return layMaxPN();
            }
            catch
            {
                return null;
            }
        }
        public void Load_ThemThucDon()
        {
            string sql = "select * from MonAn";

            da_ThemXoaSuaMA = new SqlDataAdapter(sql, conn);

            da_ThemXoaSuaMA.Fill(ds, "ThemXoaSuaMA");
        }
        public bool ThemThucDon(string pMaMon, string pTenMon, string pDonGia,string pMaNhom)
        {
            try
            {
                DataRow dr_them = ds.Tables["ThemXoaSuaMA"].NewRow();

                dr_them["MaMon"] = pMaMon;
                dr_them["TenMon"] = pTenMon;
                dr_them["DonViTinh"] = "Phần";
                dr_them["DonGia"] = pDonGia;
                dr_them["MaNhom"] = pMaNhom;

                ds.Tables["ThemXoaSuaMA"].Rows.Add(dr_them);

                SqlCommandBuilder buil = new SqlCommandBuilder(da_ThemXoaSuaMA);

                da_ThemXoaSuaMA.Update(ds, "ThemXoaSuaMA");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}

