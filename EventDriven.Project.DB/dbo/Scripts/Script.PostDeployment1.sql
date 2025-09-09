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
<<<<<<< HEAD
    ('admin',    HASHBYTES('SHA2_256', 'admin123'), 'Admin'),
    ('registrar', HASHBYTES('SHA2_256', 'admin123'), 'Registrar'),
    ('cashier',  HASHBYTES('SHA2_256', 'admin123'), 'Cashier');
=======
    ('admin',     CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 'Admin'),
    ('registrar', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 'Registrar'),
    ('cashier',   CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 'Cashier');
>>>>>>> 035a4109b1ef3e58695267d3ca8fff5cead191ba
