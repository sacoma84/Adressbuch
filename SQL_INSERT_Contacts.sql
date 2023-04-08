
USE [C:\USERS\HP\ONEDRIVE\DOKUMENTE\DB_ADDRESSBOOK.MDF]
GO

INSERT INTO [dbo].[contact]
           (
           [firstName]
           ,[lastName]
           
           ,[street]
           ,[postalCode]
           ,[city]
           ,[country]
           ,[email]
           ,[phone]
           ,[birthday])
     VALUES
     
('Max', ' Mustermann', 'Musterstraße 1', '12345', 'Muster-Stadt', 'Deutschalnd', 'max@mustermann.de', '49731123456', DATEFROMPARTS(2000,2,1)),
('Erica', 'Musterfrau', 'Mustergasse 7', '54321', 'Muster-Dorf', 'Deutschalnd', 'erica@musterfrau.de', '49731654321', DATEFROMPARTS(2000,3,1)),
('Tina', 'Test', 'Test-Straße 123', '12312', 'Test-Stradt', 'Deutschalnd', 'Tina@Test.de', '49785212365', DATEFROMPARTS(2002,2,2)),
('Tim', 'Tester', 'Tester-Straße 456', '45645', 'Tester-Dorf', 'Deutschalnd', 'Tim@Tester.de', '498521367', DATEFROMPARTS(2003,3,3)),
('Irene', 'Irgendwer', 'Irgendeine Straße 5', '75395', 'Irgendwo-Stadt', 'Deutschalnd', 'Irene@Irgendwer.de', '49785612378', DATEFROMPARTS(2004,4,4));


GO