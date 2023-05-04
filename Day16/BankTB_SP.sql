create or alter procedure ShowAcno(@accno int)
as
begin
select * from BankTB where ACNO=@accno;
end;

exec ShowAcno 101;