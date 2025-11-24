/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DECLARE @CurrentAcademicYear AS NVARCHAR(20) = CONCAT(YEAR(GETDATE()), '-', YEAR(GETDATE()) + 1);

-- Insert academic year if it doesn't exist
IF NOT EXISTS (
    SELECT 1
    FROM tblAcademicYear
    WHERE YearName = @CurrentAcademicYear
)
BEGIN
    INSERT INTO tblAcademicYear (YearName, StartDate, EndDate, IsActive)
    VALUES (
        @CurrentAcademicYear,
        DATEFROMPARTS(YEAR(GETDATE()), 6, 1),   -- Example start date (adjust if needed)
        DATEFROMPARTS(YEAR(GETDATE()) + 1, 3, 31), -- Example end date (adjust if needed)
        1
    );
END



INSERT INTO tblUser (username, userPassword, Role) 
VALUES
    ('Admin',    HASHBYTES('SHA2_256', 'admin123'), 'Admin'),
    ('Registrar', HASHBYTES('SHA2_256', 'registrar123'), 'Registrar'),
    ('Cashier',  HASHBYTES('SHA2_256', 'cashier123'), 'Cashier');

begin
INSERT INTO tblFeeStructure (GradeLevel, BaseTuition, LabFee, LibraryFee, SportsFee)
VALUES 
('Grade 7', 42000.00, 1500.00, 1000.00, 500.00),  -- TotalFee = 45000.00
('Grade 8', 44000.00, 1700.00, 1000.00, 300.00),  -- TotalFee = 47000.00
('Grade 9', 47000.00, 2000.00, 1000.00, 0.00),    -- TotalFee = 50000.00
('Grade 10', 49000.00, 2000.00, 1000.00, 0.00);   -- TotalFee = 52000.00

end


Begin
DECLARE @AcademicYearId INT = (SELECT Id FROM tblAcademicYear WHERE YearName = @CurrentAcademicYear);



INSERT INTO [dbo].[tblStudents]
(FirstName, MiddleName, LastName, Status, BirthDate, GradeLevel, Nationality,
 FatherName, FatherContact, MotherName, MotherContact, ParentAddress,
 GuardianName, GuardianRelationship, GuardianContact, GuardianAddress,
 Suffix, Section, Gender, Email, LastSchool, LastGrade, Address, Contact, GWA,
 AcademicYearId)
VALUES
-- 1
('Juan', 'Santos', 'Dela Cruz', 'Old', '2010-05-15', 'Grade 9', 'Filipino',
 'Jose Dela Cruz', '09171234567', 'Maria Santos', '09187654321', 'Balayan, Batangas',
 'Pedro Lopez', 'Uncle', '09981231234', 'Caloocan, Balayan', '', '9-A', 'Male',
 'juan.delacruz@email.com', 'Balayan Elementary', 'Grade 8', 'Balayan, Batangas',
 '09171234567', 88.5, @AcademicYearId),

-- 2
('Ana', 'Lopez', 'Reyes', 'New', '2011-02-20', 'Grade 8', 'Filipino',
 'Carlos Reyes', '09170001111', 'Elena Lopez', '09180002222', 'Lemery, Batangas',
 'Rosa Garcia', 'Aunt', '09993334444', 'Lipa, Batangas', '', '8-B', 'Female',
 'ana.reyes@email.com', 'Lemery Elementary', 'Grade 7', 'Lemery, Batangas',
 '09170001111', 92.3, @AcademicYearId),

-- 3
('Mark', 'David', 'Flores', 'Transferee', '2009-09-12', 'Grade 10', 'Filipino',
 'Ramon Flores', '09221231234', 'Cristina David', '09334445555', 'Nasugbu, Batangas',
 'Luis Cruz', 'Brother', '09176667777', 'Batangas City', '', '10-C', 'Male',
 'mark.flores@email.com', 'Nasugbu High', 'Grade 9', 'Nasugbu, Batangas',
 '09221231234', 85.7, @AcademicYearId),

-- 4
('Sophia', 'Cruz', 'Garcia', 'New', '2012-03-30', 'Grade 7', 'Filipino',
 'Mario Garcia', '09175559999', 'Teresa Cruz', '09182223333', 'Balayan, Batangas',
 'Isabel Torres', 'Cousin', '09445556666', 'Calaca, Batangas', '', '7-A', 'Female',
 'sophia.garcia@email.com', 'Balayan Elementary', 'Grade 7',
 'Balayan, Batangas', '09175559999', 91.2, @AcademicYearId),

-- 5
('Miguel', 'Andres', 'Torres', 'Old', '2011-06-18', 'Grade 8', 'Filipino',
 'Antonio Torres', '09170008888', 'Luisa Andres', '09181119999',
 'Balayan, Batangas', 'Roberto Ramos', 'Uncle', '09225557777',
 'San Juan, Batangas', '', '8-C', 'Male', 'miguel.torres@email.com',
 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas', '09170008888',
 87.9, @AcademicYearId),

-- 6
('Julia', 'Marie', 'Ramos', 'Transferee', '2010-12-25', 'Grade 9', 'Filipino',
 'Oscar Ramos', '09173334444', 'Carmen Marie', '09184445555', 'Taal, Batangas',
 'Paula Villanueva', 'Aunt', '09331112222', 'Bauan, Batangas', '', '9-B',
 'Female', 'julia.ramos@email.com', 'Taal Elementary', 'Grade 8',
 'Taal, Batangas', '09173334444', 94.1, @AcademicYearId),

-- 7
('Daniel', 'Santos', 'Villanueva', 'Old', '2009-07-05', 'Grade 10', 'Filipino',
 'Rogelio Villanueva', '09172225555', 'Angela Santos', '09185556666',
 'Balayan, Batangas', 'Fernando Cruz', 'Grandfather', '09556667777',
 'Tanauan, Batangas', '', '10-A', 'Male', 'daniel.villanueva@email.com',
 'Balayan High', 'Grade 9', 'Balayan, Batangas', '09172225555',
 90.0, @AcademicYearId),

-- 8
('Isabella', 'Maria', 'Fernandez', 'New', '2012-08-22', 'Grade 7', 'Filipino',
 'Vicente Fernandez', '09173337777', 'Patricia Maria', '09189990000',
 'Calaca, Batangas', 'Cecilia Reyes', 'Aunt', '09228889999',
 'Balayan, Batangas', '', '7-B', 'Female', 'isabella.fernandez@email.com',
 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas', '09173337777',
 93.4, @AcademicYearId),

-- 9
('Gabriel', 'Jose', 'Mendoza', 'Transferee', '2011-04-14', 'Grade 8', 'Filipino',
 'Salvador Mendoza', '09176665555', 'Dolores Jose', '09182228888',
 'Balayan, Batangas', 'Eduardo Ramos', 'Uncle', '09174443333',
 'Lemery, Batangas', '', '8-A', 'Male', 'gabriel.mendoza@email.com',
 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas', '09176665555',
 86.8, @AcademicYearId),

-- 10
('Camille', 'Rose', 'Castillo', 'Old', '2010-10-09', 'Grade 9', 'Filipino',
 'Julio Castillo', '09177774444', 'Marta Rose', '09181112222',
 'San Luis, Batangas', 'Beatriz Lopez', 'Aunt', '09175556666',
 'Balayan, Batangas', '', '9-C', 'Female', 'camille.castillo@email.com',
 'San Luis Elementary', 'Grade 8', 'San Luis, Batangas', '09177774444',
 89.6, @AcademicYearId),

-- 11
('Patrick', 'Reyes', 'Morales', 'New', '2012-01-25', 'Grade 7', 'Filipino',
 'Hector Morales', '09178883333', 'Veronica Reyes', '09183334444',
 'Batangas City', 'Ricardo Garcia', 'Uncle', '09176662222',
 'Lipa, Batangas', '', '7-C', 'Male', 'patrick.morales@email.com',
 'Batangas Elementary', 'Grade 7', 'Batangas City', '09178883333',
 91.7, @AcademicYearId),

-- 12
('Angela', 'Marie', 'Gutierrez', 'Transferee', '2009-11-11', 'Grade 10', 'Filipino',
 'Francisco Gutierrez', '09175551111', 'Clarissa Marie', '09187778888',
 'Balayan, Batangas', 'Alfonso Torres', 'Grandfather', '09170009999',
 'Tanauan, Batangas', '', '10-B', 'Female', 'angela.gutierrez@email.com',
 'Balayan High', 'Grade 9', 'Balayan, Batangas', '09175551111',
 95.0, @AcademicYearId),

-- 13
('Christian', 'Paul', 'Santiago', 'Old', '2011-03-19', 'Grade 8', 'Filipino',
 'Pedro Santiago', '09173338888', 'Evelyn Paul', '09189991111',
 'Calaca, Batangas', 'Ramon Lopez', 'Uncle', '09171112222',
 'Balayan, Batangas', '', '8-B', 'Male',
 'christian.santiago@email.com',
 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas',
 '09173338888', 87.2, @AcademicYearId),

-- 14
('Nicole', 'Grace', 'Navarro', 'New', '2010-09-03', 'Grade 9', 'Filipino',
 'Benito Navarro', '09174445555', 'Sandra Grace', '09186667777',
 'Balayan, Batangas', 'Teresa Mendoza', 'Aunt', '09179998888',
 'San Jose, Batangas', '', '9-A', 'Female', 'nicole.navarro@email.com',
 'Balayan Elementary', 'Grade 8', 'Balayan, Batangas', '09174445555',
 92.5, @AcademicYearId),

-- 15
('Joseph', 'Luis', 'Domingo', 'Transferee', '2009-05-21', 'Grade 10', 'Filipino', 
 'Dominic Domingo', '09175552222', 'Rosario Luis', '09187776666',
 'Balayan, Batangas', 'Miguel Ramos', 'Grandfather', '09176661111', 'Magnito Street, Batangas',
 '', '10-C', 'Male',
 'joseph.domingo@email.com',
 'Balayan High', 'Grade 9', 'Balayan, Batangas',
 '09175552222', 88.9, @AcademicYearId),

-- 16
('Clarisse', 'Anne', 'Valdez', 'Old', '2011-07-30', 'Grade 8', 'Filipino',
 'Cesar Valdez', '09176663333', 'Helena Anne', '09189992222',
 'Lemery, Batangas', 'Felisa Garcia', 'Aunt', '09172223333',
 'Balayan, Batangas', '', '8-C', 'Female',
 'clarisse.valdez@email.com',
 'Lemery Elementary', 'Grade 7', 'Lemery, Batangas',
 '09176663333', 90.4, @AcademicYearId),

-- 17
('Andrew', 'James', 'Pascual', 'New', '2012-02-18', 'Grade 7', 'Filipino',
 'Mario Pascual', '09175559999', 'Jocelyn James', '09183336666',
 'Calaca, Batangas', 'Leonardo Cruz', 'Uncle', '09173331111',
 'Balayan, Batangas', '', '7-B', 'Male',
 'andrew.pascual@email.com',
 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas',
 '09175559999', 89.1, @AcademicYearId),

-- 18
('Katrina', 'Joy', 'Marquez', 'Old', '2010-12-07', 'Grade 9', 'Filipino',
 'Jorge Marquez', '09179992222', 'Lucia Joy', '09182221111',
 'Balayan, Batangas', 'Carolina Torres', 'Aunt', '09174442222',
 'San Juan, Batangas', '', '9-B', 'Female',
 'katrina.marquez@email.com',
 'Balayan Elementary', 'Grade 8', 'Balayan, Batangas',
 '09179992222', 91.8, @AcademicYearId),

-- 19
('Nathan', 'Allan', 'Roxas', 'Transferee', '2009-08-16', 'Grade 10', 'Filipino',
 'Roberto Roxas', '09172224444', 'Miriam Allan', '09185558888',
 'Taal, Batangas', 'Diego Ramos', 'Grandfather', '09179997777',
 'Batangas City', '', '10-A', 'Male',
 'nathan.roxas@email.com',
 'Taal High', 'Grade 9', 'Taal, Batangas',
 '09172224444', 93.0, @AcademicYearId),

-- 20
('Samantha', 'Mae', 'Aquino', 'New', '2011-06-29', 'Grade 8', 'Filipino',
 'Vicente Aquino', '09173332222', 'Adela Mae', '09182229999',
 'Balayan, Batangas', 'Josefina Garcia', 'Aunt', '09176664444',
 'Calaca, Batangas', '', '8-A', 'Female',
 'samantha.aquino@email.com',
 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas',
 '09173332222', 90.6, @AcademicYearId),

-- 21
('Luis', 'Antonio', 'Hernandez', 'Old', '2010-04-10', 'Grade 9', 'Filipino',
 'Manuel Hernandez', '09171112233', 'Rosa Antonio', '09182233445', 'Balayan, Batangas',
 'Tito Reyes', 'Uncle', '09173344556', 'Lemery, Batangas', '', '9-C', 'Male',
 'luis.hernandez@email.com', 'Balayan Elementary', 'Grade 8', 'Balayan, Batangas',
 '09171112233', 87.4, @AcademicYearId),

-- 22
('Maria', 'Elena', 'Santos', 'New', '2012-05-05', 'Grade 7', 'Filipino',
 'Pedro Santos', '09174455667', 'Ana Elena', '09185566778', 'Calaca, Batangas',
 'Lola Cruz', 'Grandmother', '09176677889', 'Balayan, Batangas', '', '7-A', 'Female',
 'maria.santos@email.com', 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas',
 '09174455667', 92.1, @AcademicYearId),

-- 23
('Carlos', 'Miguel', 'Lopez', 'Transferee', '2009-10-20', 'Grade 10', 'Filipino',
 'Juan Lopez', '09177788990', 'Sofia Miguel', '09188899001', 'Taal, Batangas',
 'Tito Garcia', 'Uncle', '09179900112', 'Batangas City', '', '10-B', 'Male',
 'carlos.lopez@email.com', 'Taal High', 'Grade 9', 'Taal, Batangas',
 '09177788990', 89.3, @AcademicYearId),

-- 24
('Elena', 'Rose', 'Cruz', 'Old', '2011-01-15', 'Grade 8', 'Filipino',
 'Antonio Cruz', '09172233445', 'Maria Rose', '09183344556', 'Balayan, Batangas',
 'Tita Reyes', 'Aunt', '09174455667', 'San Juan, Batangas', '', '8-B', 'Female',
 'elena.cruz@email.com', 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas',
 '09172233445', 91.0, @AcademicYearId),

-- 25
('Ricardo', 'Jose', 'Garcia', 'New', '2012-07-12', 'Grade 7', 'Filipino',
 'Luis Garcia', '09175566778', 'Carmen Jose', '09186677889', 'Lemery, Batangas',
 'Lolo Torres', 'Grandfather', '09177788990', 'Lipa, Batangas', '', '7-C', 'Male',
 'ricardo.garcia@email.com', 'Lemery Elementary', 'Grade 7', 'Lemery, Batangas',
 '09175566778', 88.7, @AcademicYearId),

-- 26
('Patricia', 'Ann', 'Torres', 'Transferee', '2010-11-08', 'Grade 9', 'Filipino',
 'Miguel Torres', '09178899001', 'Elena Ann', '09189900112', 'San Luis, Batangas',
 'Tita Lopez', 'Aunt', '09171112233', 'Balayan, Batangas', '', '9-A', 'Female',
 'patricia.torres@email.com', 'San Luis Elementary', 'Grade 8', 'San Luis, Batangas',
 '09178899001', 93.2, @AcademicYearId),

-- 27
('Fernando', 'Luis', 'Ramos', 'Old', '2009-06-25', 'Grade 10', 'Filipino',
 'Oscar Ramos', '09173344556', 'Isabel Luis', '09184455667', 'Balayan, Batangas',
 'Tito Mendoza', 'Uncle', '09175566778', 'Tanauan, Batangas', '', '10-C', 'Male',
 'fernando.ramos@email.com', 'Balayan High', 'Grade 9', 'Balayan, Batangas',
 '09173344556', 90.5, @AcademicYearId),

-- 28
('Cristina', 'Marie', 'Villanueva', 'New', '2011-09-18', 'Grade 8', 'Filipino',
 'Rogelio Villanueva', '09176677889', 'Angela Marie', '09187788990', 'Calaca, Batangas',
 'Lola Garcia', 'Grandmother', '09178899001', 'Balayan, Batangas', '', '8-A', 'Female',
 'cristina.villanueva@email.com', 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas',
 '09176677889', 89.8, @AcademicYearId),

-- 29
('Roberto', 'Paul', 'Fernandez', 'Transferee', '2010-03-22', 'Grade 9', 'Filipino',
 'Vicente Fernandez', '09179900112', 'Patricia Paul', '09181112233', 'Nasugbu, Batangas',
 'Tito Cruz', 'Uncle', '09172233445', 'Batangas City', '', '9-B', 'Male',
 'roberto.fernandez@email.com', 'Nasugbu High', 'Grade 8', 'Nasugbu, Batangas',
 '09179900112', 86.9, @AcademicYearId),
-- 30 
('Victoria', 'Grace', 'Mendoza', 'Old', '2012-04-30', 'Grade 7', 'Filipino',
 'Salvador Mendoza', '09171122334', 'Dolores Grace', '09182233445', 'Balayan, Batangas',
 'Tita Ramos', 'Aunt', '09173344556', 'Calaca, Batangas', '', '7-B', 'Female',
 'victoria.mendoza@email.com', 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas',
 '09171122334', 88.2, @AcademicYearId),

-- 31
('Eduardo', 'Carlos', 'Castillo', 'New', '2011-11-14', 'Grade 8', 'Filipino',
 'Julio Castillo', '09172233456', 'Marta Carlos', '09183344567', 'San Luis, Batangas',
 'Lolo Lopez', 'Grandfather', '09174455678', 'Balayan, Batangas', '', '8-C', 'Male',
 'eduardo.castillo@email.com', 'San Luis Elementary', 'Grade 7', 'San Luis, Batangas',
 '09172233456', 91.3, @AcademicYearId),

-- 32
('Francesca', 'Joy', 'Morales', 'Transferee', '2010-07-19', 'Grade 9', 'Filipino',
 'Hector Morales', '09175566789', 'Veronica Joy', '09186677890', 'Batangas City',
 'Tito Garcia', 'Uncle', '09177788901', 'Lipa, Batangas', '', '9-A', 'Female',
 'francesca.morales@email.com', 'Batangas Elementary', 'Grade 8', 'Batangas City',
 '09175566789', 94.5, @AcademicYearId),

-- 33
('Rafael', 'Luis', 'Gutierrez', 'Old', '2009-12-03', 'Grade 10', 'Filipino',
 'Francisco Gutierrez', '09178899012', 'Clarissa Luis', '09189900123', 'Balayan, Batangas',
 'Tita Torres', 'Aunt', '09171112234', 'Tanauan, Batangas', '', '10-A', 'Male',
 'rafael.gutierrez@email.com', 'Balayan High', 'Grade 9', 'Balayan, Batangas',
 '09178899012', 89.7, @AcademicYearId),

-- 34
('Diana', 'Marie', 'Santiago', 'New', '2012-06-27', 'Grade 7', 'Filipino',
 'Pedro Santiago', '09173344567', 'Evelyn Marie', '09184455678', 'Calaca, Batangas',
 'Lola Cruz', 'Grandmother', '09175566789', 'Balayan, Batangas', '', '7-C', 'Female',
 'diana.santiago@email.com', 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas',
 '09173344567', 92.8, @AcademicYearId),

-- 35
('Antonio', 'Paul', 'Navarro', 'Transferee', '2011-05-09', 'Grade 8', 'Filipino',
 'Benito Navarro', '09176677890', 'Sandra Paul', '09187788901', 'Balayan, Batangas',
 'Tito Mendoza', 'Uncle', '09178899012', 'San Jose, Batangas', '', '8-B', 'Male',
 'antonio.navarro@email.com', 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas',
 '09176677890', 87.6, @AcademicYearId),

-- 36
('Monica', 'Grace', 'Domingo', 'Old', '2010-08-16', 'Grade 9', 'Filipino',
 'Dominic Domingo', '09179900123', 'Rosario Grace', '09181112234', 'Balayan, Batangas',
 'Lolo Ramos', 'Grandfather', '09172233456', 'Magnito Street, Batangas', '', '9-B', 'Female',
 'monica.domingo@email.com', 'Balayan Elementary', 'Grade 8', 'Balayan, Batangas',
 '09179900123', 90.9, @AcademicYearId),

-- 37
('Leonardo', 'James', 'Valdez', 'New', '2012-03-11', 'Grade 7', 'Filipino',
 'Cesar Valdez', '09171122345', 'Helena James', '09182233456', 'Lemery, Batangas',
 'Tita Garcia', 'Aunt', '09173344567', 'Balayan, Batangas', '', '7-A', 'Male',
 'leonardo.valdez@email.com', 'Lemery Elementary', 'Grade 7', 'Lemery, Batangas',
 '09171122345', 89.4, @AcademicYearId),

-- 38
('Bianca', 'Rose', 'Pascual', 'Transferee', '2010-01-28', 'Grade 9', 'Filipino',
 'Mario Pascual', '09174455678', 'Jocelyn Rose', '09185566789', 'Calaca, Batangas',
 'Tito Cruz', 'Uncle', '09176677890', 'Balayan, Batangas', '', '9-C', 'Female',
 'bianca.pascual@email.com', 'Calaca Elementary', 'Grade 8', 'Calaca, Batangas',
 '09174455678', 93.7, @AcademicYearId),

-- 39
('Diego', 'Allan', 'Marquez', 'Old', '2009-09-05', 'Grade 10', 'Filipino',
 'Jorge Marquez', '09177788901', 'Lucia Allan', '09188899012', 'Balayan, Batangas',
 'Lola Torres', 'Grandmother', '09179900123', 'San Juan, Batangas', '', '10-B', 'Male',
 'diego.marquez@email.com', 'Balayan High', 'Grade 9', 'Balayan, Batangas',
 '09177788901', 91.1, @AcademicYearId),

-- 40
('Camila', 'Mae', 'Roxas', 'New', '2011-10-22', 'Grade 8', 'Filipino',
 'Roberto Roxas', '09172233456', 'Miriam Mae', '09183344567', 'Taal, Batangas',
 'Tito Garcia', 'Uncle', '09174455678', 'Batangas City', '', '8-A', 'Female',
 'camila.roxas@email.com', 'Taal Elementary', 'Grade 7', 'Taal, Batangas',
 '09172233456', 88.3, @AcademicYearId),

-- 41
('Felipe', 'Jose', 'Hernandez', 'Transferee', '2010-04-17', 'Grade 9', 'Filipino',
 'Manuel Hernandez', '09175566789', 'Rosa Jose', '09186677890', 'Balayan, Batangas',
 'Lolo Reyes', 'Grandfather', '09177788901', 'Lemery, Batangas', '', '9-A', 'Male',
 'felipe.hernandez@email.com', 'Balayan Elementary', 'Grade 8', 'Balayan, Batangas',
 '09175566789', 92.4, @AcademicYearId),

-- 42
('Gabriela', 'Elena', 'Santos', 'Old', '2012-02-09', 'Grade 7', 'Filipino',
 'Pedro Santos', '09178899012', 'Ana Elena', '09189900123', 'Calaca, Batangas',
 'Tita Cruz', 'Aunt', '09171112234', 'Balayan, Batangas', '', '7-B', 'Female',
 'gabriela.santos@email.com', 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas',
 '09178899012', 90.2, @AcademicYearId),

-- 43
('Hugo', 'Miguel', 'Lopez', 'New', '2011-12-01', 'Grade 8', 'Filipino',
 'Juan Lopez', '09173344567', 'Sofia Miguel', '09184455678', 'Taal, Batangas',
 'Tito Garcia', 'Uncle', '09175566789', 'Batangas City', '', '8-C', 'Male',
 'hugo.lopez@email.com', 'Taal Elementary', 'Grade 7', 'Taal, Batangas',
 '09173344567', 87.8, @AcademicYearId),

-- 44
('Isabel', 'Rose', 'Cruz', 'Transferee', '2009-11-30', 'Grade 10', 'Filipino',
 'Antonio Cruz', '09176677890', 'Maria Rose', '09187788901', 'Balayan, Batangas',
 'Lola Reyes', 'Grandmother', '09178899012', 'San Juan, Batangas', '', '10-C', 'Female',
 'isabel.cruz@email.com', 'Balayan High', 'Grade 9', 'Balayan, Batangas',
 '09176677890', 94.0, @AcademicYearId),

-- 45
('Javier', 'Jose', 'Garcia', 'Old', '2010-06-14', 'Grade 9', 'Filipino',
 'Luis Garcia', '09179900123', 'Carmen Jose', '09181112234', 'Lemery, Batangas',
 'Tito Torres', 'Uncle', '09172233456', 'Lipa, Batangas', '', '9-B', 'Male',
 'javier.garcia@email.com', 'Lemery Elementary', 'Grade 8', 'Lemery, Batangas',
 '09179900123', 89.5, @AcademicYearId),

-- 46
('Karla', 'Ann', 'Torres', 'New', '2012-08-03', 'Grade 7', 'Filipino',
 'Miguel Torres', '09171122345', 'Elena Ann', '09182233456', 'San Luis, Batangas',
 'Lolo Lopez', 'Grandfather', '09173344567', 'Balayan, Batangas', '', '7-C', 'Female',
 'karla.torres@email.com', 'San Luis Elementary', 'Grade 7', 'San Luis, Batangas',
 '09171122345', 91.6, @AcademicYearId),

-- 47
('Luis', 'Luis', 'Ramos', 'Transferee', '2011-03-26', 'Grade 8', 'Filipino',
 'Oscar Ramos', '09174455678', 'Isabel Luis', '09185566789', 'Balayan, Batangas',
 'Tita Mendoza', 'Aunt', '09176677890', 'Tanauan, Batangas', '', '8-B', 'Male',
 'luis.ramos@email.com', 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas',
 '09174455678', 88.1, @AcademicYearId),

-- 48
('Natalia', 'Marie', 'Villanueva', 'Old', '2010-05-12', 'Grade 9', 'Filipino',
 'Rogelio Villanueva', '09177788901', 'Angela Marie', '09188899012', 'Calaca, Batangas',
 'Tito Cruz', 'Uncle', '09179900123', 'Balayan, Batangas', '', '9-C', 'Female',
 'natalia.villanueva@email.com', 'Calaca Elementary', 'Grade 8', 'Calaca, Batangas',
 '09177788901', 93.3, @AcademicYearId),

-- 49
('Oscar', 'Paul', 'Fernandez', 'New', '2012-01-07', 'Grade 7', 'Filipino',
 'Vicente Fernandez', '09172233456', 'Patricia Paul', '09183344567', 'Nasugbu, Batangas',
 'Lola Garcia', 'Grandmother', '09174455678', 'Batangas City', '', '7-A', 'Male',
 'oscar.fernandez@email.com', 'Nasugbu Elementary', 'Grade 7', 'Nasugbu, Batangas',
 '09172233456', 90.7, @AcademicYearId),

-- 50
('Paula', 'Grace', 'Mendoza', 'Transferee', '2009-07-29', 'Grade 10', 'Filipino',
 'Salvador Mendoza', '09175566789', 'Dolores Grace', '09186677890', 'Balayan, Batangas',
 'Tito Ramos', 'Uncle', '09177788901', 'Calaca, Batangas', '', '10-A', 'Female',
 'paula.mendoza@email.com', 'Balayan High', 'Grade 9', 'Balayan, Batangas',
 '09175566789', 92.9, @AcademicYearId);
;

-- Insert Student Registrations
INSERT INTO [dbo].[tblStudentRegistration] (StudentId, Section, Requirements, PaymentMethod)
VALUES
(1, '9-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(2, '8-B', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(3, '10-C', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(4, '7-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(5, '8-C', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(6, '9-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(7, '10-A', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(8, '7-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(9, '8-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(10, '9-C', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(11, '7-C', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(12, '10-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(13, '8-B', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(14, '9-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(15, '10-C', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(16, '8-C', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(17, '7-B', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(18, '9-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(19, '10-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(20, '8-A', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(21, '9-C', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(22, '7-A', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(23, '10-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(24, '8-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(25, '9-A', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(26, '7-C', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(27, '10-C', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(28, '8-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(29, '9-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(30, '7-B', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(31, '10-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(32, '8-C', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(33, '9-C', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(34, '7-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(35, '10-B', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(36, '8-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(37, '9-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(38, '7-C', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(39, '10-C', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(40, '8-A', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(41, '9-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(42, '7-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(43, '10-A', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(44, '8-C', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(45, '9-C', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(46, '7-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(47, '10-B', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(48, '8-B', 'Good Moral, Form 137, Birth Certificate', 'Partial'),
(49, '9-A', 'Good Moral, Form 137, Birth Certificate', 'Full'),
(50, '7-C', 'Good Moral, Form 137, Birth Certificate', 'Partial');


 end

-- Insert Sections
INSERT INTO [dbo].[tblSections] ([SectionName]) 
VALUES 
('7-A'), 
('7-B'), 
('7-C'),
('8-A'), 
('8-B'), 
('8-C'),
('9-A'), 
('9-B'), 
('9-C'),
('10-A'), 
('10-B'), 
('10-C');

-- Insert Teachers (Example)
-- Adding more teachers
-- Adding 12 Teachers with additional roles (e.g., Advisors, Subject Teachers, etc.)
INSERT INTO [dbo].[tblTeachers] (TeacherID,[TeacherName]) VALUES
(1, 'Zarah Austria'),
(2, 'Hanz Llenard Sacdalan'),
(3, 'Michael Tagle'),
(4, 'Jean Andre Vergel De Dios'),
(5,'Janine De Guzman'),    -- Teacher 5
(6,'Joshua Reyes'),        -- Teacher 6
(7,'Ronaldo Lopez'),       -- Teacher 7
(8,'Cynthia Magno'),       -- Teacher 8
(9,'Marianne Ramos'),      -- Teacher 9
(10,'Gabrielle Santos'),    -- Teacher 10
(11,'Liza Fernandez'),      -- Teacher 11
(12,'Clara Reyes');         -- Teacher 12

-- Insert Subjects
INSERT INTO [dbo].[tblSubjects] ([SubjectID],[SubjectName], [Category])
VALUES
(1, 'Science', NULL),
(2, 'Filipino', NULL),
(3, 'Mathematics', NULL),
(4, 'Edukasyon sa Pagpapakatao (EsP)', NULL),
(5, 'Music', 'MAPEH'),
(6, 'Arts', 'MAPEH'),
(7, 'Physical Education', 'MAPEH'),
(8, 'Health', 'MAPEH'),
(9, 'Araling Panlipunan (AP)', NULL),
(10, 'English', NULL),
(11, 'Technology and Livelihood Education (TLE)', NULL);

INSERT INTO [dbo].[tblSchedules] ([SectionID], [TeacherID], [SubjectID], [StartTime], [EndTime], [Day], [GradeLevel])
VALUES
(1, 1, 1, '08:00:00', '09:00:00', 'Monday', 'Grade 7'),
(1, 2, 1, '09:00:00', '10:00:00', 'Monday', 'Grade 7'),
(2, 3, 2, '08:00:00', '09:00:00', 'Monday', 'Grade 7'),
(2, 4, 2, '09:00:00', '10:00:00', 'Monday', 'Grade 7'),
(3, 5, 3, '08:00:00', '09:00:00', 'Monday', 'Grade 7'),
(3, 6, 3, '09:00:00', '10:00:00', 'Monday', 'Grade 7'),
(4, 7, 4, '08:00:00', '09:00:00', 'Monday', 'Grade 7'),
(4, 8, 4, '09:00:00', '10:00:00', 'Monday', 'Grade 7'),

(5, 9, 1, '08:00:00', '09:00:00', 'Tuesday', 'Grade 7'),
(5, 10, 1, '09:00:00', '10:00:00', 'Tuesday', 'Grade 7'),
(6, 11, 2, '08:00:00', '09:00:00', 'Tuesday', 'Grade 7'),
(6, 12, 2, '09:00:00', '10:00:00', 'Tuesday', 'Grade 7'),

(7, 1, 3, '08:00:00', '09:00:00', 'Wednesday', 'Grade 7'),
(7, 2, 3, '09:00:00', '10:00:00', 'Wednesday', 'Grade 7'),
(8, 3, 4, '08:00:00', '09:00:00', 'Wednesday', 'Grade 7'),
(8, 4, 4, '09:00:00', '10:00:00', 'Wednesday', 'Grade 7'),
(9, 5, 5, '08:00:00', '09:00:00', 'Wednesday', 'Grade 7'),
(9, 6, 5, '09:00:00', '10:00:00', 'Wednesday', 'Grade 7'),

(10, 7, 6, '08:00:00', '09:00:00', 'Thursday', 'Grade 7'),
(10, 8, 6, '09:00:00', '10:00:00', 'Thursday', 'Grade 7'),
(11, 9, 7, '08:00:00', '09:00:00', 'Thursday', 'Grade 7'),
(11, 10, 7, '09:00:00', '10:00:00', 'Thursday', 'Grade 7'),
(12, 11, 8, '08:00:00', '09:00:00', 'Thursday', 'Grade 7'),
(12, 12, 8, '09:00:00', '10:00:00', 'Thursday', 'Grade 7'),

(1, 1, 1, '08:00:00', '09:00:00', 'Friday', 'Grade 7'),
(1, 2, 1, '09:00:00', '10:00:00', 'Friday', 'Grade 7'),
(2, 3, 2, '08:00:00', '09:00:00', 'Friday', 'Grade 7'),
(2, 4, 2, '09:00:00', '10:00:00', 'Friday', 'Grade 7'),
(3, 5, 3, '08:00:00', '09:00:00', 'Friday', 'Grade 7'),
(3, 6, 3, '09:00:00', '10:00:00', 'Friday', 'Grade 7'),
(4, 7, 4, '08:00:00', '09:00:00', 'Friday', 'Grade 7'),
(4, 8, 4, '09:00:00', '10:00:00', 'Friday', 'Grade 7'),
(5, 9, 1, '08:00:00', '09:00:00', 'Friday', 'Grade 7'),
(5, 10, 1, '09:00:00', '10:00:00', 'Friday', 'Grade 7'),
(6, 11, 2, '08:00:00', '09:00:00', 'Friday', 'Grade 7'),
(6, 12, 2, '09:00:00', '10:00:00', 'Friday', 'Grade 7');


INSERT INTO [dbo].[tblSchedules] ([SectionID], [TeacherID], [SubjectID], [StartTime], [EndTime], [Day], [GradeLevel])
VALUES
-- Monday
(1, 1, 1, '08:00:00', '09:00:00', 'Monday', 'Grade 8'),
(1, 2, 1, '09:00:00', '10:00:00', 'Monday', 'Grade 8'),
(2, 3, 2, '08:00:00', '09:00:00', 'Monday', 'Grade 8'),
(2, 4, 2, '09:00:00', '10:00:00', 'Monday', 'Grade 8'),
(3, 5, 3, '08:00:00', '09:00:00', 'Monday', 'Grade 8'),
(3, 6, 3, '09:00:00', '10:00:00', 'Monday', 'Grade 8'),
(4, 7, 4, '08:00:00', '09:00:00', 'Monday', 'Grade 8'),
(4, 8, 4, '09:00:00', '10:00:00', 'Monday', 'Grade 8'),

-- Tuesday
(5, 9, 1, '08:00:00', '09:00:00', 'Tuesday', 'Grade 8'),
(5, 10, 1, '09:00:00', '10:00:00', 'Tuesday', 'Grade 8'),
(6, 11, 2, '08:00:00', '09:00:00', 'Tuesday', 'Grade 8'),
(6, 12, 2, '09:00:00', '10:00:00', 'Tuesday', 'Grade 8'),

-- Wednesday
(7, 1, 3, '08:00:00', '09:00:00', 'Wednesday', 'Grade 8'),
(7, 2, 3, '09:00:00', '10:00:00', 'Wednesday', 'Grade 8'),
(8, 3, 4, '08:00:00', '09:00:00', 'Wednesday', 'Grade 8'),
(8, 4, 4, '09:00:00', '10:00:00', 'Wednesday', 'Grade 8'),
(9, 5, 5, '08:00:00', '09:00:00', 'Wednesday', 'Grade 8'),
(9, 6, 5, '09:00:00', '10:00:00', 'Wednesday', 'Grade 8'),

-- Thursday
(10, 7, 6, '08:00:00', '09:00:00', 'Thursday', 'Grade 8'),
(10, 8, 6, '09:00:00', '10:00:00', 'Thursday', 'Grade 8'),
(11, 9, 7, '08:00:00', '09:00:00', 'Thursday', 'Grade 8'),
(11, 10, 7, '09:00:00', '10:00:00', 'Thursday', 'Grade 8'),
(12, 11, 8, '08:00:00', '09:00:00', 'Thursday', 'Grade 8'),
(12, 12, 8, '09:00:00', '10:00:00', 'Thursday', 'Grade 8'),

-- Friday
(1, 1, 1, '08:00:00', '09:00:00', 'Friday', 'Grade 8'),
(1, 2, 1, '09:00:00', '10:00:00', 'Friday', 'Grade 8'),
(2, 3, 2, '08:00:00', '09:00:00', 'Friday', 'Grade 8'),
(2, 4, 2, '09:00:00', '10:00:00', 'Friday', 'Grade 8'),
(3, 5, 3, '08:00:00', '09:00:00', 'Friday', 'Grade 8'),
(3, 6, 3, '09:00:00', '10:00:00', 'Friday', 'Grade 8'),
(4, 7, 4, '08:00:00', '09:00:00', 'Friday', 'Grade 8'),
(4, 8, 4, '09:00:00', '10:00:00', 'Friday', 'Grade 8'),
(5, 9, 1, '08:00:00', '09:00:00', 'Friday', 'Grade 8'),
(5, 10, 1, '09:00:00', '10:00:00', 'Friday', 'Grade 8'),
(6, 11, 2, '08:00:00', '09:00:00', 'Friday', 'Grade 8'),
(6, 12, 2, '09:00:00', '10:00:00', 'Friday', 'Grade 8');

INSERT INTO [dbo].[tblSchedules] ([SectionID], [TeacherID], [SubjectID], [StartTime], [EndTime], [Day], [GradeLevel])
VALUES
-- Monday
(1, 1, 1, '08:00:00', '09:00:00', 'Monday', 'Grade 9'),
(1, 2, 1, '09:00:00', '10:00:00', 'Monday', 'Grade 9'),
(2, 3, 2, '08:00:00', '09:00:00', 'Monday', 'Grade 9'),
(2, 4, 2, '09:00:00', '10:00:00', 'Monday', 'Grade 9'),
(3, 5, 3, '08:00:00', '09:00:00', 'Monday', 'Grade 9'),
(3, 6, 3, '09:00:00', '10:00:00', 'Monday', 'Grade 9'),
(4, 7, 4, '08:00:00', '09:00:00', 'Monday', 'Grade 9'),
(4, 8, 4, '09:00:00', '10:00:00', 'Monday', 'Grade 9'),

-- Tuesday
(5, 9, 1, '08:00:00', '09:00:00', 'Tuesday', 'Grade 9'),
(5, 10, 1, '09:00:00', '10:00:00', 'Tuesday', 'Grade 9'),
(6, 11, 2, '08:00:00', '09:00:00', 'Tuesday', 'Grade 9'),
(6, 12, 2, '09:00:00', '10:00:00', 'Tuesday', 'Grade 9'),

-- Wednesday
(7, 1, 3, '08:00:00', '09:00:00', 'Wednesday', 'Grade 9'),
(7, 2, 3, '09:00:00', '10:00:00', 'Wednesday', 'Grade 9'),
(8, 3, 4, '08:00:00', '09:00:00', 'Wednesday', 'Grade 9'),
(8, 4, 4, '09:00:00', '10:00:00', 'Wednesday', 'Grade 9'),
(9, 5, 5, '08:00:00', '09:00:00', 'Wednesday', 'Grade 9'),
(9, 6, 5, '09:00:00', '10:00:00', 'Wednesday', 'Grade 9'),

-- Thursday
(10, 7, 6, '08:00:00', '09:00:00', 'Thursday', 'Grade 9'),
(10, 8, 6, '09:00:00', '10:00:00', 'Thursday', 'Grade 9'),
(11, 9, 7, '08:00:00', '09:00:00', 'Thursday', 'Grade 9'),
(11, 10, 7, '09:00:00', '10:00:00', 'Thursday', 'Grade 9'),
(12, 11, 8, '08:00:00', '09:00:00', 'Thursday', 'Grade 9'),
(12, 12, 8, '09:00:00', '10:00:00', 'Thursday', 'Grade 9'),

-- Friday
(1, 1, 1, '08:00:00', '09:00:00', 'Friday', 'Grade 9'),
(1, 2, 1, '09:00:00', '10:00:00', 'Friday', 'Grade 9'),
(2, 3, 2, '08:00:00', '09:00:00', 'Friday', 'Grade 9'),
(2, 4, 2, '09:00:00', '10:00:00', 'Friday', 'Grade 9'),
(3, 5, 3, '08:00:00', '09:00:00', 'Friday', 'Grade 9'),
(3, 6, 3, '09:00:00', '10:00:00', 'Friday', 'Grade 9'),
(4, 7, 4, '08:00:00', '09:00:00', 'Friday', 'Grade 9'),
(4, 8, 4, '09:00:00', '10:00:00', 'Friday', 'Grade 9'),
(5, 9, 1, '08:00:00', '09:00:00', 'Friday', 'Grade 9'),
(5, 10, 1, '09:00:00', '10:00:00', 'Friday', 'Grade 9'),
(6, 11, 2, '08:00:00', '09:00:00', 'Friday', 'Grade 9'),
(6, 12, 2, '09:00:00', '10:00:00', 'Friday', 'Grade 9');


INSERT INTO [dbo].[tblSchedules] ([SectionID], [TeacherID], [SubjectID], [StartTime], [EndTime], [Day], [GradeLevel])
VALUES
-- Monday
(1, 1, 1, '08:00:00', '09:00:00', 'Monday', 'Grade 10'),
(1, 2, 1, '09:00:00', '10:00:00', 'Monday', 'Grade 10'),
(2, 3, 2, '08:00:00', '09:00:00', 'Monday', 'Grade 10'),
(2, 4, 2, '09:00:00', '10:00:00', 'Monday', 'Grade 10'),
(3, 5, 3, '08:00:00', '09:00:00', 'Monday', 'Grade 10'),
(3, 6, 3, '09:00:00', '10:00:00', 'Monday', 'Grade 10'),
(4, 7, 4, '08:00:00', '09:00:00', 'Monday', 'Grade 10'),
(4, 8, 4, '09:00:00', '10:00:00', 'Monday', 'Grade 10'),

-- Tuesday
(5, 9, 1, '08:00:00', '09:00:00', 'Tuesday', 'Grade 10'),
(5, 10, 1, '09:00:00', '10:00:00', 'Tuesday', 'Grade 10'),
(6, 11, 2, '08:00:00', '09:00:00', 'Tuesday', 'Grade 10'),
(6, 12, 2, '09:00:00', '10:00:00', 'Tuesday', 'Grade 10'),

-- Wednesday
(7, 1, 3, '08:00:00', '09:00:00', 'Wednesday', 'Grade 10'),
(7, 2, 3, '09:00:00', '10:00:00', 'Wednesday', 'Grade 10'),
(8, 3, 4, '08:00:00', '09:00:00', 'Wednesday', 'Grade 10'),
(8, 4, 4, '09:00:00', '10:00:00', 'Wednesday', 'Grade 10'),
(9, 5, 5, '08:00:00', '09:00:00', 'Wednesday', 'Grade 10'),
(9, 6, 5, '09:00:00', '10:00:00', 'Wednesday', 'Grade 10'),

-- Thursday
(10, 7, 6, '08:00:00', '09:00:00', 'Thursday', 'Grade 10'),
(10, 8, 6, '09:00:00', '10:00:00', 'Thursday', 'Grade 10'),
(11, 9, 7, '08:00:00', '09:00:00', 'Thursday', 'Grade 10'),
(11, 10, 7, '09:00:00', '10:00:00', 'Thursday', 'Grade 10'),
(12, 11, 8, '08:00:00', '09:00:00', 'Thursday', 'Grade 10'),
(12, 12, 8, '09:00:00', '10:00:00', 'Thursday', 'Grade 10'),

-- Friday
(1, 1, 1, '08:00:00', '09:00:00', 'Friday', 'Grade 10'),
(1, 2, 1, '09:00:00', '10:00:00', 'Friday', 'Grade 10'),
(2, 3, 2, '08:00:00', '09:00:00', 'Friday', 'Grade 10'),
(2, 4, 2, '09:00:00', '10:00:00', 'Friday', 'Grade 10'),
(3, 5, 3, '08:00:00', '09:00:00', 'Friday', 'Grade 10'),
(3, 6, 3, '09:00:00', '10:00:00', 'Friday', 'Grade 10'),
(4, 7, 4, '08:00:00', '09:00:00', 'Friday', 'Grade 10'),
(4, 8, 4, '09:00:00', '10:00:00', 'Friday', 'Grade 10'),
(5, 9, 1, '08:00:00', '09:00:00', 'Friday', 'Grade 10'),
(5, 10, 1, '09:00:00', '10:00:00', 'Friday', 'Grade 10'),
(6, 11, 2, '08:00:00', '09:00:00', 'Friday', 'Grade 10'),
(6, 12, 2, '09:00:00', '10:00:00', 'Friday', 'Grade 10');


-- Execute the Philippine Middle School Schedule Stored Procedure
-- For ALL STUDENTS in tblStudents

DECLARE @StudentId INT;

DECLARE cur CURSOR FOR
    SELECT Id FROM tblStudents;

OPEN cur;

FETCH NEXT FROM cur INTO @StudentId;
WHILE @@FETCH_STATUS = 0
BEGIN
    EXEC CreatePhilippineMiddleSchoolSchedule @StudentId = @StudentId;

    FETCH NEXT FROM cur INTO @StudentId;
END;

CLOSE cur;
DEALLOCATE cur;
