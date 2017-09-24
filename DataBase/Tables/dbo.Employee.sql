
/****** Object:  Table [dbo].[Employee]    Script Date: 24-09-2017 21:34:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[Id] [int] NOT NULL,
	[EmpNo] [nvarchar](10) NOT NULL,
	[Designation] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[Created_Date] [datetime] NOT NULL,
	[Created_By] [nvarchar](100) NOT NULL,
	[Updated_Date] [datetime] NOT NULL,
	[Updated_By] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO


