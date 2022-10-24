--create database School2;

--CREATE TABLE Students(
--Id INT PRIMARY KEY NOT NULL IDENTITY(1,1), 
--fName NVARCHAR(15),
--lName NVARCHAR(20)
--);
--One to one with student
--One to one relationships need to be one sided, a true 1 to 1 creates 
--a lot of difficulty for adding to creating tables
--CREATE TABLE IdCards (
-- Id int PRIMARY KEY NOT NULL IDENTITY(1,1),
-- StudentId int UNIQUE FOREIGN KEY REFERENCES Students(Id) 
-- )

--DROP TABLE IdCards; 
--DROP TABLE Students;
--insert into Students 
--values('Jimmy','Buffet');

--insert into IdCards
--Values(1);
--We need to first add a student 
--so then we can add an Id Card
--INSERT INTO Students 
--VALUES('Kenny', 'Coleslaw'); 
--INSERT INTO IdCards 
--VALUES(1);
--SELECT * FROM IdCards;
--SELECT * from Students;
 --One to Many
 --The foreign in 1 to many, goes on the many side. 
 --CREATE TABLE Teacher(
 --Id int PRIMARY KEY NOT NULL IDENTITY(1,1),
 --lName NVARCHAR(20)
 --)
 
 --INSERT INTO Teacher VALUES('Ms. Crabapple')
 --INSERT INTO Teacher VALUES('Mr. Garrison')
 
 --ALTER TABLE Students 
 --ADD TeacherID int FOREIGN KEY REFERENCES Teacher(Id);  
--INSERT INTO Students 
--VALUES('Kenny', 'Coleslaw',2),
--	  ('Jeni', 'Cabage', 1),
--	  ('Jeffy', 'Baker', 2), 
--	  ('Sarah', 'Sasparilla', 1),
--	  ('Kenny', 'Coleslaw',2);

--If you're working with a big dataset, joins are the most performant 
--way of looking at the overlap on 2 tables
 --SELECT * 
 --FROM Students
 --FULL outer JOIN Teacher ON Teacher.Id = Students.TeacherId; 



 --Many to Many 
 -- Between Students and their grades 
 -- Sort of like Permanently saving a join as a table 
 --Neither of the main tables need to have a foreign key 
 --The Foreign keys should exist in the compound table 
--CREATE TABLE Grades (
--Id INT PRIMARY KEY NOT NULL IDENTITY(1,1), 
--grade nvarchar(1)
--)

--Insert into Grades 
--values('A'), ('B'), ('C'), ('D'), ('F');

--CREATE TABLE StudentGrades( 
--Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
-- StudentId int FOREIGN KEY REFERENCES Students(Id), 
-- GradeId int FOREIGN KEY REFERENCES Grades(Id), 
-- [Subject] nvarchar(15)  
--);
Insert into StudentGrades 
Values(1,1, 'History'), (3, 2, 'Math'), (2, 4, 'Chemistry'), (1,1, 'History' ); 
Select * from StudentGrades; 
--INSERT INTO StudentGrades 
--VALUES(2,1),
--	  (2,1),
--	  (3,2),
--	  (4,4),
--	  (1,1)


--SELECT * FROM StudentGrades

