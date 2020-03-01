CREATE TABLE [dbo].[users]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(100) NOT NULL, 
    [Password] NVARCHAR(MAX) NOT NULL, 
    [DateCreated] DATETIME NOT NULL, 
    [DateUpdated] DATETIME NOT NULL, 
    [LastLogin] DATETIME NOT NULL 
)
