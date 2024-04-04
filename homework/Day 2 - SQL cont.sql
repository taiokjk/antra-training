USE AdventureWorks2019
GO

-- Q1
SELECT COUNT(*)
FROM Production.Product p
-- 504 products

-- Q2
SELECT COUNT(p.ProductSubcategoryID)
FROM Production.Product p

-- Q3
SELECT ps.ProductSubcategoryID, COUNT(p.ProductID) AS CountedProducts
FROM Production.ProductSubcategory ps
	JOIN Production.Product p on ps.ProductSubcategoryID = p.ProductSubcategoryID
GROUP BY ps.ProductSubcategoryID

-- Q4
SELECT COUNT(*)
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NULL
-- 209 products don't have a subcategory

-- Q5
SELECT pri.ProductID, SUM(pri.Quantity) AS TheSum
FROM Production.ProductInventory pri
GROUP BY pri.ProductID
ORDER BY pri.ProductID

-- Q6
SELECT pri.ProductID, SUM(pri.Quantity) AS TheSum
FROM Production.ProductInventory pri
WHERE pri.LocationID = 40
GROUP BY pri.ProductID
HAVING SUM(pri.Quantity) < 100

-- Q7
SELECT pri.Shelf, pri.ProductID, SUM(pri.Quantity) AS TheSum
FROM Production.ProductInventory pri
WHERE pri.LocationID = 40
GROUP BY pri.Shelf, pri.ProductID
HAVING SUM(pri.Quantity) < 100

-- Q8
SELECT pri.LocationID, AVG(pri.Quantity) AS TheAvg
FROM Production.ProductInventory pri
WHERE pri.LocationID = 10
GROUP BY pri.LocationID

-- Q9
SELECT pri.ProductID, pri.Shelf, AVG(pri.Quantity) AS TheAvg
FROM Production.ProductInventory pri
GROUP BY pri.ProductID, pri.Shelf

-- Q10
SELECT pri.ProductID, pri.Shelf, AVG(pri.Quantity) AS TheAvg
FROM Production.ProductInventory pri
WHERE pri.Shelf != 'N/A'
GROUP BY pri.ProductID, pri.Shelf

-- Q11
SELECT p.Color,
	p.Class,
	COUNT(*) AS TheCount,
	AVG(p.ListPrice) AS AvgPrice
FROM Production.Product p
WHERE p.Color IS NOT NULL AND p.Class IS NOT NULL
GROUP BY p.Color, p.Class

-- Q12
SELECT cr.[Name] AS Country, sp.[Name] AS Province
FROM Person.CountryRegion cr
	JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
ORDER BY cr.[Name]

-- Q13
SELECT cr.[Name] AS Country, sp.[Name] AS Province
FROM Person.CountryRegion cr
	JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.[Name] IN ('Germany', 'Canada')
ORDER BY cr.[Name]


USE Northwind
GO

-- Q14
SELECT p.ProductName
FROM Products p
	JOIN [Order Details] od ON p.ProductID = od.ProductID
		JOIN Orders o ON od.OrderID = o.OrderID
WHERE YEAR(o.OrderDate) > YEAR(GETDATE()) - 25

-- Q15
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS Quantity
FROM Orders o
	JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY o.ShipPostalCode
ORDER BY Quantity DESC

-- Q16
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS Quantity
FROM Orders o
	JOIN [Order Details] od ON o.OrderID = od.OrderID
WHERE YEAR(o.OrderDate) > YEAR(GETDATE()) - 25
GROUP BY o.ShipPostalCode
ORDER BY Quantity DESC

-- Q17
SELECT c.City, COUNT(c.CustomerID) AS CustomerCount
FROM Customers c
GROUP BY c.City

-- Q18
SELECT c.City, COUNT(c.CustomerID) AS CustomerCount
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) > 2

-- Q19
SELECT c.ContactName, o.OrderDate
FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '01/01/1998'

-- Q20
SELECT c.ContactName, o.OrderDate
FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
ORDER BY o.OrderDate DESC

-- Q21
SELECT c.ContactName, SUM(od.Quantity) AS AmountOrder
FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
		JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.ContactName
ORDER BY c.ContactName

-- Q22
SELECT c.ContactName, SUM(od.Quantity) AS AmountOrder
FROM Customers c
	JOIN Orders o ON c.CustomerID = o.CustomerID
		JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.ContactName
HAVING SUM(od.Quantity) > 100
ORDER BY c.ContactName

-- Q23
SELECT sp.CompanyName AS [Supplier Company Name],
	s.CompanyName AS [Shipping Company Name]
FROM Suppliers sp
	JOIN Products p ON sp.SupplierID = p.SupplierID
		JOIN [Order Details] od ON p.ProductID = od.ProductID
			JOIN Orders o ON od.OrderID = o.OrderID
				JOIN Shippers s ON o.ShipVia = s.ShipperID
GROUP BY sp.CompanyName, s.CompanyName
ORDER BY sp.CompanyName

-- Q24
SELECT p.ProductName, o.OrderDate
FROM Products p
	JOIN [Order Details] od ON p.ProductID = od.ProductID
		JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY Convert(char(8), o.OrderDate, 112), p.ProductName, o.OrderDate

-- Q25
SELECT e.FirstName + ' ' + e.LastName AS Employee1,
	f.FirstName + ' ' + f.LastName AS Employee2,
	e.Title
FROM Employees e
	JOIN Employees f ON e.Title = f.Title AND e.EmployeeID != f.EmployeeID

-- Q26
SELECT m.FirstName + ' ' + m.LastName AS Manager, COUNT(e.EmployeeID) AS NumOfEmployees
FROM Employees m
	JOIN Employees e ON m.EmployeeID = e.ReportsTo
WHERE m.Title = 'Sales Manager'
GROUP BY m.FirstName + ' ' + m.LastName

-- Q27
SELECT c.City, c.ContactName, c.CompanyName, 'Customer' [Type]
FROM Customers c
UNION ALL
SELECT s.City, s.ContactName, s.CompanyName, 'Supplier' [Type]
FROM Suppliers s