CREATE TABLE [dbo].[tblPartialPayment]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
	[StudentNo] NVARCHAR(50) NOT NULL,
	[AmountPaid] DECIMAL(10,2) NOT NULL,
	[DatePaid] DATETIME NOT NULL DEFAULT GETDATE(),
	[RemainingBalance] DECIMAL(10,2) NOT NULL,
	[PaymentMethod] NVARCHAR(50) NULL
)
