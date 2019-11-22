CREATE PROCEDURE spInsertEmployee  
 @FirstName VARCHAR(20),@LastName VARCHAR(20),@Age VARCHAR(3),@Email VARCHAR(25),@EmployeeAddress VARCHAR(100)  
AS  
BEGIN  
 INSERT INTO EmployeeTable(FirstName, LastName, Age, Email,EmployeeAddress)  
VALUES (@FirstName, @LastName, @Age, @Email,@EmployeeAddress);  
END