CREATE TABLE [dbo].[tblStudentRegistration]
(
	[Id] INT IDENTITY(100,1) NOT NULL PRIMARY KEY,
	[Section] VARCHAR(50) NOT NULL,
	[Requirements] VARCHAR(100) NOT NULL,
	[PaymentMethod] VARCHAR(50) NOT NULL
);
