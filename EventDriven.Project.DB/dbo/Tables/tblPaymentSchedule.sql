CREATE TABLE [dbo].[tblPaymentSchedule]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
    [StudentId] INT NOT NULL FOREIGN KEY REFERENCES tblStudents(Id),
    [DueDate] DATE NOT NULL,
    [AmountDue] DECIMAL(10,2) NOT NULL,
    [Description] NVARCHAR(100),   -- e.g., "1st Grading Payment"
    [IsPaid] BIT NULL DEFAULT 0
)
