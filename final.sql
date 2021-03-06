USE [db_project]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 1/14/2022 2:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[ID_cate] [varchar](50) NOT NULL,
	[name_cate] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 1/14/2022 2:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[ID_custom] [varchar](50) NOT NULL,
	[name_custom] [nvarchar](100) NOT NULL,
	[address_custom] [nvarchar](max) NOT NULL,
	[phone_number] [varchar](50) NOT NULL,
	[product_name] [varchar](max) NULL,
	[amount] [int] NULL,
	[sum_price] [float] NULL,
	[date_order] [datetime] NULL,
	[method] [nvarchar](50) NULL,
	[ID_order] [varchar](50) NOT NULL,
	[status] [nvarchar](50) NULL,
	[status_order] [nvarchar](50) NULL,
 CONSTRAINT [PK_customers] PRIMARY KEY CLUSTERED 
(
	[ID_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 1/14/2022 2:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[ID] [int] NOT NULL,
	[name_product] [nvarchar](50) NULL,
	[image] [nvarchar](max) NULL,
	[descrip] [nvarchar](250) NULL,
	[quality] [int] NULL,
	[price] [float] NULL,
	[category] [nvarchar](50) NULL,
	[date] [datetime] NULL,
 CONSTRAINT [ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_user]    Script Date: 1/14/2022 2:05:33 PM ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 1/14/2022 2:05:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[DiaChi] [varchar](50) NULL,
	[Sodienthoai] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[categories] ([ID_cate], [name_cate]) VALUES (N'SV3', N'Realme')
INSERT [dbo].[categories] ([ID_cate], [name_cate]) VALUES (N'SV1', N'Nokia')
INSERT [dbo].[categories] ([ID_cate], [name_cate]) VALUES (N'SV2', N'SamSung')
INSERT [dbo].[categories] ([ID_cate], [name_cate]) VALUES (N'SV4', N'Apple')
GO
INSERT [dbo].[customers] ([ID_custom], [name_custom], [address_custom], [phone_number], [product_name], [amount], [sum_price], [date_order], [method], [ID_order], [status], [status_order]) VALUES (N'3', N'triet minh', N'123', N'123123123', N'SamSung Galaxy S10', 1, 15000000, CAST(N'2022-01-14T14:01:06.940' AS DateTime), N'Tiền mặt', N'108', N'Chưa thanh toán', N'Chưa giao')
INSERT [dbo].[customers] ([ID_custom], [name_custom], [address_custom], [phone_number], [product_name], [amount], [sum_price], [date_order], [method], [ID_order], [status], [status_order]) VALUES (N'3', N'triet minh', N'123', N'123123123', N'Samsung Z Flip 3 Nokia 3310', 2, 31000000, CAST(N'2022-01-14T14:02:50.077' AS DateTime), N'Tiền mặt', N'124', N'Chưa thanh toán', N'Chưa giao')
INSERT [dbo].[customers] ([ID_custom], [name_custom], [address_custom], [phone_number], [product_name], [amount], [sum_price], [date_order], [method], [ID_order], [status], [status_order]) VALUES (N'3', N'triet minh', N'123', N'123123123', N'Iphone 13', 1, 25000000, CAST(N'2022-01-14T14:01:33.350' AS DateTime), N'Momo', N'147', N'Đã thanh toán', N'Chưa giao')
INSERT [dbo].[customers] ([ID_custom], [name_custom], [address_custom], [phone_number], [product_name], [amount], [sum_price], [date_order], [method], [ID_order], [status], [status_order]) VALUES (N'3', N'triet minh', N'123', N'123123123', N'SamSung Galaxy S10', 1, 15000000, CAST(N'2022-01-14T13:45:12.693' AS DateTime), N'Momo', N'560', N'Đã thanh toán', N'Chưa giao')
GO
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (1, N'Nokia Note 10', N'Nokia.jpg', N'Nokia is the best', 9, 1500000, N'Nokia', CAST(N'2022-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (2, N'SamSung Galaxy S10', N'SamSung.jpg', N'SamSung is the best', 6, 15000000, N'SamSung', CAST(N'2022-01-11T00:00:00.000' AS DateTime))
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (3, N'Iphone 12', N'iphone12.jpg', N'Iphone 12 is the best', 17, 20000000, N'Apple', CAST(N'2022-01-11T00:00:00.000' AS DateTime))
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (4, N'Iphone 13', N'iphone13.jpg', N'Iphone 13 is pro vip ', 8, 25000000, N'Apple', CAST(N'2022-01-14T00:00:00.000' AS DateTime))
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (5, N'Realme 6', N'realme6.jpg', N'Realme is the best phone', 19, 6000000, N'Realme', CAST(N'2022-01-14T00:00:00.000' AS DateTime))
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (7, N'Samsung Z Flip 3', N'samsungs21.jpg', N'The best phone of 2022', 3, 30000000, N'SamSung', CAST(N'2022-01-14T00:00:00.000' AS DateTime))
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (8, N'Nokia 3310', N'nokia3310.jpg', N'Nokia beautiful', 1, 1000000, N'Nokia', CAST(N'2022-01-14T00:00:00.000' AS DateTime))
INSERT [dbo].[products] ([ID], [name_product], [image], [descrip], [quality], [price], [category], [date]) VALUES (9, N'Realme 6 Pro', N'realme6pro.jpg', N'Powerful', 4, 2100000, N'Realme', CAST(N'2022-01-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tb_user] ([id_user], [name_login], [full_name], [_password], [telephone]) VALUES (N'NV1', N'King123', N'KingDom12', N'123454', N'31231232')
INSERT [dbo].[tb_user] ([id_user], [name_login], [full_name], [_password], [telephone]) VALUES (N'NV2', N'KingNope', N'Huỳnh Văn Toàn', N'12345', N'03123123')
INSERT [dbo].[tb_user] ([id_user], [name_login], [full_name], [_password], [telephone]) VALUES (N'NV3', N'triet', N'Minhtriet', N'1234', N'1234321')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [Email], [Password], [DiaChi], [Sodienthoai]) VALUES (2, N'King', N'Nope', N'nhock123@gmail.com', N'827ccb0eea8a706c4c34a16891f84e7b', NULL, NULL)
INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [Email], [Password], [DiaChi], [Sodienthoai]) VALUES (3, N'triet', N'minh', N'ttriet@gmail.com', N'202cb962ac59075b964b07152d234b70', N'123', 123123123)
INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [Email], [Password], [DiaChi], [Sodienthoai]) VALUES (4, N'Triết', N'Minh', N'minhtriet@gmail.com', N'e10adc3949ba59abbe56e057f20f883e', N'Kiên Giang', 932452234)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
