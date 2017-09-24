

/****** Object:  Table [dbo].[Work_Order_Detail]    Script Date: 24-09-2017 21:36:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Work_Order_Detail](
	[Id] [int] NOT NULL,
	[Order_Name] [nvarchar](50) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[Created_Date] [datetime] NOT NULL,
	[Created_By] [nvarchar](100) NOT NULL,
	[Updated_Date] [datetime] NOT NULL,
	[Updated_By] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO


