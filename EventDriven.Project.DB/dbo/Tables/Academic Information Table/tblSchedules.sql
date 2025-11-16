CREATE TABLE [dbo].[tblSchedules]
(
    [ScheduleID] INT PRIMARY KEY IDENTITY(1,1),
    [SectionID] INT,  -- Define the SectionID column first
    [TeacherID] INT,  -- Define the TeacherID column first
    [SubjectID] INT,  -- Define the SubjectID column first
    [StartTime] TIME,
    [EndTime] TIME,
    [Day] VARCHAR(10),  -- Optional: For Day of the Week (e.g., 'Monday')
    [GradeLevel] NVARCHAR(20) ,

    -- Define foreign key constraints
    CONSTRAINT FK_tblSchedules_Section FOREIGN KEY ([SectionID]) REFERENCES [dbo].[tblSections]([SectionID]),
    CONSTRAINT FK_tblSchedules_Teacher FOREIGN KEY ([TeacherID]) REFERENCES [dbo].[tblTeachers]([TeacherID]),
    CONSTRAINT FK_tblSchedules_Subject FOREIGN KEY ([SubjectID]) REFERENCES [dbo].[tblSubjects]([SubjectID]),

);
