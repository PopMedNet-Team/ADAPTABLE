/****** Object:  Table [dbo].[PMN_RACE_CODE_LOOKUP]    Script Date: 08/30/2013 08:15:24 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PMN_RACE_CODE_LOOKUP]') AND type in (N'U'))
DROP TABLE [dbo].[I2B2_PMN_RACE_CODE_LOOKUP]
GO

/****** Object:  Table [dbo].[PMN_RACE_CODE_LOOKUP]    Script Date: 08/30/2013 08:15:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[I2B2_PMN_RACE_CODE_LOOKUP](
	[RACE_CD] [varchar](50) NOT NULL,
	[RACE_CHAR] [varchar](50) NOT NULL,
 CONSTRAINT [PK_I2B2_PMN_RACE_CODE_LOOKUP] PRIMARY KEY CLUSTERED 
(
	[RACE_CD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


