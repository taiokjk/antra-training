CREATE TABLE #LocalTemp(
	Num INT
)
DECLARE @Var INT = 1
WHILE (@Var <= 10)
BEGIN
	INSERT INTO #LocalTemp(Num) VALUES(@Var)
	SET @Var = @Var + 1
END
SELECT * FROM #LocalTemp

SELECT * FROM tempdb.sys.tables

CREATE TABLE ##GlobalLocalTemp(
	Num INT
)
DECLARE @Var2 INT = 1
WHILE (@Var2 <= 10)
BEGIN
	INSERT INTO ##GlobalLocalTemp(Num) VALUES(@Var2)
	SET @Var2 = @Var2 + 1
END
SELECT * FROM ##GlobalLocalTemp

DECLARE @today DATETIME
SET @today = GETDATE()
PRINT @today

DECLARE @weekDays TABLE (
	DayNum INT,
	DayAbb VARCHAR(20),
	WeekName VARCHAR(20)
)
INSERT INTO @WeekDays VALUES
(1, 'Mon', 'Monday'),
(2, 'Tue', 'Tuesday'),
(3, 'Wed', 'Wednesday'),
(4, 'Thu', 'Thursday'),
(5, 'Fri', 'Friday'),
(6, 'Sat', 'Saturday'),
(7, 'Sun', 'Sunday')
SELECT * FROM @weekDays

CREATE PROC spHello
AS
BEGIN
	PRINT 'Hello World'
END
EXEC spHello

CREATE PROC spAddNumbers
@a INT,
@b INT
AS
BEGIN
	PRINT @a + @b
END
EXEC spAddNumbers 10, 20

CREATE PROC spGetName
@id INT,
@name VARCHAR(20) OUT
AS
BEGIN
	SELECT @name = [name]
	FROM Employee e
	WHERE e.id = @id
END

BEGIN
	DECLARE @n VARCHAR(20)
	EXEC spGetName 2, @n OUT
END

CREATE PROC spGetAllEmp
AS
BEGIN
	SELECT *
	FROM Employee e
END
EXEC spGetAllEmp

CREATE FUNCTION GetTotalRevenue(@price money, @discount real, @quantity int)
RETURNS money
AS
BEGIN
	DECLARE @revenue money
	SET @revenue = @price + (1-@discount) * @quantity
	RETURN @revenue
END

SELECT od.UnitPrice, od.Quantity, od.Discount, dbo.GetTotalRevenue(od.UnitPrice, od.Discount, od.Quantity) AS Revenue
FROM [Order Details] od

CREATE FUNCTION ExpensiveProduct(@threshold money)
RETURNS TABLE
AS
	RETURN SELECT *
	FROM Products
	WHERE UnitPrice > @threshold

SELECT *
FROM dbo.ExpensiveProduct(100)

SELECT c.CustomerId, c.ContactName, c.City
FROM Customers c
ORDER BY c.CustomerID
OFFSET 10 ROWS
FETCH NEXT 10 ROWS ONLY

DECLARE @PagNum INT
DECLARE @RowsOfPage INT
DECLARE @MaxTablePage FLOAT
SET @PagNum = 1
SET @RowsOfPage = 10
SELECT @MaxTablePage = COUNT(*) FROM Customers
SET @MaxTablePage = CEILING(@MaxTablePage/@RowsOfPage)
WHILE (@PagNum <= @MaxTablePage)
BEGIN
	SELECT c.CustomerId, c.ContactName, c.City
	FROM Customers c
	ORDER BY c.CustomerID
	OFFSET @RowsOfPage*(@PagNum-1) ROWS
	FETCH NEXT @RowsOfPage ROWS ONLY
	SET @PagNum = @PagNum + 1
END


