
select * from employee123

Create procedure AddNewEmpDetails
(  
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50)  
)  
as  
begin  
   Insert into Employee123 values(@Name,@City,@Address)  
End 

exec AddNewEmpDetails 'jaya', 'mysore','no.22'
----------------------------------------------------------------------

Create Procedure GetEmployees
as  
begin  
   select * from Employee123  
End 

==========================================================
try it : 
id column make it as auto increment in Employee123 table 

ALTER TABLE Employee123 AUTO_INCREMENT=1   xxxxxxxxxxxxxx

ALTER TABLE Employee123 DROP COLUMN ID ALTER TABLE Employee123 ADD ID INT IDENTITY(1,1)==========================================================================Create procedure UpdateEmpDetails  
(  
   @EmpId int,  @Name varchar (50),  @City varchar (50), @Address varchar (50)  
)  
as  
begin  
   Update Employee123  set Name=@Name, City=@City,   Address=@Address  where Id=@EmpId  
End 
------------------------------------------------------------
Create procedure DeleteEmpById  
(  
   @EmpId int  
)  
as   
begin  
   Delete from Employee123 where Id=@EmpId  
End 
