//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhaHang
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        public HOADON()
        {
            this.CHITIET_HD = new HashSet<CHITIET_HD>();
        }
    
        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public int MaKH { get; set; }
        public string MaBan { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
    
        public virtual BANAN BANAN { get; set; }
        public virtual ICollection<CHITIET_HD> CHITIET_HD { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}