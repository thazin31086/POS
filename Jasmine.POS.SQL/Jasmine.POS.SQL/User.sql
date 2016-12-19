CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserName] VARCHAR(50) NULL, 
    [FirstName] NCHAR(10) NULL, 
    [LastName] NCHAR(10) NULL, 
    [RoleID] INT NULL, 
    [TFN] VARCHAR(50) NULL, 
    [mobile] VARCHAR(50) NULL, 
    [address] VARBINARY(300) NULL, 
    CONSTRAINT [FK_User_ToRole] FOREIGN KEY ([RoleID]) REFERENCES [Role]([RoleID]), 
	
)
