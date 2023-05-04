DECLARE @empid int;
DECLARE employee_cursor CURSOR
FOR 
SELECT eid FROM employee ORDER BY eid;
OPEN employee_cursor;
FETCH NEXT FROM employee_cursor INTO @empid;
CLOSE employee_cursor;
DEALLOCATE employee_cursor;