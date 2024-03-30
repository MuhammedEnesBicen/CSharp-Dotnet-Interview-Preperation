-- QUESTİON ARE TAKEN FROM THE REPO: https://github.com/eirkostop/SQL-Northwind-exercises

select * from Orders
where OrderDate = '1997-05-19' -- Date format is YYYY-MM-DD

-- Exercise SQL Queries for JOINS 
-------------------------------------------------------------------------------
-- 1. Create a report for all the orders of 1996 and their Customers (152 rows)
select * from Orders
left join Customers 
on Orders.CustomerID = Customers.CustomerID
where Year(Orders.OrderDate) = 1996

-- 2. Create a report that shows the number of employees and customers 
-- from each city that has employees in it (5 rows)

select Employees.City, 
	   Count(Employees.City) as CountEmployees, 
	   Count(Customers.City) as CountCustomers
	   
	   from Employees
	   left join Customers on Employees.City = Customers.City
	   group by Employees.City
	   having Count(Employees.City) > 0


-- 3. Create a report that shows the number of employees and customers
-- from each city that has customers in it (69 rows)

select Customers.City, 
Count(Customers.City) as CountCustomers,
Count(Employees.City) as CountEmployees
from Customers 
left join Employees on Customers.City = Employees.City
Group by Customers.City
having Count(Customers.City) > 0


-- 4. Create a report that shows the number of employees
-- and customers from each city ( rows)

-- (I took this solution from chatGPT)
SELECT City, 
       COUNT(DISTINCT EmployeeID) AS NumberOfEmployees, 
       COUNT(DISTINCT CustomerID) AS NumberOfCustomers
FROM (
    SELECT City, EmployeeID, NULL AS CustomerID
    FROM Employees
    UNION ALL
    SELECT City, NULL AS EmployeeID, CustomerID
    FROM Customers
) AS CombinedData
GROUP BY City
ORDER BY City;


-- (Solution 2 for question 4)
-- this soultion is taken from the repo which i took questions from
SELECT
	ISNULL (e.City,	c.City) AS [City],
	COUNT(DISTINCT e.EmployeeID) AS [Number of Employees],
	COUNT(DISTINCT c.CustomerID) AS [Number of Customers]
FROM Employees e FULL JOIN Customers c ON 
	e.City = c.City
GROUP BY e.City, c.City
ORDER BY [City];

-------------------------------------------------------------------------------

