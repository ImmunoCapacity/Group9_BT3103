CREATE VIEW [dbo].[vwStudentPaymentHistory]
AS
SELECT 
    p.Id AS PaymentId,
    s.Id AS StudentId,
    s.FirstName + ' ' + s.LastName AS StudentName,
    s.GradeLevel,
    p.DatePaid,
    p.PaymentType,
    p.AmountPaid,
    -- Running remaining balance: tuition - total paid up to this payment
    fs.TuitionFee - (
        SELECT ISNULL(SUM(p2.AmountPaid), 0)
        FROM tblPayments p2
        WHERE p2.StudentId = s.Id
          AND p2.DatePaid <= p.DatePaid
    ) AS RemainingBalance
FROM tblPayments p
INNER JOIN tblStudents s ON p.StudentId = s.Id
INNER JOIN tblFeeStructure fs ON s.GradeLevel = fs.GradeLevel;
