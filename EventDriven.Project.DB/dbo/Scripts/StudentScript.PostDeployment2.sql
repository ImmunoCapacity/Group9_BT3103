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
INSERT INTO dbo.Students
(FirstName, MiddleName, LastName, Status, BirthDate, GradeLevel, Nationality,
 FatherName, FatherContact, MotherName, MotherContact, ParentAddress,
 GuardianName, GuardianRelationship, GuardianContact, GuardianAddress)
VALUES
-- 1
('Juan', 'Santos', 'Dela Cruz', 'Active', '2010-05-15', 'Grade 9', 'Filipino',
 'Jose Dela Cruz', '09171234567', 'Maria Santos', '09187654321', 'Balayan, Batangas',
 'Pedro Lopez', 'Uncle', '09981231234', 'Caloocan, Balayan'),

-- 2
('Ana', 'Lopez', 'Reyes', 'Active', '2011-02-20', 'Grade 8', 'Filipino',
 'Carlos Reyes', '09170001111', 'Elena Lopez', '09180002222', 'Lemery, Batangas',
 'Rosa Garcia', 'Aunt', '09993334444', 'Lipa, Batangas'),

-- 3
('Mark', 'David', 'Flores', 'Active', '2009-09-12', 'Grade 10', 'Filipino',
 'Ramon Flores', '09221231234', 'Cristina David', '09334445555', 'Nasugbu, Batangas',
 'Luis Cruz', 'Brother', '09176667777', 'Batangas City'),

-- 4
('Sophia', 'Cruz', 'Garcia', 'Active', '2012-03-30', 'Grade 7', 'Filipino',
 'Mario Garcia', '09175559999', 'Teresa Cruz', '09182223333', 'Balayan, Batangas',
 'Isabel Torres', 'Cousin', '09445556666', 'Calaca, Batangas'),

-- 5
('Miguel', 'Andres', 'Torres', 'Active', '2011-06-18', 'Grade 8', 'Filipino',
 'Antonio Torres', '09170008888', 'Luisa Andres', '09181119999', 'Balayan, Batangas',
 'Roberto Ramos', 'Uncle', '09225557777', 'San Juan, Batangas'),

-- 6
('Julia', 'Marie', 'Ramos', 'Active', '2010-12-25', 'Grade 9', 'Filipino',
 'Oscar Ramos', '09173334444', 'Carmen Marie', '09184445555', 'Taal, Batangas',
 'Paula Villanueva', 'Aunt', '09331112222', 'Bauan, Batangas'),

-- 7
('Daniel', 'Santos', 'Villanueva', 'Active', '2009-07-05', 'Grade 10', 'Filipino',
 'Rogelio Villanueva', '09172225555', 'Angela Santos', '09185556666', 'Balayan, Batangas',
 'Fernando Cruz', 'Grandfather', '09556667777', 'Tanauan, Batangas'),

-- 8
('Isabella', 'Maria', 'Fernandez', 'Active', '2012-08-22', 'Grade 7', 'Filipino',
 'Vicente Fernandez', '09173337777', 'Patricia Maria', '09189990000', 'Calaca, Batangas',
 'Cecilia Reyes', 'Aunt', '09228889999', 'Balayan, Batangas'),

-- 9
('Gabriel', 'Jose', 'Mendoza', 'Active', '2011-04-14', 'Grade 8', 'Filipino',
 'Salvador Mendoza', '09176665555', 'Dolores Jose', '09182228888', 'Balayan, Batangas',
 'Eduardo Ramos', 'Uncle', '09174443333', 'Lemery, Batangas'),

-- 10
('Camille', 'Rose', 'Castillo', 'Active', '2010-10-09', 'Grade 9', 'Filipino',
 'Julio Castillo', '09177774444', 'Marta Rose', '09181112222', 'San Luis, Batangas',
 'Beatriz Lopez', 'Aunt', '09175556666', 'Balayan, Batangas'),

-- 11
('Patrick', 'Reyes', 'Morales', 'Active', '2012-01-25', 'Grade 7', 'Filipino',
 'Hector Morales', '09178883333', 'Veronica Reyes', '09183334444', 'Batangas City',
 'Ricardo Garcia', 'Uncle', '09176662222', 'Lipa, Batangas'),

-- 12
('Angela', 'Marie', 'Gutierrez', 'Active', '2009-11-11', 'Grade 10', 'Filipino',
 'Francisco Gutierrez', '09175551111', 'Clarissa Marie', '09187778888', 'Balayan, Batangas',
 'Alfonso Torres', 'Grandfather', '09170009999', 'Tanauan, Batangas'),

-- 13
('Christian', 'Paul', 'Santiago', 'Active', '2011-03-19', 'Grade 8', 'Filipino',
 'Pedro Santiago', '09173338888', 'Evelyn Paul', '09189991111', 'Calaca, Batangas',
 'Ramon Lopez', 'Uncle', '09171112222', 'Balayan, Batangas'),

-- 14
('Nicole', 'Grace', 'Navarro', 'Active', '2010-09-03', 'Grade 9', 'Filipino',
 'Benito Navarro', '09174445555', 'Sandra Grace', '09186667777', 'Balayan, Batangas',
 'Teresa Mendoza', 'Aunt', '09179998888', 'San Jose, Batangas'),

-- 15
('Joseph', 'Luis', 'Domingo', 'Active', '2009-05-21', 'Grade 10', 'Filipino',
 'Dominic Domingo', '09175552222', 'Rosario Luis', '09187776666', 'Balayan, Batangas',
 'Miguel Ramos', 'Grandfather', '09176661111', 'Taal, Batangas'),

-- 16
('Clarisse', 'Anne', 'Valdez', 'Active', '2011-07-30', 'Grade 8', 'Filipino',
 'Cesar Valdez', '09176663333', 'Helena Anne', '09189992222', 'Lemery, Batangas',
 'Felisa Garcia', 'Aunt', '09172223333', 'Balayan, Batangas'),

-- 17
('Andrew', 'James', 'Pascual', 'Active', '2012-02-18', 'Grade 7', 'Filipino',
 'Mario Pascual', '09175559999', 'Jocelyn James', '09183336666', 'Calaca, Batangas',
 'Leonardo Cruz', 'Uncle', '09173331111', 'Balayan, Batangas'),

-- 18
('Katrina', 'Joy', 'Marquez', 'Active', '2010-12-07', 'Grade 9', 'Filipino',
 'Jorge Marquez', '09179992222', 'Lucia Joy', '09182221111', 'Balayan, Batangas',
 'Carolina Torres', 'Aunt', '09174442222', 'San Juan, Batangas'),

-- 19
('Nathan', 'Allan', 'Roxas', 'Active', '2009-08-16', 'Grade 10', 'Filipino',
 'Roberto Roxas', '09172224444', 'Miriam Allan', '09185558888', 'Taal, Batangas',
 'Diego Ramos', 'Grandfather', '09179997777', 'Batangas City'),

-- 20
('Samantha', 'Mae', 'Aquino', 'Active', '2011-06-29', 'Grade 8', 'Filipino',
 'Vicente Aquino', '09173332222', 'Adela Mae', '09182229999', 'Balayan, Batangas',
 'Josefina Garcia', 'Aunt', '09176664444', 'Calaca, Batangas');