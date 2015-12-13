CREATE TABLE [dbo].[tbl_ProductCategories]
(
	[CategoryId] INT NOT NULL IDENTITY , 
    [Name] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_tbl_ProductCategories] PRIMARY KEY ([CategoryId])
)
