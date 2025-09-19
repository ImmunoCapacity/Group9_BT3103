CREATE TABLE [dbo].[tblStudents]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    
    [FirstName] NVARCHAR(50) NOT NULL,
    [MiddleName] NVARCHAR(50) NULL,
    [LastName] NVARCHAR(50) NOT NULL,
    [Status] NVARCHAR(20) NOT NULL,            
    [BirthDate] DATE NOT NULL,
    [GradeLevel] NVARCHAR(20) NOT NULL,        
    [Nationality] NVARCHAR(50) NULL,

    [FatherName] NVARCHAR(100) NULL,
    [FatherContact] NVARCHAR(20) NULL,
    [MotherName] NVARCHAR(100) NULL,
    [MotherContact] NVARCHAR(20) NULL,
    [ParentAddress] NVARCHAR(255) NULL,

    [GuardianName] NVARCHAR(100) NULL,
    [GuardianRelationship] NVARCHAR(50) NULL,
    [GuardianContact] NVARCHAR(20) NULL,
    [GuardianAddress] NVARCHAR(255) NULL,

    [CreatedAt] DATETIME DEFAULT GETDATE()
)
