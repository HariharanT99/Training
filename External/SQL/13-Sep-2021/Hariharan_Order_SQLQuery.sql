CREATE DATABASE OrderManagement;

USE OrderManagement;

CREATE TABLE Customer(
Customer_Id INT,
Customer_Name VARCHAR(150),
Address VARCHAR(500),
PRIMARY KEY (Customer_Id)
);

CREATE TABLE Items(
Item_Number INT,
Item_Name VARCHAR(300),
Unit_Price MONEY,
PRIMARY KEY (Item_Number)
);

CREATE TABLE OrderDetails(
Order_Number INT,
Order_Date DATE,
Customer_Id INT,
PRIMARY KEY (Order_Number),
FOREIGN KEY (Customer_Id) REFERENCES Customer(Customer_Id)
);

CREATE TABLE OrderItems(
Order_Number INT,
Item_Number INT,
FOREIGN KEY (Order_Number) REFERENCES OrderDetails(Order_Number),
FOREIGN KEY (Item_Number) REFERENCES Items(Item_Number)
);

INSERT INTO Customer
VALUES (0, 'Hari','Main Road, kumbakonam')

INSERT INTO Customer
VALUES (1, 'Sam','Main Road, kumbakonam')
INSERT INTO Customer
VALUES (2, 'Raju','Main Road, kumbakonam')
INSERT INTO Customer
VALUES (3, 'Ram','Main Road, kumbakonam')


INSERT INTO Items
VALUES (0, 'Shirt',1000)
INSERT INTO Items
VALUES (1, 'Pant',1500)
INSERT INTO Items
VALUES (2, 'T-Shirt',500)

INSERT INTO OrderDetails
VALUES (0,'2021-09-13',  2)

INSERT INTO OrderItems
VALUES(0,1)

INSERT INTO OrderItems
VALUES(0,2)