CREATE TRIGGER trg_InsertStudentSchedules
ON tblStudents
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @StudentId INT;

    DECLARE student_cursor CURSOR FOR
    SELECT Id FROM inserted;

    OPEN student_cursor;
    FETCH NEXT FROM student_cursor INTO @StudentId;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        EXEC CreatePaymentScheduleForStudent @StudentId;
        FETCH NEXT FROM student_cursor INTO @StudentId;
    END

    CLOSE student_cursor;
    DEALLOCATE student_cursor;
END
