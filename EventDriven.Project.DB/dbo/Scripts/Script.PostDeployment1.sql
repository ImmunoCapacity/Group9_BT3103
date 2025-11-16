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
INSERT INTO tblUser (username, userPassword, Role) 
VALUES
    ('Admin',    HASHBYTES('SHA2_256', 'admin123'), 'Admin'),
    ('Registrar', HASHBYTES('SHA2_256', 'registrar123'), 'Registrar'),
    ('Cashier',  HASHBYTES('SHA2_256', 'cashier123'), 'Cashier');




INSERT INTO [dbo].[tblStudents]
(FirstName, MiddleName, LastName, Status, BirthDate, GradeLevel, Nationality,
 FatherName, FatherContact, MotherName, MotherContact, ParentAddress,
 GuardianName, GuardianRelationship, GuardianContact, GuardianAddress,
 Suffix, Section, Gender, Email, LastSchool, LastGrade, Address, Contact, GWA)
VALUES
-- 1
('Juan', 'Santos', 'Dela Cruz', 'Active', '2010-05-15', 'Grade 9', 'Filipino',
 'Jose Dela Cruz', '09171234567', 'Maria Santos', '09187654321', 'Balayan, Batangas',
 'Pedro Lopez', 'Uncle', '09981231234', 'Caloocan, Balayan', '', '9-A', 'Male', 'juan.delacruz@email.com', 'Balayan Elementary', 'Grade 8', 'Balayan, Batangas', '09171234567', 88.5),

-- 2
('Ana', 'Lopez', 'Reyes', 'Active', '2011-02-20', 'Grade 8', 'Filipino',
 'Carlos Reyes', '09170001111', 'Elena Lopez', '09180002222', 'Lemery, Batangas',
 'Rosa Garcia', 'Aunt', '09993334444', 'Lipa, Batangas', '', '8-B', 'Female', 'ana.reyes@email.com', 'Lemery Elementary', 'Grade 7', 'Lemery, Batangas', '09170001111', 92.3),

-- 3
('Mark', 'David', 'Flores', 'Active', '2009-09-12', 'Grade 10', 'Filipino',
 'Ramon Flores', '09221231234', 'Cristina David', '09334445555', 'Nasugbu, Batangas',
 'Luis Cruz', 'Brother', '09176667777', 'Batangas City', '', '10-C', 'Male', 'mark.flores@email.com', 'Nasugbu High', 'Grade 9', 'Nasugbu, Batangas', '09221231234', 85.7),

-- 4
('Sophia', 'Cruz', 'Garcia', 'Active', '2012-03-30', 'Grade 7', 'Filipino',
 'Mario Garcia', '09175559999', 'Teresa Cruz', '09182223333', 'Balayan, Batangas',
 'Isabel Torres', 'Cousin', '09445556666', 'Calaca, Batangas', '', '7-A', 'Female', 'sophia.garcia@email.com', 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas', '09175559999', 91.2),

-- 5
('Miguel', 'Andres', 'Torres', 'Active', '2011-06-18', 'Grade 8', 'Filipino',
 'Antonio Torres', '09170008888', 'Luisa Andres', '09181119999', 'Balayan, Batangas',
 'Roberto Ramos', 'Uncle', '09225557777', 'San Juan, Batangas', '', '8-C', 'Male', 'miguel.torres@email.com', 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas', '09170008888', 87.9),

-- 6
('Julia', 'Marie', 'Ramos', 'Active', '2010-12-25', 'Grade 9', 'Filipino',
 'Oscar Ramos', '09173334444', 'Carmen Marie', '09184445555', 'Taal, Batangas',
 'Paula Villanueva', 'Aunt', '09331112222', 'Bauan, Batangas', '', '9-B', 'Female', 'julia.ramos@email.com', 'Taal Elementary', 'Grade 8', 'Taal, Batangas', '09173334444', 94.1),

-- 7
('Daniel', 'Santos', 'Villanueva', 'Active', '2009-07-05', 'Grade 10', 'Filipino',
 'Rogelio Villanueva', '09172225555', 'Angela Santos', '09185556666', 'Balayan, Batangas',
 'Fernando Cruz', 'Grandfather', '09556667777', 'Tanauan, Batangas', '', '10-A', 'Male', 'daniel.villanueva@email.com', 'Balayan High', 'Grade 9', 'Balayan, Batangas', '09172225555', 90.0),

-- 8
('Isabella', 'Maria', 'Fernandez', 'Active', '2012-08-22', 'Grade 7', 'Filipino',
 'Vicente Fernandez', '09173337777', 'Patricia Maria', '09189990000', 'Calaca, Batangas',
 'Cecilia Reyes', 'Aunt', '09228889999', 'Balayan, Batangas', '', '7-B', 'Female', 'isabella.fernandez@email.com', 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas', '09173337777', 93.4),

-- 9
('Gabriel', 'Jose', 'Mendoza', 'Active', '2011-04-14', 'Grade 8', 'Filipino',
 'Salvador Mendoza', '09176665555', 'Dolores Jose', '09182228888', 'Balayan, Batangas',
 'Eduardo Ramos', 'Uncle', '09174443333', 'Lemery, Batangas', '', '8-A', 'Male', 'gabriel.mendoza@email.com', 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas', '09176665555', 86.8),

-- 10
('Camille', 'Rose', 'Castillo', 'Active', '2010-10-09', 'Grade 9', 'Filipino',
 'Julio Castillo', '09177774444', 'Marta Rose', '09181112222', 'San Luis, Batangas',
 'Beatriz Lopez', 'Aunt', '09175556666', 'Balayan, Batangas', '', '9-C', 'Female', 'camille.castillo@email.com', 'San Luis Elementary', 'Grade 8', 'San Luis, Batangas', '09177774444', 89.6),

-- 11
('Patrick', 'Reyes', 'Morales', 'Active', '2012-01-25', 'Grade 7', 'Filipino',
 'Hector Morales', '09178883333', 'Veronica Reyes', '09183334444', 'Batangas City',
 'Ricardo Garcia', 'Uncle', '09176662222', 'Lipa, Batangas', '', '7-C', 'Male', 'patrick.morales@email.com', 'Batangas Elementary', 'Grade 7', 'Batangas City', '09178883333', 91.7),

-- 12
('Angela', 'Marie', 'Gutierrez', 'Active', '2009-11-11', 'Grade 10', 'Filipino',
 'Francisco Gutierrez', '09175551111', 'Clarissa Marie', '09187778888', 'Balayan, Batangas',
 'Alfonso Torres', 'Grandfather', '09170009999', 'Tanauan, Batangas', '', '10-B', 'Female', 'angela.gutierrez@email.com', 'Balayan High', 'Grade 9', 'Balayan, Batangas', '09175551111', 95.0),

-- 13
('Christian', 'Paul', 'Santiago', 'Active', '2011-03-19', 'Grade 8', 'Filipino',
 'Pedro Santiago', '09173338888', 'Evelyn Paul', '09189991111', 'Calaca, Batangas',
 'Ramon Lopez', 'Uncle', '09171112222', 'Balayan, Batangas', '', '8-B', 'Male', 'christian.santiago@email.com', 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas', '09173338888', 87.2),

-- 14
('Nicole', 'Grace', 'Navarro', 'Active', '2010-09-03', 'Grade 9', 'Filipino',
 'Benito Navarro', '09174445555', 'Sandra Grace', '09186667777', 'Balayan, Batangas',
 'Teresa Mendoza', 'Aunt', '09179998888', 'San Jose, Batangas', '', '9-A', 'Female', 'nicole.navarro@email.com', 'Balayan Elementary', 'Grade 8', 'Balayan, Batangas', '09174445555', 92.5),

-- 15
('Joseph', 'Luis', 'Domingo', 'Active', '2009-05-21', 'Grade 10', 'Filipino',
 'Dominic Domingo', '09175552222', 'Rosario Luis', '09187776666', 'Balayan, Batangas',
 'Miguel Ramos', 'Grandfather', '09176661111', 'Taal, Batangas', '', '10-C', 'Male', 'joseph.domingo@email.com', 'Balayan High', 'Grade 9', 'Balayan, Batangas', '09175552222', 88.9),

-- 16
('Clarisse', 'Anne', 'Valdez', 'Active', '2011-07-30', 'Grade 8', 'Filipino',
 'Cesar Valdez', '09176663333', 'Helena Anne', '09189992222', 'Lemery, Batangas',
 'Felisa Garcia', 'Aunt', '09172223333', 'Balayan, Batangas', '', '8-C', 'Female', 'clarisse.valdez@email.com', 'Lemery Elementary', 'Grade 7', 'Lemery, Batangas', '09176663333', 90.4),

-- 17
('Andrew', 'James', 'Pascual', 'Active', '2012-02-18', 'Grade 7', 'Filipino',
 'Mario Pascual', '09175559999', 'Jocelyn James', '09183336666', 'Calaca, Batangas',
 'Leonardo Cruz', 'Uncle', '09173331111', 'Balayan, Batangas', '', '7-B', 'Male', 'andrew.pascual@email.com', 'Calaca Elementary', 'Grade 7', 'Calaca, Batangas', '09175559999', 89.1),

-- 18
('Katrina', 'Joy', 'Marquez', 'Active', '2010-12-07', 'Grade 9', 'Filipino',
 'Jorge Marquez', '09179992222', 'Lucia Joy', '09182221111', 'Balayan, Batangas',
 'Carolina Torres', 'Aunt', '09174442222', 'San Juan, Batangas', '', '9-B', 'Female', 'katrina.marquez@email.com', 'Balayan Elementary', 'Grade 8', 'Balayan, Batangas', '09179992222', 91.8),

-- 19
('Nathan', 'Allan', 'Roxas', 'Active', '2009-08-16', 'Grade 10', 'Filipino',
 'Roberto Roxas', '09172224444', 'Miriam Allan', '09185558888', 'Taal, Batangas',
 'Diego Ramos', 'Grandfather', '09179997777', 'Batangas City', '', '10-A', 'Male', 'nathan.roxas@email.com', 'Taal High', 'Grade 9', 'Taal, Batangas', '09172224444', 93.0),

-- 20
('Samantha', 'Mae', 'Aquino', 'Active', '2011-06-29', 'Grade 8', 'Filipino',
 'Vicente Aquino', '09173332222', 'Adela Mae', '09182229999', 'Balayan, Batangas',
 'Josefina Garcia', 'Aunt', '09176664444', 'Calaca, Batangas', '', '8-A', 'Female', 'samantha.aquino@email.com', 'Balayan Elementary', 'Grade 7', 'Balayan, Batangas', '09173332222', 90.6);

 INSERT INTO tblFeeStructure (GradeLevel, TuitionFee)
VALUES 
('Grade 7', 45000.00),
('Grade 8', 47000.00),
('Grade 9', 50000.00),
('Grade 10', 52000.00);

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
