CREATE TABLE [dbo].[Users]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [PasswordHash] VARBINARY(64) NOT NULL, -- hashed password storage
    [Role] NVARCHAR(50) NOT NULL
);
