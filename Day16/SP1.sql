create or ALTER procedure sp_PrintDate as 
begin
SELECT getdate();
end;

exec sp_PrintDate


