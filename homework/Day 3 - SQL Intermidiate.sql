USE Northwind
GO

-- Q1
SELECT DISTINCT c.City AS City
FROM Customers c
UNION
SELECT DISTINCT e.City AS City
FROM Employees e

-- Q2
-- a
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN (
	SELECT DISTINCT e.City
	FROM Employees e)
-- b
SELECT DISTINCT c.City
FROM Customers c
EXCEPT
SELECT DISTINCT e.City
FROM Employees e


-- Q3
SELECT p.ProductName, SUM(od.Quantity) AS TotalQuantity
FROM Products p
	JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName

-- Q4
SELECT c.City, SUM(od.Quantity) AS TotalQuantity
FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
		JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City

-- Q5
-- I don't know why we need to use Union or Subquery
-- When this query suffices
SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) >= 2
-- a
-- b

-- Q6
SELECT c.City, COUNT(DISTINCT od.ProductID) AS Products
FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
		JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2

-- Q7
SELECT c.ContactName
FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity
GROUP BY c.ContactName

-- Q8
CREATE FUNCTION GetMostOrderedCityByProduct(@id INT)
RETURNS NVARCHAR(15)
AS
BEGIN
	DECLARE @city NVARCHAR(15)
	SELECT TOP 1 @city = c.City
	FROM Products p
		JOIN [Order Details] od ON p.ProductID = od.ProductID
			JOIN Orders o ON od.OrderID = o.OrderID
				JOIN Customers c ON o.CustomerID = c.CustomerID
	WHERE p.ProductID = @id
	GROUP BY c.City
	ORDER BY SUM(od.Quantity) DESC	

	RETURN @city
END

SELECT TOP 5 p.ProductName,
	AVG(od.UnitPrice * (1-od.Discount)) AS AveragePrice,
	dbo.GetMostOrderedCityByProduct(p.ProductID) AS City
FROM Products p
	JOIN [Order Details] od ON p.ProductID = od.ProductID
		JOIN Orders o ON od.OrderID = o.OrderID
			JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY p.ProductName, p.ProductID
ORDER BY SUM(od.Quantity) DESC

-- Q9
-- a
SELECT e.City
FROM Employees e
WHERE e.City NOT IN (
	SELECT c.City
	FROM Customers c)
-- b
SELECT DISTINCT e.City
FROM Employees e
EXCEPT
SELECT DISTINCT c.City
FROM Customers c

-- Q10
SELECT City, OrderRank, QuantityRank
FROM (
	SELECT c.City,
		RANK() OVER (ORDER BY COUNT(o.OrderID) DESC) AS OrderRank,
		RANK() OVER (ORDER BY SUM(od.Quantity) DESC) AS QuantityRank
	FROM Customers c
		JOIN Orders o ON c.CustomerID = o.CustomerID
			JOIN [Order Details] od ON o.OrderID = od.OrderID
	GROUP BY c.City
) ranking
WHERE OrderRank = 1 AND QuantityRank = 1

-- Q11
DELETE T
FROM
(
SELECT *
, DupRank = ROW_NUMBER() OVER (
              PARTITION BY key_value
              ORDER BY (SELECT NULL)
            )
FROM original_table
) AS T
WHERE DupRank > 1 