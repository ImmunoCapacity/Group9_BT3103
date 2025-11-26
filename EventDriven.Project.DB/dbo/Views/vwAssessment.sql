CREATE VIEW vwStudentAssessment AS
SELECT 
    -- Student Info
    s.Id AS StudentId,
    s.FirstName,
    s.MiddleName,
    s.LastName,
    s.GradeLevel,
    s.Section AS StudentSection,
    s.GWA,
    s.Status,
    s.AssessmentStatus,
    s.EnrollmentStatus,

    -- Registration
    r.Id AS RegistrationId,
    r.Section AS RegistrationSection,
    r.Requirements,
    r.PaymentMethod,

    -- Payments
    p.Id AS PaymentId,
    p.AmountPaid,
    p.DatePaid,
    p.PaymentType,

    -- Section
    sec.SectionID AS SectionId,
    sec.SectionName,

    -- Schedule
    sch.ScheduleID,
    sch.StartTime,
    sch.EndTime,
    sch.Day,
    sch.GradeLevel AS ScheduleGradeLevel,

    -- Teacher
    t.TeacherID,
    t.TeacherName,

    -- Subject
    sub.SubjectID,
    sub.SubjectName,
    sub.Category,

    --Academic Year
    ac.Id as YearId,
    ac.YearName as YearName

FROM tblStudents s

LEFT JOIN tblStudentRegistration r
    ON s.Id = r.StudentId

LEFT JOIN tblPayments p
    ON s.Id = p.StudentId

LEFT JOIN tblSections sec
    ON s.Section = sec.SectionName

-- ⭐ Key part: Match schedule by GradeLevel & SectionID
LEFT JOIN tblSchedules sch
    ON sch.SectionID = sec.SectionID
    AND sch.GradeLevel = s.GradeLevel  -- ⭐ FIX: ensures correct grade subjects

LEFT JOIN tblTeachers t
    ON sch.TeacherID = t.TeacherID

LEFT JOIN tblSubjects sub
    ON sch.SubjectID = sub.SubjectID
LEFT JOIN tblAcademicYear ac ON s.AcademicYearId = ac.Id;
    ;
