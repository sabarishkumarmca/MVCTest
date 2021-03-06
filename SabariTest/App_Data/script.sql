USE [SabariTest]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 04-05-2020 14:49:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DOB] [date] NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Dept] [nvarchar](50) NOT NULL,
	[Salary] [numeric](9, 2) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExceptionLogger]    Script Date: 04-05-2020 14:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExceptionLogger](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExceptionMessage] [nvarchar](max) NULL,
	[ControllName] [nvarchar](max) NULL,
	[ExceptionStackTrace] [nvarchar](max) NULL,
	[LogTime] [datetime] NOT NULL,
 CONSTRAINT [PK_ExceptionLogger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
