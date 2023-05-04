--create table employee(eid integer primary key, ename varchar(25), city varchar(25), salary money);
--create table orders(oid integer primary key,eid integer, item varchar(25), 
--	foreign key(eid) references employee(eid));

--drop table employee;

--insert into employee values(101,'John','Kochi',10000);
--insert into employee values(102,'Tom','Trivandrum',5000);
--insert into employee values(103,'Sam','Ernklm',35000);
--insert into employee values(104,'Ram','Kozhikode',20000);

--select * from employee;

--insert into orders values(201,103,'Pen');
--insert into orders values(202,101,'Book');
--insert into orders values(203,102,'Pencil');
--insert into orders values(204,102,'Water Bottle');

--select * from orders;

--drop table orders;

 --select e.ename,o.item from employee e left join orders o on e.eid=o.eid;

  select e.ename,o.item from employee e right join orders o on e.eid=o.eid;

