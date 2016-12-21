CREATE TABLE [dbo].[OrderDetails]
(
	[OrderDetailID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderID] INT NULL, 
    [ProductID] INT NULL, 
    [Qty] INT NULL, 
    CONSTRAINT [FK_OrderDetails_ToProduct] FOREIGN KEY ([ProductID]) REFERENCES [Product]([ProductID])    
)
