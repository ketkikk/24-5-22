create database Employeecpg1;

create table Employeeinformation1(Eid int,Ename varchar(200),salary int,Egender varchar(50),department varchar(300));

insert into Employeeinformation1 values(101,'vishwam',25000,'m','ele');
insert into Employeeinformation1 values(102,'ankita',26000,'f','cs');
insert into Employeeinformation1 values(103,'kedar',20000,'m','it');
insert into Employeeinformation1 values(104,'kavita',24000,'f','mech');
insert into Employeeinformation1 values(101,'ketki',26000,'f','ele');

select max(salary) from  Employeeinformation1;

select * from Employeeinformation1 where department='ele';

select count(*) from Employeeinformation1;

select AVG(salary) from Employeeinformation1;

select * from Employeeinformation1 where Eid in (104,103,102);