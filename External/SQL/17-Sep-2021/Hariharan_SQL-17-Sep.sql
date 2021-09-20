CREATE DATABASE BookManagement

USE BookManagement

/* Create tables */

CREATE TABLE Publisher(
PublisherId INT,
PublisherName VARCHAR(150),
AddressLine1 VARCHAR(100),
AddressLine2 VARCHAR(100),
AddressLine3 VARCHAR(100),
EmailId VARCHAR(50),
PRIMARY KEY (PublisherId),
);


CREATE TABLE BookCategory(
CategoryId INT,
CategoryName VARCHAR(200),
PRIMARY KEY (CategoryId)
);

CREATE TABLE Author(
AuthorId INT,
AuthorName VARCHAR(150),
PRIMARY KEY (AuthorId)
);


CREATE TABLE Book(
BookId INT,
Title VARCHAR(100),
CategoryId INT,
AuthorId INT,
PublisherId INT,
Copies BIGINT,
Edition INT,
YearofPublish INT,
AcquisitionDate TIMESTAMP,
Price DECIMAL,
RackNo INT,
PRIMARY KEY (BookId),
FOREIGN KEY (CategoryId) REFERENCES BookCategory(CategoryId),
FOREIGN KEY (PublisherId) REFERENCES Publisher(PublisherId)
);

CREATE TABLE Department(
DepartmentId INT,
DepartmentName VARCHAR(150),
PRIMARY KEY(DepartmentId)
);

CREATE TABLE MemberStatus(
StatusId INT,
Status VARCHAR(50),
PRIMARY KEY (StatusId)
);

CREATE TABLE Member(
MemberId INT,
MemberName VARCHAR(150),
DepartmentId INT,
MembershipStartDate TIMESTAMP,
Status INT,
PRIMARY KEY (MemberId),
FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId),
FOREIGN KEY (Status)REFERENCES MemberStatus(StatusId)
);

CREATE TABLE BookTransaction(
BookId INT,
MemberId INT,
IsuueDate DATETIME,
DueDate DATETIME,
ReturnDate DATETIME,
FOREIGN KEY (BookId) REFERENCES Book(BookId),
FOREIGN KEY (MemberId) REFERENCES Member(MemberId)
);

/* Insert some values*/

INSERT INTO BookCategory (CategoryId, CategoryName)
VALUES ( 1, 'Classic'),
( 2, 'Action and Adventure'),
( 3, 'Comic Book'),
( 4, 'Fantasy'),
( 5, 'Historical Fiction');

INSERT INTO BookCategory (CategoryId, CategoryName)
VALUES
( 6, 'Horror'),
(7, 'RDBMS');

INSERT INTO BookCategory (CategoryId, CategoryName)
VALUES ( 8 , 'Education');

INSERT INTO Author( AuthorId, AuthorName)
VALUES ( 1, 'Robert Louis Stevenson' ),
( 2, 'William Shakespeare ' ),
( 3, 'Bram Stoker' ),
(4, 'Guido van Rossum');


INSERT INTO Publisher( PublisherId, PublisherName)
VALUES ( 1001, 'Signet Classics'),
(1002, 'Greenbooks editor'),
(1003, 'Willey publication');


INSERT INTO Book(BookId, Title, CategoryId, AuthorId, PublisherId, Copies, Edition, YearofPublish, Price, RackNo)
VALUES ( 101001, ' Treasure Island', 2, 1, 1001, 100, 4, 2007, 1500, 4),
(101002, 'Kidnapped', 2, 1, 1002, 150, 3, 2009, 1200, 4),
(101003, 'Hamlet', 6, 2, 1001, 250, 2, 2015, 2200, 7),
(101004, 'Romeo and Juliet', 4, 2, 1002, 500, 3, 2011, 2500, 3),
(101005, 'Dracula', 2, 3, 1001, 500, 3, 2014, 1900, 1),
(101006, 'DBMS Fundamentals', 7, 2, 1003, 700, 8, 2018, 700, 2);

INSERT INTO Book(BookId, Title, CategoryId, AuthorId, PublisherId, Copies, Edition, YearofPublish, Price, RackNo)
VALUES
(101007, 'Python', 8, 4, 1003, 1200,3, 2017,1000, 4),
(101008, 'SQL-SERVER', 8, 3, 1001, 900, 9, 2019, 550, 2);

INSERT INTO Book(BookId, Title, CategoryId, AuthorId, PublisherId, Copies, Edition, YearofPublish, Price, RackNo)
VALUES
(101009, 'DBMS Intermidiate', 7, 2, 1003, 1100, 6, 2019, 650, 2),
(101010, 'DBMS Advance', 7, 2, 1003, 1000, 4, 2019, 850, 2);


INSERT INTO MemberStatus(StatusId, Status)
VALUES (0,'Inactive'),( 1, 'Active');

INSERT INTO Department(DepartmentId, DepartmentName)
VALUES ( 1,'CSE' ),
( 2,'MECH' ),
( 3,'EEE' ),
( 4,'ECE' );

INSERT INTO Member(MemberId, MemberName, DepartmentId, Status)
VALUES
(101, 'Hari', 2, 1),
(102, 'Raj', 3, 1),
(103, 'Clady', 1, 1),
(104, 'David', 1, 0),
(105, 'Naresh', 4, 1);


INSERT INTO BookTransaction(BookId, MemberId, IsuueDate, DueDate, ReturnDate)
VALUES(101002, 102, '2021-02-26', '2021-04-15', '2021-04-10'),
(101003, 101, '2021-03-26', '2021-04-26', '2021-04-30'),
(101004, 105, '2021-09-28', '2021-11-01', NULL),
(101010, 101, '2021-09-26', '2021-10-29', NULL),
(101006, 103, '2021-01-06', '2021-04-05', '2021-04-10'),
(101007, 104, '2021-03-11', '2021-05-15', '2021-05-10'),
(101003, 101, '2021-05-13', '2021-06-15', '2021-05-29'),
(101002, 104, '2021-07-11', '2021-08-28', '2021-08-20'),
(101001, 105, '2021-03-26', '2021-04-05', '2021-04-01'),
(101008, 103, '2021-02-16', '2021-04-10', '2021-04-15'),
(101010, 102, '2021-01-06', '2021-03-19', '2021-03-08'),
(101001, 101, '2021-04-26', '2021-06-15', '2021-06-10'),
(101009, 103, '2021-05-26', '2021-08-05', '2021-08-01');



/* 1.	How many books are there in each category? */

SELECT CategoryId, COUNT(BookId) AS No_Of_Books FROM Book
GROUP BY CategoryId;

/* 2.	Title wise display the number of copies in RDBMS category */

SELECT B.Title, B.Copies FROM Book B
INNER JOIN BookCategory Bcatg
ON Bcatg.CategoryId = B.CategoryId
WHERE Bcatg.CategoryName = 'RDBMS';

/* 3.	Display Category Name, Title and Edition */

SELECT Bcatg.CategoryName, B.Title, B.Edition FROM Book B
INNER JOIN BookCategory Bcatg
ON Bcatg.CategoryId = B.CategoryId;

/* 4.	Which publisher book is maximum available in library? */

SELECT PublisherId, COUNT(BookId) AS BookCount FROM Book
GROUP BY PublisherId
HAVING COUNT(BookId) = (
SELECT MAX(Bk.BkCnt) FROM Book B
INNER JOIN ( 
SELECT PublisherId, COUNT(BookId) AS BkCnt FROM Book
GROUP BY PublisherId) AS Bk ON Bk.PublisherId = B.PublisherId);

/* 5.	Display Title, Member-Name, Due-Date, Delay */

SELECT B.Title, M.MemberName, BT.DueDate, DATEDIFF(Day, BT.DueDate, BT.ReturnDate) AS Delay FROM BookTransaction BT
INNER JOIN Member M ON M.MemberId = BT.MemberId
INNER JOIN Book B ON B.BookId = BT.BookId
WHERE DATEDIFF(Day, BT.DueDate, BT.ReturnDate) > 0;


/* 6.	Display the categories of books published by Willey publication */

SELECT B.CategoryId FROM Book B
INNER JOIN Publisher P
ON P.PublisherId = B.PublisherId
WHERE P.PublisherName = 'Willey publication'
GROUP BY B.CategoryId;

/* 7.	Which categories of books least utilized? */

SELECT B.CategoryId, COUNT(B.BookId) AS BookCount FROM Book B
INNER JOIN BookTransaction BT
ON BT.BookId = B.BookId
GROUP BY B.CategoryId
HAVING COUNT(B.BookId) = (
SELECT MIN(Bk.BkCnt) FROM (
SELECT B.CategoryId, COUNT(B.BookId) AS BkCnt FROM Book B
INNER JOIN BookTransaction BT
ON BT.BookId = B.BookId
GROUP BY B.CategoryId) AS Bk)


/* 8.	Which categories of books most utilized? */

SELECT B.CategoryId, COUNT(B.BookId) AS BookCount FROM Book B
INNER JOIN BookTransaction BT
ON BT.BookId = B.BookId
GROUP BY B.CategoryId
HAVING COUNT(B.BookId) = (
SELECT MAX(Bk.BkCnt) FROM (
SELECT B.CategoryId, COUNT(B.BookId) AS BkCnt FROM Book B
INNER JOIN BookTransaction BT
ON BT.BookId = B.BookId
GROUP BY B.CategoryId) AS Bk)

/* 9.	Display the books were not lent during last quarter of year. */

SELECT BookId, QUARTER (IsuueDate) FROM BookTransaction
WHERE QUARTER(IsuueDate) > 3;

SELECT QUARTER ("2017-01-01 09:34:21");

/* 10.	Display the book details by each member. */

SELECT BT.MemberId, * FROM Book B
INNER JOIN BookTransaction BT
ON BT.BookId = B.BookId
ORDER BY BT.MemberId

/* 11.	Which author book is more in library? */

SELECT AuthorId, COUNT(BookId) AS BookCount FROM Book
GROUP BY AuthorId
HAVING COUNT(BookId) = (
SELECT MAX(Bk.BkCnt) FROM Book B
INNER JOIN ( 
SELECT AuthorId, COUNT(BookId) AS BkCnt FROM Book
GROUP BY AuthorId) AS Bk ON Bk.AuthorId = B.AuthorId);

/* 12.	Which author book is the costliest? */

SELECT AuthorId, MAX(Price) AS Price FROM Book
GROUP BY AuthorId
HAVING MAX(Price) = (
SELECT MAX(Price) FROM Book);

/* 13.	Along the member, list the book that cross due date. */

SELECT M.MemberId, M.MemberName FROM Member M
INNER JOIN BookTransaction BT
ON BT.MemberId = M.MemberId
WHERE BT.DueDate < GETDATE() AND BT.ReturnDate IS NULL;


/* 14.	Who is the most delaying member in the library? */

SELECT BT.MemberId, DATEDIFF(Day, BT.IsuueDate, BT.ReturnDate) AS Delay FROM BookTransaction BT
WHERE DATEDIFF(Day, BT.IsuueDate, BT.ReturnDate) = (
SELECT MAX(BTD.Delay) FROM(
SELECT DATEDIFF(Day, BT.IsuueDate, BT.ReturnDate) AS Delay FROM BookTransaction BT
WHERE DATEDIFF(Day, BT.IsuueDate, BT.ReturnDate) IS NOT NULL) AS BTD);


/* 15.	Which publication is being used by most of the members? */

SELECT B.PublisherId, COUNT(B.BookId) AS BookCount FROM Book B
INNER JOIN BookTransaction BT
ON BT.BookId = B.BookId
GROUP BY B.PublisherId
HAVING COUNT(B.BookId) = (
SELECT MAX(BkCnt.BookCount) FROM (
SELECT COUNT(B.BookId) AS BookCount FROM Book B
INNER JOIN BookTransaction BT
ON BT.BookId = B.BookId
GROUP BY B.PublisherId) AS BkCnt);

/* 16.	How many copies of book available in each category? */

SELECT CategoryId, SUM(Copies) AS No_Of_Copies FROM Book
GROUP BY CategoryId;

/* 17.	Find the books that are lent after few days of its acquisition.	*/

SELECT BT.BookId FROM BookTransaction BT
INNER JOIN Book B
ON B.BookId = BT.BookId
WHERE CAST(B.AcquisitionDate AS datetime) > BT.IsuueDate;

/* 18.	Along with book details, list the members who return the book before the due date. */

SELECT B.*,M.MemberId, M.MemberName FROM BookTransaction BT
INNER JOIN Member M ON M.MemberId = BT.MemberId
INNER JOIN Book B ON B.BookId = BT.BookId
WHERE DATEDIFF(Day, BT.DueDate, BT.ReturnDate) < 0;

/* 19.	Which is the costliest book in each publication? */

SELECT B.PublisherId, B.BookId, B.Price FROM Book B
JOIN (
SELECT MAX(Price) AS MaxPrice FROM Book
GROUP BY PublisherId) AS BP ON BP.MaxPrice = B.Price

/* 20.	Generate last 10-year report that should display the Title, no: of times it been rented, last lent date, is book available for today. */



/* 21.	Which publication book us maximum available in library? */

SELECT PublisherId, COUNT(BookId) AS BookCount FROM Book
GROUP BY PublisherId
HAVING COUNT(BookId) = (
SELECT MAX(Bk.BkCnt) FROM Book B
INNER JOIN ( 
SELECT PublisherId, COUNT(BookId) AS BkCnt FROM Book
GROUP BY PublisherId) AS Bk ON Bk.PublisherId = B.PublisherId);

/* 22.	Rank the book based on the transaction */

SELECT BookId, COUNT(BookId) AS No_Of_Transaction FROM BookTransaction
GROUP BY BookId
ORDER BY COUNT(BookId) DESC;