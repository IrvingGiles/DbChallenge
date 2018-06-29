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

IF '$(LoadTestData)' = 'true' 

BEGIN
DELETE FROM [dbo].[Treatment];
DELETE FROM [dbo].[Pet];
DELETE FROM [dbo].[Procedure];
DELETE FROM [dbo].[Owner];


INSERT INTO [Owner] (OwnerId, Surname, FirstName, PHONE) VALUES
(1, 'Sinatra', 'Frank', 400111222),
(2, 'Ellington', 'Duke', 4000222333),
(3, 'Fitzgerald', 'Ella', 4000333444);

INSERT INTO [Procedure] (ProcedureId, Description, Price) VALUES
(01, 'Rabies Vaccination', $24.00),
(10, 'Examine and treat', $30.00),
(05, 'Heart Worm Test', $25.00),
(08, 'Tetnus Vaccination', $17.00);



INSERT INTO Pet (PetId, Name, Type, OwnerId) VALUES
(001, 'Buster', 'Dog', 1),
(002, 'Fluffy', 'Cat', 1),
(003, 'Stew', 'Rabbit', 2),
(004, 'Buster', 'Dog', 3),
(005, 'Pooper', 'Dog', 3);


INSERT INTO Treatment (TreatmentId, ProcedureId, PetId, ownerId, PetName, Dates, Notes, Price) VALUES
(111, 01, 001, 1, 'Buster','20/Jun/17', 'Routine Vaccination', $22.00),
(222, 01, 001, 1, 'Buster', '15/May/18', 'Booster Shot', $24.00),
(333, 10, 002, 1, 'Fluffy','10/May/18', 'Cat Fight Wounds', $30.00),
(444, 05, 003, 2, 'Stew', '10/May/18', 'Cooking Injuries', $30.00),
(555, 10, 005, 3, 'Pooper','10/May/18', 'Routine Test', $25.00);


END