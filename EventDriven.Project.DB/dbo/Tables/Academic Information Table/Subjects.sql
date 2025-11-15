CREATE TABLE [dbo].[Subjects]
(
	[SubjectID] INT IDENTITY(1,1) PRIMARY KEY,
	[SubjectName] NVARCHAR(100) NOT NULL,
	[Category] NVARCHAR(100) NULL
)
