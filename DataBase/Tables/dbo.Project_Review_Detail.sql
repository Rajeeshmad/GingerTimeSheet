
/****** Object:  Table [dbo].[Project_Review_Detail]    Script Date: 24-09-2017 21:36:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Project_Review_Detail](
	[Id] [int] NOT NULL,
	[Employee_Id] [int] NOT NULL,
	[Project_Id] [int] NOT NULL,
	[Review_Enabled] [bit] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[Created_Date] [datetime] NOT NULL,
	[Created_By] [nvarchar](100) NOT NULL,
	[Updated_Date] [datetime] NOT NULL,
	[Updated_By] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO


