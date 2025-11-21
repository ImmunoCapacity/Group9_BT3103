CREATE TABLE [dbo].[tblFeeStructure]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [GradeLevel] NVARCHAR(50) NOT NULL UNIQUE,
    [BaseTuition] DECIMAL(10, 2) NOT NULL, [LabFee] DECIMAL(10, 2) NOT NULL, [LibraryFee] DECIMAL(10, 2) NOT NULL, [SportsFee] DECIMAL(10, 2) NOT NULL,
    [TuitionFee] AS ([BaseTuition] + [LabFee] + [LibraryFee] + [SportsFee]) PERSISTED
);
