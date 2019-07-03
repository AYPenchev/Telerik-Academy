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
GROUP BY e.DepartmentID
ORDER BY e.DepartmentID;
-----------------------------------------------

--10
SELECT COUNT(e.EmployeeId) AS EmployeeCount, d.Name AS DepartmentName, t.Name AS TownName
FROM Employees e 
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
JOIN Addresses a
    ON e.AddressID = a.AddressID
JOIN Towns t
    ON t.TownID = a.TownID
GROUP BY d.Name, t.Name
ORDER BY d.Name
-----------------------------------------------

--11
SELECT  e.EmployeeID AS ManagerId,
        CONCAT(e.FirstName, ' ', e.LastName) AS ManagerName,
        COUNT(e.EmployeeID) AS EmployeesCount
FROM Employees e 
JOIN Employees m
    ON m.ManagerID = e.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(e.EmployeeID) = 5;
-----------------------------------------------

--12
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS EmployeeName,
	    ISNULL(m.FirstName, '(no manager)') AS ManagerName
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID
-----------------------------------------------

--13
SELECT LastName
FROM Employees 
WHERE LEN(LastName) = 5;
-----------------------------------------------

--14
SELECT CONVERT(VARCHAR(25), GETDATE(), 113);
-----------------------------------------------

--15
CREATE TABLE Users (
    UserId Int IDENTITY NOT NULL,
    Username NVARCHAR(50) NOT NULL CHECK (LEN(Username) > 3),
    Password NVARCHAR(256) NOT NULL CHECK (LEN(Password) > 5),
    FullName NVARCHAR(50) NOT NULL CHECK (LEN(FullName) > 5),
    LastLoginTime DATETIME,
    CONSTRAINT PK_Users PRIMARY KEY(UserId),
    CONSTRAINT UQ_Username UNIQUE(Username),
) 
GO
-----------------------------------------------

--16
GO
CREATE VIEW [Users in system today] AS
SELECT Username FROM Users as u
WHERE DATEDIFF(day, LastLoginTime, GETDATE()) = 0;
-----------------------------------------------

--17
CREATE TABLE Groups (
    GroupId Int IDENTITY NOT NULL,
    Name NVARCHAR(50) NOT NULL
    CONSTRAINT PK_Groups PRIMARY KEY(GroupId),
    CONSTRAINT UQ_Name UNIQUE(Name),
) 
GO
-----------------------------------------------

--18
ALTER TABLE Users ADD GroupId int
GO

ALTER TABLE Users
    ADD CONSTRAINT FK_Users_Groups
    FOREIGN KEY (GroupId)
    REFERENCES Groups(GroupId)
GO
-----------------------------------------------

--19
INSERT INTO Groups VALUES
 ('Instagram'),
 ('Google'),
 ('LinkedIn'),
 ('Gmail'),
 ('Telerik Academy'),
 ('GitHub');

INSERT INTO Users VALUES
 ('UserName1', 'qWeRty1', 'FullName1', '2019-3-06 00:00:00', 1),
 ('UserName2', 'qWeRty2', 'FullName2', '2019-3-07 00:00:00', 2),
 ('UserName3', 'qWeRty3', 'FullName3', '2019-3-08 00:00:00', 3),
 ('UserName4', 'qWeRty4', 'FullName4', '2019-3-09 00:00:00', 4),
 ('UserName5', 'qWeRty5', 'FullName5', '2019-3-10 00:00:00', 5),
 ('UserName6', 'qWeRty6', 'FullName6', '2019-3-11 00:00:00', 6);
 -----------------------------------------------

--20
UPDATE Users
SET Username = REPLACE(Username, 'UserName', 'USERNAME')
WHERE GroupId > 3;
 -----------------------------------------------

--21
DELETE FROM Users
WHERE GroupId IN (2, 3, 4, 5)

DELETE FROM Groups
WHERE GroupId IN (2, 3, 4, 5)
 -----------------------------------------------

--22
-- Sorry for the bad data in the base but table Users have constraints and name and password weren't long enough. 
INSERT INTO Users (Username, FullName, Password)
        (SELECT LOWER(CONCAT(LEFT(e.FirstName, 1), e.Salary, e.MiddleName, e.LastName)),
                CONCAT(e.FirstName, ' ', e.LastName),
                LOWER(CONCAT(LEFT(e.FirstName, 1), e.LastName, e.Salary))
        FROM Employees e)
GO
 -----------------------------------------------

--23
INSERT INTO Users (Username, Password, FullName, LastLoginTime)
 VALUES
 ('NICKname1', 'password1', 'Names1', '2010-3-06 00:00:00'),
 ('NICKname2', 'password2', 'Names2', '2010-3-07 00:00:00'),
 ('NICKname3', 'password3', 'Names3', '2010-3-08 00:00:00'),
 ('NICKname4', 'password4', 'Names4', '2010-3-09 00:00:00'),
 ('NICKname5', 'password5', 'Names5', '2010-3-10 00:00:00'),
 ('NICKname6', 'password6', 'Names6', '2010-3-11 00:00:00'),
 ('NICKname7', 'password7', 'Names7', '2010-3-12 00:00:00'),
 ('NICKname8', 'password8', 'Names8', '2010-3-13 00:00:00'),
 ('NICKname9', 'password9', 'Names9', '2010-3-14 00:00:00')
 GO

 UPDATE Users
 SET Password = 'NULL VALUE'
 WHERE DATEDIFF(day, LastLoginTime, '2010-3-10') > 0;
-----------------------------------------------

--24
DELETE FROM Users
WHERE Password = 'NULL VALUE';
-----------------------------------------------

--25
SELECT AVG(e.Salary) AS [Average Employee Salary], d.Name, e.JobTitle
FROM Employees e 
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name
-----------------------------------------------

--26
SELECT MIN(e.Salary) AS [Minimal Employee Salary], d.Name, e.JobTitle, MIN(e.FirstName) AS [First Name]
FROM Employees e 
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name;
-----------------------------------------------

--27
SELECT TOP 1 t.Name, COUNT(e.EmployeeID) AS [Employee Count]
FROM Employees e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY [Employee Count] DESC
-----------------------------------------------

--28
SELECT COUNT(m.EmployeeID) AS [Managers Count], t.Name AS [Town Name]
FROM Employees e
JOIN Employees m
  ON e.ManagerID = m.EmployeeID
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns t
ON t.TownID = a.TownID
GROUP BY t.Name
-----------------------------------------------

--29
CREATE TABLE WorkHours (
    WorkReportId int IDENTITY,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    CONSTRAINT PK_Id PRIMARY KEY(WorkReportId),
    CONSTRAINT FK_Employees_WorkHours 
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId)
) 
GO

--- INSERT
DECLARE @counter int;
SET @counter = 20;
WHILE @counter > 0
BEGIN
    INSERT INTO WorkHours(EmployeeId, OnDate, Task, [Hours])
    VALUES (@counter, GETDATE(), 'TASK: ' + CONVERT(varchar(10), @counter), @counter)
    SET @counter = @counter - 1
END

--- UPDATE
UPDATE WorkHours
SET Comments = 'This update is working!'
WHERE [Hours] > 6

--- DELETE
DELETE FROM WorkHours
WHERE EmployeeId IN (2, 4, 6, 8, 10, 12, 14, 16, 18, 20)

--- TABLE: WorkHoursLogs
CREATE TABLE WorkHoursLogs (
    WorkLogId INT,
    EmployeeId INT NOT NULL,
    OnDate DATETIME NOT NULL,
    Task NVARCHAR(256) NOT NULL,
    Hours INT NOT NULL,
    Comments NVARCHAR(256),
    [Action] NVARCHAR(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 
GO

--- TRIGGER FOR INSERT
CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Insert'
    FROM inserted
GO

--- TRIGGER FOR DELETE
CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Delete'
    FROM deleted
GO

--- TRIGGER FOR UPDATE
CREATE TRIGGER tr_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'InsertUpdate'
    FROM inserted

INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'DeleteUpdate'
    FROM deleted
GO

--- TEST TRIGGERS
DELETE FROM WorkHoursLogs

INSERT INTO WorkHours(EmployeeId, OnDate, Task, [Hours])
VALUES (25, GETDATE(), 'TASK: 25', 25)

DELETE FROM WorkHours
WHERE EmployeeId = 25

UPDATE WorkHours
SET Comments = 'Updated'
WHERE EmployeeId = 3
-----------------------------------------------

--30
BEGIN TRAN

ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees
GO

DELETE e FROM Employees e
JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- ROLLBACK TRAN
-- COMMIT TRAN
-----------------------------------------------

--31
BEGIN TRANSACTION

DROP TABLE EmployeesProjects

-- ROLLBACK TRANSACTION
-- COMMIT TRANSACTION
-----------------------------------------------

--32
BEGIN TRANSACTION

SELECT * 
INTO #TemporaryTableEmployeesProjects  --- Create new table
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT * 
INTO EmployeesProjects --- Create new table
FROM #TemporaryTableEmployeesProjects;

DROP TABLE #TempEmployeesProjects

-- ROLLBACK TRANSACTION
-- COMMIT TRANSACTION
