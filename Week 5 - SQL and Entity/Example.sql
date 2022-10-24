--Create database Pets; 

--drop table Pets; 
--Create table Pets(
--	--Generally foreign keys point to primary keys of other tables 
--	--You get the most use out of primary keys, they can used to look up rows 
--	id int primary key not null identity(1,1), 
--	species nvarchar(25)
--);

--insert into Pets 
--values('Cat'), ('Dog'), ('Snake'), ('Spider'); 
--Select * from Pets;

--create table PetOwners(
--	id int primary key not null identity(1,1), 
--	[name] nvarchar(20),
--	--For this column, when I make new petowner rows, I can only put ids for pets from the pets table
--	petId int foreign key references Pets(Id) 
--);

--insert into PetOwners
--values('Jose', 2), ('Phil', 1), ('Sarah', 3), ('June', 1);

--insert into PetOwners 
--values('Jimmy', 10);