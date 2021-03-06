USE [master]
GO
/****** Object:  Database [ThuVien]    Script Date: 7/30/2020 8:50:16 AM ******/
CREATE DATABASE [ThuVien]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [ThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ThuVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [ThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ThuVien] SET DB_CHAINING OFF 
GO
USE [ThuVien]
GO
/****** Object:  Table [dbo].[CuonSach]    Script Date: 7/30/2020 8:50:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuonSach](
	[MaSach] [nchar](4) NULL,
	[MaCuon] [nchar](4) NOT NULL,
	[ViTri] [nvarchar](50) NULL,
 CONSTRAINT [PK_CuonSach] PRIMARY KEY CLUSTERED 
(
	[MaCuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DauSach]    Script Date: 7/30/2020 8:50:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DauSach](
	[MaSach] [nchar](4) NOT NULL,
	[Tua] [nvarchar](50) NOT NULL,
	[MaNXB] [nchar](4) NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 7/30/2020 8:50:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaThe] [nchar](4) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[NgayCap] [date] NULL,
	[HanDung] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 7/30/2020 8:50:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuonTra]    Script Date: 7/30/2020 8:50:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuonTra](
	[MaThe] [nchar](4) NOT NULL,
	[MaCuon] [nchar](4) NOT NULL,
	[MaNV] [nchar](4) NOT NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
 CONSTRAINT [PK_MuonTra] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC,
	[MaCuon] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/30/2020 8:50:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](4) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Nu] [bit] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDT] [nvarchar](50) NULL,
	[NgayNV] [date] NULL,
	[Luong] [numeric](18, 0) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 7/30/2020 8:50:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [nchar](4) NOT NULL,
	[TenNXB] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 7/30/2020 8:50:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [nchar](4) NOT NULL,
	[MaSach] [nchar](4) NOT NULL,
	[TenTG] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[ButDanh] [nvarchar](50) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S001', N'C101', N'Lầu 1')
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S001', N'C102', N'Lầu 2')
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S001', N'C103', N'Lầu 1')
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S001', N'C104', N'Lầu 4')
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S001', N'C105', N'Lầu 4')
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S002', N'C201', N'Lầu 1')
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S003', N'C202', N'Lầu 7')
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S003', N'C301', N'Lầu 9')
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S004', N'C401', N'Lầu 1')
INSERT [dbo].[CuonSach] ([MaSach], [MaCuon], [ViTri]) VALUES (N'S004', N'C402', N'Lầu 1')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S001', N'KT CHĂN NUÔI BÒ', N'N001')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S002', N'KT CHĂN NUÔI TÔM', N'N009')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S003', N'Lập trình cuộc sống', N'N001')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S004', N'BLOCKCHAIN', N'N001')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S005', N'Kiến thức tổng hợp', N'N002')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S006', N'CÙNG NHÌN LẠI', N'N004')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S007', N'KỸ THUẬT CƠ KHÍ', N'N009')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S008', N'KỸ THUẬT LẬP TRÌNH', N'N003')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S009', N'TOÁN CAO CẤP', N'N002')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S010', N'VẬT LÝ ĐẠI CƯƠNG', N'N001')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S011', N'HOÁ ĐẠI CƯƠNG', N'N009')
INSERT [dbo].[DauSach] ([MaSach], [Tua], [MaNXB]) VALUES (N'S012', N'TỔNG HỢP HOÁ SINH', N'N001')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D001', N'NGUYỄN VĂN TRÌNH', CAST(N'2014-11-11' AS Date), CAST(N'2019-03-12' AS Date), CAST(N'2020-03-12' AS Date), N'QUẬN 9')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D002', N'TRẦN KHÁNH DƯƠNG', CAST(N'2004-12-11' AS Date), CAST(N'2019-01-12' AS Date), CAST(N'2020-01-12' AS Date), N'QUẬN 10')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D003', N'TRẦN KHÁNH LONG', CAST(N'1996-06-05' AS Date), CAST(N'2019-01-01' AS Date), CAST(N'2020-01-01' AS Date), N'QUẬN 12')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D004', N'HOÀ CHÍ HOÀNG TRUNG', CAST(N'1994-11-21' AS Date), CAST(N'2018-12-01' AS Date), CAST(N'2020-12-01' AS Date), N'THỦ ĐỨC')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D005', N'NGUYỄN NGỌC ĐJAI', CAST(N'1019-11-11' AS Date), CAST(N'2019-02-01' AS Date), CAST(N'2020-02-01' AS Date), N'QUẬN 1')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D006', N'HOÀNG TRỌNG AN ', CAST(N'2001-04-02' AS Date), CAST(N'2019-01-17' AS Date), CAST(N'2020-01-17' AS Date), N'QUẬN 5')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D007', N'Nguyễn Ngọc Trang', CAST(N'1999-05-10' AS Date), CAST(N'2019-01-19' AS Date), CAST(N'2020-01-19' AS Date), N'Quận 9')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D008', N'Trương Duy Ngọc', CAST(N'1989-02-11' AS Date), CAST(N'2019-01-21' AS Date), CAST(N'2020-01-21' AS Date), N'Quận 1')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D009', N'Trần Thanh Phong', CAST(N'2000-01-01' AS Date), CAST(N'2019-01-31' AS Date), CAST(N'2020-01-31' AS Date), N'Quận 11')
INSERT [dbo].[DocGia] ([MaThe], [Hoten], [NgaySinh], [NgayCap], [HanDung], [DiaChi]) VALUES (N'D010', N'Nguyễn Trọng Đại', CAST(N'1999-01-18' AS Date), CAST(N'2019-02-01' AS Date), CAST(N'2020-02-01' AS Date), N'Quận 1')
INSERT [dbo].[Login] ([ID], [Pass]) VALUES (N'admin123', N'123')
INSERT [dbo].[Login] ([ID], [Pass]) VALUES (N'admin456', N'123')
INSERT [dbo].[Login] ([ID], [Pass]) VALUES (N'adminadmin', N'123')
INSERT [dbo].[Login] ([ID], [Pass]) VALUES (N'khanhtrinh', N'123')
INSERT [dbo].[Login] ([ID], [Pass]) VALUES (N'ltwindow', N'123')
INSERT [dbo].[Login] ([ID], [Pass]) VALUES (N'sonhai', N'123')
INSERT [dbo].[Login] ([ID], [Pass]) VALUES (N'tienganh', N'23')
INSERT [dbo].[MuonTra] ([MaThe], [MaCuon], [MaNV], [NgayMuon], [NgayTra]) VALUES (N'D001', N'C101', N'NV01', CAST(N'2019-03-11' AS Date), CAST(N'2019-04-11' AS Date))
INSERT [dbo].[MuonTra] ([MaThe], [MaCuon], [MaNV], [NgayMuon], [NgayTra]) VALUES (N'D001', N'C201', N'NV07', CAST(N'2019-01-11' AS Date), CAST(N'2019-07-11' AS Date))
INSERT [dbo].[MuonTra] ([MaThe], [MaCuon], [MaNV], [NgayMuon], [NgayTra]) VALUES (N'D001', N'C301', N'NV09', CAST(N'2019-03-09' AS Date), CAST(N'2019-09-09' AS Date))
INSERT [dbo].[MuonTra] ([MaThe], [MaCuon], [MaNV], [NgayMuon], [NgayTra]) VALUES (N'D001', N'C401', N'NV01', CAST(N'2019-01-17' AS Date), CAST(N'2019-04-17' AS Date))
INSERT [dbo].[MuonTra] ([MaThe], [MaCuon], [MaNV], [NgayMuon], [NgayTra]) VALUES (N'D006', N'C102', N'NV07', CAST(N'2019-02-12' AS Date), CAST(N'2019-04-12' AS Date))
INSERT [dbo].[MuonTra] ([MaThe], [MaCuon], [MaNV], [NgayMuon], [NgayTra]) VALUES (N'D007', N'C104', N'NV06', CAST(N'2019-01-14' AS Date), CAST(N'2019-02-14' AS Date))
INSERT [dbo].[MuonTra] ([MaThe], [MaCuon], [MaNV], [NgayMuon], [NgayTra]) VALUES (N'D009', N'C202', N'NV07', CAST(N'2019-04-01' AS Date), CAST(N'2019-04-18' AS Date))
INSERT [dbo].[MuonTra] ([MaThe], [MaCuon], [MaNV], [NgayMuon], [NgayTra]) VALUES (N'D009', N'C402', N'NV01', CAST(N'2019-03-11' AS Date), CAST(N'2019-05-19' AS Date))
INSERT [dbo].[MuonTra] ([MaThe], [MaCuon], [MaNV], [NgayMuon], [NgayTra]) VALUES (N'D010', N'C301', N'NV01', CAST(N'2019-04-11' AS Date), CAST(N'2019-05-11' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'NV01', N'Trần Thị B', 1, N'Gò vấp', N'09090     ', CAST(N'2014-07-16' AS Date), CAST(6500000 AS Numeric(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'NV02', N'Võ Văn Bé', 0, N'Gò vấp', N'0909090909', CAST(N'1995-08-05' AS Date), CAST(6700000 AS Numeric(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'NV03', N'Long Văn Bi', 0, N'Quận 9', N'0909090909', CAST(N'2018-09-03' AS Date), CAST(6800000 AS Numeric(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'NV04', N'Trần Văn Dền', 0, N'Quận 1', N'1231231231', CAST(N'2004-08-15' AS Date), CAST(8000000 AS Numeric(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'NV05', N'Đi Không Về', 1, N'Quận 5', N'1232131231', CAST(N'1990-09-26' AS Date), CAST(10000000 AS Numeric(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'NV06', N'Nguyễn Văn AA', 0, N'Gò vấp', N'1231231231', CAST(N'2006-12-08' AS Date), CAST(5000000 AS Numeric(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'NV07', N'Nguyễn Văn AB', 0, N'Tân bình', N'1232134354', CAST(N'2012-11-05' AS Date), CAST(5500000 AS Numeric(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'NV08', N'Nguyễn Văn AC', 0, N'Bình thạnh', N'5645243266', CAST(N'2001-07-12' AS Date), CAST(7000000 AS Numeric(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'NV09', N'Nguyễn Văn AD', 0, N'Tân bình', N'1921873161', CAST(N'2018-10-30' AS Date), CAST(9000000 AS Numeric(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [Nu], [DiaChi], [SoDT], [NgayNV], [Luong]) VALUES (N'TT05', N'Nguyễn Thị AE', 1, N'Bình thạnh', N'9621835281', CAST(N'2018-11-30' AS Date), CAST(5600000 AS Numeric(18, 0)))
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N001', N'NXB Kim Đồng', N'Quận 7')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N002', N'NXB Sinh Viên', N'Thủ Đức')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N003', N'NXB Thăng Long', N'Quận 5')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N004', N'NXB Thanh Niên', N'Quân 1')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N005', N'NXB Winglen', N'Quận 3')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N006', N'Sự Thật', N'Quận 7')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N007', N'Ánh Sáng', N'Quận 1')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N008', N'Con Đường Mới', N'Quận 9')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N009', N'Quốc Gia', N'Thủ Đức')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi]) VALUES (N'N010', N'Sáng Tạo', N'Quận 1')
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T001', N'S001', N'Hemmingway', N'Quận 2', N'')
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T001', N'S002', N'Hemingway', N'Quận 2', N'Độc Hành')
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T001', N'S003', N'Hemingway', N'Quận 7', N'Cố Hương')
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T001', N'S004', N'Hemingway', N'Quận 8', N'Chốn Xưa')
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T002', N'S001', N'Nguyễn Nhật', N'Thủ Đức', N'Tìm về')
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T003', N'S001', N'Long Nhất', N'Quận 10', N'Sống')
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T004', N'S001', N'Nhật Quang', N'Quận 1', NULL)
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T005', N'S009', N'Nguyễn Ngọc', N'Quận 9', NULL)
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T009', N'S010', N'Trần Qúy', N'Thủ Đức', N'Con Con')
INSERT [dbo].[TacGia] ([MaTG], [MaSach], [TenTG], [DiaChi], [ButDanh]) VALUES (N'T010', N'S001', N'Nguyễn Quang', N'Quận 1', NULL)
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD  CONSTRAINT [FK_CuonSach_DauSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[DauSach] ([MaSach])
GO
ALTER TABLE [dbo].[CuonSach] CHECK CONSTRAINT [FK_CuonSach_DauSach]
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD  CONSTRAINT [FK_DauSach_NXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[DauSach] CHECK CONSTRAINT [FK_DauSach_NXB]
GO
ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD  CONSTRAINT [FK_MuonTra_CuonSach] FOREIGN KEY([MaCuon])
REFERENCES [dbo].[CuonSach] ([MaCuon])
GO
ALTER TABLE [dbo].[MuonTra] CHECK CONSTRAINT [FK_MuonTra_CuonSach]
GO
ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD  CONSTRAINT [FK_MuonTra_DocGia] FOREIGN KEY([MaThe])
REFERENCES [dbo].[DocGia] ([MaThe])
GO
ALTER TABLE [dbo].[MuonTra] CHECK CONSTRAINT [FK_MuonTra_DocGia]
GO
ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD  CONSTRAINT [FK_MuonTra_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[MuonTra] CHECK CONSTRAINT [FK_MuonTra_NhanVien]
GO
ALTER TABLE [dbo].[TacGia]  WITH CHECK ADD  CONSTRAINT [FK_TacGia_DauSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[DauSach] ([MaSach])
GO
ALTER TABLE [dbo].[TacGia] CHECK CONSTRAINT [FK_TacGia_DauSach]
GO
USE [master]
GO
ALTER DATABASE [ThuVien] SET  READ_WRITE 
GO
