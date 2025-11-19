CREATE VIEW [dbo].[vwStudentPaymentBalance]
AS
SELECT 
    s.Id AS StudentId,
    s.FirstName + ' ' + s.LastName AS StudentName,
    s.GradeLevel,
    fs.TuitionFee,

    sr.PaymentMethod,   -- From Registration

    ISNULL(SUM(p.AmountPaid), 0) AS TotalPaid,
    (fs.TuitionFee - ISNULL(SUM(p.AmountPaid), 0)) AS RemainingBalance,
    MAX(p.DatePaid) AS LastPaymentDate,

    (
        SELECT TOP 1 p2.PaymentType
        FROM tblPayments p2
        WHERE p2.StudentId = s.Id
        ORDER BY p2.DatePaid DESC
    ) AS LastPaymentType,

    -- ⭐ Next unpaid schedule
    (
        SELECT TOP 1 ps.DueDate
        FROM tblPaymentSchedule ps
        WHERE ps.StudentId = s.Id AND ps.IsPaid = 0
        ORDER BY ps.DueDate ASC
    ) AS NextDueDate,

    (
        SELECT TOP 1 ps.AmountDue
        FROM tblPaymentSchedule ps
        WHERE ps.StudentId = s.Id AND ps.IsPaid = 0
        ORDER BY ps.DueDate ASC
    ) AS NextAmountDue,

    (
        SELECT TOP 1 ps.Description
        FROM tblPaymentSchedule ps
        WHERE ps.StudentId = s.Id AND ps.IsPaid = 0
        ORDER BY ps.DueDate ASC
    ) AS NextScheduleDescription

FROM tblStudents s
INNER JOIN tblFeeStructure fs 
    ON s.GradeLevel = fs.GradeLevel
LEFT JOIN tblStudentRegistration sr
    ON s.Id = sr.StudentId
LEFT JOIN tblPayments p 
    ON s.Id = p.StudentId
GROUP BY 
    s.Id, s.FirstName, s.LastName, 
    s.GradeLevel, fs.TuitionFee, sr.PaymentMethod;
