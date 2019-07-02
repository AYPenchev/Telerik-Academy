--1
SELECT FirstName, MiddleName, LastName, Salary
FROM Employees
WHERE Salary = (SELECT MIN(Salary)
				FROM Employees);
-----------------------------------------------

--2
SELECT FirstName, MiddleName, LastName, Salary
FROM Employees
WHERE Salary < (SELECT MIN(Salary) * 1.1
				FROM Employees);
-----------------------------------------------

--3
SELECT FirstName, MiddleName, LastName, Salary, e.DepartmentID
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE Salary = (SELECT MIN(Salary)
				FROM Employees
				WHERE DepartmentID = e.DepartmentID)
ORDER BY e.DepartmentID;
-----------------------------------------------

--4
SELECT AVG(Salary)
FROM Employees
WHERE DepartmentID = 1;
-----------------------------------------------

--5
SELECT AVG(e.Salary)
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales';
-----------------------------------------------

--6
SELECT COUNT(*)
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales';
-----------------------------------------------

--7
SELECT COUNT(*)
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID; 
-----------------------------------------------

--8
SELECT COUNT(*)
FROM Employees e
WHERE e.ManagerID IS NULL; 
-----------------------------------------------

--9
SELECT AVG(Salary), e.DepartmentID
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
--WHERE Salary = (SELECT AVG(Salary)
--				FROM Employees)
ORDER BY e.DepartmentID;