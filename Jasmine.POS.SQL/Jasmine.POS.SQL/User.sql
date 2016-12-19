CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserName] VARCHAR(50) NULL, 
	[Password] VARCHAR(50) NULL, 
    [FirstName] VARCHAR(200) NULL, 
    [LastName] VARCHAR(200) NULL, 
    [RoleID] INT NULL, 
    [TFN] VARCHAR(50) NULL, 
    [mobile] VARCHAR(50) NULL, 
    [address] VARCHAR(400) NULL, 
    CONSTRAINT [FK_User_ToRole] FOREIGN KEY ([RoleID]) REFERENCES [Role]([RoleID]), 
	
)
