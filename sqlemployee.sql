create database employee1;
drop database employee1;

create table employeeinformation(Eid int,Ename varchar(200),salary int,Egender varchar);

select * from employeeinformation;

insert into employeeinformation values(101,'vishwam',25000,'m');
insert into employeeinformation values(102,'ankita',26000,'f');
insert into employeeinformation values(103,'kedar',20000,'m');
insert into employeeinformation values(104,'kavita',24000,'f');

delete  from employeeinformation where Eid=104;
update employeeinformation  set Ename='vedant' where Eid=101;

