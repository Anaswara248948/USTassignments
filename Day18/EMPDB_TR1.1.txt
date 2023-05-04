create trigger empinstr on employee 
after insert 
as 
select 'Row Created';