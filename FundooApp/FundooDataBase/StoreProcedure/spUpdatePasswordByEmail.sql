CREATE procedure [dbo].[spUpdatePasswordByEmail]     

(      

 @Email VARCHAR(100),
 @Password NVARCHAR(MAX)
)      

AS    

BEGIN      

   Update FundooApp     

   set Password = @Password    

   where Email = @Email;    

END