CREATE PROCEDURE [dbo].[spInsertUser]   
 @FirstName VARCHAR(50),  
 @LastName VARCHAR(50),  
 @Email VARCHAR(100),  
 @Password NVARCHAR(MAX),  
 @PhoneNumber VARCHAR(15),  
 @UserAddress VARCHAR(100)    
AS    
BEGIN    
 INSERT INTO FundooApp (FirstName, LastName, Email, Password,PhoneNumber,UserAddress)    
VALUES (@FirstName, @LastName, @Email,@Password,@PhoneNumber,@UserAddress);    
END