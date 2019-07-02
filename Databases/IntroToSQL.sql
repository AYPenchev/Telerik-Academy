-- 4
SELECT DepartmentID, Name, ManagerID
FROM Departments;
------------------------------------------

--5
SELECT Name AS DepartmentName
FROM Departments;
------------------------------------------

--6
SELECT Salary
FROM Employees; 
------------------------------------------

--7
SELECT FirstName, MiddleName, LastName
FROM Employees;
------------------------------------------

--8
SELECT FirstName + '.' + LastName + '@telerik.com' AS [Full Email Addresses]
FROM Employees;
------------------------------------------

--9
SELECT DISTINCT Salary
FROM Employees;
------------------------------------------

--10
SELECT *
FROM Employees
WHERE JobTitle = 'Sales Representative';
------------------------------------------

--11
SELECT FirstName, MiddleName, LastName
FROM Employees
WHERE FirstName LIKE 'SA%';
------------------------------------------

--12
SELECT FirstName, MiddleName, LastName
FROM Employees
WHERE LastName LIKE '%ei%';
------------------------------------------

--13
SELECT Salary
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000;
------------------------------------------

--14
SELECT e.FirstName, e.MiddleName, e.LastName
FROM Employees e
WHERE e.Salary = 25000 OR e.Salary = 14000 OR e.Salary = 12500 OR e.Salary = 23600;
------------------------------------------

--15
SELECT FirstName, LastName
FROM Employees
WHERE ManagerID IS NULL;
------------------------------------------

--16
SELECT * 
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC;
------------------------------------------

--17
SELECT TOP 5 FirstName, Salary
FROM Employees
ORDER BY Salary DESC;
------------------------------------------

--18
SELECT *
FROM Employees e
INNER JOIN  Addresses a
ON e.AddressID = a.AddressID;   
------------------------------------------

--19
SELECT *
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID;
------------------------------------------

--20
SELECT e.FirstName AS [Employee name], m.FirstName[Manager name]
FROM Employees e
INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID;
------------------------------------------

--21
SELECT e.FirstName AS [Employee name], m.FirstName[Manager name], a.AddressText
FROM Employees e
INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID
INNER JOIN Addresses a
ON m.AddressID = a.AddressID; 
------------------------------------------

--22
SELECT d.Name
FROM Departments d
UNION
SELECT t.Name
FROM Towns t;
------------------------------------------

--23 Show employee and manager name, but some of the managers don't have employees,
--this mean the are not managers.
SELECT e.FirstName AS [Employee name], m.FirstName AS [Manager name]
FROM Employees e
RIGHT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID;
------------------------------------------

--23.1 There are only 4 employees that don't have manager.
SELECT e.FirstName AS [Employee name], m.FirstName AS [Manager name]
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID;
------------------------------------------

--24
SELECT e.FirstName, e.MiddleName, e.LastName, e.HireDate, d.Name
FROM Employees e
FULL OUTER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name = 'Finance') AND
(CONVERT(VARCHAR(25), e.HireDate, 120) LIKE '200[0-4]%'
OR CONVERT(VARCHAR(25), e.HireDate, 120) LIKE '199[5-9]%');
--This also works:
--e.HireDate between '1995-01-01 00:00:00' AND '2005-01-01 00:00:00';