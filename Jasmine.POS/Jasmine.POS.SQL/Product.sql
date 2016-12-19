CREATE TABLE [dbo].[Product]
(
	[ProductID] INT NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(500) NULL, 
    [SellingPrice ] DECIMAL(18, 2) NULL, 
    [ProductCategoryID] INT NOT NULL, 
    CONSTRAINT [FK_Product_ToProductCategory] FOREIGN KEY ([ProductCategoryID]) REFERENCES [ProductCategory]([ProductCategoryID])
)
