create procedure sp_GetSalary
@empid int, @sal money output as
begin
select @sal = salary from employee where eid=@empid;
end;