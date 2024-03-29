/******
USE master
DROP DATABASE [HTMTTB]
******/
CREATE DATABASE HTMTTB
GO

USE [HTMTTB]
GO
/****** Object:  Table [dbo].[BorrowEquipment]    Script Date: 10/7/2023 1:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorrowEquipment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Class] [char](6) NULL,
	[Phone] [varchar](15) NOT NULL,
	[BorrowedDate] [datetime2](7) NULL,
	[ReturnDate] [datetime2](7) NULL,
	[ConfirmBorrowed] [nvarchar](15) NULL,
	[ReturnConfirm] [nvarchar](15) NULL,
	[Pen] [nvarchar](20) NULL,
	[Wipes] [nchar](20) NULL,
	[Chalk] [nvarchar](20) NULL,
	[Projector] [nvarchar](20) NULL,
	[Connector] [nvarchar](20) NULL,
	[Mic] [nvarchar](50) NULL,
	[PowerOutlet] [nvarchar](15) NULL,
	[BottledWater] [nvarchar](20) NULL,
	[Status] [nchar](1) NOT NULL,
	[StudentCode] [nchar](10) NOT NULL,
	[Room] [nchar](4) NULL,
 CONSTRAINT [PK__BorrowEq__3214EC278202E566] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Device]    Script Date: 10/7/2023 1:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Device](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PenAndWipes] [nvarchar](20) NULL,
	[ChalkAndWipes] [nvarchar](20) NULL,
	[Projector] [nvarchar](20) NULL,
	[Connector] [nvarchar](20) NULL,
	[Mic] [nvarchar](10) NULL,
	[PowerOutlet] [nvarchar](15) NULL,
	[BottledWater] [nvarchar](20) NULL,
	[Status] [nvarchar](50) NULL,
	[Time] [smalldatetime] NULL,
 CONSTRAINT [PK__Device__3214EC27CD0F867D] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 10/7/2023 1:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Date] [nvarchar](30) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
