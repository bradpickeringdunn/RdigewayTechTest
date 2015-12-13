CREATE TABLE [dbo].[tbl_Products]
(
	[ProductId] INT NOT NULL IDENTITY , 
    [Name] VARCHAR(100) NOT NULL, 
    [Description] VARCHAR(500) NOT NULL, 
    [Price] DECIMAL NOT NULL, 
    [CategoryId] INT NOT NULL, 
    [IsActive] NCHAR(10) NOT NULL, 
    CONSTRAINT [PK_tbl_Products] PRIMARY KEY ([ProductId]), 
    CONSTRAINT [FK_tbl_Products_tbl_Categories] FOREIGN KEY (CategoryId) REFERENCES tbl_ProductCategories(CategoryId)
)
