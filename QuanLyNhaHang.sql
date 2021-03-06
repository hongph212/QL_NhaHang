USE [QL_NhaHang]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[UserName] [varchar](10) NOT NULL,
	[Pass] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BANAN]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANAN](
	[MaBan] [varchar](10) NOT NULL,
	[TenBan] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](10) NULL,
 CONSTRAINT [PK_MaBan] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIET_HD]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIET_HD](
	[MaHD] [int] NOT NULL,
	[MaMon] [varchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
	[SoLuong] [int] NULL,
	[TongMon] [int] NULL,
 CONSTRAINT [PK_MaHD_MaMon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPN]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPN](
	[MAPN] [varchar](15) NOT NULL,
	[MASP] [varchar](10) NOT NULL,
	[DONGIA] [float] NULL,
	[SOLUONG] [int] NULL,
	[TONGTIENSP] [float] NULL,
 CONSTRAINT [PK_CTPN] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[quyen] [int] NOT NULL,
	[TenChucVu] [nvarchar](20) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[quyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [int] NULL,
	[MaBan] [varchar](10) NULL,
	[TongTien] [money] NULL,
	[NgayLap] [datetime] NULL,
 CONSTRAINT [PK_MaHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](10) NULL,
	[TheTV] [varchar](10) NULL,
	[DiemTL] [float] NULL,
 CONSTRAINT [PK_MaKH] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONAN](
	[MaMon] [varchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[DonGia] [float] NULL,
	[MaNhom] [varchar](10) NULL,
 CONSTRAINT [PK_MaMon] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [varchar](10) NOT NULL,
	[TENNCC] [nvarchar](30) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[UserName] [varchar](10) NULL,
	[DienThoai] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[quyen] [int] NULL,
	[NgayVaoLam] [date] NULL CONSTRAINT [DF_NGAYVL]  DEFAULT (sysdatetime()),
	[LuongCB] [float] NULL CONSTRAINT [DF_LUONG]  DEFAULT ('3000000'),
 CONSTRAINT [PK_MaNV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMMONAN]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMMONAN](
	[MaNhom] [varchar](10) NOT NULL,
	[TenNhom] [nvarchar](100) NULL,
 CONSTRAINT [PK_MaNhom] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [varchar](15) NOT NULL,
	[NGAYNHAP] [date] NULL,
	[THANHTIEN] [float] NULL,
	[MANCC] [varchar](10) NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUTHANHTOAN]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUTHANHTOAN](
	[SoPhieu] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[TongTien] [float] NULL,
	[MaNV] [varchar](10) NULL,
	[MaKH] [int] NULL,
	[MaBan] [varchar](10) NULL,
 CONSTRAINT [PK_SoPhieu] PRIMARY KEY CLUSTERED 
(
	[SoPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [varchar](10) NOT NULL,
	[TENSP] [nvarchar](30) NULL,
	[DONGIA] [float] NULL,
	[MaNhom] [varchar](10) NOT NULL,
 CONSTRAINT [PK_NC] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ACCOUNT] ([UserName], [Pass], [MaNV]) VALUES (N'44', N'123456', N'2')
INSERT [dbo].[ACCOUNT] ([UserName], [Pass], [MaNV]) VALUES (N'55', N'123456', N'2')
INSERT [dbo].[ACCOUNT] ([UserName], [Pass], [MaNV]) VALUES (N'66', N'123456', N'2')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL0012', N'Phòng Lạnh 12', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL0013', N'Phòng Lạnh 13', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL006', N'Phòng Lạnh 6', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL007', N'Phòng Lạnh 7', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL008', N'Phòng Lạnh 8', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL009', N'Phòng Lạnh 9', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL01', N'Phòng Lạnh 1', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL010', N'Phòng Lạnh 10', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL011', N'Phòng Lạnh 11', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL02', N'Phòng Lạnh 2', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL03', N'Phòng Lạnh 3', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL04', N'Phòng Lạnh 4', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'PL05', N'Phòng Lạnh 5', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV0012', N'Sân Vườn 12', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV0013', N'Sân Vườn 13', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV006', N'Sân Vườn 6', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV007', N'Sân Vườn 7', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV008', N'Sân Vườn 8', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV009', N'Sân Vườn 9', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV01', N'Sân Vườn 1', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV010', N'Sân Vườn 10', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV011', N'Sân Vườn 11', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV02', N'Sân Vườn 2', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV03', N'Sân Vườn 3', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV04', N'Sân Vườn 4', N'0')
INSERT [dbo].[BANAN] ([MaBan], [TenBan], [TrangThai]) VALUES (N'SV05', N'Sân Vườn 5', N'0')
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaMon], [TenMon], [DonGia], [SoLuong], [TongMon]) VALUES (1, N'M00003', N'Sting', 25000, 2, 50000)
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaMon], [TenMon], [DonGia], [SoLuong], [TongMon]) VALUES (1, N'M00005', N'Nước Cam Ép', 35000, 1, 35000)
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaMon], [TenMon], [DonGia], [SoLuong], [TongMon]) VALUES (1, N'M00022', N'Tôm sông', 600000, 1, 600000)
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaMon], [TenMon], [DonGia], [SoLuong], [TongMon]) VALUES (2, N'M00011', N'Chè khoai', 45000, 200, 900000)
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaMon], [TenMon], [DonGia], [SoLuong], [TongMon]) VALUES (17, N'M00002', N'Bia Tiger', 30000, 3, 90000)
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaMon], [TenMon], [DonGia], [SoLuong], [TongMon]) VALUES (17, N'M00003', N'Sting', 25000, 1, 25000)
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaMon], [TenMon], [DonGia], [SoLuong], [TongMon]) VALUES (17, N'M00004', N'PépSi', 25000, 1, 25000)
INSERT [dbo].[CHITIET_HD] ([MaHD], [MaMon], [TenMon], [DonGia], [SoLuong], [TongMon]) VALUES (17, N'M00030', N'Thịt Bò nướng khối', 5000000, 2, 10000000)
INSERT [dbo].[CHUCVU] ([quyen], [TenChucVu]) VALUES (1, N'Quản Lý')
INSERT [dbo].[CHUCVU] ([quyen], [TenChucVu]) VALUES (2, N'Nhân Viên')
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (1, N'1', 1, N'PL03', 685000.0000, CAST(N'2020-12-27 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (2, N'1', 1, N'PL02', 900000.0000, CAST(N'2020-11-11 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (3, N'1', 1, N'PL03', 800000.0000, CAST(N'2020-12-11 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (7, N'1', 1, N'PL05', 1200000.0000, CAST(N'2020-10-12 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (10, N'2', 1, N'PL006', 4000000.0000, CAST(N'2020-08-09 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (11, N'2', 1, N'PL008', 500000.0000, CAST(N'2020-02-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (12, N'2', 1, N'SV01', 8000000.0000, CAST(N'2020-02-02 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (13, N'2', 1, N'SV02', 10000000.0000, CAST(N'2020-03-03 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (14, N'2', 1, N'SV03', 6000000.0000, CAST(N'2020-04-04 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (15, N'1', 1, N'SV05', 8000000.0000, CAST(N'2020-05-05 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (16, N'2', 1, N'SV006', 7000000.0000, CAST(N'2020-06-06 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (17, N'1', 1, N'PL01', 10140000.0000, CAST(N'2020-12-28 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (18, N'1', 1, N'PL01', NULL, CAST(N'2020-12-28 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (19, N'1', 1, N'PL01', NULL, CAST(N'2020-12-28 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (20, N'1', 1, N'PL01', NULL, CAST(N'2020-12-28 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (21, N'2', 1, N'PL01', NULL, CAST(N'2020-12-28 00:00:00.000' AS DateTime))
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaBan], [TongTien], [NgayLap]) VALUES (22, N'2', 2, N'PL02', NULL, CAST(N'2020-12-28 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [DienThoai], [TheTV], [DiemTL]) VALUES (1, N'ABC', N'Nam', N'TPHCM', N'123', N'', 0)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [DiaChi], [DienThoai], [TheTV], [DiemTL]) VALUES (2, N'ABC', N'Nam', N'TPHCM', N'111', N'', 0)
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00001', N'Bia Heniken', N'Lon', 30000, N'N00005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00002', N'Bia Tiger', N'Chai', 30000, N'N00005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00003', N'Sting', N'Lon', 25000, N'N00005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00004', N'PépSi', N'Lon', 25000, N'N00005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00005', N'Nước Cam Ép', N'Ly', 35000, N'N00005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00006', N'Nước Trà Tắc', N'Ly', 25000, N'N00005')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00008', N'Rau Câu', N'Dĩa', 50000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00009', N'Trái Cây', N'Dĩa', 50000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00011', N'Chè khoai', N'Bát', 45000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00012', N'Mì gói thêm', N'Vắt', 5000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00013', N'Nước lẩu thêm', N'Bát', 20000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00014', N'Bún thêm', N'Đãi', 5000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00015', N'Thịt thêm', N'Đĩa', 100000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00016', N'Hải sản thêm', N'Đĩa', 200000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00019', N'Thịt heo 3 chỉ nướng', N'Kg', 350000, N'N00002')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00020', N'Thịt bò tơ', N'kg', 650000, N'N00003')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00021', N'Cá Lóc', N'kg', 400000, N'N00004')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00022', N'Tôm sông', N'kg', 600000, N'N00004')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00023', N'Lẩu Thái', N'Bát', 400000, N'N00007')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00024', N'Lẩu Bò tơ', N'Bát', 700000, N'N00007')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00025', N'Lẩu Hải sản', N'Bát', 500000, N'N00007')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00026', N'Rau thêm', N'Đĩa', 25000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00027', N'Kim Chi ', N'Đĩa', 25000, N'N00006')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00028', N'Thịt heo nướng muối ớt', N'Kg', 300000, N'N00002')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00029', N'Sườn heo nướng phô mai', N'Kg', 300000, N'N00002')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00030', N'Thịt Bò nướng khối', N'kg', 5000000, N'N00003')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00031', N'Gà ta nướng lu', N'kg', 300000, N'N00001')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00032', N'Gà ta nướng mật ong', N'kg', 300000, N'N00001')
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DonViTinh], [DonGia], [MaNhom]) VALUES (N'M00033', N'Gà Nướng muối tiêu chanh', N'Phần', 150000, N'N00001')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'NCC001', N'Trang Trại Gà Văn Đô')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'NCC002', N'Trang Trại Heo Hồng Phúc')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'NCC003', N'Trang Trại Bò ABC')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'NCC004', N'Công Ty Hãi Sãn Xanh')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'NCC005', N'Công Ty Cua BCD')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'NCC006', N'Công Ty Mực F')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'NCC007', N'Trang Trại Cá D')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'NCC008', N'Công Ty number 1')
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC]) VALUES (N'NCC009', N'Công Ty Bia Sài Gòn')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [UserName], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh], [quyen], [NgayVaoLam], [LuongCB]) VALUES (N'1', N'Nguyễn Văn Đô', N'admin', N'0353898075', N'Tây Ninh', CAST(N'2000-12-12' AS Date), N'Nam', 1, CAST(N'2018-01-01' AS Date), 1050000)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [UserName], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh], [quyen], [NgayVaoLam], [LuongCB]) VALUES (N'2', N'Nguyễn Hồng Phúc', N'phuc', N'0353898075', N'H? Chí Minh', CAST(N'2000-12-12' AS Date), N'Nữ', 1, CAST(N'2018-01-01' AS Date), 1050000)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [UserName], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh], [quyen], [NgayVaoLam], [LuongCB]) VALUES (N'3', N'Trần Hữu Phúc', N'3', N'111', N'Tây Ninh', CAST(N'2000-12-12' AS Date), N'Nam', 1, CAST(N'2020-11-20' AS Date), NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [UserName], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh], [quyen], [NgayVaoLam], [LuongCB]) VALUES (N'44', N'ABC', N'44', N'079', N'TPHCM', CAST(N'2000-12-20' AS Date), N'Nam', 1, CAST(N'2020-12-12' AS Date), NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [UserName], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh], [quyen], [NgayVaoLam], [LuongCB]) VALUES (N'55', N'Nguyễn Văn A', N'55', N'000', N'Tây Ninh', CAST(N'2000-12-12' AS Date), N'Nam', 2, CAST(N'2020-11-20' AS Date), NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [UserName], [DienThoai], [DiaChi], [NgaySinh], [GioiTinh], [quyen], [NgayVaoLam], [LuongCB]) VALUES (N'66', N'Tran Thai Toan', N'66', N'100', N'Tây Ninh', CAST(N'2000-12-12' AS Date), N'Nam', 2, CAST(N'2020-11-20' AS Date), NULL)
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'N00001', N'Món Gà')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'N00002', N'Món Heo')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'N00003', N'Món Bò')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'N00004', N'Hải Sản')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'N00005', N'Thức Uống')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'N00006', N'Món Ăn Kèm')
INSERT [dbo].[NHOMMONAN] ([MaNhom], [TenNhom]) VALUES (N'N00007', N'Lẩu')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONGIA], [MaNhom]) VALUES (N'SP001', N'Thịt Gà', 300000, N'N00001')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONGIA], [MaNhom]) VALUES (N'SP002', N'Thịt Heo', 200000, N'N00002')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONGIA], [MaNhom]) VALUES (N'SP003', N'Thịt Bò', 500000, N'N00003')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONGIA], [MaNhom]) VALUES (N'SP004', N'Tôm Hùm', 2000000, N'N00004')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONGIA], [MaNhom]) VALUES (N'SP005', N'Cua Hoàng Đế', 5000000, N'N00004')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONGIA], [MaNhom]) VALUES (N'SP006', N'Mực', 10000000, N'N00004')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONGIA], [MaNhom]) VALUES (N'SP007', N'Cá Hồi', 700000, N'N00004')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONGIA], [MaNhom]) VALUES (N'SP008', N'Nước Ngọt', 10000, N'N00005')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [DONGIA], [MaNhom]) VALUES (N'SP009', N'Beer', 20000, N'N00005')
ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNT_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[ACCOUNT] CHECK CONSTRAINT [FK_ACCOUNT_NV]
GO
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD  CONSTRAINT [FK_MaHD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIET_HD] CHECK CONSTRAINT [FK_MaHD]
GO
ALTER TABLE [dbo].[CHITIET_HD]  WITH CHECK ADD  CONSTRAINT [FK_MaMon] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MONAN] ([MaMon])
GO
ALTER TABLE [dbo].[CHITIET_HD] CHECK CONSTRAINT [FK_MaMon]
GO
ALTER TABLE [dbo].[CHITIETPN]  WITH CHECK ADD  CONSTRAINT [FK_CTPN] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PHIEUNHAP] ([MAPN])
GO
ALTER TABLE [dbo].[CHITIETPN] CHECK CONSTRAINT [FK_CTPN]
GO
ALTER TABLE [dbo].[CHITIETPN]  WITH CHECK ADD  CONSTRAINT [FK_CTPNSP] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETPN] CHECK CONSTRAINT [FK_CTPNSP]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HD_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HD_NV]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_MaBan] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BANAN] ([MaBan])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_MaBan]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_MaKH]
GO
ALTER TABLE [dbo].[MONAN]  WITH CHECK ADD  CONSTRAINT [FK_MaNhom] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMMONAN] ([MaNhom])
GO
ALTER TABLE [dbo].[MONAN] CHECK CONSTRAINT [FK_MaNhom]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NV_CV] FOREIGN KEY([quyen])
REFERENCES [dbo].[CHUCVU] ([quyen])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NV_CV]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PNNACC] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PNNACC]
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK_MaBan1] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BANAN] ([MaBan])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN] CHECK CONSTRAINT [FK_MaBan1]
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK_MaKH1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN] CHECK CONSTRAINT [FK_MaKH1]
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK_MaNV1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTHANHTOAN] CHECK CONSTRAINT [FK_MaNV1]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_NLMNA] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMMONAN] ([MaNhom])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_NLMNA]
GO
/****** Object:  Trigger [dbo].[TongTienHD]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[TongTienHD] ON [dbo].[CHITIET_HD]
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @tongtien FLOAT
	SELECT @tongtien = SUM(dbo.CHITIET_HD.TongMon)
	FROM dbo.CHITIET_HD,Inserted
	WHERE Inserted.mahd = dbo.CHITIET_HD.mahd
	UPDATE dbo.HOADON
	SET tongtien = @tongtien
	FROM Inserted
	WHERE HOADON.mahd = Inserted.mahd
END

GO
/****** Object:  Trigger [dbo].[TongTienPN]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[TongTienPN] ON [dbo].[CHITIETPN]
FOR INSERT, UPDATE
AS
BEGIN
DECLARE @giasp INT
	UPDATE dbo.CHITIETPN
	SET dbo.CHITIETPN.TONGTIENSP= Inserted.SOLUONG*Inserted.DONGIA
	FROM Inserted
	WHERE dbo.CHITIETPN.masp = Inserted.masp AND dbo.CHITIETPN.mapn = Inserted.mapn

	DECLARE @tongtien FLOAT
	SELECT @tongtien = SUM(dbo.CHITIETPN.TONGTIENSP)
	FROM dbo.CHITIETPN,Inserted
	WHERE Inserted.mapn = dbo.CHITIETPN.mapn 
	UPDATE dbo.PHIEUNHAP
	SET THANHTIEN = @tongtien
	FROM Inserted
	WHERE PHIEUNHAP.MAPN = Inserted.MAPN
END
GO
/****** Object:  Trigger [dbo].[dang_nhap]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[dang_nhap]
on [dbo].[NHANVIEN]
for insert
as
begin 
   declare @manv varchar(20)
   select @manv=[MaNV] from  inserted
   if not exists (select*from [dbo].[ACCOUNT] where [UserName]=@manv)
   insert into [dbo].[ACCOUNT] values (@manv,'123456',2)
end
GO
/****** Object:  Trigger [dbo].[del_dang_nhap]    Script Date: 12/28/2020 6:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[del_dang_nhap]
on [dbo].[NHANVIEN]
for delete
as 
begin
   declare @manv varchar(50)
   select @manv=[MaNV] from deleted
   delete from ACCOUNT where [UserName]=@manv
end
GO
