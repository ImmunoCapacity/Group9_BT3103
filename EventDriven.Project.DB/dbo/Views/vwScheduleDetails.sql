-- Create View for Schedule Details
CREATE VIEW [dbo].[vwScheduleDetails] AS
SELECT 
    s.SectionName,
    t.TeacherName,
    sub.SubjectName,
    sc.StartTime,
    sc.EndTime,
    sc.Day
FROM 
    tblSchedules sc
JOIN 
    tblSections s ON sc.SectionID = s.SectionID
JOIN 
    tblTeachers t ON sc.TeacherID = t.TeacherID
JOIN 
    tblSubjects sub ON sc.SubjectID = sub.SubjectID
