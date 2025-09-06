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
INSERT INTO [dbo].[Users] ([Username], [PasswordHash], [Role])
VALUES
    ('admin', HASHBYTES('SHA2_256', 'admin'), 'admin'),
    ('Hanz', HASHBYTES('SHA2_256', 'Hanz'), 'Cashier');



