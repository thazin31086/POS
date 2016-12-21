CREATE TABLE [dbo].[Discount]
(
	[DiscountID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] VARCHAR(200) NULL, 
    [Percentage] DECIMAL(18, 2) NULL
)
