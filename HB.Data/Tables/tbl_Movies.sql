CREATE TABLE [dbo].[tbl_Movies]
(
	[MovieId] INT NOT NULL PRIMARY KEY, 
    [ProductId] INT NOT NULL, 
    [CategoryId] INT NOT NULL, 
    [Genre] VARCHAR(50) NOT NULL, 
    [Length] INT NOT NULL, 
    [AgeLimit] INT NOT NULL, 
    CONSTRAINT [FK_tbl_Movies_tbl_Products] FOREIGN KEY (ProductId) REFERENCES tbl_Products(ProductId), 
    CONSTRAINT [FK_tbl_Movies_tbl_ProductCategories] FOREIGN KEY (CategoryId) REFERENCES tbl_ProductCategories(CategoryId)
)
