
/****** Object:  Table [dbo].[Project]    Script Date: 24-09-2017 21:35:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Project](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Department] [int] NULL,
	[Parent] [int] NULL,
	[Status] [tinyint] NOT NULL,
	[Created_Date] [datetime] NOT NULL,
	[Created_By] [nvarchar](100) NOT NULL,
	[Updated_Date] [datetime] NOT NULL,
	[Updated_By] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO


