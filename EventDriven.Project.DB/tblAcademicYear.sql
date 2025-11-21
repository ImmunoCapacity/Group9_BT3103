CREATE TABLE [dbo].[tblAcademicYear]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [YearName] VARCHAR(20) NOT NULL,       -- e.g., '2024-2025'
    [StartDate] DATE NOT NULL,
    [EndDate] DATE NOT NULL,
    [IsActive] BIT DEFAULT 0,
    [CreatedAt] DATETIME DEFAULT GETDATE(),
    [UpdatedAt] DATETIME DEFAULT GETDATE()
);
