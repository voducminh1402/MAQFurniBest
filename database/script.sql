USE [master]
GO
/****** Object:  Database [FurnitureShop]    Script Date: 3/19/2022 7:23:51 PM ******/
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
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[Category]    Script Date: 3/19/2022 7:23:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[CategoryImage] [ntext] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[ProductAvailable]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[RoleClaims]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[Roles]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[ShippingInfo]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[ShippingStatus]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[UserClaims]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[UserLogins]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[UserRoles]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[UserStatus]    Script Date: 3/19/2022 7:23:52 PM ******/
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
/****** Object:  Table [dbo].[UserTokens]    Script Date: 3/19/2022 7:23:52 PM ******/
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
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (1, N'Book Table', N'https://i.pinimg.com/564x/22/55/d8/2255d8cd5a3bcfe6eb43a93357847d4e.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (2, N'Cocktail Table', N'https://i.pinimg.com/564x/fb/5f/a5/fb5fa56a1e44f45217c81fd280d62596.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (3, N'Wood Chair', N'https://i.pinimg.com/564x/50/d2/10/50d21073257903211bb6862a88c50ae0.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (4, N'Woven Chair', N'https://i.pinimg.com/564x/7d/53/bb/7d53bbde3429d6137a85f938b3b39e95.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (5, N'Decor Shelf', N'https://i.pinimg.com/564x/67/0f/79/670f79b9c9e37b0fc896a8b40d526b74.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (6, N'Cupboard', N'https://i.pinimg.com/564x/79/25/1e/79251eeb6de352152eeb13bf56cdabe3.jpg')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryImage]) VALUES (8, N'Iron Table', N'https://i.imgur.com/Ep2N0K5.png')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'04e1bbeb-143d-4010-86bf-f9d6f364bb5b', N'c700228c-61cd-491e-a06c-5df11315b88d', CAST(1940000.00 AS Decimal(16, 2)), CAST(N'2022-03-11T22:08:29.897' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'265390ee-518d-4558-9747-eabce4caebf3', N'c700228c-61cd-491e-a06c-5df11315b88d', CAST(12833000.00 AS Decimal(16, 2)), CAST(N'2022-03-17T09:50:20.107' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'3194a525-3586-408c-9bb7-7f58e31e8441', N'c700228c-61cd-491e-a06c-5df11315b88d', CAST(1940000.00 AS Decimal(16, 2)), CAST(N'2022-03-11T22:18:38.383' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'66e68821-79d9-4845-aaf2-0b6a89b21ce1', N'8e296151-eae4-4654-859e-3ad62c7edfae', CAST(1750000.00 AS Decimal(16, 2)), CAST(N'2022-03-17T10:13:07.277' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'6c9299f1-a177-44f8-a0b9-093707843d43', N'0dd0e9b4-36d8-440d-a5e2-39d58b752206', CAST(7171000.00 AS Decimal(16, 2)), CAST(N'2022-03-17T15:27:19.423' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'7950e0e4-1506-470a-a745-93b11f98b8f6', N'0dd0e9b4-36d8-440d-a5e2-39d58b752206', CAST(1750000.00 AS Decimal(16, 2)), CAST(N'2022-03-17T15:27:50.140' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'85052d48-b9b9-406d-8e54-ee237345a79d', N'0dd0e9b4-36d8-440d-a5e2-39d58b752206', CAST(3890000.00 AS Decimal(16, 2)), CAST(N'2022-03-18T15:38:58.440' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'856e4dd3-fdf2-4e63-ad3a-8f42964a2559', N'0dd0e9b4-36d8-440d-a5e2-39d58b752206', CAST(2133000.00 AS Decimal(16, 2)), CAST(N'2022-03-18T15:12:27.593' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'a6a70377-195f-4c72-ad0b-eb9131483cb1', N'0dd0e9b4-36d8-440d-a5e2-39d58b752206', CAST(13493000.00 AS Decimal(16, 2)), CAST(N'2022-03-18T16:15:31.150' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'd4afc6c2-4718-4e71-b159-abb1a3e3bc07', N'c700228c-61cd-491e-a06c-5df11315b88d', CAST(1940000.00 AS Decimal(16, 2)), CAST(N'2022-03-11T22:18:34.687' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'e6cb7750-9cdf-4017-951d-6f20cccb0229', N'88464515-8ce1-4d50-b421-fe046aa17712', CAST(10690000.00 AS Decimal(16, 2)), CAST(N'2022-03-12T22:59:28.663' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'ec7c641b-5904-418c-a254-855ac3c8ac29', N'0dd0e9b4-36d8-440d-a5e2-39d58b752206', CAST(2326000.00 AS Decimal(16, 2)), CAST(N'2022-03-18T15:49:38.663' AS DateTime))
INSERT [dbo].[Order] ([OrderID], [UserID], [TotalPrice], [CreateDate]) VALUES (N'effce9dc-b4f3-43c0-9dde-fd72c425d803', N'88464515-8ce1-4d50-b421-fe046aa17712', CAST(16660000.00 AS Decimal(16, 2)), CAST(N'2022-03-12T21:24:52.223' AS DateTime))
GO
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'1223397d-81a5-4f58-a763-ff21bb842e76', N'effce9dc-b4f3-43c0-9dde-fd72c425d803', N'2', CAST(190000.00 AS Decimal(16, 2)), 14)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'13ba51d7-7a0a-4ed0-9bcb-caddcd10b2f8', N'265390ee-518d-4558-9747-eabce4caebf3', N'1c84f8f5-486f-484d-81a7-5184aadefc50', CAST(193000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'1b4a3140-31e3-4955-b9fc-c4232d8ca88e', N'a6a70377-195f-4c72-ad0b-eb9131483cb1', N'1c84f8f5-486f-484d-81a7-5184aadefc50', CAST(193000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'1e9f5c5a-dce9-4016-bede-3e74b0017bfa', N'6c9299f1-a177-44f8-a0b9-093707843d43', N'1c84f8f5-486f-484d-81a7-5184aadefc50', CAST(193000.00 AS Decimal(16, 2)), 17)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'207a0ae7-89e3-452d-978e-24dca6970585', N'04e1bbeb-143d-4010-86bf-f9d6f364bb5b', N'2', CAST(190000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'2b379738-790a-4fe0-add2-a69759beda0d', N'7950e0e4-1506-470a-a745-93b11f98b8f6', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'39370e08-c183-417e-8362-beeb6de54fee', N'ec7c641b-5904-418c-a254-855ac3c8ac29', N'1c84f8f5-486f-484d-81a7-5184aadefc50', CAST(193000.00 AS Decimal(16, 2)), 2)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'4ff1b318-c014-43cc-8a92-001790aab358', N'85052d48-b9b9-406d-8e54-ee237345a79d', N'2', CAST(190000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'513eb002-b0f2-4ddf-b97b-95903f0be542', N'6c9299f1-a177-44f8-a0b9-093707843d43', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'56c65ed1-b4e0-48af-a845-8a7210626fc1', N'a6a70377-195f-4c72-ad0b-eb9131483cb1', N'cb7f660a-a6b5-4da4-8644-d271722ac69c', CAST(1800000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'5d458238-db46-493b-9786-a53b260e0484', N'66e68821-79d9-4845-aaf2-0b6a89b21ce1', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'5f06c365-4fcc-4fc6-8465-671d320a4b11', N'6c9299f1-a177-44f8-a0b9-093707843d43', N'619f76ea-38e0-4e55-a413-08b059b2e0b2', CAST(1950000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'66b541a4-4932-4e08-8496-2fb858c815cb', N'856e4dd3-fdf2-4e63-ad3a-8f42964a2559', N'2', CAST(190000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'722d980b-6970-4691-a494-49d59209ba35', N'e6cb7750-9cdf-4017-951d-6f20cccb0229', N'2', CAST(190000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'7f4d9397-8392-4d33-96cd-d1d8de909c19', N'effce9dc-b4f3-43c0-9dde-fd72c425d803', N'1', CAST(1750000.00 AS Decimal(16, 2)), 8)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'80da7902-5af3-4198-9c6c-79829a5a6da3', N'856e4dd3-fdf2-4e63-ad3a-8f42964a2559', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'87c65d1d-7750-4943-a802-7068b5e51f13', N'a6a70377-195f-4c72-ad0b-eb9131483cb1', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'917337b9-5f17-48dd-bfe0-29179e336ac0', N'6c9299f1-a177-44f8-a0b9-093707843d43', N'2', CAST(190000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'9c533db4-fc6e-404e-b018-b3b60578343b', N'85052d48-b9b9-406d-8e54-ee237345a79d', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'a5a78b0c-3c02-488e-a257-bef9631b4f66', N'e6cb7750-9cdf-4017-951d-6f20cccb0229', N'1', CAST(1750000.00 AS Decimal(16, 2)), 6)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'ac5943b8-479b-4f87-841d-da5c0a94f5d9', N'd4afc6c2-4718-4e71-b159-abb1a3e3bc07', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'c0d57dd0-1c1c-4762-b9a4-9eeb099ac25a', N'ec7c641b-5904-418c-a254-855ac3c8ac29', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'cb30c71f-8aa7-40c3-a876-fc73c50c9c99', N'3194a525-3586-408c-9bb7-7f58e31e8441', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'd03092ea-3138-4f34-bf34-57ac6c2dd560', N'3194a525-3586-408c-9bb7-7f58e31e8441', N'2', CAST(190000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'e3fefdd7-5005-4c7f-9038-afd66eead3dd', N'265390ee-518d-4558-9747-eabce4caebf3', N'1', CAST(1750000.00 AS Decimal(16, 2)), 6)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'e54aaa56-9c46-47bb-85b1-601aca654f8a', N'265390ee-518d-4558-9747-eabce4caebf3', N'619f76ea-38e0-4e55-a413-08b059b2e0b2', CAST(1950000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'e6c77f7a-dd68-4133-bf45-90ce3ac7d08d', N'04e1bbeb-143d-4010-86bf-f9d6f364bb5b', N'1', CAST(1750000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'ea7bcad4-a86b-4dba-85ad-a2424655c2f6', N'ec7c641b-5904-418c-a254-855ac3c8ac29', N'2', CAST(190000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'ed9ac5b4-b053-40b6-b6b3-526ae3a3c4e9', N'85052d48-b9b9-406d-8e54-ee237345a79d', N'619f76ea-38e0-4e55-a413-08b059b2e0b2', CAST(1950000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'eddff127-ba15-4b09-a4a9-6f0ef37d17d5', N'd4afc6c2-4718-4e71-b159-abb1a3e3bc07', N'2', CAST(190000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'f25decb7-5341-447a-b3ef-996830c7d19a', N'a6a70377-195f-4c72-ad0b-eb9131483cb1', N'619f76ea-38e0-4e55-a413-08b059b2e0b2', CAST(1950000.00 AS Decimal(16, 2)), 5)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'f5632b7e-4718-45c0-b566-c2527dd58d3f', N'265390ee-518d-4558-9747-eabce4caebf3', N'2', CAST(190000.00 AS Decimal(16, 2)), 1)
INSERT [dbo].[OrderDetail] ([DetailID], [OrderID], [ProductID], [DetailPrice], [Quantity]) VALUES (N'fd4c3517-79e0-4239-a7de-49f2c53ca082', N'856e4dd3-fdf2-4e63-ad3a-8f42964a2559', N'1c84f8f5-486f-484d-81a7-5184aadefc50', CAST(193000.00 AS Decimal(16, 2)), 1)
GO
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'1', N'Wooden Coffee Table', N'https://i.pinimg.com/564x/84/d3/c0/84d3c019a1a6cab57b2e098744c21864.jpg', CAST(1750000.00 AS Decimal(16, 2)), 18, N'This unique wooden table has 4 hidden drawers that slide out to reveal tons of storage for magazines, books, board games, blankets, and more.
', 1, 2, CAST(N'2022-03-04T17:21:00.000' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'1c84f8f5-486f-484d-81a7-5184aadefc50', N'Austen Bookshelf', N'https://i.imgur.com/VN0fYEs.jpg', CAST(193000.00 AS Decimal(16, 2)), 8, N'Sense and sensibility, just like its namesake. The Austen bookshelf’s slim, compact design belies its capacity.The five open shelves give you room aplenty for your next book shopping spree.
Made from sheesham wood
Available in 2 finishes
Please refer to the images for dimension details
Indoor use only', 1, 1, CAST(N'2022-03-16T19:04:47.240' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'2', N'Nort Chair', N'https://i.pinimg.com/564x/bf/20/41/bf2041df7625900e09dcf1c6ee499ed2.jpg', CAST(190000.00 AS Decimal(16, 2)), 18, N'design studio focusing on furniture and lighting', 1, 3, CAST(N'2022-03-04T17:21:00.000' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'619f76ea-38e0-4e55-a413-08b059b2e0b2', N'Dining Room Chairs Charcoal', N'https://i.imgur.com/BksaaQa.jpg', CAST(1950000.00 AS Decimal(16, 2)), 15, N'Best things I have ever owned & not only are they so pretty but most importantly, that are so comfortable. Love it.', 1, 4, CAST(N'2022-03-16T18:41:27.723' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'88fc7dff-7dfb-4f0a-aefb-160fa9a89472', N'Bacio Cream Boucle Lounge Chair', N'https://i.imgur.com/uP39LpI.jpg', CAST(1950000.00 AS Decimal(16, 2)), 0, N'Boucle takes on cream-colored hues in loungeable chair designed by Ross Cassidy. Bubbly and oversized in shape, with an FSC ®-certified wood frame and rounded legs made of solid bleached oak. CB2 exclusive.', 2, 4, CAST(N'2022-03-16T19:39:10.573' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'c4ad9dde-73fc-4f42-a4b5-ee35cf37dee3', N'Mobile Bath 80 cm Basin Ceramic', N'https://i.imgur.com/TIQ3xzr.jpg', CAST(1275000.00 AS Decimal(16, 2)), 18, N'La MarinelliGroup offre la possibilità di acquistare in un''unica soluzione il tuo bagno in modo funzionale e confortevole. Il mobiletto salvaspazio della nuova collezione Melissa e'' realizzato in legno nobilitato con finitura esterna dai toni decisi e dai colori accesi, adatta per arredamenti che si vogliono distinguere per design e ricercatezza anche nei bagni piu'' piccoli. Nello stesso set e'' possibile acquistare separatamente la colonna.', 1, 5, CAST(N'2022-03-16T19:58:23.133' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'cb7f660a-a6b5-4da4-8644-d271722ac69c', N'Wood Chair Specical', N'https://i.imgur.com/AqdY3zg.jpg', CAST(1800000.00 AS Decimal(16, 2)), 191, N'This product is VERY fluffy and comfortable. The material isn’t cheap at all. They look and feel very luxurious. ', 1, 3, CAST(N'2022-03-16T18:32:59.300' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'e81dfc4e-d1f0-4297-8ead-9c3f3a6e2f00', N'Jerry Pair Of Dining Chairs', N'https://i.imgur.com/fcn54aH.jpg', CAST(3750000.00 AS Decimal(16, 2)), 6, N'Great quality product for the money I have purchased ', 1, 8, CAST(N'2022-03-16T18:55:52.097' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'edc06890-92dc-484f-aef3-32493284735a', N'UVA Taupe Stalk 6''–8'' Set Of 3', N'https://i.imgur.com/ORBa6ip.jpg', CAST(130000.00 AS Decimal(16, 2)), 173, N'Dried uva stalk elevates any corner, entryway or fireplace with 6 to 8 feet of natural beauty. Sold in a statement-making set of three.', 1, 5, CAST(N'2022-03-16T19:55:21.840' AS DateTime))
INSERT [dbo].[Product] ([ProductID], [ProductName], [ProductImage], [ProductPrice], [Quantity], [Description], [AvailableID], [CategoryID], [CreateDate]) VALUES (N'f15a8ee8-7166-4855-bea9-9cd79b9ba4c9', N'Alavanca Oxidized Nickle Light', N'https://i.imgur.com/FSHwHHl.jpg', CAST(16666000.00 AS Decimal(16, 2)), 12, N'Sleek pendant light designed by Studio Anansi hangs sculptural vibes from above with a soft, ambient glow. Finished in a rich patinated nickel, light is vintage-inspired yet very contemporary. Learn more about Studio Anansi on our blog. CB2 exclusive.', 1, 6, CAST(N'2022-03-16T19:56:35.973' AS DateTime))
GO
INSERT [dbo].[ProductAvailable] ([AvailableID], [AvailableName]) VALUES (1, N'Còn hàng')
INSERT [dbo].[ProductAvailable] ([AvailableID], [AvailableName]) VALUES (2, N'Đã hết hàng')
INSERT [dbo].[ProductAvailable] ([AvailableID], [AvailableName]) VALUES (3, N'Đang về hàng')
INSERT [dbo].[ProductAvailable] ([AvailableID], [AvailableName]) VALUES (4, N'Sản phẩm ngừng kinh doanh')
GO
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Admin', N'Admin', N'Admin')
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'User', N'User', N'User')
GO
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', N'', N'04e1bbeb-143d-4010-86bf-f9d6f364bb5b', 1)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', N'ok', N'265390ee-518d-4558-9747-eabce4caebf3', 1)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', N'', N'3194a525-3586-408c-9bb7-7f58e31e8441', 1)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', N'ok', N'66e68821-79d9-4845-aaf2-0b6a89b21ce1', 1)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', N'ok', N'6c9299f1-a177-44f8-a0b9-093707843d43', 3)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', NULL, N'7950e0e4-1506-470a-a745-93b11f98b8f6', 3)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', N'ok', N'85052d48-b9b9-406d-8e54-ee237345a79d', 3)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', N'ok', N'856e4dd3-fdf2-4e63-ad3a-8f42964a2559', 3)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', NULL, N'a6a70377-195f-4c72-ad0b-eb9131483cb1', 3)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', N'', N'd4afc6c2-4718-4e71-b159-abb1a3e3bc07', 3)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', N'ship tan cua', N'e6cb7750-9cdf-4017-951d-6f20cccb0229', 3)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', NULL, N'ec7c641b-5904-418c-a254-855ac3c8ac29', 3)
INSERT [dbo].[ShippingInfo] ([FullName], [Address], [City], [State], [Phone], [Note], [OrderID], [StatusID]) VALUES (N'Duc Minh Vo', N'Thu Duc', N'Ho Chi Minh', N'Vietnam', N'0852484847', NULL, N'effce9dc-b4f3-43c0-9dde-fd72c425d803', 3)
GO
INSERT [dbo].[ShippingStatus] ([StatusID], [StatusName]) VALUES (1, N'Complete')
INSERT [dbo].[ShippingStatus] ([StatusID], [StatusName]) VALUES (2, N'Pending')
INSERT [dbo].[ShippingStatus] ([StatusID], [StatusName]) VALUES (3, N'Processing')
GO
INSERT [dbo].[UserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'106161812809698114786', N'Google', N'8ef5cf79-dbfc-40fc-9442-22940888ff73')
INSERT [dbo].[UserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'115843525768199749161', N'Google', N'c700228c-61cd-491e-a06c-5df11315b88d')
GO
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'88464515-8ce1-4d50-b421-fe046aa17712', N'1')
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'0aed90bd-d8a7-4c8e-aaf3-0fab8471d655', N'2')
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'0dd0e9b4-36d8-440d-a5e2-39d58b752206', N'2')
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'37d90550-095f-460d-83d4-cb0ada402c49', N'2')
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'8e296151-eae4-4654-859e-3ad62c7edfae', N'2')
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'c700228c-61cd-491e-a06c-5df11315b88d', N'2')
GO
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0aed90bd-d8a7-4c8e-aaf3-0fab8471d655', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 2, N'member1@estore.com', N'MEMBER1@ESTORE.COM', N'member1@estore.com', N'MEMBER1@ESTORE.COM', 0, N'AQAAAAEAACcQAAAAEG7+x8Z6g3AVFER5cFoX6CbZ1I6CYTB7kI3uddxrIaDamaDn8JyDQTymsQrA+ZGRmw==', N'IC5LJ7DFM4TDQHA6SF4QZ7RLVMZR27XI', N'359081bd-553e-4586-be44-42e58c2c11e8', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0dd0e9b4-36d8-440d-a5e2-39d58b752206', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 2, N'user2@user.com', N'USER2@USER.COM', N'user2@user.com', N'USER2@USER.COM', 1, N'AQAAAAEAACcQAAAAELUIZx+sViXzF5B6B0y5dQ3TSmsv3c/gKKYD/Na3KIknHRDTIPhXYy+QXegOaFyEWw==', N'E6TV2TRACJI6KUT4SYUR7Q7EGSO7UHPR', N'e0345e6b-2525-48fc-a01f-cc610d1bd877', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'1bb6fc62-b58b-4926-9c71-3bd305597359', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 2, N'user@user.com', N'USER@USER.COM', N'user@user.com', N'USER@USER.COM', 1, N'AQAAAAEAACcQAAAAEFyJLcWiNWvwChwASon68FluLtQR42h0rs5AUZ3OuSju0L6DkkuqQUUeLkMtIk1BWQ==', N'RGZXZOJIRKXZJXHKR6A25VGHSYTJ5NBC', N'0cf40689-108d-4e93-8a7b-1b367dffb703', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'37d90550-095f-460d-83d4-cb0ada402c49', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 0, N'user12@user.com', N'USER12@USER.COM', N'user12@user.com', N'USER12@USER.COM', 0, N'AQAAAAEAACcQAAAAEJ9ZhbFC+Bzvi2YUOR6jdFbdpHsZg7s0q/H+v3+6f0KNbcjejOXc21fvGDAYUf+0JA==', N'BCXAO2K4ZIZ5G2FOLOE7VNYUGBX4XLUV', N'99b5078b-d060-47ef-9873-810347e7afd3', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'88464515-8ce1-4d50-b421-fe046aa17712', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 1, N'admin@admin.com', N'ADMIN@ADMIN.COM', N'admin@admin.com', N'ADMIN@ADMIN.COM', 1, N'AQAAAAEAACcQAAAAEB2rGssOlJ2Td3bjOGGxdrwRGSA0CWXJY/q3hiG41HYN47DJ0CquZYLsKm33W6yAmA==', N'A7JF2LKB2XSTLDF4Y6EMTQXA5BPXNM5J', N'f3baaf74-947a-4887-8eee-4ebdaace116d', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8e296151-eae4-4654-859e-3ad62c7edfae', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 2, 2, N'member2@estore.com', N'MEMBER2@ESTORE.COM', N'member2@estore.com', N'MEMBER2@ESTORE.COM', 1, N'AQAAAAEAACcQAAAAEABJ+kDaan20XWaV0WnQ4vooS9frbpQKalKeuumWhtEi/4On105aH5KO9BWB9NjVdg==', N'NMETFGVPA4QYC4TZFVF2VZUVCYFZQKDE', N'eb2d9080-19b0-4c1f-93d5-1ca948ed1954', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8ef5cf79-dbfc-40fc-9442-22940888ff73', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 0, N'minhvdse150114@fpt.edu.vn', N'MINHVDSE150114@FPT.EDU.VN', N'minhvdse150114@fpt.edu.vn', N'MINHVDSE150114@FPT.EDU.VN', 1, NULL, N'IR56PEDIUXQOJPBRDXEFLWOA5ROKPMCT', N'211af4fc-3fdd-4454-a79b-0319e566d76b', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c700228c-61cd-491e-a06c-5df11315b88d', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 2, N'voducminh140201@gmail.com', N'VODUCMINH140201@GMAIL.COM', N'voducminh140201@gmail.com', N'VODUCMINH140201@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDGe7vfauZEfT3pa01RekDNQedrZGpIGY/b0kPMIFaTo2EyYerm6BPcMxwdeyDQMGg==', N'TORR23YBHAIZHJPAKXAEYYTCXY2K7MYR', N'd2e4416d-aacd-4c37-bc71-ed313b798039', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [CreateDate], [UserStatusId], [RoleId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f0c49452-fe08-4f8b-9819-3deb94aa773f', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 2, N'user1@user.com', N'USER1@USER.COM', N'user1@user.com', N'USER1@USER.COM', 0, N'AQAAAAEAACcQAAAAEBYD0zj6Kee82uVf7sOrBTdAV6/sEjmI4moET4IKx/RDi45Q9x71AJQqa5/EKy/qYQ==', N'E4WR2ATIGQ2XGPXYOANUZ3RCGWQVIIQO', N'54d8a8be-2838-4147-b0c5-54ef538de3b8', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[UserStatus] ([StatusID], [StatusName]) VALUES (1, N'Đang hoạt động')
INSERT [dbo].[UserStatus] ([StatusID], [StatusName]) VALUES (2, N'Ngừng hoạt động')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleClaims_RoleId1]    Script Date: 3/19/2022 7:23:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId1] ON [dbo].[RoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 3/19/2022 7:23:52 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[Roles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserClaims_UserId1]    Script Date: 3/19/2022 7:23:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId1] ON [dbo].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserLogins_UserId1]    Script Date: 3/19/2022 7:23:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserLogins_UserId1] ON [dbo].[UserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoles_RoleId1]    Script Date: 3/19/2022 7:23:52 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId1] ON [dbo].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 3/19/2022 7:23:52 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[Users]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 3/19/2022 7:23:52 PM ******/
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
