--CREATE Database DonutsNDevs; 
--Create Table Donuts(
--	id int primary key identity(1,1), 
--	[name] nvarchar(25), 
--	calories int, 
--	photo nvarchar(250),
--	photo_attribution nvarchar(250)
--); 

--insert into Donuts 
--values('glazed', 260, 'https://grandcircusco.github.io/demo-apis/donuts/images/d1.jpg','https://www.publicdomainpictures.net/en/view-image.php?image=170500&picture=fresh-glazed-doughnut' ),
--('Chocolate Glazed', 340, 'https://grandcircusco.github.io/demo-apis/donuts/images/d2.jpg', 'https://commons.wikimedia.org/wiki/File:Chocolate-glazed_doughnut_(1330895).jpg'),
--('Boston Cream', 300, 'https://grandcircusco.github.io/demo-apis/donuts/images/d3.jpg','https://commons.wikimedia.org/wiki/File:DD-Boston-Cream-Donut.jpg')

--select * from Donuts; 

--create table Devs(
--	id int primary key identity(1,1), 
--	firstName nvarchar(16), 
--	lastName nvarchar(20),
--	innovation nvarchar(60), 
--	[year] int
--);

--insert into Devs
--Values('Blaise', 'Pascal', 'Invented the mechanical Calculator', 1645),
--('Ada', 'Lovelace', 'published the first computer programs', 1843), 
--('Charles', 'Babbage', 'designed first mechanical computer', 1837 );