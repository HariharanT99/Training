/* 1.	Which category has maximum product? */ -- 4 hrs


SELECT P.CategoryID, COUNT(P.ProductID) FROM Products P
JOIN Categories C ON P.CategoryID = C.CategoryID
GROUP BY P.CategoryID
HAVING COUNT(P.ProductID) = (SELECT MAX(ProdCount.Products) FROM (SELECT P.CategoryID, COUNT(P.ProductID) AS Products FROM Products P
JOIN Categories C ON P.CategoryID = C.CategoryID
GROUP BY P.CategoryID) AS ProdCount);


/* 2.	Which category has minimum product? */ -- 10 Mins

SELECT P.CategoryID, COUNT(P.ProductID) FROM Products P
JOIN Categories C ON P.CategoryID = C.CategoryID
GROUP BY P.CategoryID
HAVING COUNT(P.ProductID) = (SELECT MIN(ProdCount.Products) FROM (SELECT P.CategoryID, COUNT(P.ProductID) AS Products FROM Products P
JOIN Categories C ON P.CategoryID = C.CategoryID
GROUP BY P.CategoryID) AS ProdCount)


/* 3.	Which category has no product? */

SELECT * FROM Categories WHERE CategoryID NOT IN (SELECT CategoryID From Products);

/* 4.	Which category has the costliest product? */ --25 mins

SELECT P.CategoryID, MAX(P.UnitPrice) FROM Products P
GROUP BY P.CategoryID
HAVING MAX(P.UnitPrice) = (SELECT MAX(Price.HighPrice) FROM (SELECT P.CategoryID, MAX(P.UnitPrice) AS HighPrice FROM Products P
GROUP BY P.CategoryID) AS Price);

/* 5.	Which category has lot of products with respect to quantity on hand? */ --20 mins

SELECT P.CategoryID,SUM(P.UnitsInStock) AS TotalStock FROM Products P
GROUP BY CategoryID
HAVING SUM(P.UnitsInStock) = (
SELECT MAX(Categ.TotalStock) FROM (
SELECT CategoryID,SUM(UnitsInStock) AS TotalStock FROM Products
GROUP BY CategoryID) AS Categ);


/* 6.	Category wise display the costliest product? */  --15 mins

SELECT Pd.CategoryID, Pd.ProductID, Pd.ProductName, Pd.UnitPrice  FROM Products Pd
JOIN(
SELECT CategoryID, MAX(UnitPrice) AS Price FROM Products
GROUP BY CategoryID) AS Categ ON Categ.CategoryID = Pd.CategoryID AND Categ.Price = Pd.UnitPrice


/* 7.	Category wise display the product with minimum quantity on hand? */ -- 45 mins

SELECT Pd.CategoryID, Pd.ProductID, Pd.ProductName, Pd.UnitsInStock  FROM Products Pd
JOIN(
SELECT CategoryID, MIN(UnitsInStock) AS MinStock FROM Products
GROUP BY CategoryID) AS Categ ON Categ.CategoryID = Pd.CategoryID AND Categ.MinStock = Pd.UnitsInStock;


/* 8.	Which order has maximum products? */  --20 mins


SELECT MIN(Ord.COrd) FROM (SELECT O.OrderID, COUNT(O.OrderID) AS COrd FROM [Order Details] O
GROUP BY O.OrderID) AS Ord



/* 9.	Which products has ordered frequently? */  -- 30 mins

SELECT ProductID, COUNT(ProductId) FROM [Order Details]
GROUP BY ProductID
HAVING COUNT(ProductId) = (SELECT MAX(Ord.Prod) FROM (SELECT ProductID, COUNT(ProductId) AS Prod FROM [Order Details]
GROUP BY ProductID) AS Ord);

/* 10.	Which products has ordered least? */  -- 15 mins

SELECT ProductID, COUNT(ProductId) FROM [Order Details]
GROUP BY ProductID
HAVING COUNT(ProductId) = (SELECT MIN(Ord.Prod) FROM (SELECT ProductID, COUNT(ProductId) AS Prod FROM [Order Details]
GROUP BY ProductID) AS Ord);

/* 11.	Which product is not all ordered? */  --10 mins

SELECT * FROM Orders WHERE OrderID NOT IN (SELECT OrderID From [Order Details]);

/* 12.	Find the costliest order */ --25 mins

SELECT Od.OrderID, SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount))
FROM [Order Details] Od
GROUP BY Od.OrderID 
HAVING SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) = 
(SELECT MAX(OrdDet.TotalPrice) 
FROM (SELECT Od.OrderID,SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) AS TotalPrice
FROM [Order Details] Od
GROUP BY Od.OrderID) AS OrdDet)


/* 13.	In which date the costliest order made? */  --15 mins

SELECT OrderDate FROM Orders
WHERE OrderID = (
SELECT Od.OrderID
FROM [Order Details] Od
GROUP BY Od.OrderID 
HAVING SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) = 
(SELECT MAX(OrdDet.TotalPrice) 
FROM (SELECT Od.OrderID,SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) AS TotalPrice
FROM [Order Details] Od
GROUP BY Od.OrderID) AS OrdDet));

/* 14.	Which customer made the costliest order? */  --15 mins

SELECT * FROM Customers
WHERE CustomerID = (
SELECT CustomerID FROM Orders
WHERE OrderID = (
SELECT Od.OrderID
FROM [Order Details] Od
GROUP BY Od.OrderID 
HAVING SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) = 
(SELECT MAX(OrdDet.TotalPrice) 
FROM (SELECT Od.OrderID,SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) AS TotalPrice
FROM [Order Details] Od
GROUP BY Od.OrderID) AS OrdDet)));

/* 15.	Which customer made the costliest order today? */  --20 mins

DECLARE @MN AS INT = (SELECT O.OrderID FROM [Order Details] O
JOIN(
SELECT OrderID FROM Orders
WHERE OrderDate = '1998-02-02 00:00:00.000') AS Od ON Od.OrderID = O.OrderID
GROUP BY O.OrderID
HAVING SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) = (
SELECT MAX(Ord.Price) FROM (
SELECT O.OrderID,SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) AS Price FROM [Order Details] O
JOIN(
SELECT OrderID FROM Orders
WHERE OrderDate = '1998-02-02 00:00:00.000') AS Od ON Od.OrderID = O.OrderID
GROUP BY O.OrderID) AS Ord));

DECLARE @CD AS VARCHAR(7) =( SELECT CustomerID FROM Orders
WHERE OrderID = @MN);

SELECT * FROM Customers
WHERE CustomerID = @CD;


/*
SELECT O.OrderID, SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) FROM [Order Details] O
JOIN(
SELECT OrderID FROM Orders
WHERE OrderDate = '1998-02-02 00:00:00.000') AS Od ON Od.OrderID = O.OrderID
GROUP BY O.OrderID
HAVING SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) = (
SELECT MAX(Ord.Price) FROM (
SELECT O.OrderID,SUM(((UnitPrice*Quantity)-((UnitPrice * Quantity)/100)*Discount)) AS Price FROM [Order Details] O
JOIN(
SELECT OrderID FROM Orders
WHERE OrderDate = '1998-02-02 00:00:00.000') AS Od ON Od.OrderID = O.OrderID
GROUP BY O.OrderID) AS Ord);
*/