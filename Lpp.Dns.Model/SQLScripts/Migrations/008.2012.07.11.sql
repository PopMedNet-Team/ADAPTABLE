IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspSearchLookupListValues]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspSearchLookupListValues]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspSearchLookupListValues]
	@ListId INT,
	@SearchText VARCHAR(500)
AS 
BEGIN
	DECLARE @index int
	DECLARE @ParseText VARCHAR(500)
	
	SET @ParseText = REPLACE(RTRIM(LTRIM(@SearchText)), '*', '%') -- Replacing * with %
	
	SET @SearchText = REPLACE(RTRIM(LTRIM(@SearchText)), '%', '') -- Removing % sign from original search string
	
	SET @index = PatIndex('%[0-9]%', @SearchText) -- Check if its ItemCode or ItemName
	
	IF (@SearchText = '') GOTO Search_NoSearchText

	--ELSE IF (@ListId = 7 AND (@index = 1 OR @index = 2 OR @index = 3)) GOTO Search_ItemCode
	
	ELSE IF (@index = 1 OR @index = 2) GOTO Search_ItemCode

	ELSE GOTO Search_ItemName

Search_ItemCode:
	IF(@ParseText = '%') -- Find All for that ListId
		BEGIN
			SELECT ItemName, ItemCode, ItemCodeWithNoPeriod
			FROM LookupListValues
			WHERE listid = @ListId
			ORDER BY ItemCode
		END
		
	ELSE IF (CHARINDEX('%', @ParseText)>0 AND LEN(@ParseText)>1)	-- e.g. A1010* or *A1010 or *A10*10*
		BEGIN
			SELECT ItemName, ItemCode, ItemCodeWithNoPeriod
			FROM LookupListValues
			WHERE listid = @ListId AND ItemCode LIKE @ParseText 
			ORDER BY ItemCode
		END
			
	ELSE IF (CHARINDEX(',', @SearchText)>0) -- e.g. G0328,G0260
		BEGIN
			DECLARE @Cnt int
			DECLARE @SearchValue VARCHAR(250)
			DECLARE @tblResult TABLE(ItemName VARCHAR(500), ItemCode varchar(50), ItemCodeWithNoPeriod varchar(50))
			DECLARE @SplitTable TABLE(ROWID INT, value VARCHAR(500))
			
			INSERT INTO @SplitTable SELECT * FROM dbo.Split( ',', @SearchText ) AS s 

			SELECT @Cnt = Count(*) from @SplitTable

			WHILE @Cnt > 0 
			BEGIN 
				SELECT @SearchValue = [value] from  @SplitTable where ROWID = @Cnt
				
				INSERT INTO @tblResult 
				SELECT ItemName, ItemCode, ItemCodeWithNoPeriod
				FROM LookupListValues
				WHERE listid = @ListId AND ItemCode Like @SearchValue
				ORDER BY ItemCode
				SET @Cnt = @Cnt - 1	
			END

			SELECT ItemCode, ItemName,ItemCodeWithNoPeriod FROM @tblResult ORDER BY ItemCode
		END
			
	ELSE IF (CHARINDEX('-', @SearchText)>0) -- e.g. G0328-G0260
		BEGIN
			DECLARE @From VARCHAR(50)
			DECLARE @To VARCHAR(50)
		
			SET @From = SUBSTRING(@SearchText, 1, CAST(CHARINDEX('-', @SearchText) AS INT)-1)
			SET @To = SUBSTRING(@SearchText, CAST(CHARINDEX('-', @SearchText) AS INT)+1, len(@SearchText))
			
			SELECT ItemName, ItemCode,ItemCodeWithNoPeriod
			FROM LookupListValues
			WHERE listid = @ListId AND ItemCode >= @From AND ItemCode <= @To
			ORDER BY ItemCode
			
		END
	ELSE								-- e.g. G0328
		BEGIN
			SELECT ItemName, ItemCode, ItemCodeWithNoPeriod
			FROM LookupListValues
			WHERE listid = @ListId AND ItemCode = @SearchText
			ORDER BY ItemCode
		END
	RETURN
	
Search_ItemName:
	BEGIN
		IF (CHARINDEX('%', @ParseText) = 0) 
			BEGIN
				SET @SearchText = REPLACE(@ParseText, '%', '')
				
				SELECT ItemName, ItemCode,ItemCodeWithNoPeriod FROM LookupListValues  
				WHERE listid = @ListId AND FREETEXT (ItemName, @SearchText )
				GROUP BY ItemName, ItemCode,ItemCodeWithNoPeriod
				ORDER BY ItemCode
			END
		ELSE		
			BEGIN
				SELECT ItemName, ItemCode,ItemCodeWithNoPeriod FROM LookupListValues  
				WHERE listid = @ListId AND ItemName LIKE @ParseText 
				GROUP BY ItemName, ItemCode,ItemCodeWithNoPeriod
				ORDER BY ItemCode
			END
	END
	RETURN
Search_NoSearchText:	
	BEGIN
		SELECT ItemName, ItemCode,ItemCodeWithNoPeriod FROM LookupListValues	
		WHERE 0 = 1;
	END
	RETURN	
END
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[uspGetLookupListCategoryValues]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[uspGetLookupListCategoryValues]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[uspGetLookupListCategoryValues]
	@ListId INT,
	@CategoryId INT
AS 

BEGIN
	SELECT * FROM LookupListValues  
	WHERE listid = @ListId AND CategoryId = @CategoryId
	ORDER by ItemName
END
GO

IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[LookupListValues]') AND name = N'PK_LookupListValues')
ALTER TABLE [dbo].[LookupListValues] DROP CONSTRAINT [PK_LookupListValues]
GO

IF  EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[LookupListValues]') AND name = N'ui_ID')
DROP FULLTEXT INDEX ON [dbo].[LookupListValues]
DROP INDEX [ui_ID] ON [dbo].[LookupListValues] WITH ( ONLINE = OFF )
GO

ALTER TABLE [dbo].[LookupListValues] ALTER COLUMN ItemCode varchar(200) not null
GO

ALTER TABLE [dbo].[LookupListValues] ADD CONSTRAINT [PK_LookupListValues] PRIMARY KEY CLUSTERED 
(
	[ListId] ASC,
	[CategoryId] ASC,
	[ItemName] ASC,
	[ItemCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [ui_ID] ON [dbo].[LookupListValues] 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE FULLTEXT INDEX ON [dbo].[LookupListValues](
[ItemCode] LANGUAGE [English], 
[ItemName] LANGUAGE [English])
KEY INDEX [ui_ID]ON ([Full_Text_Catalog], FILEGROUP [PRIMARY])
WITH (CHANGE_TRACKING = AUTO, STOPLIST = SYSTEM)
GO

Update LookupListValues
Set ItemCode = LEFT(ItemName, 200)
Where ListId In (1, 2, 3, 12)
