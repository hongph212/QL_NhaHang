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
    
    public partial class CHITIET_HD
    {
        public string MaHD { get; set; }
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> TongMon { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        public virtual MONAN MONAN { get; set; }
    }
}
