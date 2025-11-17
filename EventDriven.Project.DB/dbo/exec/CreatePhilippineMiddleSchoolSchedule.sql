CREATE PROCEDURE [dbo].[CreatePhilippineMiddleSchoolSchedule]
    @StudentId INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @GradeLevel NVARCHAR(50),
            @TuitionFee DECIMAL(10,2),
            @InstallmentAmount DECIMAL(10,2),
            @SY INT;

    -- SY (school year)
    SET @SY = YEAR(GETDATE());

    -- Get student grade level
    SELECT @GradeLevel = GradeLevel
    FROM tblStudents
    WHERE Id = @StudentId;

    -- Get tuition fee for that grade
    SELECT @TuitionFee = TuitionFee
    FROM tblFeeStructure
    WHERE GradeLevel = @GradeLevel;

    -- Divide into 4 equal installments
    SET @InstallmentAmount = @TuitionFee / 4;

    -- Insert Philippine grading period schedule
    INSERT INTO tblPaymentSchedule (StudentId, DueDate, AmountDue, Description)
    VALUES
        (@StudentId, DATEFROMPARTS(@SY, 7, 1),  @InstallmentAmount, 'Enrollment / Downpayment'),
        (@StudentId, DATEFROMPARTS(@SY, 9, 1),  @InstallmentAmount, '1st Grading Payment'),
        (@StudentId, DATEFROMPARTS(@SY, 11, 1), @InstallmentAmount, '2nd Grading Payment'),
        (@StudentId, DATEFROMPARTS(@SY + 1, 2, 1), @InstallmentAmount, '3rd Grading Payment');
END;
