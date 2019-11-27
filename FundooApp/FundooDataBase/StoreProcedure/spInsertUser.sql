CREATE PROCEDURE spInsertUser   
 @FirstName VARCHAR(50),@LastName VARCHAR(50),@Email VARCHAR(100),@PhoneNumber nchar(15),@UserAddress VARCHAR(100)    
AS    
BEGIN    
 INSERT INTO FundooApp (FirstName, LastName, Email, PhoneNumber,UserAddress)    
VALUES (@FirstName, @LastName, @Email, @PhoneNumber,@UserAddress);    
END