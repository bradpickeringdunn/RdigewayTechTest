USE [HonestBobDev]
GO
SET IDENTITY_INSERT [dbo].[tbl_ProductCategories] ON 

GO
INSERT [dbo].[tbl_ProductCategories] ([CategoryId], [Name]) VALUES (1, N'Books')
GO
INSERT [dbo].[tbl_ProductCategories] ([CategoryId], [Name]) VALUES (2, N'Movies')
GO
SET IDENTITY_INSERT [dbo].[tbl_ProductCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Products] ON 

GO
INSERT [dbo].[tbl_Products] ([ProductId], [Name], [Description], [Price], [CategoryId], [IsActive]) VALUES (1, N'Harry Potter', N'Childrens book', CAST(300 AS Decimal(18, 0)), 1, N'1         ')
GO
INSERT [dbo].[tbl_Products] ([ProductId], [Name], [Description], [Price], [CategoryId], [IsActive]) VALUES (2, N'Enemy at the gate', N'WW2 movie', CAST(100 AS Decimal(18, 0)), 2, N'1         ')
GO
INSERT [dbo].[tbl_Products] ([ProductId], [Name], [Description], [Price], [CategoryId], [IsActive]) VALUES (3, N'Color of Magic', N'Adult / children', CAST(200 AS Decimal(18, 0)), 1, N'1         ')
GO
INSERT [dbo].[tbl_Products] ([ProductId], [Name], [Description], [Price], [CategoryId], [IsActive]) VALUES (4, N'Green mile', N'scifi movie', CAST(20 AS Decimal(18, 0)), 2, N'1         ')
GO
INSERT [dbo].[tbl_Products] ([ProductId], [Name], [Description], [Price], [CategoryId], [IsActive]) VALUES (11, N'Before I Go To Sleep', N'Memories define us. So what if you lost yours every time you went to sleep? An original, haunting and deeply chilling debut thriller, and a Sunday Times bestseller in hardcover.', CAST(4 AS Decimal(18, 0)), 1, N'1         ')
GO
INSERT [dbo].[tbl_Products] ([ProductId], [Name], [Description], [Price], [CategoryId], [IsActive]) VALUES (12, N'War Horse', N'From master storyteller, Michael Morpurgo comes an incredibly moving story about one horse''s experience in the deadly chaos of the first world war. In 1914, Joey, a young farm horse, is sold to the army and thrust into the midst of the war on the Western Front. With his officer, he charges towards the enemy, witnessing the horror of the frontline. But even in the desolation of the trenches, Joey''s courage touches the soldiers around him.', CAST(4 AS Decimal(18, 0)), 1, N'1         ')
GO
INSERT [dbo].[tbl_Products] ([ProductId], [Name], [Description], [Price], [CategoryId], [IsActive]) VALUES (13, N'Diary of a Wimpy Kid: The Ugly Truth', N'Catch the hapless Greg Heffley as he navigates his way through family and school life with his best friend, Rowley, by his side in a brand new Wimpy Kid adventure!', CAST(5 AS Decimal(18, 0)), 1, N'1         ')
GO
INSERT [dbo].[tbl_Products] ([ProductId], [Name], [Description], [Price], [CategoryId], [IsActive]) VALUES (14, N'The Fabulous Baker Brothers', N'Tom and Henry Herbert - The Fabulous Baker Brothers - are fifth generation bakers with a passion for food in all its forms. Tom is a talented master baker whose famous Hobbs House Bakery sits just next door to his younger brother Henry''s butchery. Together our young brothers work side by side making the amazing bread and delicious meaty accompaniments and fillings that have made their businesses so successful.', CAST(11 AS Decimal(18, 0)), 1, N'1         ')
GO
INSERT [dbo].[tbl_Products] ([ProductId], [Name], [Description], [Price], [CategoryId], [IsActive]) VALUES (15, N'The Prisoner', N'One of Henderson''s best agents is being held captive in Frankfurt. A set of forged record cards could be his ticket to freedom, but might just as easily become his death warrant. A vital mission awaits him in France - if he can find a way to escape.', CAST(4 AS Decimal(18, 0)), 1, N'1         ')
GO
SET IDENTITY_INSERT [dbo].[tbl_Products] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Books] ON 

GO
INSERT [dbo].[tbl_Books] ([BookId], [ProductId], [CategoryId], [Author], [ISBN], [PageCount]) VALUES (4, 1, 1, N'J.K Rowling', N'1132132dsdfsssdfs', 200)
GO
INSERT [dbo].[tbl_Books] ([BookId], [ProductId], [CategoryId], [Author], [ISBN], [PageCount]) VALUES (5, 2, 1, N'Terry Pratchet', N'565rgerge', 400)
GO
SET IDENTITY_INSERT [dbo].[tbl_Books] OFF
GO
