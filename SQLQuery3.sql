create function GetFullName(@ID int)
returns varchar(200)  AS 
Begin
return (select CONCAT(firstname,' ',lastname) as FullName from students where id=@ID);
End