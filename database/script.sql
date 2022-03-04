USE [master]
GO
/****** Object:  Database [FurnitureShop]    Script Date: 3/4/2022 8:56:50 PM ******/
CREATE DATABASE [FurnitureShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FurnitureShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQL2019EXP\MSSQL\DATA\FurnitureShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FurnitureShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQL2019EXP\MSSQL\DATA\FurnitureShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FurnitureShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FurnitureShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FurnitureShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FurnitureShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FurnitureShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FurnitureShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FurnitureShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [FurnitureShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FurnitureShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FurnitureShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FurnitureShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FurnitureShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FurnitureShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FurnitureShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FurnitureShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FurnitureShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FurnitureShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FurnitureShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FurnitureShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FurnitureShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FurnitureShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FurnitureShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FurnitureShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FurnitureShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FurnitureShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FurnitureShop] SET  MULTI_USER 
GO
ALTER DATABASE [FurnitureShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FurnitureShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FurnitureShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FurnitureShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FurnitureShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FurnitureShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FurnitureShop] SET QUERY_STORE = OFF
GO
USE [FurnitureShop]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[CategoryImage] [ntext] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [nvarchar](50) NOT NULL,
	[UserID] [nvarchar](450) NOT NULL,
	[TotalPrice] [decimal](16, 2) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[DetailID] [nvarchar](50) NOT NULL,
	[OrderID] [nvarchar](50) NOT NULL,
	[ProductID] [nvarchar](50) NOT NULL,
	[DetailPrice] [decimal](16, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[DetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](120) NOT NULL,
	[ProductImage] [ntext] NOT NULL,
	[ProductPrice] [decimal](16, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Description] [ntext] NOT NULL,
	[AvailableID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductAvailable]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductAvailable](
	[AvailableID] [int] NOT NULL,
	[AvailableName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProductAvailable] PRIMARY KEY CLUSTERED 
(
	[AvailableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleClaims]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingInfo]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingInfo](
	[FullName] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](450) NOT NULL,
	[City] [nvarchar](450) NOT NULL,
	[State] [nvarchar](450) NOT NULL,
	[Phone] [nvarchar](22) NOT NULL,
	[Note] [ntext] NULL,
	[OrderID] [nvarchar](50) NOT NULL,
	[StatusID] [int] NOT NULL,
 CONSTRAINT [PK_ShippingInfo] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingStatus]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingStatus](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ShippingStatus] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserClaims]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogins]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [nvarchar](450) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UserStatusId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserStatus]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserStatus](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserStatus] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTokens]    Script Date: 3/4/2022 8:56:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220301123501_Init', N'5.0.14')
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (1, N'Book Table', N'https://i.pinimg.com/564x/22/55/d8/2255d8cd5a3bcfe6eb43a93357847d4e.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (2, N'Cocktail Table', N'https://i.pinimg.com/564x/fb/5f/a5/fb5fa56a1e44f45217c81fd280d62596.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (3, N'Wood Chair', N'https://i.pinimg.com/564x/50/d2/10/50d21073257903211bb6862a88c50ae0.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (4, N'Woven Chair', N'https://i.pinimg.com/564x/7d/53/bb/7d53bbde3429d6137a85f938b3b39e95.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (5, N'Decor Shelf', N'https://i.pinimg.com/564x/67/0f/79/670f79b9c9e37b0fc896a8b40d526b74.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (6, N'Cupboard', N'https://i.pinimg.com/564x/79/25/1e/79251eeb6de352152eeb13bf56cdabe3.jpg')
GO
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'1', N'Wooden Coffee Table', N'https://i.pinimg.com/564x/84/d3/c0/84d3c019a1a6cab57b2e098744c21864.jpg', CAST(1750000.00 AS Decimal(16, 2)), 18, N'This unique wooden table has 4 hidden drawers that slide out to reveal tons of storage for magazines, books, board games, blankets, and more.
', 1, 2, CAST(N'2022-03-04T17:21:00.000' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'2', N'Nort Chair', N'https://i.pinimg.com/564x/bf/20/41/bf2041df7625900e09dcf1c6ee499ed2.jpg', CAST(190000.00 AS Decimal(16, 2)), 35, N'design studio focusing on furniture and lighting', 1, 3, CAST(N'2022-03-04T17:21:00.000' AS DateTime))
GO
INSERT [dbo].[ProductAvailable] ([AvailableID], [AvailableName]) VALUES (1, N'Còn hàng')
INSERT [dbo].[ProductAvailable] ([AvailableID], [AvailableName]) VALUES (2, N'Đã hết hàng')
INSERT [dbo].[ProductAvailable] ([AvailableID], [AvailableName]) VALUES (3, N'Đang về hàng')
INSERT [dbo].[ProductAvailable] ([AvailableID], [AvailableName]) VALUES (4, N'Sản phẩm ngừng kinh doanh')
GO
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Admin', N'Admin', N'Admin')
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'User', N'User', N'User')
GO
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'37d90550-095f-460d-83d4-cb0ada402c49', N'2')
GO
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1bb6fc62-b58b-4926-9c71-3bd305597359', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 2, N'user@user.com', N'USER@USER.COM', N'user@user.com', N'USER@USER.COM', 1, N'AQAAAAEAACcQAAAAEFyJLcWiNWvwChwASon68FluLtQR42h0rs5AUZ3OuSju0L6DkkuqQUUeLkMtIk1BWQ==', N'RGZXZOJIRKXZJXHKR6A25VGHSYTJ5NBC', N'0cf40689-108d-4e93-8a7b-1b367dffb703', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'37d90550-095f-460d-83d4-cb0ada402c49', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 0, N'user12@user.com', N'USER12@USER.COM', N'user12@user.com', N'USER12@USER.COM', 0, N'AQAAAAEAACcQAAAAEJ9ZhbFC+Bzvi2YUOR6jdFbdpHsZg7s0q/H+v3+6f0KNbcjejOXc21fvGDAYUf+0JA==', N'BCXAO2K4ZIZ5G2FOLOE7VNYUGBX4XLUV', N'99b5078b-d060-47ef-9873-810347e7afd3', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'88464515-8ce1-4d50-b421-fe046aa17712', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 1, N'admin@admin.com', N'ADMIN@ADMIN.COM', N'admin@admin.com', N'ADMIN@ADMIN.COM', 1, N'AQAAAAEAACcQAAAAEB2rGssOlJ2Td3bjOGGxdrwRGSA0CWXJY/q3hiG41HYN47DJ0CquZYLsKm33W6yAmA==', N'A7JF2LKB2XSTLDF4Y6EMTQXA5BPXNM5J', N'f3baaf74-947a-4887-8eee-4ebdaace116d', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f0c49452-fe08-4f8b-9819-3deb94aa773f', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 2, N'user1@user.com', N'USER1@USER.COM', N'user1@user.com', N'USER1@USER.COM', 0, N'AQAAAAEAACcQAAAAEBYD0zj6Kee82uVf7sOrBTdAV6/sEjmI4moET4IKx/RDi45Q9x71AJQqa5/EKy/qYQ==', N'E4WR2ATIGQ2XGPXYOANUZ3RCGWQVIIQO', N'54d8a8be-2838-4147-b0c5-54ef538de3b8', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[UserStatus] ([StatusID], [StatusName]) VALUES (1, N'Đang hoạt động')
INSERT [dbo].[UserStatus] ([StatusID], [StatusName]) VALUES (2, N'Ngừng hoạt động')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleClaims_RoleId1]    Script Date: 3/4/2022 8:56:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId1] ON [dbo].[RoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 3/4/2022 8:56:50 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[Roles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserClaims_UserId1]    Script Date: 3/4/2022 8:56:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId1] ON [dbo].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserLogins_UserId1]    Script Date: 3/4/2022 8:56:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserLogins_UserId1] ON [dbo].[UserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoles_RoleId1]    Script Date: 3/4/2022 8:56:50 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId1] ON [dbo].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 3/4/2022 8:56:50 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[Users]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 3/4/2022 8:56:50 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[Users]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Users]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductAvailable] FOREIGN KEY([AvailableID])
REFERENCES [dbo].[ProductAvailable] ([AvailableID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductAvailable]
GO
ALTER TABLE [dbo].[RoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoleClaims] CHECK CONSTRAINT [FK_RoleClaims_Roles_RoleId]
GO
ALTER TABLE [dbo].[ShippingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ShippingInfo_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[ShippingInfo] CHECK CONSTRAINT [FK_ShippingInfo_Order]
GO
ALTER TABLE [dbo].[ShippingInfo]  WITH CHECK ADD  CONSTRAINT [FK_ShippingInfo_ShippingStatus] FOREIGN KEY([StatusID])
REFERENCES [dbo].[ShippingStatus] ([StatusID])
GO
ALTER TABLE [dbo].[ShippingInfo] CHECK CONSTRAINT [FK_ShippingInfo_ShippingStatus]
GO
ALTER TABLE [dbo].[UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserClaims_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserClaims] CHECK CONSTRAINT [FK_UserClaims_Users_UserId]
GO
ALTER TABLE [dbo].[UserLogins]  WITH CHECK ADD  CONSTRAINT [FK_UserLogins_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserLogins] CHECK CONSTRAINT [FK_UserLogins_Users_UserId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles_RoleId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users_UserId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserStatus] FOREIGN KEY([UserStatusId])
REFERENCES [dbo].[UserStatus] ([StatusID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserStatus]
GO
ALTER TABLE [dbo].[UserTokens]  WITH CHECK ADD  CONSTRAINT [FK_UserTokens_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserTokens] CHECK CONSTRAINT [FK_UserTokens_Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [FurnitureShop] SET  READ_WRITE 
GO
