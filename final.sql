USE [db_project]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 1/5/2022 11:37:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[ID_cate] [varchar](50) NOT NULL,
	[name_cate] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 1/5/2022 11:37:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[ID_custom] [varchar](50) NOT NULL,
	[name_custom] [nvarchar](100) NOT NULL,
	[address_custom] [nvarchar](max) NOT NULL,
	[phone_number] [varchar](50) NOT NULL,
	[product_name] [varchar](100) NULL,
	[amount] [int] NULL,
	[sum_price] [float] NULL,
	[date_order] [datetime] NULL,
	[method] [nvarchar](50) NULL,
	[ID_order] [varchar](50) NULL,
	[status] [nvarchar](50) NULL,
	[status_order] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 1/5/2022 11:37:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[ID] [int] NULL,
	[name_product] [varchar](50) NOT NULL,
	[image] [varchar](max) NOT NULL,
	[descrip] [nvarchar](250) NULL,
	[quality] [int] NOT NULL,
	[price] [float] NOT NULL,
	[category] [varchar](50) NOT NULL,
	[date] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_user]    Script Date: 1/5/2022 11:37:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_user](
	[id_user] [varchar](20) NOT NULL,
	[name_login] [varchar](50) NOT NULL,
	[full_name] [nvarchar](50) NOT NULL,
	[_password] [varchar](50) NOT NULL,
	[telephone] [varchar](50) NULL,
 CONSTRAINT [id_user] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/5/2022 11:37:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[IsAdmin] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[categories] ([ID_cate], [name_cate]) VALUES (N'SA2', N'SamSung')
INSERT [dbo].[categories] ([ID_cate], [name_cate]) VALUES (N'SA4', N'Apple')
INSERT [dbo].[categories] ([ID_cate], [name_cate]) VALUES (N'SA3', N'ReadMe')
INSERT [dbo].[categories] ([ID_cate], [name_cate]) VALUES (N'SA5', N'Nokia')
INSERT [dbo].[categories] ([ID_cate], [name_cate]) VALUES (N'SA6', N'Oppo')
GO
INSERT [dbo].[customers] ([ID_custom], [name_custom], [address_custom], [phone_number], [product_name], [amount], [sum_price], [date_order], [method], [ID_order], [status], [status_order]) VALUES (N'CT3', N'Dược Lão', N'Hồng Mông giới', N'3123123123', N'Nokia', 13, 195000, CAST(N'2022-01-03T00:00:00.000' AS DateTime), N'MoMo', N'xetcgv', N'Chưa thanh toán', N'Đang giao')
GO
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (1, N'Nokia', N'nokia.jpg', N'Nokia is the best', 12, 15000, N'Nokia', CAST(N'2022-01-05T00:00:00.000' AS DateTime))
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (2, N'SamSung S9 plus', N'Samsung.jpg', N'SamSung is the best', 15, 160000000, N'SamSung', CAST(N'2022-01-06T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tb_user] ([id_user], [name_login], [full_name], [_password], [telephone]) VALUES (N'NV1', N'King12', N'KingDom', N'12345', N'31231232')
INSERT [dbo].[tb_user] ([id_user], [name_login], [full_name], [_password], [telephone]) VALUES (N'NV2', N'KingNope', N'Huỳnh Văn Toản', N'12345', N'03123123')
GO
