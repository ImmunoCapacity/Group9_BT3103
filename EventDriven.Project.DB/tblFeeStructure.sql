CREATE TABLE [dbo].[tblFeeStructure]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [GradeLevel] NVARCHAR(50) NOT NULL UNIQUE,
    [TuitionFee] DECIMAL(10, 2) NOT NULL
);
