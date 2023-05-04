--create table BankTB(ACNO integer primary key, AcHolderName varchar(30), Balance float, RefACNO integer);

--insert into BankTB values(101, 'Anu', 45000, 102);
--insert into BankTB values(102, 'Rahul', 10000, 101);

--select * from BankTB;

--drop table BankTB;


--multi word alias name uses []
--SELF JOIN
select a.ACNO as 'ACNO', a.AcHolderName as [Account Holder Name], a.Balance as 'Balance', a.RefACNO as [Ref Acno], 
		r.AcHolderName as [Name of Referer] from BankTB a left join BankTB r on a.RefACNO=r.ACNO;