--1
CREATE TABLE Persons (
	PersonId INT IDENTITY NOT NULL,
	FirstName NVARCHAR(50) CHECK (LEN(FirstName) > 2),
	LastName NVARCHAR(50),
	SSN NVARCHAR(50),
	CONSTRAINT PK_PersonId PRIMARY KEY(PersonId),
	CONSTRAINT UQ_SSN UNIQUE(SSN)
);

CREATE TABLE Accounts (
	AccountId INT IDENTITY NOT NULL,
	PersonId INT,
	Balance INT,
	CONSTRAINT PK_AccountId PRIMARY KEY(AccountId),
	CONSTRAINT FK_PersonId FOREIGN KEY(PersonId)
	REFERENCES Persons(PersonId)
);

INSERT INTO Persons VALUES
('firstname1', 'lastname1', '12345678'),
('firstname2', 'lastname2', '45678'),
('firstname3', 'lastname3', '12348'),
('firstname4', 'lastname4', '1235678'),
('firstname5', 'lastname5', '')

INSERT INTO Accounts VALUES
(1, 1230),
(2, 456),
(3, 789),
(4, 109),
(5, 87654)
GO

USE TelerikAcademy
GO

CREATE PROC dbo.usp_SelectFullNames
AS
	SELECT CONCAT(FirstName, ' ', LastName)
	FROM Persons
GO
---------------------------------------------------------

--2
CREATE PROC dbo.usp_SelectBalanceBiggerThanParameterNames
AS
	DECLARE @MoneyAmount INT
	SET @MoneyAmount = 800
	SELECT Balance
	FROM Accounts
	WHERE Balance > @MoneyAmount


EXEC sp_depends 'usp_SelectBalanceBiggerThanParameterNames'
GO
---------------------------------------------------------

--3
CREATE FUNCTION ufn_CalcSumAfterInterest(@sum MONEY, @interest DECIMAL(10, 8), @numberOfMonths INT)
	RETURNS MONEY
AS
BEGIN
	RETURN @sum - (@sum * @interest * @numberOfMonths)
END
GO

SELECT dbo.ufn_CalcSumAfterInterest(1000, 0.01, 5) as [Money after interest]
---------------------------------------------------------

--4
GO
CREATE PROC dbo.usp_GiveInterestToAccount(@AccountId INT, @interestRate DECIMAL)
AS
    DECLARE @balance money
    SELECT @balance = Balance FROM Accounts WHERE AccountId = @accountId

    DECLARE @newBalance money;
    SELECT @newBalance = dbo.ufn_CalcSumAfterInterest(@balance, @interestRate, 1)

    SELECT p.FirstName, p.LastName, a.Balance, @newBalance AS NewBalance
    FROM Accounts a
    JOIN Persons p
        ON a.PersonId = p.PersonId
    WHERE a.AccountId = @accountId
GO

EXEC  dbo.usp_GiveInterestToAccount 1, 0.1;
---------------------------------------------------------

--5
GO
CREATE PROC usp_WithdrawMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance -= @money
        WHERE AccountId = @accountId
    COMMIT TRAN
GO

CREATE PROC usp_DepositMoney(@accountId int, @money money)
AS
    BEGIN TRAN
        UPDATE Accounts
        SET Balance += @money
        WHERE AccountId = @accountId
    COMMIT TRAN
GO

EXEC usp_WithdrawMoney 1, 1000

EXEC usp_DepositMoney 2, 2000
---------------------------------------------------------

--6
--- TABLE: Logs
CREATE TABLE Logs (
    LogId int IDENTITY PRIMARY KEY,
    AccountId int NOT NULL,
    OldSum money NOT NULL,
    NewSum money NOT NULL,
    CONSTRAINT FK_Logs_Accounts
        FOREIGN KEY (AccountId)
        REFERENCES Accounts(AccountId)
)

--- Creates Trigger
GO
CREATE TRIGGER tr_UpdateAccountBalance ON Accounts FOR UPDATE
AS
    DECLARE @oldSum money;
    SELECT @oldSum = Balance FROM deleted;

    INSERT INTO Logs(AccountId, OldSum, NewSum)
        SELECT AccountId, @oldSum, Balance
        FROM inserted
GO

EXEC usp_WithdrawMoney 1, 1000

EXEC usp_DepositMoney 2, 2000
---------------------------------------------------------

--7
IF NOT EXISTS (
    SELECT value
    FROM sys.configurations
    WHERE name = 'clr enabled' AND value = 1
)
BEGIN
    EXEC sp_configure @configname = clr_enabled, @configvalue = 1
    RECONFIGURE
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'RegExpLike') 
    DROP FUNCTION RegExpLike;
GO 

IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'SqlRegularExpressions') 
    DROP assembly SqlRegularExpressions; 
GO      

IF EXISTS (SELECT * FROM sys.objects WHERE name = 'udf_AllMatchingNames') 
    DROP FUNCTION udf_AllMatchingNames;
GO  

CREATE Assembly SqlRegularExpressions 
   FROM 'C:\C#-course\Databases\SqlRegularExpressions.dll' 
   WITH PERMISSION_SET = SAFE; 
GO 

CREATE FUNCTION RegExpLike(@Text nvarchar(MAX), @Pattern nvarchar(255)) RETURNS BIT
    AS EXTERNAL NAME SqlRegularExpressions.SqlRegularExpressions.[Like]
GO

CREATE FUNCTION udf_AllMatchingNames(@pattern nvarchar(255))
    RETURNS @MatchedNames TABLE ( Name varchar(50) )
AS
BEGIN
    INSERT @MatchedNames
    SELECT * FROM 
        (SELECT e.FirstName FROM Employees e
        UNION
        SELECT e.LastName FROM Employees e
        UNION 
        SELECT t.Name FROM Towns t) as temp(name)
    WHERE 1 = dbo.RegExpLike(LOWER(Name), @pattern)
    RETURN
END
GO

SELECT * FROM udf_AllMatchingNames('^[oistmiahf]+') --- all allowed matches

SELECT * FROM udf_AllMatchingNames('^[oistmiahf]+') WHERE Name = 'Sofia' --- allowed
UNION
SELECT * FROM udf_AllMatchingNames('^[oistmiahf]+') WHERE Name = 'Smith' --- allowed
UNION
SELECT * FROM udf_AllMatchingNames('^[oistmiahf]+') WHERE Name = 'Rob' --- forbidden
UNION
SELECT * FROM udf_AllMatchingNames('^[oistmiahf]+') WHERE Name = 'Guy' --- forbidden
GO

DROP FUNCTION RegExpLike;
DROP assembly SqlRegularExpressions; 
DROP FUNCTION [dbo].[udf_AllMatchingNames];
GO
---------------------------------------------------------

--8
DECLARE empCursor CURSOR READ_ONLY FOR
    SELECT emp1.FirstName, emp1.LastName, t1.Name, emp2.FirstName, emp2.LastName
    FROM Employees emp1
    JOIN Addresses a1
        ON emp1.AddressID = a1.AddressID
    JOIN Towns t1
        ON a1.TownID = t1.TownID,
        Employees emp2
        JOIN Addresses a2
            ON emp2.AddressID = a2.AddressID
        JOIN Towns t2
            ON a2.TownID = t2.TownID
    WHERE t1.TownID = t2.TownID AND emp1.EmployeeID != emp2.EmployeeID
    ORDER BY emp1.FirstName, emp2.FirstName

OPEN empCursor

DECLARE @firstName1 nvarchar(50), 
        @lastName1 nvarchar(50),
        @townName nvarchar(50),
        @firstName2 nvarchar(50),
        @lastName2 nvarchar(50)
FETCH NEXT FROM empCursor INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2

DECLARE @counter int;
SET @counter = 0;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @counter = @counter + 1;

    PRINT @firstName1 + ' ' + @lastName1 + 
          '     ' + @townName + '       ' +
          @firstName2 + ' ' + @lastName2;

    FETCH NEXT FROM empCursor 
    INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2
END

print 'Total records: ' + CAST(@counter AS nvarchar(10));

CLOSE empCursor
DEALLOCATE empCursor
---------------------------------------------------------

--9
IF NOT EXISTS (
    SELECT value
    FROM sys.configurations
    WHERE name = 'clr enabled' AND value = 1
)
BEGIN
    EXEC sp_configure @configname = clr_enabled, @configvalue = 1
    RECONFIGURE
END
GO

-- Remove the aggregate and assembly if they're there
IF (OBJECT_ID('dbo.concat') IS NOT NULL) 
    DROP Aggregate concat; 
GO 

IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'concat_assembly') 
    DROP assembly concat_assembly; 
GO      

CREATE Assembly concat_assembly 
   AUTHORIZATION dbo 
   FROM 'C:\C#-course\Databases\SqlStringConcatenation.dll' 
   WITH PERMISSION_SET = SAFE; 
GO 

CREATE AGGREGATE dbo.concat ( 
    @Value NVARCHAR(MAX),
    @Delimiter NVARCHAR(4000) 
) 
    RETURNS NVARCHAR(MAX) 
    EXTERNAL Name concat_assembly.concat; 
GO 

--- CURSOR
DECLARE empCursor CURSOR READ_ONLY FOR
    SELECT t.Name, dbo.concat(e.FirstName + ' ' + e.LastName, ', ')
    FROM Towns t
    JOIN Addresses a
        ON t.TownID = a.TownID
    JOIN Employees e
        ON a.AddressID = e.AddressID
    GROUP BY t.Name
    ORDER BY t.Name

OPEN empCursor

DECLARE @townName nvarchar(50), 
        @employeesNames nvarchar(max)        
FETCH NEXT FROM empCursor INTO @townName, @employeesNames

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @townName + ' -> ' + @employeesNames;

    FETCH NEXT FROM empCursor 
    INTO @townName, @employeesNames
END

CLOSE empCursor
DEALLOCATE empCursor
GO

DROP Aggregate concat; 
DROP assembly concat_assembly; 
GO
---------------------------------------------------------

--10
IF NOT EXISTS (
    SELECT value
    FROM sys.configurations
    WHERE name = 'clr enabled' AND value = 1
)
BEGIN
    EXEC sp_configure @configname = clr_enabled, @configvalue = 1
    RECONFIGURE
END
GO

-- Remove the aggregate and assembly if they're there
IF (OBJECT_ID('dbo.concat') IS NOT NULL) 
    DROP Aggregate concat; 
GO 

IF EXISTS (SELECT * FROM sys.assemblies WHERE name = 'concat_assembly') 
    DROP assembly concat_assembly; 
GO      

CREATE Assembly concat_assembly 
   AUTHORIZATION dbo 
   FROM 'C:\C#-course\Databases\SqlStringConcatenation.dll' 
   WITH PERMISSION_SET = SAFE; 
GO 

CREATE AGGREGATE dbo.concat ( 
    @Value NVARCHAR(MAX),
    @Delimiter NVARCHAR(4000) 
) 
    RETURNS NVARCHAR(MAX) 
    EXTERNAL Name concat_assembly.concat; 
GO 

SELECT dbo.concat(FirstName + ' ' + LastName, ', ')
FROM Employees
GO

DROP Aggregate concat; 
DROP assembly concat_assembly; 
GO
