USE AdventureWorks2019
GO

-- Q1
SELECT p.ProductID, p.[Name], p.Color, p.ListPrice
FROM Production.Product p

-- Q2
SELECT p.ProductID, p.[Name], p.Color, p.ListPrice
FROM Production.Product p
WHERE p.ListPrice <> 0

-- Q3
SELECT p.ProductID, p.[Name], p.Color, p.ListPrice
FROM Production.Product p
WHERE p.Color IS NULL

-- Q4
SELECT p.ProductID, p.[Name], p.Color, p.ListPrice
FROM Production.Product p
WHERE p.Color IS NOT NULL

-- Q5
SELECT p.ProductID, p.[Name], p.Color, p.ListPrice
FROM Production.Product p
WHERE p.Color IS NOT NULL AND p.ListPrice > 0

-- Q6
SELECT p.[Name] + ' ' + p.Color AS "Concatenated"
FROM Production.Product p
WHERE p.Color IS NOT NULL

-- Q7
SELECT 'NAME: ' + p.[Name] + ' -- COLOR: ' + p.Color AS "Concatenated"
FROM Production.Product p
WHERE (p.[Name] LIKE '%Crankarm' OR p.[Name] LIKE 'Chainring%') AND p.Color IS NOT NULL
ORDER BY p.[Name] DESC

-- Q8
SELECT p.ProductID, p.[Name]
FROM Production.Product p
WHERE p.ProductID BETWEEN 400 AND 500

-- Q9
SELECT p.ProductID, p.[Name], p.Color
FROM Production.Product p
WHERE p.Color IN ('Black', 'Blue')

-- Q10
SELECT p.[Name]
FROM Production.Product p
WHERE p.[Name] LIKE 's%'

-- Q11
SELECT p.[Name], p.ListPrice
FROM Production.Product p
ORDER BY p.[Name]

-- Q12
SELECT p.[Name], p.ListPrice
FROM Production.Product p
WHERE p.[Name] LIKE '[a,s]%'
ORDER BY p.[Name]

-- Q13
SELECT p.[Name]
FROM Production.Product p
WHERE p.[Name] LIKE 'spo[^k]%'
ORDER BY p.[Name]

-- Q14
SELECT DISTINCT p.Color
FROM Production.Product p
ORDER BY p.Color DESC

-- Q15
SELECT DISTINCT p.ProductSubcategoryID, p.Color
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NOT NULL AND p.Color IS NOT NULL