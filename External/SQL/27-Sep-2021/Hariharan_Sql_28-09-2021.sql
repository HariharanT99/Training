

USE Northwind;

/* 1.	Write a procedure to insert New Customers */

CREATE PROC uspCreateCustomer
@CustomerId nchar(5),
@CompanyName nvarchar(40),
@ContactName nvarchar(30),
@ContactTitle nvarchar(30),
@Address nvarchar(60),
@City nvarchar(15),
@Region nvarchar(15) = NULL,
@PostalCode nvarchar(10),
@Country nvarchar(15),
@Phone nvarchar(24),
@Fax nvarchar(24)
as
BEGIN
	IF ( @CustomerId IS NOT NULL and @CompanyName IS NOT NULL) 
	BEGIN
		BEGIN TRY
			Insert Into Customers 
			( 
			CustomerID
			,CompanyName
			,ContactName
			,ContactTitle
			,Address
			,City
			,Region
			,PostalCode
			,Country
			,Phone
			,Fax)
			VALUES (@CustomerId, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax)
		END TRY

		BEGIN CATCH
			Print('Error occurred, try to mention the parameter name while passing the parameter values')
		END CATCH
	END
	ELSE
	BEGIN
		Print('CustomerId and Company Name should not be NULL')
	END
END

EXEC uspCreateCustomer @customerId = 'ZXPS1',@companyName = 'HallWay', @contactName = 'Ramu', @contactTitle = 'Service provider', 
 @address = 'Abc street', @city = 'Chennai', @region = 'SS', @postalcode = '600119', @country = 'India', @phone = '9923234321', @fax = '1232112'

 --Test Query
select CustomerID, CompanyName from Customers
where CustomerID = 'ZXPS1'

 /* 2.	Write a procedure to insert New Orders */

CREATE PROC uspCreateOrders
@CustomerId nchar(5),
@EmployeeID int,
@OrderDate datetime,
@RequiredDate datetime,
@ShippedDate datetime,
@ShipVia int,
@Freight money,
@ShipName nvarchar(40),
@ShipAddress nvarchar(60),
@ShipCity nvarchar(15),
@ShipRegion nvarchar(15) = NULL,
@ShipPostalCode nvarchar(10),
@ShipCountry nvarchar(15)
as
BEGIN
	BEGIN TRY
		Insert Into Orders
		( 
		CustomerID
		,EmployeeID
		,OrderDate
		,RequiredDate
		,ShippedDate
		,ShipVia
		,Freight
		,ShipName
		,ShipAddress
		,ShipCity
		,ShipRegion
		,ShipPostalCode
		,ShipCountry
		)
		VALUES (@CustomerId, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName,
		@ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry)
	END TRY

	BEGIN CATCH
		Print('Values are not inserted, try to mention the parameter name while passing the parameter values')
	END CATCH
END

EXEC uspCreateOrders @orderId = 2012, @customerId = 'KOENE', @employeeId = 6, @orderDate = '2020-11-12', @requiredDate = '2020-11-29', 
@shippedDate = '2020-11-15', @shipVia = 2, @freight = 32.12, @shipName = 'Hari', @shipAddress = 'zxy street', @shipCity = 'Thanjavur', 
@shipRegion = NULL, @shipPostalCode = '62913', @shipCountry = 'India'

select OrderID, ShipName from Orders
where OrderID = 2012

/* 3.	Write a procedure to update the price of an existing product */

CREATE PROC uspUpdatePrice
@ProductID int,
@UnitPrice money
as
BEGIN
	BEGIN TRY
		Update Products
		Set UnitPrice = @UnitPrice
		where ProductID = @ProductID
	END TRY
	BEGIN CATCH
		Print('Values are not updated. Try again')
	END CATCH
END

EXEC uspUpdatePrice 1, 20.00

--Test Query
select ProductID, ProductName, UnitPrice from Products
where ProductID = 1;


/* 4.	Write a procedure to delete discontinued products */

ALTER TABLE Products
ADD Current_Status nvarchar(7); 

CREATE PROC uspDeleteDiscontinuedProducts
as
BEGIN
	UPDATE Products SET Current_Status = 
	CASE 
	    WHEN Discontinued = 1 THEN 'Inactive'
	    ELSE 'Active'
	END
END

EXEC uspDeleteDiscontinuedProducts

/* 5.	Write a procedure to get the discontinued products */

CREATE PROC uspGetDiscontinuedProducts
as
BEGIN
	Select ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock from Products
	Where Discontinued = 1
END

EXEC uspGetDiscontinuedProducts

/* 6.	Write a procedure to update the phone number of a given supplier */

CREATE PROC uspUpdateSupplierPhone
@SupplierID int,
@Phone nvarchar(24)
as
BEGIN
	BEGIN TRY
		Update Suppliers
		Set Phone = @Phone
		Where SupplierID = @SupplierID
	END TRY
	BEGIN CATCH
		Print('Values are not updated.Try again')
	END CATCH
END

EXEC uspUpdateSupplierPhone 21, '987654321'

--Test Query
select SupplierID, Phone from Suppliers
where SupplierID = 21

/* 7.	Write a procedure to list the employees working under Manager */

CREATE OR ALTER PROC uspEmployeeWithManager
@managername VARCHAR(20)
AS
BEGIN
    Select M.FirstName + ' ' + M.LastName as Employer 
	from Employees E
    JOIN Employees M 
	On E.EmployeeID = M.ReportsTo
    Where M.ReportsTo IS NOT NULL AND E.FirstName LIKE @managername
END

EXEC uspEmployeeWithManager 'andrew';

/* 8.	Write a procedure to search a supplier & display its details */

DECLARE @SupplierID INT = NULL
DECLARE @CompanyName nvarchar(50) = 'Tokyo Traders'
DECLARE @ContactName nvarchar(50) = NULL



 

Select SupplierID, CompanyName, ContactName, ContactTitle from Suppliers
WHERE  @SupplierID IS NULL OR SupplierID = @SupplierID OR
		 @CompanyName IS NULL OR CompanyName = @CompanyName OR
		@ContactName IS NULL OR ContactName = @ContactName

CREATE PROC uspSearchSupplier
@SupplierID int = NULL,
@CompanyName nvarchar(40) = NULL,
@ContactName nvarchar(30) = NULL
as
BEGIN
	BEGIN TRY
		IF (@SupplierID IS NOT NULL)
			BEGIN
				Select SupplierID
				,CompanyName
				,ContactName
				,ContactTitle 
				from Suppliers
				Where SupplierID = @SupplierID
			END
		ELSE IF (@CompanyName IS NOT NULL)
			BEGIN
				Select SupplierID
				,CompanyName
				,ContactName
				,ContactTitle 
				from Suppliers
				Where CompanyName = @CompanyName
			END
		ELSE
			BEGIN
				Select SupplierID
				,CompanyName
				,ContactName
				,ContactTitle 
				from Suppliers
				Where ContactName = @ContactName
			END
	END TRY
	BEGIN CATCH
		Print('Not Found : Mention the parameters name while passing the values')
	END CATCH
END

EXEC uspSearchSupplier @SupplierId = 1 


/* 9.	Write a procedure to print the number of products in a given order */

CREATE PROC uspNoOfProducts_Order
@OrderID int
as
BEGIN
	Select OrderID
	,COUNT(ProductID) as No_Of_Products 
	from [Order Details]
	Where OrderID = @OrderID
	Group By OrderID
END

EXEC uspNoOfProducts_Order 10251

/* 10.	Write a procedure to print the number of products in a given category */

CREATE PROC uspNoOfProducts_Category
@CategoryID int = NULL,
@CategoryName nvarchar(15) = NULL
as
BEGIN
	IF (@CategoryID IS NOT NULL)
		BEGIN
			Select CategoryID
			,COUNT(ProductID) as No_Of_Products 
			from Products
			Where CategoryID = @CategoryID
			Group By CategoryID
		END
	ELSE
		BEGIN
			DECLARE @catId int = (Select CategoryID 
									from Categories 
									Where CategoryName = @CategoryName)

			Select CategoryID
			,COUNT(ProductID) as No_Of_Products 
			from Products
			Where CategoryID = @catId
			Group By CategoryID
		END
END

EXEC uspNoOfProducts_Category @categoryName = 'Meat/Poultry'
EXEC uspNoOfProducts_Category 3

/* 11.	Write a procedure to print the number of employees hired on given month and year (Jan 2012) */

CREATE PROC uspNoOfEmployeesHired_Month_Year
@Month int,
@Year int
as
BEGIN
	IF ( @Month IS NOT NULL AND @Year IS NOT NULL)
		BEGIN
			Select COUNT(EmployeeID) as No_Of_Employees from Employees
			Where DATEPART(Month,HireDate) = @Month AND DATEPART(Year,HireDate) = @Year
			Group By DATEPART(Month,HireDate),DATEPART(Year,HireDate)
		END
	ELSE
		BEGIN
			Print('Enter the month and year')
		END
END

EXEC uspNoOfEmployeesHired_Month_Year 10,1993

/* 12.	Write a function that accepts orderId as a parameter and returns billing information */

CREATE FUNCTION udfBillingInformation (@order_Id int)
RETURNS TABLE
as
	RETURN 
		Select o.OrderID
		,o.CustomerID
		,o.OrderDate
		,o.ShipName
		,SUM((od.UnitPrice*od.Quantity)-(od.Discount*(od.UnitPrice*od.Quantity))) as Price 
		from Orders o
		JOIN [Order Details] od
		on o.OrderID = od.OrderID AND od.OrderID = @order_Id
		Group By o.OrderID
				,o.OrderID
				,o.CustomerID
				,o.OrderDate
				,o.ShipName


Select OrderID, CustomerID, OrderDate, ShipName, Price from udfBillingInformation(10248)
		

/* 13.	Write a function that accepts orderId as a parameter and returns no: of products */

CREATE FUNCTION udfNoOfProducts_OrderId (@order_Id int)
RETURNS int
as
BEGIN
	RETURN 
		(
		Select COUNT(ProductID)
		from [Order Details]
		Where OrderID = @order_Id
		Group By OrderID
		)
END

SELECT [dbo].[udfNoOfProducts_OrderId] (10248) as No_Of_Products

/* 14.	Write a function that accepts Emp id as a parameter returns Employee info  */

CREATE FUNCTION udfEmployeeInformation (@emp_Id int)
RETURNS TABLE
as
RETURN 
	Select EmployeeID
		,(FirstName+' '+LastName) as Name
		,Title
		,TitleOfCourtesy
		,BirthDate
		,HireDate
		,Address
		,City
		,PostalCode
		,Country
		,HomePhone
	from Employees
	Where EmployeeID = 2

Select EmployeeID
		,Name
		,Title
		,TitleOfCourtesy
		,BirthDate
		,HireDate
		,Address
		,City
		,PostalCode
		,Country
		,HomePhone 
from udfEmployeeInformation(2)

/* 15.	Write a function to return the most active customer */

CREATE FUNCTION udfMostActiveCustomer()
RETURNS nvarchar(6)
as 
BEGIN
	RETURN (
		--DECLARE @Max_ord int = (Select Max(Ord.No_Of_Orders) from (Select COUNT(OrderID) as No_Of_Orders from Orders Group By CustomerID) as Ord)

		Select CustomerID as No_Of_Orders 
		from Orders 
		Group By CustomerID
		Having COUNT(OrderID) = (
								Select Max(Ord.No_Of_Orders) 
								from (
										Select COUNT(OrderID) as No_Of_Orders 
										from Orders 
										Group By CustomerID
										) as Ord
								)
		)
END

Select [dbo].[udfMostActiveCustomer]() as Most_Active_Customer


/* 16.	Write a function to return the costliest product */

--Max Price Function
CREATE FUNCTION udfMaxPrice()
RETURNS money
as
BEGIN
	RETURN (Select MAX(UnitPrice) from Products)
END

SELECT [dbo].[udfMaxPrice]()

--Costliest Product Function
CREATE FUNCTION udfCostliestProduct()
RETURNS int
as
BEGIN
	RETURN(
		Select ProductID from Products
		Where UnitPrice = [dbo].[udfMaxPrice]()
		)
END
		
Select [dbo].[udfCostliestProduct]() as Product_Id

/* 17.	Write a function to count the number of employees hired on a particular date */

CREATE FUNCTION udfNoOfEmployees_Date (@date date)
RETURNS int
as
BEGIN
	RETURN(
		Select COUNT(EmployeeID) from Employees
		Where HireDate = @date
		Group By HireDate
		)
END

Select [dbo].[udfNoOfEmployees_Date]('1993-10-17') as No_Of_Employees

/* 18.	Write a function return no of orders that are delivered on time */

CREATE FUNCTION udfNoOfOrdersDeliveredOnTime()
RETURNS int
as
BEGIN
	RETURN(
		Select COUNT(OrderID) from Orders
		Where RequiredDate > ShippedDate
		)
END

Select [dbo].[udfNoOfOrdersDeliveredOnTime]() as No_Of_Orders


/* 19.	Write a function return no of orders whose bill values is less than 1500 */

CREATE FUNCTION udfNoOfOrders_BillValuesLessthan1500()
RETURNS int
as
BEGIN
	RETURN(
		Select COUNT(Ord.OrderID) from(
		Select OrderID from [Order Details]
		Group By OrderID
		Having SUM(UnitPrice * Quantity) < 1500) as Ord
		)
END

Select [dbo].[udfNoOfOrders_BillValuesLessthan1500]() as No_of_Orders

/* 20.	Write a function, orderId as parameter return order details */
/*
CREATE FUNCTION udfOrderDetails (@order_Id int)
RETURNS TABLE
as
RETURN
	Select OrderID, CustomerId, EmployeeID, OrderDate, RequiredDate, ShippedDate,
	ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry
	from Orders
	Where OrderID = @order_Id
*/

CREATE FUNCTION udfOrderDetails (@order_Id int)
RETURNS TABLE
as
RETURN
	SELECT o.OrderID, o.CustomerID, o.EmployeeID, o.OrderDate, o.RequiredDate, o.ShippedDate, o.ShipVia, o.Freight, o.ShipName,
	o.ShipAddress, o.ShipCity, o.ShipRegion, o.ShipPostalCode, o.ShipCountry, SUM(od.UnitPrice * od.Quantity) as Total_Price from [Order Details] od
	JOIN Orders o on od.OrderID = o.OrderID AND o.OrderID = @order_Id
	GROUP BY o.OrderID, o.CustomerID, o.EmployeeID, o.OrderDate, o.RequiredDate, o.ShippedDate, o.ShipVia, o.Freight, o.ShipName,
	o.ShipAddress, o.ShipCity, o.ShipRegion, o.ShipPostalCode, o.ShipCountry

Select OrderID,CustomerID,EmployeeID,OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress,
ShipCity, ShipRegion, ShipPostalCode, ShipCountry, Total_Price
from udfOrderDetails(10250)

/* 21.	Write a function category as parameter and list details of the products, name, and price */

CREATE FUNCTION udfProductsByCategory (@categoryId int)
RETURNS TABLE
as
RETURN
	Select ProductID, ProductName, UnitPrice from Products
	Where CategoryID = @categoryId

Select ProductID, ProductName, UnitPrice from udfProductsByCategory(2)

/* 22.	Get sales report for last five years based on categories and products */

CREATE PROC uspSalesReport_Dates
@FromDate date,
@ToDate date
as
BEGIN
	Select P.CategoryID, P.ProductID, COUNT(o.OrderID) as No_Of_Times, SUM(od.UnitPrice * od.Quantity - od.Discount) as TotalPrice from Products P
	JOIN [Order Details] od On P.ProductID = od.ProductID
	JOIN Orders O on O.OrderID= od.OrderID
	Where OrderDate BETWEEN @FromDate AND @ToDate
	Group By p.ProductID,P.CategoryID
	Order By P.CategoryID, P.ProductID
END

EXEC uspSalesReport_Dates @FromDate = '1996-07-06', @ToDate = '1998-05-06'

/* 23.	Get the organizational structure for the given employee */

CREATE PROC uspOrganizationalStructure_Employee 
@EmployeeID int
as
BEGIN
	WITH CTE_Employee
	as(
		Select EmployeeID, (FirstName+' '+LastName)as Name, ReportsTo from Employees
		Where EmployeeID = @EmployeeID

		Union ALL

		Select e.EmployeeID, (e.FirstName+' '+e.LastName)as Name, e.ReportsTo from Employees e
		JOIN CTE_Employee cte
		ON e.EmployeeID = cte.ReportsTo
		)

	Select e.EmployeeID,e.Name, ISNULL(cte.Name,'Boss') from CTE_Employee e
	LEFT JOIN CTE_Employee cte
	ON e.ReportsTo = cte.EmployeeID
END

EXEC uspOrganizationalStructure_Employee 3

/* 24.	Find the best employee for the given year based on sales  */

CREATE PROC uspBestEmployee_Year
@Year int
as
BEGIN
	WITH Orders_Count
	as
	(Select COUNT(OrderID) as No_Of_Orders from Orders
	Where DATEPART(Year,OrderDate) = @Year
	Group By EmployeeID)

	Select EmployeeID, COUNT(OrderID) as No_Of_Orders from Orders
	Where DATEPART(Year,OrderDate) = @Year
	Group By EmployeeID
	Having COUNT(OrderID) = (Select MAX(No_Of_Orders) from Orders_Count)
END

EXEC uspBestEmployee_Year 1996

/* 25.	Generate region-based sales reports for the last 10 years */

SELECT ShipRegion, COUNT(CASE WHEN (DATEPART(year,OrderDate) = 1996) THEN OrderID ELSE null END) AS "1996",
		COUNT(CASE WHEN (DATEPART(year,OrderDate) = 1997) THEN OrderID ELSE null END) AS "1997",
		COUNT(CASE WHEN (DATEPART(year,OrderDate) = 1998) THEN OrderID ELSE null END) AS "1998"
FROM Orders
Group By ShipRegion


--Last Five Years
SELECT ShipRegion, COUNT(CASE WHEN (DATEPART(year,OrderDate) = DATEPART(year,GETDATE())) THEN OrderID ELSE null END) AS "Current Year",
		COUNT(CASE WHEN (DATEPART(year,OrderDate) = (DATEPART(year,GETDATE()))-1) THEN OrderID ELSE null END) AS "Last Year",
		COUNT(CASE WHEN (DATEPART(year,OrderDate) = (DATEPART(year,GETDATE()))-2) THEN OrderID ELSE null END) AS "2 Years Back",
		COUNT(CASE WHEN (DATEPART(year,OrderDate) = (DATEPART(year,GETDATE()))-3) THEN OrderID ELSE null END) AS "3 Years Back",
		COUNT(CASE WHEN (DATEPART(year,OrderDate) = (DATEPART(year,GETDATE()))-4) THEN OrderID ELSE null END) AS "4 Years Back",
		COUNT(CASE WHEN (DATEPART(year,OrderDate) = (DATEPART(year,GETDATE()))-5) THEN OrderID ELSE null END) AS "5 Years Back"
FROM Orders
Group By ShipRegion

print((DATEPART(year,GETDATE()))-5)

/* 26.	Which region has more employee and show the count based on region and then territory? */

SELECT RegionID,COUNT(CASE WHEN (EmployeeID = 1) THEN RegionID ELSE null END) AS "Employee 1",
		COUNT(CASE WHEN (EmployeeID = 2) THEN RegionID ELSE null END) AS "Employee 2",
		COUNT(CASE WHEN (EmployeeID = 3) THEN RegionID ELSE null END) AS "Employee 3",
		COUNT(CASE WHEN (EmployeeID = 4) THEN RegionID ELSE null END) AS "Employee 4",
		COUNT(CASE WHEN (EmployeeID = 5) THEN RegionID ELSE null END) AS "Employee 5",
		COUNT(CASE WHEN (EmployeeID = 6) THEN RegionID ELSE null END) AS "Employee 6",
		COUNT(CASE WHEN (EmployeeID = 7) THEN RegionID ELSE null END) AS "Employee 7",
		COUNT(CASE WHEN (EmployeeID = 8) THEN RegionID ELSE null END) AS "Employee 8",
		COUNT(CASE WHEN (EmployeeID = 9) THEN RegionID ELSE null END) AS "Employee 9"
FROM Territories T
JOIN EmployeeTerritories E
on T.TerritoryID = E.TerritoryID
Group  By RegionID

/* 27.	Write a procedure to print the invoice for the given order */

CREATE PROC uspInvoice
@OrderId int
as
BEGIN
	Select o.OrderID, o.CustomerID, o.OrderDate, o.ShippedDate, o.ShipName, o.ShipAddress, o.ShipCity, o.ShipRegion, 
	o.ShipPostalCode, o.ShipCountry, SUM(od.UnitPrice * od.Quantity) as Total_Price from [Order Details] od
	JOIN Orders o on od.OrderID = o.OrderID AND o.OrderID = @OrderId
	Group By o.OrderID, o.CustomerID, o.OrderDate, o.ShippedDate, o.ShipName, o.ShipAddress, o.ShipCity, o.ShipRegion, 
	o.ShipPostalCode, o.ShipCountry
END

EXEC uspInvoice 10250


		Insert Into Customers ( CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)
		VALUES ( 'Hari', 'Haran', 'Tas', 'Abc street', 'ABC', 'SS', '234234', 'India', '9876543211', '113232-32')