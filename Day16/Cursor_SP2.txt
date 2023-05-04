DECLARE @empid int;
--DECLARE @total money;
DECLARE @sal money;
DECLARE @grandsalary money;
set @grandsalary=0;
DECLARE employee_cursor CURSOR
FOR 
SELECT eid FROM employee ORDER BY eid;
OPEN employee_cursor;
FETCH NEXT FROM employee_cursor INTO @empid;

while @@FETCH_STATUS=0
begin
	@grandsalary=@grandsalary+salary;

CLOSE employee_cursor;
DEALLOCATE employee_cursor;