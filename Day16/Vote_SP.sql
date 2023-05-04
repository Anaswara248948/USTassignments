create or alter procedure Voting(@age int) as
begin
if @age >= 18
	print 'You can Vote';
else
	print 'You can not Vote';
end;

exec Voting 21;