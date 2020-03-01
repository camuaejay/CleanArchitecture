CREATE PROCEDURE [dbo].[InsertUser]
	@Id UNIQUEIDENTIFIER,
	@Username NVARCHAR(100),
	@Password NVARCHAR(MAX)
AS
	INSERT INTO users(Id, Username, Password, DateCreated, DateUpdated, LastLogin) VALUES (@Id, @Username, @Password, GETUTCDATE(), GETUTCDATE(), GETUTCDATE())
RETURN 0
