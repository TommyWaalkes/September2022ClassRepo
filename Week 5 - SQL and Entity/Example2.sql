--select * from Customers 
--where PostalCode='1010' or PostalCode='3012' or PostalCode='12209' or PostalCode='05023';

--select * from Customers 
--where PostalCode in ('1010', '3012', '12209', '05023');

--Select distinct City from Customers 
--where City is not null;

--Select * from orders; 
--SELECT Sum(Freight) 
--from Orders;

--Select * from Employees; 
Select DATEDIFF(year,HireDate, GETDATE())
from Employees;