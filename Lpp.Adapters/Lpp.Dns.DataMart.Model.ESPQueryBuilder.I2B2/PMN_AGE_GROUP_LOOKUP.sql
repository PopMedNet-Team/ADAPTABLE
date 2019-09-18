/****** Object:  Table [dbo].[PMN_AGE_GROUP_LOOKUP]    Script Date: 08/30/2013 08:16:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PMN_AGE_GROUP_LOOKUP]') AND type in (N'U'))
DROP TABLE [dbo].[PMN_AGE_GROUP_LOOKUP]
GO

/****** Object:  Table [dbo].[PMN_AGE_GROUP_LOOKUP]    Script Date: 08/30/2013 08:16:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PMN_AGE_GROUP_LOOKUP](
	[AGE_AT_ENCOUNTER] [int] NOT NULL,
	[AGE_GROUP_5_YEARS] [varchar](50) NULL,
	[AGE_GROUP_10_YEARS] [varchar](50) NULL,
 CONSTRAINT [PK_PMN_AGE_GROUP_LOOKUP] PRIMARY KEY CLUSTERED 
(
	[AGE_AT_ENCOUNTER] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


