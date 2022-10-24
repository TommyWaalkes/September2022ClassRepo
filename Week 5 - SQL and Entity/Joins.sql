
--Outer Join shows where both table intersect as well as any row 
--that doesn't have an id for the second table
--select fName, Teacher.lName from Students
--full outer join Teacher on Students.TeacherID = Teacher.Id; 

--inner join show only the mappings between tables and excludes anyone that's unpaired
--select fName, Teacher.lName from Students
--inner join Teacher on Students.TeacherID = Teacher.Id;
--select * from Teacher; 
--This shows me the unlinked person in my students table, but not the teacher table
--select fName, Teacher.lName from Students
--left join Teacher on Students.TeacherID = Teacher.Id;

--select fName, Teacher.lName from Students
--right join Teacher on Students.TeacherID = Teacher.Id;
