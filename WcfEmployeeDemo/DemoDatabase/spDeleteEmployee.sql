CREATE PROCEDURE spDeleteEmployee  
 @Id int  
AS  
BEGIN  
DELETE FROM EmployeeTable WHERE Id=@Id  
END 