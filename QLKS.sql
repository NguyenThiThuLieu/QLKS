USE [QLKS]
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 01/06/2022 6:21:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatPhong](
	[MaKH] [int] NOT NULL,
	[NgayDen] [date] NULL,
	[NgayDi] [date] NULL,
	[MaPhong] [nchar](10) NOT NULL,
	[TienCoc] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 01/06/2022 6:21:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [nchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[GiaDV] [float] NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 01/06/2022 6:21:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[ThanhTien] [float] NULL,
	[TrangThai] [bit] NULL,
	[NgayThanhToan] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 01/06/2022 6:21:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[CMND] [varchar](20) NOT NULL,
	[SDT] [char](10) NULL,
	[QuocTich] [nvarchar](50) NULL,
	[VIP] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 01/06/2022 6:21:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[MatKhau] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 01/06/2022 6:21:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[LoaiPhong] [nvarchar](50) NULL,
	[TrangThai] [bit] NOT NULL,
	[Gia] [float] NULL,
	[HinhAnh] [nvarchar](50) NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SDDV]    Script Date: 01/06/2022 6:21:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SDDV](
	[MaKH] [int] NOT NULL,
	[MaDV] [nchar](10) NOT NULL,
	[NgaySD] [date] NULL,
	[TrangThai] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuePhong]    Script Date: 01/06/2022 6:21:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuePhong](
	[MaKH] [int] NOT NULL,
	[NgayDen] [date] NULL,
	[NgayDi] [date] NULL,
	[MaPhong] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[TrangThai] [bit] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[DatPhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [TienCoc]) VALUES (1, CAST(N'2021-02-09' AS Date), CAST(N'2021-02-11' AS Date), N'F101      ', 200000)
INSERT [dbo].[DatPhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [TienCoc]) VALUES (1, CAST(N'2022-01-05' AS Date), CAST(N'2022-01-08' AS Date), N'F101      ', 200000)
INSERT [dbo].[DatPhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [TienCoc]) VALUES (2, CAST(N'2022-01-09' AS Date), CAST(N'2022-01-13' AS Date), N'V106      ', 240000)
INSERT [dbo].[DatPhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [TienCoc]) VALUES (2, CAST(N'2022-01-09' AS Date), CAST(N'2022-01-12' AS Date), N'V205      ', 240000)
INSERT [dbo].[DatPhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [TienCoc]) VALUES (2, CAST(N'0001-01-01' AS Date), CAST(N'0001-01-01' AS Date), N'V106      ', 240000)
INSERT [dbo].[DatPhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [TienCoc]) VALUES (12, CAST(N'2022-01-13' AS Date), CAST(N'2022-01-10' AS Date), N'V106      ', 240000)
INSERT [dbo].[DatPhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [TienCoc]) VALUES (12, CAST(N'2022-01-13' AS Date), CAST(N'2022-01-10' AS Date), N'V205      ', 240000)
GO
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (N'AS        ', N'Ăn sáng', 50000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (N'AT        ', N'Ăn trưa', 70000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (N'AToi      ', N'Ăn tối', 70000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (N'GU        ', N'Giặt ủi', 20000)
INSERT [dbo].[DichVu] ([MaDV], [TenDV], [GiaDV]) VALUES (N'PV        ', N'Phục vụ', 50000)
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (1, 1, 620000, 1, CAST(N'2022-01-03' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (2, 7, 600020, 1, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (3, 7, 600000, 1, CAST(N'2022-01-05' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (4, 7, 600000, 1, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (5, 7, 600000, 1, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (6, 7, 600000, 1, CAST(N'2022-01-06' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (7, 2, 1250000, 1, CAST(N'2022-01-04' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (8, 2, 550000, 1, CAST(N'2022-01-06' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (9, 2, 550000, 1, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (10, 2, 550000, 1, CAST(N'2022-01-06' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (11, 2, 550000, 1, CAST(N'2022-01-06' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (12, 7, 600000, 1, CAST(N'2022-01-06' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (13, 2, 550000, 1, CAST(N'2022-01-06' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (14, 7, 600000, 1, CAST(N'2022-01-06' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (15, 2, 550000, 0, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (16, 2, 550000, 0, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [ThanhTien], [TrangThai], [NgayThanhToan]) VALUES (17, 2, 550000, 1, CAST(N'2022-01-12' AS Date))
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (1, N'Sơn Tùng', N'458798655', N'0356876452', N'Thái Bình', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (2, N'Lâm Ngạn Tuấn', N'24081995', N'0698723256', N'Trung Quốc', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (3, N'Nhậm Gia Luân', N'11041989', N'0396526532', N'Thanh Đảo', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (4, N'MTP', N'05071995', N'0626526598', N'Việt Nam', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (5, N'Evan', N'24081995', N'0096532969', N'Việt Nam', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (6, N'Allen', N'06546588', N'0988695630', N'Mỹ', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (7, N'Nguyễn Thị Thu Liễu', N'215589255', N'0367724451', N'Bình Định', 1)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (8, N'Thu', N'215589253', N'0367724451', N'Việt Nam', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (9, N'Thu', N'215589254', N'0367724451', N'Lào Cai', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (10, N'sang', N'457645899', N'0367724451', N'Lào Cai', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (11, N'Sallen', N'222222222', N'0367724451', N'Việt Nam', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (12, N'Thu Liễu', N'2155589255', N'0367724451', N'Việt Nam', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (15, N'Nguyễn Ngọc Thiện', N'154468522', N'0988695630', N'Bình Định', 0)
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [CMND], [SDT], [QuocTich], [VIP]) VALUES (16, N'Hạo Thiên', N'478895688', N'0359845754', N'Việt Nam', 0)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Ngaysinh], [GioiTinh], [SDT], [MatKhau]) VALUES (N'NV1       ', N'Bùi Văn Tình', CAST(N'2001-01-08' AS Date), N'Nam', N'0357896482', N'vantinh   ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Ngaysinh], [GioiTinh], [SDT], [MatKhau]) VALUES (N'NV2       ', N'Thu Liễu', CAST(N'2001-10-15' AS Date), N'', N'0367724451', N'          ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Ngaysinh], [GioiTinh], [SDT], [MatKhau]) VALUES (N'NV3       ', N'Sallen', CAST(N'2001-08-29' AS Date), N'Nữ', N'0315689465', N'sallen    ')
GO
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F101      ', N'Phòng 101', N'1', 0, 500000, N'F101      .jpg')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F102      ', N'Phòng 102', N'1', 1, 500000, N'F102      .jpg')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F103      ', N'Phòng 103', N'1', 0, 500000, N'F103      .jpg')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F104      ', N'Phòng 104', N'2', 1, 700000, N'F104      .jpg')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F105      ', N'Phòng 105', N'2', 0, 700000, N'F105      .jpg')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F201      ', N'Phòng 201', N'1', 0, 600000, N'F201      .jpg')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F202      ', N'Phòng 202', N'2', 1, 800000, N'F202      .png')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F203      ', N'Phòng 203', N'2', 0, 800000, N'F203      .jpg')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F204      ', N'Phòng 204', N'1', 0, 600000, N'F204      .jpg')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F301      ', N'Phòng 301', N'4', 0, 900000, NULL)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F302      ', N'Phòng 302', N'3', 0, 900000, NULL)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'F303      ', N'Phòng 303', N'5', 0, 1000000, NULL)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'V106      ', N'Phòng 106', N'1', 1, 800000, NULL)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'V107      ', N'Phòng 107', N'2', 0, 1000000, NULL)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'V205      ', N'Phòng 205', N'1', 0, 800000, NULL)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'V206      ', N'Phòng 206', N'2', 0, 1200000, NULL)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [LoaiPhong], [TrangThai], [Gia], [HinhAnh]) VALUES (N'V207      ', N'Phòng 207', N'5', 0, 800000, NULL)
GO
INSERT [dbo].[SDDV] ([MaKH], [MaDV], [NgaySD], [TrangThai]) VALUES (1, N'AS        ', CAST(N'2022-01-04' AS Date), 0)
INSERT [dbo].[SDDV] ([MaKH], [MaDV], [NgaySD], [TrangThai]) VALUES (2, N'AS        ', CAST(N'2022-01-05' AS Date), 0)
INSERT [dbo].[SDDV] ([MaKH], [MaDV], [NgaySD], [TrangThai]) VALUES (1, N'AT        ', CAST(N'2022-01-04' AS Date), 0)
GO
INSERT [dbo].[ThuePhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [MaNV], [TrangThai]) VALUES (2, CAST(N'2021-12-31' AS Date), CAST(N'2022-01-06' AS Date), N'F102      ', N'NV1       ', 0)
INSERT [dbo].[ThuePhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [MaNV], [TrangThai]) VALUES (2, CAST(N'2022-01-09' AS Date), CAST(N'2022-01-12' AS Date), N'F102      ', N'NV1       ', 0)
INSERT [dbo].[ThuePhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [MaNV], [TrangThai]) VALUES (2, CAST(N'2022-01-05' AS Date), CAST(N'2022-01-12' AS Date), N'F104      ', N'NV1       ', 0)
INSERT [dbo].[ThuePhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [MaNV], [TrangThai]) VALUES (2, CAST(N'2021-12-31' AS Date), CAST(N'2022-01-06' AS Date), N'F103      ', N'NV1       ', 0)
INSERT [dbo].[ThuePhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [MaNV], [TrangThai]) VALUES (12, CAST(N'2022-01-05' AS Date), CAST(N'2022-01-12' AS Date), N'V106      ', N'NV1       ', 0)
INSERT [dbo].[ThuePhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [MaNV], [TrangThai]) VALUES (11, CAST(N'2022-01-02' AS Date), CAST(N'2022-01-12' AS Date), N'F202      ', N'NV2       ', 0)
INSERT [dbo].[ThuePhong] ([MaKH], [NgayDen], [NgayDi], [MaPhong], [MaNV], [TrangThai]) VALUES (7, CAST(N'2022-01-01' AS Date), CAST(N'2022-01-06' AS Date), N'F201      ', N'NV1       ', 0)
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_KhachHang]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_Phong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[SDDV]  WITH CHECK ADD  CONSTRAINT [FK_SDDV_DichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[SDDV] CHECK CONSTRAINT [FK_SDDV_DichVu]
GO
ALTER TABLE [dbo].[SDDV]  WITH CHECK ADD  CONSTRAINT [FK_SDDV_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[SDDV] CHECK CONSTRAINT [FK_SDDV_KhachHang]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_KhachHang]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_NhanVien]
GO
ALTER TABLE [dbo].[ThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[ThuePhong] CHECK CONSTRAINT [FK_ThuePhong_Phong]
GO
