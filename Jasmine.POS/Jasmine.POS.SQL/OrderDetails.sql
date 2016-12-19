CREATE TABLE [dbo].[OrderDetails]
(
	[OrderDetailID] INT NOT NULL PRIMARY KEY, 
    [OrderID] INT NULL, 
    [ProductID] INT NULL, 
    [Qty] INT NULL    
)
