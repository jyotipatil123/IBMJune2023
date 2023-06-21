create database ibmjune2023

use ibmjune2023

create table mytable(id int, name varchar(20))

--data types : 
--   varchar, int, decimal, number , nvarchar, money, geography, xml...
   
--DML: data manipulation language 
--    insert, delete, modify/update

insert into mytable(id, name) values(10,'anita')
insert into mytable(id, name) values(11,'sunita')
insert into mytable(id, name) values(12,'sourabh')   
   
 select * from mytable

 insert into mytable(id, name) values(13,'puneet'),(14,'lalita'),(15,'akshata')
   
 --delete a record : 
 delete from mytable where id=15

 -- update a record 
 update mytable set name='areez' where id=13
   
select * from customer
delete from customer where custid is null 

select * from employee

alter table : 
-------------

alter table employee add empcity varchar(50)

alter table employee alter column empname varchar(100)

drop : 
-------
   drop database ibmjune2023

   drop table employee

select * from employee where empcity='bangalore'

select * from employee where empcity='BANGALORE'

 --------------------------------------------------
 OPERATORS : 
 1. arithemtic operators  +  -  * / mod
 2. logical opeators  and , or 
 3. assignment operators =
 4. realtional operators <  <=  > >=


 select custid+salary 'custid+custsalary' from customer 

 alias : alternate name /heading
 as  or without as 

 select 10+3 'addition result', 10-3 as 'subtraction result',
        10*3 'multiplication result' , 10/3 as 'division result'

 select  10 % 3 'modulus result'

 Operators : 

 1. null
   select * from customer where custid is null
   select * from customer where custid is not null

2.  between : 
   select * from customer where custid between 10 and 15
    select * from customer where custid not between 10 and 15

3.  order by : 
    select * from customer order by custname asc
    select * from customer order by custname 

	select * from customer order by custname desc

	Can we sort more than 1 column ?  Question 

4.  Like :  _  1 character  % group of chars
   select * from customer where custname like 'van_____'

   select * from customer where custname not like 'a%'

   select * from customer where custname like 'van%'

   select * from customer where salary like '2*'  xxxxxxxxxxxxxxxxxx wrong

5.  in : 
   select * from customer where custid in ( 12,15,16)

   select * from customer where custid not in ( 12,15,16)

6.  all : 
   select * from customer where custid <= all(select empid from employee where empid >13)
   select custname from customer where custid <= all(select empid from employee where empid >13) 

7.  any : 

select * from customer where custid <= any(select empid from employee where empid >13)

Sub query : 
   outer query( inner query) query within a query 
===================================================

Joins : 

select * from customer

select * from order1

1. inner join 
select * from customer c inner join order1 o on c.custid=o.custid

2.  left outer join  / left join
select * from customer c left outer join  order1 o on c.custid=o.custid

without null values : 
select * from customer c left outer join  order1 o on c.custid=o.custid
where orderid is not null

3.  right outer join / right join

select * from customer as c right outer join  order1 as o on c.custid=o.custid

without null values : 
select * from customer c right outer join  order1 o on c.custid=o.custid
where orderid is not null

4.  full outer join / full join 
select * from customer as c full outer join  order1 as o on c.custid=o.custid

without null values : 
select * from customer c full outer join  order1 o on c.custid=o.custid
where orderid is not null

5. cross join / cartesian product 

select * from customer cross join order1 
11   

select * from order1
4
11 x 4 == 44 rows 
equi join, non equi join, self join 
=============================================================

set theory
union union all intersect ......

select * from employee
union
select * from teacher

select empid,empname from employee
intersect
select teacherid,teachername from teacher

select empid,empname from employee
except
select teacherid,teachername from teacher

Except , union all ?????  try it 

================================================================

keys : 
   unique key  -PK
   alternate key
   primary key 1 column or more than 1 column 
   foreign key
   candidate key 

   select * from customer

   select * from order1

   custid+custname     custid+city     custid+salary
================================================================
constraints 
unique
foreign key  FK
primary key  PK
not null
check 
default