CREATE TABLE [dbo].[tblPayments]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [StudentId] INT NOT NULL FOREIGN KEY REFERENCES tblStudents(Id), 
    [AmountPaid] DECIMAL(10, 2) NOT NULL, 
    [Change] DECIMAL(10, 2) NOT NULL,
    [DatePaid] DATETIME NULL DEFAULT GETDATE(), 
    [PaymentType] NVARCHAR(10) NULL CHECK (PaymentType IN ('Full', 'Partial'))
);
