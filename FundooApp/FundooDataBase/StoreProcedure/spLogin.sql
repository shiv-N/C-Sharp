CREATE PROCEDURE [dbo].[spLogin]     
 @Email VARCHAR(100),    
 @Password NVARCHAR(MAX)     
AS      
BEGIN      
 SELECT Id,FirstName,LastName,Email,PhoneNumber,UserAddress FROM FundooApp    
 WHERE Email=@Email AND Password = @Password;     
END