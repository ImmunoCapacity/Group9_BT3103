CREATE VIEW [dbo].[vwStudentPaymentBalance]
AS
SELECT 
    s.Id AS StudentId,
    s.FirstName + ' ' + s.LastName AS StudentName,
    s.GradeLevel,
    fs.TuitionFee,
    ISNULL(SUM(p.AmountPaid), 0) AS TotalPaid,
    (fs.TuitionFee - ISNULL(SUM(p.AmountPaid), 0)) AS RemainingBalance,
    MAX(p.DatePaid) AS LastPaymentDate,
    (
        SELECT TOP 1 p2.PaymentType
        FROM tblPayments p2
        WHERE p2.StudentId = s.Id
        ORDER BY p2.DatePaid DESC
    ) AS LastPaymentType
FROM tblStudents s
INNER JOIN tblFeeStructure fs ON s.GradeLevel = fs.GradeLevel
LEFT JOIN tblPayments p ON s.Id = p.StudentId
GROUP BY s.Id, s.FirstName, s.LastName, s.GradeLevel, fs.TuitionFee;