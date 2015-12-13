CREATE TABLE [dbo].[tbl_Books]
(
	[BookId] INT NOT NULL IDENTITY , 
    [ProductId] INT NOT NULL, 
    [CategoryId] INT NOT NULL, 
    [Author] VARCHAR(100) NOT NULL, 
    [ISBN] VARCHAR(100) NOT NULL, 
    [PageCount] INT NOT NULL, 
    CONSTRAINT [PK_tbl_Books] PRIMARY KEY ([BookId]), 
    CONSTRAINT [FK_tbl_Books_tbl_ProductCategories] FOREIGN KEY (CategoryId) REFERENCES tbl_ProductCategories(CategoryId), 
    CONSTRAINT [FK_tbl_Books_tbl_Products] FOREIGN KEY (ProductId) REFERENCES tbl_Products(ProductId)
)
