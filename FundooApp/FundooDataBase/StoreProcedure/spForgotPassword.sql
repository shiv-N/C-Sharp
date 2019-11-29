CREATE PROCEDURE [dbo].[spForgotPassword]     
 @Email VARCHAR(100)     
AS      
BEGIN      
 SELECT Id,FirstName,LastName,Email,PhoneNumber,UserAddress FROM FundooApp    
 WHERE Email=@Email;     
END