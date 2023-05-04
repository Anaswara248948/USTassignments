create or alter procedure EvenOdd(@num int) as
begin
if @num%2 = 0
	print 'Even Number';
else
	print 'Odd Number';
end;

exec EvenOdd 8;