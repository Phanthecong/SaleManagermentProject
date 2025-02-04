USE [master]
GO
/****** Object:  Database [SalesManagermentSoftwareDB]    Script Date: 12/31/2019 5:03:23 AM ******/
CREATE DATABASE [SalesManagermentSoftwareDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalesManagermentSoftwareDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SalesManagermentSoftwareDB.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SalesManagermentSoftwareDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SalesManagermentSoftwareDB_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalesManagermentSoftwareDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET  MULTI_USER 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SalesManagermentSoftwareDB]
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ChangePassword]
	@Username nvarchar(100),
	@Password varchar(20)
as
begin
	update Users
	set Password = @Password
	where Username = @Username
end
GO
/****** Object:  StoredProcedure [dbo].[Info_Update]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Info_Update]
	@CompanyID int,
	@CompanyName nvarchar(100),
	@Address nvarchar(256),
	@PhoneNumber varchar(11),
	@Fax varchar(20),
	@Website varchar(50),
	@Email varchar(50),
	@FieldID int,
	@Tax varchar(11),
	@GPKD varchar(11)
as
	update Company
	set CompanyName = @CompanyName,
		Address = @Address,
		PhoneNumber = @PhoneNumber,
		Fax = @Fax,
		Website = @Website,
		Email = @Email,
		FieldID = @FieldID,
		Tax = @Tax,
		GPKD =@GPKD
	where CompanyID = @CompanyID



GO
/****** Object:  Table [dbo].[Areas]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Areas](
	[AreaID] [int] NOT NULL,
	[AreaName] [nvarchar](100) NULL,
	[Note] [nvarchar](256) NULL,
 CONSTRAINT [PK_Areas] PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Company]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyID] [int] NOT NULL,
	[CompanyName] [nvarchar](100) NULL,
	[Address] [nvarchar](256) NULL,
	[PhoneNumber] [varchar](11) NULL,
	[Fax] [varchar](20) NULL,
	[Website] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[FieldID] [int] NULL,
	[Tax] [varchar](11) NULL,
	[GPKD] [varchar](11) NULL,
 CONSTRAINT [PF_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PB]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PB](
	[MaPB] [nchar](10) NOT NULL,
	[STT] [int] NULL,
	[TenHang] [nvarchar](100) NULL,
	[DonVi] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [real] NULL,
 CONSTRAINT [PK_CT_PB] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PN]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PN](
	[MaPN] [nchar](10) NOT NULL,
	[STT] [int] NOT NULL,
	[TenHang] [nvarchar](100) NULL,
	[DonVi] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [real] NULL,
 CONSTRAINT [PK_CT_PN] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Contact] [nvarchar](50) NULL,
	[Phonenumber] [varchar](11) NULL,
	[Email] [varchar](30) NULL,
	[Fax] [varchar](30) NULL,
	[Tax] [varchar](15) NULL,
	[Address] [nvarchar](255) NULL,
	[Website] [varchar](50) NULL,
	[AccountNumber] [varchar](20) NULL,
 CONSTRAINT [PK_Cus] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Department]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentID] [int] NULL,
	[DepartmentName] [nchar](100) NULL,
	[Note] [nchar](256) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] NOT NULL,
	[UserID] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[Address] [nvarchar](255) NULL,
	[Phonenumber] [varchar](11) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExchangeRate]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExchangeRate](
	[ExchangeRateID] [int] NULL,
	[Name] [nchar](100) NULL,
	[ExchangeRate] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fields]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fields](
	[FieldID] [int] NOT NULL,
	[FieldName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Field] PRIMARY KEY CLUSTERED 
(
	[FieldID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Form]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Form](
	[ID] [int] NULL,
	[FormID] [int] NOT NULL,
	[FormName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Form] PRIMARY KEY CLUSTERED 
(
	[FormID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupOfGoods]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupOfGoods](
	[GOGID] [int] NOT NULL,
	[GOGName] [nchar](100) NULL,
	[Note] [nchar](256) NULL,
 CONSTRAINT [PK_GroupOfGoods] PRIMARY KEY CLUSTERED 
(
	[GOGID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiHangHoa]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHangHoa](
	[IDLoaiHangHoa] [int] NOT NULL,
	[LoaiHangHoa] [nchar](10) NULL,
 CONSTRAINT [PK_LoaiHangHoa] PRIMARY KEY CLUSTERED 
(
	[IDLoaiHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[UnitID] [int] NULL,
	[WarehouseID] [int] NULL,
	[EmployeeID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[DeliveryDate] [datetime] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuBan]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuBan](
	[MaPN] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NULL,
	[KhoXuat] [int] NULL,
	[Ngay] [nvarchar](50) NULL,
	[NgayGiao] [nvarchar](50) NULL,
	[HanThanhToan] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](250) NULL,
	[TongTien] [real] NULL,
 CONSTRAINT [PK_PhieuBan] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [nchar](10) NOT NULL,
	[NCC] [nchar](10) NULL,
	[KhoXuat] [int] NULL,
	[Ngay] [nvarchar](50) NULL,
	[NgayGiao] [nvarchar](50) NULL,
	[HanThanhToan] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](250) NULL,
	[TongTien] [real] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[Image] [nvarchar](100) NULL,
	[Quantity] [int] NULL,
	[UnitID] [int] NULL,
	[Price] [float] NULL,
	[Code] [varchar](100) NULL,
	[SupplierID] [int] NULL,
	[WarehouseID] [int] NULL,
 CONSTRAINT [PF_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Role_Form]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role_Form](
	[RoleId] [int] NOT NULL,
	[FormID] [int] NOT NULL,
	[AllowAccess] [bit] NULL,
	[AllowAdd] [bit] NULL,
	[AllowDelete] [bit] NULL,
	[AllowUpdate] [bit] NULL,
	[AllowImport] [bit] NULL,
	[AllowExport] [bit] NULL,
 CONSTRAINT [PK_Role_Form] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC,
	[FormID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] NULL,
	[RoleID] [int] NOT NULL,
	[Rolename] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierID] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Contact] [nvarchar](50) NULL,
	[Address] [nvarchar](255) NULL,
	[Phonenumber] [varchar](11) NULL,
	[Fax] [varchar](30) NULL,
	[Position] [nvarchar](50) NULL,
	[Code] [nchar](10) NULL,
 CONSTRAINT [PK_Sup] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Units]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Units](
	[UnitID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] NOT NULL,
	[Username] [nvarchar](100) NULL,
	[Password] [varchar](20) NULL,
	[RoleID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 12/31/2019 5:03:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[WarehouseID] [int] IDENTITY(1,1) NOT NULL,
	[ManagementStaff] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[Contact] [nvarchar](100) NULL,
	[Address] [nvarchar](255) NULL,
	[Status] [nvarchar](20) NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[WarehouseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Areas] ([AreaID], [AreaName], [Note]) VALUES (1, N'Miền Nam', NULL)
INSERT [dbo].[Areas] ([AreaID], [AreaName], [Note]) VALUES (2, N'Miền Bắc', NULL)
INSERT [dbo].[Areas] ([AreaID], [AreaName], [Note]) VALUES (3, N'Miền Trung', NULL)
INSERT [dbo].[Company] ([CompanyID], [CompanyName], [Address], [PhoneNumber], [Fax], [Website], [Email], [FieldID], [Tax], [GPKD]) VALUES (1, N'Nhóm Tên Gì Cũng Được', N'227 Nguyễn Văn Cừ, p.4, q.5', N'', N'', N'', N'', 1, N'', N'')
INSERT [dbo].[CT_PN] ([MaPN], [STT], [TenHang], [DonVi], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'hhhh      ', 0, N'IPhone XS Max', 33, 0, 33, 1089)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [Name], [Contact], [Phonenumber], [Email], [Fax], [Tax], [Address], [Website], [AccountNumber]) VALUES (1, N'Huu Duc', N'', N'1986122031', N'duc@gmail.com', N'', N'', N'', N'', N'')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Contact], [Phonenumber], [Email], [Fax], [Tax], [Address], [Website], [AccountNumber]) VALUES (2, N'Thanh Duong', N'', N'0163754238', N'duong@gmail.com', N'', N'', N'', N'', N'')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Contact], [Phonenumber], [Email], [Fax], [Tax], [Address], [Website], [AccountNumber]) VALUES (3, N'Phan The Cong', N'', N'033226739', N'cong@gmail.com', N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Department] ([DepartmentID], [DepartmentName], [Note]) VALUES (1, N'Giám Đốc                                                                                            ', NULL)
INSERT [dbo].[Department] ([DepartmentID], [DepartmentName], [Note]) VALUES (2, N'Phòng Kinh Doanh                                                                                    ', NULL)
INSERT [dbo].[Department] ([DepartmentID], [DepartmentName], [Note]) VALUES (3, N'Phòng Kế Toán                                                                                       ', NULL)
INSERT [dbo].[Department] ([DepartmentID], [DepartmentName], [Note]) VALUES (4, N'Phong Kỹ Thuật                                                                                      ', NULL)
INSERT [dbo].[Employee] ([EmployeeID], [UserID], [Name], [Address], [Phonenumber], [Email]) VALUES (1, 1, N'Thien', N'', N'0123455672', N'thien@gmail.com')
INSERT [dbo].[Employee] ([EmployeeID], [UserID], [Name], [Address], [Phonenumber], [Email]) VALUES (2, 1, N'An', N'', N'0123452157', N'an@gmail.com')
INSERT [dbo].[Employee] ([EmployeeID], [UserID], [Name], [Address], [Phonenumber], [Email]) VALUES (3, 2, N'Phuong', N'', N'012349251', N'phuong@gmail.com')
INSERT [dbo].[ExchangeRate] ([ExchangeRateID], [Name], [ExchangeRate]) VALUES (1, N'Việt Nam Đồng                                                                                       ', 1)
INSERT [dbo].[ExchangeRate] ([ExchangeRateID], [Name], [ExchangeRate]) VALUES (2, N'Đô la Mỹ                                                                                            ', 24000)
INSERT [dbo].[ExchangeRate] ([ExchangeRateID], [Name], [ExchangeRate]) VALUES (3, N'Bảng Anh                                                                                            ', 27000)
INSERT [dbo].[ExchangeRate] ([ExchangeRateID], [Name], [ExchangeRate]) VALUES (4, N'Đồng tiền chung EU                                                                                  ', 18000)
INSERT [dbo].[Fields] ([FieldID], [FieldName]) VALUES (1, N'Sản Xuất')
INSERT [dbo].[Fields] ([FieldID], [FieldName]) VALUES (2, N'Thương Mại')
INSERT [dbo].[Fields] ([FieldID], [FieldName]) VALUES (3, N'Dịch Vụ')
INSERT [dbo].[Fields] ([FieldID], [FieldName]) VALUES (4, N'Xây Dựng')
INSERT [dbo].[Fields] ([FieldID], [FieldName]) VALUES (5, N'Khác')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (1, 1, N'User Managerment')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (2, 2, N'Warehouse Mnagerment')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (3, 3, N'Sales Managerment')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (4, 4, N'AreasForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 5, N'CustomerForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 6, N'SupplierForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 7, N'WarehouseForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 8, N'UnitForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 9, N'GOGForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 10, N'ProductForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 11, N'ExchangeRateForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 12, N'DepartmentForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 13, N'EmployeeForm')
INSERT [dbo].[Form] ([ID], [FormID], [FormName]) VALUES (NULL, 14, N'Phan quyen')
INSERT [dbo].[GroupOfGoods] ([GOGID], [GOGName], [Note]) VALUES (1, N'An ninh siêu thị                                                                                    ', NULL)
INSERT [dbo].[GroupOfGoods] ([GOGID], [GOGName], [Note]) VALUES (2, N'Dây cáp                                                                                             ', NULL)
INSERT [dbo].[GroupOfGoods] ([GOGID], [GOGName], [Note]) VALUES (3, N'Điện Thoại                                                                                          ', NULL)
INSERT [dbo].[GroupOfGoods] ([GOGID], [GOGName], [Note]) VALUES (4, N'Ổ cứng                                                                                              ', NULL)
INSERT [dbo].[LoaiHangHoa] ([IDLoaiHangHoa], [LoaiHangHoa]) VALUES (1, N'Hàng hóa  ')
INSERT [dbo].[LoaiHangHoa] ([IDLoaiHangHoa], [LoaiHangHoa]) VALUES (2, N'Dịch vụ   ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ProductID], [Quantity], [UnitID], [WarehouseID], [EmployeeID], [OrderDate], [DeliveryDate]) VALUES (1, 1, 1, 15, 1, 1, 3, CAST(N'2018-02-12 00:00:00.000' AS DateTime), CAST(N'2018-02-17 00:00:00.000' AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ProductID], [Quantity], [UnitID], [WarehouseID], [EmployeeID], [OrderDate], [DeliveryDate]) VALUES (2, 1, 2, 15, 1, 1, 3, CAST(N'2018-02-12 00:00:00.000' AS DateTime), CAST(N'2018-02-17 00:00:00.000' AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [ProductID], [Quantity], [UnitID], [WarehouseID], [EmployeeID], [OrderDate], [DeliveryDate]) VALUES (3, 2, 3, 20, 2, 1, 2, CAST(N'2018-08-25 00:00:00.000' AS DateTime), CAST(N'2018-09-04 00:00:00.000' AS DateTime))
INSERT [dbo].[PhieuBan] ([MaPN], [MaKH], [KhoXuat], [Ngay], [NgayGiao], [HanThanhToan], [GhiChu], [TongTien]) VALUES (N'          ', N'          ', 1, N'', N'', N'', N'', 0)
INSERT [dbo].[PhieuNhap] ([MaPN], [NCC], [KhoXuat], [Ngay], [NgayGiao], [HanThanhToan], [GhiChu], [TongTien]) VALUES (N'          ', N'          ', 1, N'', N'', N'', N'', 0)
INSERT [dbo].[PhieuNhap] ([MaPN], [NCC], [KhoXuat], [Ngay], [NgayGiao], [HanThanhToan], [GhiChu], [TongTien]) VALUES (N'dddd      ', N'          ', 1, N'', N'', N'', N'', 0)
INSERT [dbo].[PhieuNhap] ([MaPN], [NCC], [KhoXuat], [Ngay], [NgayGiao], [HanThanhToan], [GhiChu], [TongTien]) VALUES (N'ff        ', N'          ', 1, N'', N'', N'', N'', 0)
INSERT [dbo].[PhieuNhap] ([MaPN], [NCC], [KhoXuat], [Ngay], [NgayGiao], [HanThanhToan], [GhiChu], [TongTien]) VALUES (N'gn        ', N'HW        ', 1, N'12/25/2019 12:00:00 AM', N'12/18/2019 12:00:00 AM', N'12/11/2019 12:00:00 AM', N'aaaa', 0)
INSERT [dbo].[PhieuNhap] ([MaPN], [NCC], [KhoXuat], [Ngay], [NgayGiao], [HanThanhToan], [GhiChu], [TongTien]) VALUES (N'hhhh      ', N'          ', 1, N'', N'', N'', N'', 0)
INSERT [dbo].[PhieuNhap] ([MaPN], [NCC], [KhoXuat], [Ngay], [NgayGiao], [HanThanhToan], [GhiChu], [TongTien]) VALUES (N'PH        ', N'HW        ', 1, N'DevExpress.XtraEditors.DateEdit', N'DevExpress.XtraEditors.DateEdit', N'DevExpress.XtraEditors.DateEdit', N'1111', 0)
INSERT [dbo].[PhieuNhap] ([MaPN], [NCC], [KhoXuat], [Ngay], [NgayGiao], [HanThanhToan], [GhiChu], [TongTien]) VALUES (N'vv        ', N'          ', 1, N'', N'', N'', N'', 0)
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (1, N'IPhone XS Max', N'', N'', 12, 1, 20000000, N'', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (2, N'Huawei P30', N'', N'', 20, 1, 15000000, N'', 3, 3)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (3, N'SamSung Note10', N'', N'', 15, 1, 17000000, N'', 2, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (4, N'dd', N'đ', N'đ', 12, 1, 3333, NULL, 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (5, N'dd', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (6, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (7, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (8, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (9, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (10, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (11, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (12, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (13, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (14, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (15, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (16, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (17, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (18, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (19, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (20, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (21, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (22, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (23, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (24, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (25, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (26, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (27, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (28, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (29, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (30, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (31, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (32, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (33, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (34, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (35, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (36, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (37, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (38, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Image], [Quantity], [UnitID], [Price], [Code], [SupplierID], [WarehouseID]) VALUES (39, N'cam', N'd?', N'orangeTee', 10, 1, 12000, N'1234567a', 1, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (1, 1, 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (2, 1, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 4, 1, 1, 0, 0, 1, 1)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 5, 0, 1, 0, 0, 0, 1)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 6, 1, 1, 1, 0, 0, 1)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 7, 1, 1, 1, 0, 0, 1)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 8, 1, 1, 1, 0, 0, 0)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 9, 1, 1, 1, 0, 0, 1)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 10, 1, 1, 0, 0, 0, 1)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 11, 1, 1, 1, 0, 0, 1)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 12, 1, 1, 1, 0, 0, 1)
INSERT [dbo].[Role_Form] ([RoleId], [FormID], [AllowAccess], [AllowAdd], [AllowDelete], [AllowUpdate], [AllowImport], [AllowExport]) VALUES (3, 13, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[Roles] ([ID], [RoleID], [Rolename]) VALUES (1, 1, N'Người dùng')
INSERT [dbo].[Roles] ([ID], [RoleID], [Rolename]) VALUES (2, 2, N'Quản lý bán hàng')
INSERT [dbo].[Roles] ([ID], [RoleID], [Rolename]) VALUES (3, 3, N'Admin')
INSERT [dbo].[Roles] ([ID], [RoleID], [Rolename]) VALUES (4, 4, N'Quản lý kho')
INSERT [dbo].[Supplier] ([SupplierID], [Name], [Contact], [Address], [Phonenumber], [Fax], [Position], [Code]) VALUES (1, N'Apple Store', N'', N'', N'0966711271', N'', N'', N'AP        ')
INSERT [dbo].[Supplier] ([SupplierID], [Name], [Contact], [Address], [Phonenumber], [Fax], [Position], [Code]) VALUES (2, N'Huawei Store', N'', N'', N'0314266931', N'', N'', N'HW        ')
INSERT [dbo].[Supplier] ([SupplierID], [Name], [Contact], [Address], [Phonenumber], [Fax], [Position], [Code]) VALUES (3, N'The Gioi Di Dong', N'', N'', N'0963577437', N'', N'', N'TGDD      ')
INSERT [dbo].[Units] ([UnitID], [Name], [Note]) VALUES (1, N'Cái', N'')
INSERT [dbo].[Units] ([UnitID], [Name], [Note]) VALUES (2, N'Chiếc', N'')
INSERT [dbo].[Units] ([UnitID], [Name], [Note]) VALUES (3, N'Thùng', N'')
INSERT [dbo].[Units] ([UnitID], [Name], [Note]) VALUES (4, N'Hộp', N'')
INSERT [dbo].[Users] ([ID], [Username], [Password], [RoleID]) VALUES (1, N'huuduc', N'321', 3)
INSERT [dbo].[Users] ([ID], [Username], [Password], [RoleID]) VALUES (2, N'thanhduong', N'123', 3)
INSERT [dbo].[Users] ([ID], [Username], [Password], [RoleID]) VALUES (3, N'cong', N'1234', 3)
INSERT [dbo].[Users] ([ID], [Username], [Password], [RoleID]) VALUES (4, N'thien', N'123', 1)
INSERT [dbo].[Users] ([ID], [Username], [Password], [RoleID]) VALUES (5, N'an', N'123', 2)
INSERT [dbo].[Users] ([ID], [Username], [Password], [RoleID]) VALUES (6, N'Admin', NULL, 3)
SET IDENTITY_INSERT [dbo].[Warehouse] ON 

INSERT [dbo].[Warehouse] ([WarehouseID], [ManagementStaff], [Name], [Contact], [Address], [Status], [Note]) VALUES (1, 1, N'Apple warehouse', N'', N'', N'non blank', N'')
INSERT [dbo].[Warehouse] ([WarehouseID], [ManagementStaff], [Name], [Contact], [Address], [Status], [Note]) VALUES (2, 2, N'Huawei warehouse', N'', N'', N'non blank', N'')
INSERT [dbo].[Warehouse] ([WarehouseID], [ManagementStaff], [Name], [Contact], [Address], [Status], [Note]) VALUES (3, 3, N'SamSung warehouse', N'', N'', N'non blank', N'')
INSERT [dbo].[Warehouse] ([WarehouseID], [ManagementStaff], [Name], [Contact], [Address], [Status], [Note]) VALUES (4, 1, N'aa', N'aa', N'aa', N'aa', N'aa')
SET IDENTITY_INSERT [dbo].[Warehouse] OFF
ALTER TABLE [dbo].[Company]  WITH CHECK ADD  CONSTRAINT [FK_Com_Field] FOREIGN KEY([FieldID])
REFERENCES [dbo].[Fields] ([FieldID])
GO
ALTER TABLE [dbo].[Company] CHECK CONSTRAINT [FK_Com_Field]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Users]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customer]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employee]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Units] FOREIGN KEY([UnitID])
REFERENCES [dbo].[Units] ([UnitID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Units]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Warehouse] FOREIGN KEY([WarehouseID])
REFERENCES [dbo].[Warehouse] ([WarehouseID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Warehouse]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Supplier]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Units] FOREIGN KEY([UnitID])
REFERENCES [dbo].[Units] ([UnitID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Units]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Warehouse] FOREIGN KEY([WarehouseID])
REFERENCES [dbo].[Warehouse] ([WarehouseID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Warehouse]
GO
ALTER TABLE [dbo].[Role_Form]  WITH CHECK ADD  CONSTRAINT [FK_Role_Form_Form] FOREIGN KEY([FormID])
REFERENCES [dbo].[Form] ([FormID])
GO
ALTER TABLE [dbo].[Role_Form] CHECK CONSTRAINT [FK_Role_Form_Form]
GO
ALTER TABLE [dbo].[Role_Form]  WITH CHECK ADD  CONSTRAINT [FK_Role_Form_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Role_Form] CHECK CONSTRAINT [FK_Role_Form_Roles]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_Employee] FOREIGN KEY([ManagementStaff])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Warehouse] CHECK CONSTRAINT [FK_Warehouse_Employee]
GO
USE [master]
GO
ALTER DATABASE [SalesManagermentSoftwareDB] SET  READ_WRITE 
GO
