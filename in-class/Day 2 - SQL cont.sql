USE Northwind
GO

SELECT COUNT(o.OrderId) AS TotalNumOfRows
FROM Orders o

SELECT COUNT(*) AS TotalNumOfRows
FROM Orders o

SELECT COUNT(e.Region), COUNT(*)
FROM Employees e

SELECT c.ContactName, c.City, COUNT(o.OrderID) AS NumOfOrders
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName, c.City, c.Country
ORDER BY NumOfOrders DESC

SELECT c.ContactName, c.City, COUNT(o.OrderID) AS NumOfOrders
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.Country IN ('USA', 'Canada')
GROUP BY c.ContactName, c.City
HAVING COUNT(o.OrderID) >= 10

SELECT COUNT(DISTINCT c.City)
FROM Customers c

SELECT c.CustomerID, c.ContactName, AVG(od.UnitPrice * od.Quantity) AS AvgRevenue
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
	JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID, c.ContactName

SELECT c.CustomerID, c.ContactName, SUM(od.UnitPrice * od.Quantity) AS TotalRevenue
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
	JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID, c.ContactName

SELECT c.CustomerID, c.ContactName, MAX(od.UnitPrice * od.Quantity) AS MaxTransaction
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
	JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID, c.ContactName

SELECT c.CustomerID, c.ContactName, MIN(od.UnitPrice) AS CheapestProduct
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
	JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID, c.ContactName

SELECT TOP 10 PERCENT p.ProductID, p.ProductName
FROM Products p
ORDER BY p.UnitPrice DESC

SELECT TOP 5 c.CustomerID, c.ContactName, SUM(od.UnitPrice * od.Quantity) AS TotalRevenue
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
	JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID, c.ContactName
ORDER BY TotalRevenue DESC

SELECT c.ContactName, City
FROM Customers c
WHERE City IN (
	SELECT City
	From Customers
	WHERE ContactName = 'Alejandra Camino'
	)

SELECT DISTINCT c.CustomerID, c.ContactName, c.City, c.Country
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID

SELECT DISTINCT CustomerID, c.ContactName, c.City, c.Country
FROM Customers c
WHERE CustomerId IN (
	SELECT DISTINCT CustomerID
	FROM Orders)

SELECT o.OrderDate, e.FirstName, e.LastName
FROM Orders o JOIN Employees e ON o.EmployeeID = e.EmployeeID
WHERE e.City = 'London'
ORDER BY o.OrderDate, e.FirstName, e.LastName

SELECT o.OrderDate,
	(SELECT e1.FirstName FROM Employees e1 WHERE e1.EmployeeID = o.EmployeeID) AS FirstName,
	(SELECT e2.LastName FROM Employees e2 WHERE e2.EmployeeID = o.EmployeeID) AS LastName
FROM Orders o
WHERE (
	SELECT e3.City
	FROM Employees e3
	WHERE e3.EmployeeID = o.EmployeeID
) IN ('London')
ORDER BY o.OrderDate, FirstName, LastName

SELECT c.CustomerID, c.ContactName, c.City, c.Country, o.OrderID
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderId IS NULL

SELECT c.CustomerID, c.ContactName, c.City, c.Country
FROM Customers c
WHERE c.CustomerID NOT IN (
	SELECT DISTINCT CustomerID
	FROM Orders
)

SELECT c.ContactName, COUNT(o.OrderId) AS TotalNumOfOrders
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName
ORDER BY TotalNumOfOrders DESC

SELECT c.ContactName,
	(SELECT COUNT(o.OrderId)
	FROM Orders o
	WHERE o.CustomerID = c.CustomerID) AS TotalNumOfOrders
FROM Customers c
ORDER BY TotalNumOfOrders DESC

SELECT dt.CustomerID, dt.ContactName, dt.Address
FROM (SELECT *
	FROM Customers) dt

SELECT c.ContactName, c.City, c.Country, COUNT(o.OrderID) AS TotalNumOfOrders
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName, c.City, c.Country
ORDER BY TotalNumOfOrders DESC

SELECT c.ContactName, c.City, c.Country, dt.TotalNumOfOrders
FROM Customers c LEFT JOIN (
	SELECT CustomerID, COUNT(OrderId) AS TotalNumOfOrders
	FROM Orders o
	GROUP BY CustomerId
) dt ON dt.CustomerID = c.CustomerID
ORDER BY dt.TotalNumOfOrders DESC

SELECT City, Country
FROM Customers
UNION
SELECT City, Country
FROM Employees

SELECT City, Country
FROM Customers
UNION ALL
SELECT City, Country
FROM Employees

SELECT p.ProductId, p.ProductName, p.UnitPrice, RANK() OVER(ORDER BY UnitPrice DESC) RNK
FROM Products p

SELECT dt.ProductId, dt.ProductName, dt.UnitPrice, dt.RNK
FROM (
	SELECT p.ProductId, p.ProductName, p.UnitPrice, RANK() OVER(ORDER BY UnitPrice DESC) RNK
	FROM Products p) dt
WHERE dt.RNK = 2

SELECT p.ProductId, p.ProductName, p.UnitPrice, DENSE_RANK() OVER(ORDER BY UnitPrice DESC) RNK
FROM Products p

SELECT p.ProductId, p.ProductName, p.UnitPrice, 
	RANK() OVER(ORDER BY UnitPrice DESC) RNK,
	DENSE_RANK() OVER(ORDER BY UnitPrice DESC) DENSE_RNK,
	ROW_NUMBER() OVER(ORDER BY UnitPrice DESC) ROW_NUM
FROM Products p

SELECT c.ContactName, 
	c.Country, 
	COUNT(o.OrderID) AS NumOfOrders,
	RANK() OVER(PARTITION BY c.Country ORDER BY COUNT(o.OrderId)) AS RNK
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.ContactName, c.Country

SELECT dt.ContactName, dt.Country, dt.NumOfOrders, dt.RNK
FROM (SELECT c.ContactName, 
		c.Country, 
		COUNT(o.OrderID) AS NumOfOrders,
		ROW_NUMBER() OVER(PARTITION BY c.Country ORDER BY COUNT(o.OrderId)) AS RNK
	FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
	GROUP BY c.ContactName, c.Country) dt
WHERE dt.RNK <= 3

WITH OrderCntCTE
AS (SELECT CustomerID, COUNT(OrderId) AS TotalNumOfOrders
	FROM Orders
	GROUP BY CustomerId
)
SELECT c.ContactName, c.City, cte.TotalNumOfOrders
FROM Customers c LEFT JOIN OrderCntCTE cte ON c.CustomerID = cte.CustomerID
ORDER BY cte.TotalNumOfOrders DESC

SELECT e.EmployeeID, e.FirstName, e.ReportsTo
FROM Employees e

WITH EmHierachyCTE
AS (
	SELECT e.EmployeeID, e.FirstName, e.ReportsTo, 1 lvl
	FROM Employees e
	WHERE ReportsTo IS NULL
	UNION ALL
	SELECT e.EmployeeID, e.FirstName, e.ReportsTo, cte.lvl + 1
	FROM Employees e JOIN EmHierachyCTE cte ON e.ReportsTo = cte.EmployeeID
)
SELECT *
FROM EmHierachyCTE
ORDER BY lvl