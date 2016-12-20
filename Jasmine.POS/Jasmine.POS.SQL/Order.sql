CREATE TABLE [dbo].[Order]
(
	[OrderID] INT NOT NULL PRIMARY KEY, 
    [Customer Name] VARCHAR(250) NULL, 
    [OrderTypeID] INT NULL, 
    [CreatedDate] DATETIME NULL, 
    [BookingDate] DATETIME NULL, 
    [DiscountID] INT NULL, 
	[PaymentMethodID] INT NULL, 
    [Amount Due] DECIMAL(18, 2) NULL,    
    [Change Due] DECIMAL(18, 2) NULL, 
    CONSTRAINT [FK_Order_ToOrderType] FOREIGN KEY ([OrderTypeID]) REFERENCES [OrderType]([OrderTypeID]), 
    CONSTRAINT [FK_Order_ToDiscount] FOREIGN KEY ([DiscountID]) REFERENCES [Discount]([DiscountID]), 
    CONSTRAINT [FK_Order_ToPaymentMethodID] FOREIGN KEY ([PaymentMethodID]) REFERENCES [PaymentMethod]([PaymentMethodID])
)
