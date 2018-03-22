use empdb;
select * from employee;

drop table employee;

CREATE TABLE employee(
empid int PRIMARY KEY NOT NULL,
empName varchar(50),
empDate date);

insert into employee values(23,'Dhruvin','17/11/1993');
--insert into employee values(24,'Dhruvin','1993-17-11');
--insert into employee values(25,'Dhruvin','1993/17/11');
insert into employee values(26,'Dhruvin','17-11-1993');
--insert into employee values(27,'Dhruvin','1993-17-11 00:00:00');

