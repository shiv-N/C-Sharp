Create procedure spUpdateEmployeeById       
  
(        
  
   @Id INT ,      
@FirstName VARCHAR(20),@LastName VARCHAR(20),@Age VARCHAR(3),@Email VARCHAR(25),@EmployeeAddress VARCHAR(100)    
  
)        
  
AS      
  
BEGIN        
  
   Update EmployeeTable       
  
   set FirstName = @FirstName, LastName = @LastName, Age = @Age, Email = @Email,  
   EmployeeAddress=@EmployeeAddress      
  
   where Id=@Id        
  
END