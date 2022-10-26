--create database CompanyDb;
--create table Department(
--	id int primary key identity(1,1), 
--	[Name] nvarchar(25) not null,
--	Hiring bit,
--	[Location] nvarchar(50)
--);

--insert into Department 
--values('Technology', 1, '1570 Woodward Ave'),
--('Shipping and Recieving', 0, 'Southfield');

--select * from Department;

--create table Employee 
--(
--	SSN nchar(9) primary key, 
--	DOB Date,
--	Phone nchar(10),
--	FirstName nvarchar(30) not null, 
--	LastName nvarchar(30) not null,
--	DepartmentId int foreign key references Department(id)
--);



--insert into Employee 
--values('123456789', '1/5/1975', '3135555505', 'Charles', 'Charleston', 2), 
--('987654321', '5/2/1990', '2489995555', 'Jimmy', 'Scrambles', 1 ),
--('456789123','8/6/2001', '7895555525', 'Vince', 'Jabowski', 1 ),
--('654854632', '4/6/1988', '3139721400', 'John', 'Johnston', 2)

--Update Employee 
--set LastName = 'Spiderman'
--Where DOB = (select max(DOB) from Employee);

--Select * from Employee 
--where LastName like 'J%';
--delete from Employee
--where DOB = (Select min(DOB) from Employee);

--Select * from Employee 
--where Phone like '313%';

--Select * from Employee 
--where DOB < '9/9/1999';
--Update Employee 
--Set Phone = null
--Where DOB > '1/1/2000';
--select * from Employee where Phone is null;

--select * from Employee 
--full outer join Department on Department.id = Employee.DepartmentId;

--select * from Employee;
--drop table Employee;
--drop table Department;
drop database CompanyDb;