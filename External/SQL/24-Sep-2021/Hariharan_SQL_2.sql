CREATE DATABASE Assessment;

USE Assessment;


CREATE TABLE Client(
CustomerId INT,
First_Name VARCHAR(100),
Last_Name VARCHAR(100),
City VARCHAR(150),
State VARCHAR(200),
PRIMARY KEY (CustomerId)
);

CREATE TABLE Orders(
Id INT,
CustomerId INT,
Order_date DATE,
Item VARCHAR(150),
Quantity INT,
Price DECIMAL,
PRIMARY KEY (Id),
FOREIGN KEY (CustomerId) REFERENCES Client(CustomerId)
);


INSERT INTO Client(CustomerId, First_Name, Last_Name, State, City)
VALUES (0, 'Ram', 'Kumar', 'Tamilnadu', 'Chennai'),
(1, 'Arun', 'Balaji', 'Tamilnadu', 'Chennai'),
(2, 'Raj', 'Kamal', 'Tamilnadu', 'Chennai'),
(3, 'Hannah', 'Baker', 'Tamilnadu', 'Chennai'),
(4, 'Bala', 'Ganesh', 'Tamilnadu', 'Chennai'),
(5, 'Hari', 'Haran', 'Tamilnadu', 'Chennai'),
(6, 'Vignesh', 'Kumar', 'Tamilnadu', 'Chennai'),
(7, 'Ganesh', 'Balaji', 'Tamilnadu', 'Chennai');


INSERT INTO Orders(Id, CustomerId, Order_date, Item, Quantity, Price)
VALUES (101, 0, '01-12-2019', 'Unicycle', 2, 70),
(102, 1, '2020-10-11', 'Light', 5, 40),
(103, 2, '2018-05-21', 'Umberla', 3, 110),
(104, 5, '2020-12-21', 'Lantern', 2, 10),
(105, 5, '2021-03-12', 'tent', 2, 70),
(107, 1, '2020-12-21', 'Lantern', 5, 10),
(108, 1, '2021-03-12', 'tent', 1, 70),
(106, 6, '2020-02-02', 'Outfit', 2, 70);



/*1. From Orders table  
	a) select for customerid 5, items purchased
	b) Results to include customer name and Id as result set 1 and customerid , item, and price as result set 2 for this customer */
	
	SELECT Item FROM Orders
	WHERE CustomerId = 5;

	SELECT First_Name as 'Name', CustomerId FROM Client;
	SELECT CustomerId, Item, Price CustomerId FROM Orders;



/* 2. Select all columns from the orders table whoever purchase a Unicycle. */

SELECT Id, CustomerId, Order_date, Item, Quantity, Price FROM Orders
WHERE Item = 'Unicycle';


/* 3. Select the customerid, order_date, and item values from the orders table for any items in the item column that strat with letter 'L' */

SELECT CustomerId, Order_date, Item FROM Orders
WHERE Item LIKE 'L%';

/* 4. Select the unique items in the Orders table */

SELECT DISTINCT Item FROM Orders;

/* 5. Select the items with the maximum price in the Orders table */

DECLARE @Max_Price DECIMAL = (SELECT MAX(Price) FROM Orders)

SELECT Item FROM Orders
WHERE Price = @Max_Price;

/* 6. Select the average price of all of the items ordered that were purchased in the december month */

SELECT AVG(Price) as 'Avg_Price' FROM Orders
WHERE DATEPART( Month, Order_date) = 12;


/* 7. Display the total numbers of rows in the order table */

SELECT COUNT(Id) AS 'Total_No_Rows' FROM Orders

/* 8. For all of the tents that were ordered in the orders table, what is the price of the lowest lantern. The result show only the price column */

SELECT MIN(price*quantity) as Min_Lantern_Price FROM orders
WHERE item='lantern'
AND customerid IN (SELECT customerid FROM orders
WHERE item='tent');

/* 9. From the Orders table, select the item, maximum price and minimum price for each specific items in the table */

SELECT Item, MAX(Price) as 'Max_Price', MIN(Price) as 'Min_Price' FROM Orders
GROUP BY Item;

/* 10. How many people are in each unique state in the client table? select the state and display the number of people in each state.
	Resulting columns -- Clients Name, no. of Orders */

SELECT State, COUNT(CustomerId) AS 'No_Of_People' FROM Client
GROUP BY State;

/* 11. How many order did each client make */

SELECT CustomerId, COUNT(CustomerId) FROM Orders
GROUP BY CustomerId;


/* 12. From the orders select the select the item, maximum price, and minimum price, and minimum price for each specific items in the table.
	Only display the results if the maximum price is greater than 190.00 */

SELECT Item, MAX(Price) as 'Max_Price', MIN(Price) as 'Min_Price' FROM Orders
GROUP BY Item
HAVING MAX(Price) > 190.00;

/* 13. How many people are in each unique state in the client table? select the state and display the number of people in each state.
	Display if the number of people greater than 1 */

SELECT State, COUNT(CustomerId) AS 'No_Of_People' FROM Client
GROUP BY State
HAVING COUNT(CustomerId) > 1;

/* 14. Select the fullname ( firstname + lastname) and city for all client in the client table. display the results in ascending order based on fullname */

SELECT (First_Name + ' '+ Last_Name) as 'Full_Name', City FROM Client
ORDER BY Full_Name;

/* 15. Select the item and price for all of the items in the Orders table and the price is greater than 10.00 .
	Dispaly in ascending order based on price. */

SELECT Item, Price FROM Orders
WHERE Price > 10.00
ORDER BY Price;

/* 16. Select the customerid, order_date, and item from the Orders table for all items unless they are
	Lantern' or if they are 'Umbrella'. */

SELECT CustomerId, Order_date, Item FROM Orders
WHERE Item NOT IN ('Lantern','Umberla');


/* 17. Select the item and price of all items that start with the letter's 'C', 'H', or 'R' */

SELECT Item, Price FROM Orders
WHERE (Item LIKE 'C%') OR
(Item LIKE 'H%') OR
(Item LIKE 'R%');

/* 18. Select from the Orders table all of the rows that have a price value ranging from 10.00 to 80.00 */

SELECT Id, CustomerId, Order_date, Item, Quantity, Price FROM Orders
WHERE Price BETWEEN 10.00 AND 80.00;

/* 19. Select from the client table for all of the rows where the state value is either: Washington or Oregon */

SELECT CustomerId, First_Name, Last_Name, City, State FROM Client
WHERE State IN ( 'Washington', 'Oregon');

/* 
20. Select the distinct item and per unit price for each item in the Orders table. Resulting columns
	Item, per unit price 21. Select distinct order item with price rounded off to 2 decimals */

SELECT DISTINCT Item, Price as 'Per_Unit_Price' FROM Orders

/*  21. Select distinct order item with price rounded off to 2 decimals */

SELECT DISTINCT Item, CAST(Price as numeric(12,2)) FROM Orders


/* 22. Write a query using a join to determine which items were ordered by each of the client in the client table. 
	Select the customerid, firstname, lastname, order_date, item, and price for everything each customer purchased in the Orders table. */

SELECT C.CustomerId, C.First_Name, C.Last_Name, O.Order_date, O.Item, O.Price FROM Client C
JOIN Orders O
ON C.CustomerId = O.CustomerId

/* 23-Repeat exercise #1 , however display the results sorted by state in descending order. */

SELECT First_Name as 'Name', CustomerId FROM Client
ORDER BY State DESC;

/* 24. Select distinct customer first name from customer table as comma separated list */

SELECT DISTINCT STRING_AGG(First_Name, ', ') 
FROM Client;

/* 25. List the client with row number sorted in FirstName */

SELECT ROW_NUMBER() OVER (ORDER BY First_Name) as 'Row_Num', CustomerId, First_Name, Last_Name, City, State FROM Client

/* 26.  Now, given the table below, how can we return results that will show each employee's name,
	and his/her manager's name. Hint-user self-join */


CREATE TABLE Manager(
EmployeeId INT,
Name VARCHAR(100),
ManagerId INT,
PRIMARY KEY(EmployeeId)
);

INSERT INTO Manager( EmployeeId, Name, ManagerId)
VALUES (1, 'Sam', 10),
(2, 'Harry', 4),
(4, 'Manager', NULL),
(10, 'Another Manager', NULL);

SELECT M.Name, MG.Name FROM Manager MG
JOIN Manager M
ON MG.EmployeeId = M.ManagerId;


