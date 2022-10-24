--create database School;
--create table Students
--(
--	Id int primary key identity(1,1),
--	[Name] nvarchar(18), 
--	GPA float,
--	Major nvarchar(10)
--);

--insert into Students
--Values('Frankie Beverly', 2.9, 'Science'),
--('Jane', 3.5, 'Math'),
--('Casey', 1.1, 'Partying')


--Select * from Students; 

--create table Teachers(
--	id int primary key identity(1,1), 
--	[name] nvarchar(20), 
--	SubjectTaught  nvarchar(15) not null
--);

--insert into Teachers 
--values('Dr FunTime', 'Fun Times'), 
--('Dr Acula', 'Phlebotomy'), 
--('Dr Pepper', 'Soda Science');

--select * from Teachers; 

--You can add restrictions to columns as long as no row violates that restriction 
--alter table Teachers
--alter column rating int not null;
--Update Teachers 
--set rating = 0;
insert into Teachers 
values('Dr Shots', 'Mixology', null);
select * from Teachers;