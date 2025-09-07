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
    ('admin',     CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 'Admin'),
    ('registrar', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 'Registrar'),
    ('cashier',   CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2), 'Cashier');
