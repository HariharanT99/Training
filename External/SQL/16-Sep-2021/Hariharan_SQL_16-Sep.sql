CREATE DATABASE Institution;

USE Institution;

/* 1.	Create student table  */

CREATE TABLE Student(
ID INT,
Name VARCHAR(100),
Qualification VARCHAR(20),
Place VARCHAR(150),
PRIMARY KEY (ID)
);

/* 2.	Create course table */

CREATE TABLE Course(
CourseID INT,
CourseName VARCHAR(200),
Price MONEY,
PRIMARY KEY (CourseID)
);

CREATE TABLE Enrollement(
EnrollementID INT,
StudentID INT,
CourseID INT,
Date_Of_Enrollement DATE,
End_Of_Enrollement DATE,
Marks_Scored INT,
Fees_Paid MONEY,
PRIMARY KEY(EnrollementID),
FOREIGN KEY (StudentID) REFERENCES Student(ID),
FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
);

/* 3.	Insert student’s values */

INSERT INTO Student(ID, Name, Qualification, Place)
VALUES (101, 'Sanjay', 'BE', 'Sholinganallur'),
(102, 'Hariharan', 'MCA', 'Egmore '),
(103, 'Arun', 'Bsc', 'Mylapore'),
(104, 'Jayant', 'MBA', 'Triplicane'),
(105, 'Ram', 'BE', 'Anna Nagar'),
(106, 'Hannah', 'BTech', 'Mylapore'),
(107, 'Joe', 'MBA', 'Trivandrum'),
(108, 'Raghul', 'MCA', 'Triplicane'),
(109, 'Samuel', 'BE', 'Anna nagar');

INSERT INTO Student(ID, Name, Qualification, Place)
VALUES (110, 'Saravanan', 'BE', 'Egmore'),
(111, 'Vijay', 'MCA', 'Egmore ');

INSERT INTO Student(ID, Name, Qualification, Place)
VALUES (112, 'Prabu', 'BE', 'Triplicane');

/*
INSERT INTO Student(ID, Name, Qualification, Place, Date_Of_Joining)
VALUES (101, 'Sanjay', 'BE', 'Sholinganallur', '1999-02-12'),
(102, 'Hariharan', 'MCA', 'Egmore ', '2003-04-26'),
(103, 'Arun', 'Bsc', 'Mylapore', '2006-12-03'),
(104, 'Jayant', 'MBA', 'Triplicane', '2009-11-23'),
(105, 'Ram', 'BE', 'Anna Nagar', '2012-10-28'),
(106, 'Hannah', 'BTech', 'Mylapore', '2014-05-08'),
(107, 'Joe', 'MBA', 'Trivandrum', '2016-02-24'),
(108, 'Raghul', 'MCA', 'Triplicane', '2017-07-01'),
(109, 'Samuel', 'BE', 'Anna nagar', '2018-06-20');
*/

/* 4.	Insert courses values */

INSERT INTO Course(CourseID, CourseName, Price)
VALUES (1001, 'C++', 7000),
(1002, 'Pyhton', 9000),
(1003, 'C#', 10000),
(1004, 'Java', 7500),
(1005, 'VB', 5000),
(1006, 'F#', 4000),
(1007, 'Angular', 6500),
(1008, 'DBMS', 8000);

INSERT INTO Enrollement( EnrollementID, StudentID, CourseID, Date_Of_Enrollement, End_Of_Enrollement, Marks_Scored, Fees_Paid)
VALUES (11, 101, 1003,'1999-08-23', '1999-10-23', 85, 4000),
(12, 104, 1001,'2009-11-29', '2010-02-27', 70, 6000), 
(13, 108, 1007,'2017-08-01', '2017-10-11', NULL, 3000), 
(14, 102, 1005,'2003-05-10', '2003-08-01', 75, 2000), 
(15, 104, 1007,'2010-03-26', '2010-05-16', 80, 3500), 
(16, 107, 1002,'2007-02-27', '2007-05-17', NULL, 6000), 
(17, 103, 1004,'2007-01-02', '2007-03-12', NULL, 4000), 
(18, 105, 1006,'2012-10-28', '2012-12-28', 35, 4000), 
(19, 106, 1008,'2014-05-18', '2014-07-08', 33, 4500),
(20, 109, 1004,'2018-07-01', '2018-10-01', 75, 3000), 
(21, 109, 1007,'2018-11-03', '2019-01-09', 90, 3500); 

INSERT INTO Enrollement( EnrollementID, StudentID, CourseID, Date_Of_Enrollement, End_Of_Enrollement, Marks_Scored, Fees_Paid)
VALUES (22, 110, 1003,'1998-08-23', '1998-11-23', 85, 4000),
(23, 111, 1001,'1998-11-29', '1998-12-27', 70, 6000);

INSERT INTO Enrollement( EnrollementID, StudentID, CourseID, Date_Of_Enrollement, End_Of_Enrollement, Marks_Scored, Fees_Paid)
VALUES (24, 112, 1003,'2001-08-23', '2001-11-23', 75, 3000);

/* 5.	Add DOJ to the student table  */

ALTER TABLE Student
ADD Date_Of_Joining DATE;

UPDATE Student 
SET Date_Of_Joining = '1999-02-12'
WHERE ID = 101;

UPDATE Student 
SET Date_Of_Joining = '2003-04-26'
WHERE ID = 102;

UPDATE Student 
SET Date_Of_Joining = '2006-12-03'
WHERE ID = 103;

UPDATE Student 
SET Date_Of_Joining = '2009-11-23'
WHERE ID = 104;

UPDATE Student 
SET Date_Of_Joining = '2012-10-28'
WHERE ID = 105;


UPDATE Student 
SET Date_Of_Joining = '2014-05-08'
WHERE ID = 106;

UPDATE Student 
SET Date_Of_Joining = '2016-02-24'
WHERE ID = 107;

UPDATE Student 
SET Date_Of_Joining = '2017-07-01'
WHERE ID = 108;

UPDATE Student 
SET Date_Of_Joining = '2018-06-20'
WHERE ID = 109;

UPDATE Student 
SET Date_Of_Joining = '1998-04-02'
WHERE ID = 110;

UPDATE Student 
SET Date_Of_Joining = '1998-06-23'
WHERE ID = 111;

/* 6.	Display all courses along with their prices */

SELECT CourseID, CourseName, Price FROM Course

/* 7.	Show the names and qualification of students who joined after 1-Aug-09 */

SELECT Name, Qualification FROM Student
WHERE Date_Of_Joining > '2009-08-01';

/* 8.	Find the students from Triplicane, Egmore and Mylapore */

SELECT * FROM Student
WHERE Place IN ('Triplicane', 'Egmore', 'Mylapore');

/* 9.	Show the course in descending order with price */

SELECT CourseID, CourseName, Price FROM Course
ORDER BY Price DESC;

/* 10.	Find the students whose name starts with ‘Hari’ */

SELECT * FROM Student
WHERE Name LIKE 'Hari%';

/* 11.	Display the students whose performance has not been evaluated yet */

SELECT * FROM Student S
JOIN(
SELECT StudentID FROM Enrollement
WHERE Marks_Scored IS NULL) AS Enrol ON Enrol.StudentID = S.ID;

/* 12.	Show the course is 5000 to 10000 price range? */

SELECT * FROM Course
WHERE Price BETWEEN 5000 AND 10000;


/* 13.	Set Samuel’s marks to 82 */

DECLARE @ID AS INT = (SELECT ID FROM Student WHERE Name = 'Samuel');

UPDATE Enrollement
SET Marks_Scored = 82
WHERE StudentID = @ID;


/* 14.	Increase the price of all courses by a factor of 10% */

UPDATE Course
SET Price = Price + (Price * 0.1);

/* 15.	Set back Samuel’s marks to NULL */

DECLARE @NID AS INT = (SELECT ID FROM Student WHERE Name = 'Samuel');

UPDATE Enrollement
SET Marks_Scored = NULL
WHERE StudentID = @NID;

/* 16.	Delete course with less than 5000 */


DELETE E FROM Enrollement E
INNER JOIN Course CD
ON CD.CourseID = E.CourseID
WHERE Price < 5000

DELETE Course
WHERE Price < 5000;


/* 17.	Show the places from where there have been enrolments? */

SELECT DISTINCT S.Place FROM Student S
JOIN  Enrollement E
ON E.StudentID = S.ID

/* 18.	Find the no of days each student has been with the institute */

SELECT S.ID, SUM(DATEDIFF(DAY, Date_Of_Enrollement, End_Of_Enrollement)) AS NO_Of_Days FROM Student S
JOIN Enrollement E 
ON E.StudentID = S.ID
GROUP BY S.ID
 
/* 19.	Find the price of the least expensive course */

SELECT MIN(Price) FROM Course

/* 20.	What are the average marks of MCA students with their marks? */

SELECT AVG(MSB.Ms) AS Avg_Marks_of_Mca FROM (
SELECT Marks_Scored AS Ms FROM Enrollement E
JOIN Student S
ON S.ID = E.StudentID
WHERE Qualification = 'MCA' ) AS MSB

/* 21.	When was the last time a student joined a course? */

SELECT StudentID, MAX(Date_Of_Enrollement) FROM Enrollement
GROUP BY StudentID;

/* 22.	Find the number of BE and Anna nagar students that this institute has attracted */

SELECT COUNT(ID) AS No_Of_Students FROM Student 
WHERE Qualification = 'BE' OR Place = 'Anna nagar';

/* 23.	Among the students how many have received their final marks? */

SELECT COUNT(StudentID) AS Student_Rec_Marks FROM Enrollement
WHERE Marks_Scored IS NOT NULL;

/* 24.	How many places do the students come from? */

SELECT COUNT(Std.Place) AS No_Of_Places FROM(
SELECT Place FROM Student
GROUP BY Place) AS Std;

SELECT COUNT(Std.Place) AS No_Of_Places FROM(
SELECT Place FROM Student
GROUP BY Place) AS Std;

/* 25.	Display course, enrolments report */

SELECT C.*,E.StudentID, E.Date_Of_Enrollement, E.End_Of_Enrollement, E.Marks_Scored, E.Fees_Paid FROM Course C
INNER JOIN Enrollement E
ON C.CourseID = E.CourseID
ORDER BY C.CourseID;

/* 26.	Display Education, place and Average marks */

SELECT S.ID,S.Qualification, S.Place, ENS.AVGMark AS AVG_Mark FROM Student S
JOIN(
SELECT StudentID, AVG(Marks_Scored) AS AVGMark FROM Enrollement
GROUP BY StudentID) AS ENS ON ENS.StudentID = S.ID

/* 27.	Show the course with more than 2 enrolments */

SELECT CourseID, COUNT(StudentID) FROM Enrollement
GROUP BY CourseID
HAVING COUNT(StudentID) > 2;

/* 28.	Show the places where at least 2 students enrolled before 1 Aug 99 */

SELECT S.Place, COUNT(S.ID) FROM Student S
JOIN Enrollement E
ON E.StudentID = S.ID
WHERE Date_Of_Enrollement < '1999-08-01' 
GROUP BY S.Place
HAVING COUNT(S.ID) >= 2;

/* 29.	Who are the course mates of Samuel? */

SELECT En.StudentID FROM Enrollement En
JOIN (
SELECT E.CourseID FROM Enrollement E
JOIN(
SELECT ID FROM Student
WHERE Name = 'Samuel') AS STID ON STID.ID = E.StudentID) AS CID ON CID.CourseID = En.CourseID
GROUP BY En.StudentID

/* 30.	List all C++ Students */

SELECT E.StudentID FROM Enrollement E
JOIN Course C
ON C.CourseID = E.CourseID
WHERE CourseName = 'C++';


/* 31.	Give the names and marks of below avg student? */

SELECT S.Name,E.Marks_Scored FROM Student S
JOIN Enrollement E
ON E.StudentID = S.ID
WHERE E.Marks_Scored < 40

/* 32.	Show the students who ended up paying more than 5000 for the course */

SELECT Name, SUM(Fees_Paid) AS 'Amount Paid' FROM Student S
INNER JOIN Enrollement E
ON E.StudentId = S.ID
WHERE E.Fees_Paid > 5000
group by Name
	
/* 33.	Show the marks of students who joined after any anna nagar students */

SELECT E.StudentID, E.Marks_Scored FROM Enrollement E
INNER JOIN Student
ON (ID+1) = E.StudentID
WHERE Place = 'Anna nagar'


/* 34.	Find the course cum place mates of Prabu */



SELECT S.Place,S.ID FROM Student S

INNER JOIN Enrollement E
ON E.StudentID = S.ID
WHERE S.Name = 'Prabu';

SELECT EnId.StudentID FROM Student S
INNER JOIN(
SELECT En.StudentID FROM Enrollement En
JOIN (
SELECT E.CourseID FROM Enrollement E
JOIN(
SELECT ID FROM Student
WHERE Name = 'Prabu') AS STID ON STID.ID = E.StudentID) AS CID ON CID.CourseID = En.CourseID
GROUP BY En.StudentID) AS EnId ON EnId.StudentID = S.ID
WHERE S.Place = (SELECT Place FROM Student
WHERE Name = 'Prabu') ;

SELECT S.ID,S.Name FROM Student S
WHERE S.Place = (SELECT Place FROM Student
WHERE Name = 'Prabu')

SELECT * FROM Enrollement

SELECT En.StudentID FROM Enrollement En
JOIN (
SELECT E.CourseID FROM Enrollement E
JOIN(
SELECT ID FROM Student
WHERE Name = 'Prabu') AS STID ON STID.ID = E.StudentID) AS CID ON CID.CourseID = En.CourseID
FULL JOIN(
SELECT S.ID FROM Student S
WHERE S.Place = (SELECT Place FROM Student
WHERE Name = 'Prabu')) AS StID ON StID.ID = En.StudentID;

/* 35.	Find the students who have the same education as those who have taken the VB */

SELECT S.ID FROM Student S
JOIN(
SELECT E.StudentID FROM Enrollement E
JOIN(
SELECT CourseID FROM Course
WHERE CourseName = 'VB') AS CID ON CID.CourseID = E.CourseID) AS EID ON EID.StudentID = S.ID
GROUP BY Qualification
HAVING COUNT(S.ID) > 1;
