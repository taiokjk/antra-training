USE Northwind

SELECT c.[Description] as [Description], c.CategoryName as [Name]
FROM Categories c

SELECT *
FROM Employees e 
	JOIN Orders o ON e.EmployeeID = o.EmployeeID
	JOIN Customers c ON c.CustomerID = o.CustomerID

SELECT DISTINCT e.City FROM Employees e

SELECT e.FirstName + ' ' + e.LastName AS [Full Name] FROM Employees e

DECLARE @var VARCHAR(255)
SELECT @var = 'Hello World'
PRINT @var

SELECT c.ContactName FROM Customers c WHERE c.Country = 'Germany'

SELECT p.ProductID, p.ProductName, p.UnitPrice 
FROM Products p
WHERE p.UnitPrice = 18

SELECT c.ContactName FROM Customers c WHERE c.Country != 'Germany'

SELECT o.OrderID, o.CustomerID, o.ShipCountry FROM Orders o
WHERE o.ShipCountry IN ('USA', 'Canada')

SELECT p.ProductName, p.UnitPrice FROM Products p
WHERE p.UnitPrice BETWEEN 20 AND 30

SELECT e.EmployeeID, e.FirstName, e.LastName
FROM Employees e
WHERE Region IS NULL

SELECT e.FirstName, e.LastName
FROM Employees e
WHERE e.LastName = 'D%'

SELECT c.CustomerID, c.PostalCode
FROM Customers c
WHERE c.PostalCode LIKE '[0-3]%'

SELECT c.ContactName, c.PostalCode
FROM Customers c
WHERE c.ContactName LIKE 'A[^l-n]%'

SELECT c.ContactName, c.City
FROM Customers c
WHERE c.City != 'Boston'
ORDER BY c.ContactName ASC

SELECT e.EmployeeID, e.FirstName, o.OrderID
FROM Employees e 
JOIN Orders o ON e.EmployeeID = o.EmployeeID

SELECT c.ContactName, c.City, o.OrderDate
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID

SELECT c.ContactName, e.FirstName + ' ' + e.LastName AS [Employee], o.OrderDate
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
	JOIN Employees e ON e.EmployeeID = o.EmployeeID

SELECT c.ContactName, o.OrderID
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderID IS NULL
ORDER BY o.OrderID DESC

SELECT c.ContactName, o.OrderID
FROM Orders o RIGHT JOIN Customers c ON c.CustomerID = o.CustomerID
ORDER BY o.OrderID DESC

SELECT c.ContactName, c.Country, s.SupplierID
FROM Customers c FULL JOIN Suppliers s ON c.Country = s.Country
ORDER BY c.Country, s.Country

SELECT e.EmployeeID, e.FirstName + '' + e.LastName AS [Employee],
	m.FirstName + '' + m.LastName AS [Manager]
FROM Employees e INNER JOIN Employees m ON e.ReportsTo = m.EmployeeID

CREATE DATABASE AprBatch
GO
USE AprBatch
GO
CREATE TABLE Employee (ID int, [Name] VARCHAR(20), Salaray money)