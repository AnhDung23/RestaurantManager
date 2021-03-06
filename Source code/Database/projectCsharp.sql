USE [master]
GO
/****** Object:  Database [QuanLyNhaHang]    Script Date: 3/29/2020 1:02:57 AM ******/
CREATE DATABASE [QuanLyNhaHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhaHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNhaHang.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyNhaHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNhaHang_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyNhaHang] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhaHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhaHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhaHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyNhaHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhaHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhaHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhaHang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyNhaHang] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyNhaHang', N'ON'
GO
USE [QuanLyNhaHang]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/29/2020 1:02:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[fullname] [nvarchar](50) NULL,
	[role] [nvarchar](50) NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bill]    Script Date: 3/29/2020 1:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] NOT NULL,
	[dateCheckIn] [datetime] NULL,
	[dateCheckOut] [datetime] NULL,
	[nameTable] [nvarchar](50) NULL,
	[status] [nvarchar](50) NULL,
	[staff] [nvarchar](50) NULL,
	[total] [int] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 3/29/2020 1:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] NOT NULL,
	[idBill] [int] NULL,
	[nameFood] [nvarchar](50) NULL,
	[quantity] [int] NULL,
 CONSTRAINT [PK_BillInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Food]    Script Date: 3/29/2020 1:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[name] [nvarchar](50) NOT NULL,
	[idCategory] [int] NULL,
	[price] [int] NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 3/29/2020 1:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK_FoodCategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 3/29/2020 1:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[name] [nvarchar](50) NOT NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK_TableFood] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Account] ([username], [password], [fullname], [role], [status]) VALUES (N'adung234', N'2341999', N'Giang Luu Anh Dung', N'admin', N'Active')
INSERT [dbo].[Account] ([username], [password], [fullname], [role], [status]) VALUES (N'bap', N'221999', N'Bap', N'member', N'Inactive')
INSERT [dbo].[Account] ([username], [password], [fullname], [role], [status]) VALUES (N'hoang', N'2581997', N'Thanh Hoang', N'member', N'Active')
INSERT [dbo].[Account] ([username], [password], [fullname], [role], [status]) VALUES (N'quynh', N'30092003', N'Diem Quynh', N'member', N'Active')
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [nameTable], [status], [staff], [total]) VALUES (1, CAST(N'2020-03-03 21:30:53.670' AS DateTime), CAST(N'2020-03-03 23:30:10.843' AS DateTime), N'Bàn 1', N'Đã thanh toán', N'adung234', 1000000)
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [nameTable], [status], [staff], [total]) VALUES (2, CAST(N'2020-03-25 16:58:00.347' AS DateTime), CAST(N'2020-03-25 23:09:02.283' AS DateTime), N'Bàn 5', N'Đã thanh toán', N'adung234', 678000)
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [nameTable], [status], [staff], [total]) VALUES (3, CAST(N'2020-03-25 17:23:31.000' AS DateTime), CAST(N'2020-03-25 23:08:58.353' AS DateTime), N'Bàn 1', N'Đã thanh toán', N'adung234', 785000)
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [nameTable], [status], [staff], [total]) VALUES (4, CAST(N'2020-03-10 18:13:54.013' AS DateTime), CAST(N'2020-03-10 19:50:13.427' AS DateTime), N'Bàn 8', N'Đã thanh toán', N'adung234', 150000)
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [nameTable], [status], [staff], [total]) VALUES (5, CAST(N'2020-03-10 18:15:53.267' AS DateTime), CAST(N'2020-03-10 19:37:13.647' AS DateTime), N'Bàn 7', N'Đã thanh toán', N'adung234', 10000)
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [nameTable], [status], [staff], [total]) VALUES (6, CAST(N'2020-03-11 19:08:50.753' AS DateTime), CAST(N'2020-03-11 20:48:53.723' AS DateTime), N'Bàn 2', N'Đã thanh toán', N'adung234', 130000)
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [nameTable], [status], [staff], [total]) VALUES (7, CAST(N'2020-03-12 19:46:19.413' AS DateTime), CAST(N'2020-03-12 21:30:35.813' AS DateTime), N'Bàn 7', N'Đã thanh toán', N'adung234', 290000)
INSERT [dbo].[Bill] ([id], [dateCheckIn], [dateCheckOut], [nameTable], [status], [staff], [total]) VALUES (8, CAST(N'2020-03-12 20:14:10.167' AS DateTime), CAST(N'2020-03-12 20:59:10.347' AS DateTime), N'Bàn 10', N'Đã thanh toán', N'adung234', 48000)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (1, 2, N'Heneiken', 8)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (2, 2, N'Mực nướng', 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (3, 2, N'Lẩu thái', 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (4, 3, N'Gà quay', 5)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (5, 3, N'Cocacola', 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (6, 4, N'Mực nướng', 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (7, 3, N'Ốc xào', 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (8, 5, N'Cocacola', 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (9, 6, N'Gà quay', 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (10, 7, N'Lẩu thái', 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (11, 7, N'Cocacola', 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [nameFood], [quantity]) VALUES (12, 8, N'Heneiken', 3)
INSERT [dbo].[Food] ([name], [idCategory], [price], [status]) VALUES (N'Cocacola', 2, 10000, N'Active')
INSERT [dbo].[Food] ([name], [idCategory], [price], [status]) VALUES (N'Gà quay', 1, 130000, N'Active')
INSERT [dbo].[Food] ([name], [idCategory], [price], [status]) VALUES (N'Heneiken', 2, 16000, N'Active')
INSERT [dbo].[Food] ([name], [idCategory], [price], [status]) VALUES (N'Lẩu thái', 1, 250000, N'Active')
INSERT [dbo].[Food] ([name], [idCategory], [price], [status]) VALUES (N'Mực nướng', 1, 150000, N'Active')
INSERT [dbo].[Food] ([name], [idCategory], [price], [status]) VALUES (N'Ốc xào', 1, 35000, N'Active')
INSERT [dbo].[Food] ([name], [idCategory], [price], [status]) VALUES (N'Pepsi', 2, 10000, N'Active')
INSERT [dbo].[Food] ([name], [idCategory], [price], [status]) VALUES (N'Red bull', 2, 12000, N'Inactive')
INSERT [dbo].[Food] ([name], [idCategory], [price], [status]) VALUES (N'Tiger', 2, 15500, N'Active')
INSERT [dbo].[FoodCategory] ([id], [name], [status]) VALUES (1, N'Thức ăn', N'Active')
INSERT [dbo].[FoodCategory] ([id], [name], [status]) VALUES (2, N'Thức uống', N'Active')
INSERT [dbo].[FoodCategory] ([id], [name], [status]) VALUES (3, N'Tráng miệng', N'Inactive')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 1', N'Trống')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 10', N'Trống')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 11', N'Inactive')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 2', N'Trống')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 3', N'Trống')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 4', N'Trống')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 5', N'Trống')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 6', N'Trống')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 7', N'Trống')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 8', N'Trống')
INSERT [dbo].[TableFood] ([name], [status]) VALUES (N'Bàn 9', N'Trống')
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Account] FOREIGN KEY([staff])
REFERENCES [dbo].[Account] ([username])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Account]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_TableFood] FOREIGN KEY([nameTable])
REFERENCES [dbo].[TableFood] ([name])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_TableFood]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_Bill] FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_Bill]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_Food] FOREIGN KEY([nameFood])
REFERENCES [dbo].[Food] ([name])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_Food]
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhaHang] SET  READ_WRITE 
GO
