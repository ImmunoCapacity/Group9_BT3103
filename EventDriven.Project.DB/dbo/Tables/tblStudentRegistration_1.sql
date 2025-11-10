CREATE TABLE [dbo].[tblStudentRegistration]
(
	[Id] INT IDENTITY(100,1) NOT NULL PRIMARY KEY,
	[StudentId] INT NOT NULL FOREIGN KEY REFERENCES tblStudents(Id),
	[Section] VARCHAR(50) NOT NULL,
	[Requirements] VARCHAR(100) NOT NULL,
	[PaymentMethod] VARCHAR(50) NOT NULL
);
