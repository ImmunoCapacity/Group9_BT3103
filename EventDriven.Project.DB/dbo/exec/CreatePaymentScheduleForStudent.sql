CREATE PROCEDURE [dbo].[CreatePaymentScheduleForStudent]
    @StudentId INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @GradeLevel NVARCHAR(50),
            @TuitionFee DECIMAL(10,2),
            @InstallmentAmount DECIMAL(10,2),
            @SY INT;

    -- 1️⃣ Ensure student exists
    IF NOT EXISTS (SELECT 1 FROM tblStudents WHERE Id = @StudentId)
    BEGIN
        RAISERROR('Student with Id %d not found.', 16, 1, @StudentId);
        RETURN;
    END

    -- 2️⃣ Get student grade level
    SELECT @GradeLevel = GradeLevel
    FROM tblStudents
    WHERE Id = @StudentId;

    -- 3️⃣ Get tuition fee for that grade
    SELECT @TuitionFee = TuitionFee
    FROM tblFeeStructure
    WHERE GradeLevel = @GradeLevel;

    IF @TuitionFee IS NULL
    BEGIN
        RAISERROR('Tuition fee not found for grade %s', 16, 1, @GradeLevel);
        RETURN;
    END

    -- 4️⃣ Divide into 4 equal installments
    SET @InstallmentAmount = ROUND(@TuitionFee / 4, 2);

    -- 5️⃣ Get current school year
    SET @SY = YEAR(GETDATE());

    -- 6️⃣ Insert Philippine grading period schedule
    INSERT INTO tblPaymentSchedule (StudentId, DueDate, AmountDue, Description)
    VALUES
        (@StudentId, DATEFROMPARTS(@SY, 7, 1),  @InstallmentAmount, 'Enrollment / Downpayment'),
        (@StudentId, DATEFROMPARTS(@SY, 9, 1),  @InstallmentAmount, '1st Grading Payment'),
        (@StudentId, DATEFROMPARTS(@SY, 11, 1), @InstallmentAmount, '2nd Grading Payment'),
        (@StudentId, DATEFROMPARTS(@SY + 1, 2, 1), @InstallmentAmount, '3rd Grading Payment');

END
GO

