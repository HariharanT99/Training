


CREATE TABLE Gender(
GenderId INT,
Gender VARCHAR(6),
PRIMARY KEY(GenderId));

CREATE TABLE Employee(
Id INT,
FirstName VARCHAR(100),
LastName VARCHAR(100),
DateOfBirth DATE,
Designation VARCHAR(150),
GenderId INT,
Salary DECIMAL,
PRIMARY KEY (Id),
FOREIGN KEY (GenderId) REFERENCES Gender(GenderId));


CREATE TABLE Salary_Management(
SM_Id INT,
Hike_Cut VARCHAR(4),
Percentage INT,
Valid_Till DATE,
PRIMARY KEY(SM_Id));


CREATE TABLE Employee_Salary(
EmployeeId INT,
SM_Id INT,
FOREIGN KEY (EmployeeId) REFERENCES Employee(Id),
FOREIGN KEY (SM_Id) REFERENCES Salary_Management(SM_Id));

CREATE TABLE Skill(
Skill_Id INT,
Skill_Name VARCHAR(150),
PRIMARY KEY (Skill_Id));

CREATE TABLE Employee_Skill(
EmployeeId INT,
Skill_Id INT,
FOREIGN KEY (EmployeeId) REFERENCES Employee(Id),
FOREIGN KEY (Skill_Id) REFERENCES Skill(Skill_Id));


CREATE TABLE Project(
Project_Id INT,
Project_Name VARCHAR(150),
Budget DECIMAL,
Total_Sale DECIMAL,
PRIMARY KEY (Project_Id));


CREATE TABLE Employee_Project(
EmployeeId INT,
Project_Id INT,
FOREIGN KEY (EmployeeId) REFERENCES Employee(Id),
FOREIGN KEY (Project_Id) REFERENCES Project(Project_Id));


CREATE TABLE Target(
Target_Id INT,
Project_Id INT,
Increase_Percentage INT,
Before_that DATE,
PRIMARY KEY (Target_Id),
FOREIGN KEY (Project_Id) REFERENCES Project(Project_Id));


INSERT INTO Gender
VALUES (1, 'Male'),
(2,'Female');

INSERT INTO Employee ( Id, FirstName, LastName, DateOfBirth, Designation, GenderId, Salary)
VALUES(101 , 'Niveditha', NULL, '1993-06-21', 'Secretary',2, 20000),
(102 , 'Sudeesh', 'Patnaik', '1989-04-11', 'Programmer',1, 43000),
(103 , 'Ramesh', 'Nair', '1975-08-23', 'Programmer',1, 35000),
(104 , 'Rupavahini', 'Babu', '1988-12-10', 'Programmer',2, 43000),
(105 , 'Ravinder', 'Singh', '1983-04-24', 'QA',1, 40000),
(106 , 'Lalith', NULL, '1991-05-13', 'DBA',1, 30000),
(107 , 'Kiran', 'Gopal', '1997-04-11', 'Programmer',1, 20000),
(108 , 'Ragu', 'Ram', '1996-08-23', 'Programmer',1, 20000),
(109 , 'Dany', 'Joseph', '1998-12-10', 'Programmer',1, 20000),
(110 , 'Jeo', 'Joel', '1999-04-24', 'Programmer',1, 20000),
(111 , 'Raghul', NULL, '1996-05-13', 'Programmer',1, 20000),
(112 , 'Jack', 'Jones', '1982-04-24', 'Senior Programmer',1, 42000),
(113 , 'Zara', NULL, '1986-05-13', 'Senior Programmer',2, 44000),
(114 , 'Bala', 'Kumar', '1983-04-24', 'QA',1, 40000);

INSERT INTO Employee ( Id, FirstName, LastName, DateOfBirth, Designation, GenderId, Salary)
VALUES(115 , 'Arun', 'Kumar', '1979-06-21', 'Secretary',1, 120000),
(116 , 'Zara', 'Samueal', '1989-04-11', 'Programmer',2, 110000),
(117 , 'Cambline', 'Nishok', '1975-08-23', 'Programmer',1, 105000);


/* 1. Categorize employees on age group*/

WITH Employee_Age_Group (Emp_Id, Age) as
(
SELECT Id, DATEDIFF(year, DateOfBirth, GETDATE()) FROM Employee
)

SELECT COUNT(CASE WHEN (age < 18) THEN Emp_Id ELSE null END)                AS "Under_18",
       COUNT(CASE WHEN (age >= 18 AND age <= 29) THEN Emp_Id ELSE null END) AS "18-29",
       COUNT(CASE WHEN (age >= 30 AND age <= 39) THEN Emp_Id ELSE null END) AS "30-39",
	   COUNT(CASE WHEN (age >= 40 AND age <= 49) THEN Emp_Id ELSE null END) AS "40-49",
	   COUNT(CASE WHEN (age > 49) THEN Emp_Id ELSE null END)                AS "Above_50"
FROM Employee_Age_Group


/* 2. Categorize based on gender and salary. */

SELECT GenderId,"Max. Salary"=max(salary)
FROM Employee
GROUP BY GenderId;


SELECT GenderId, COUNT(CASE WHEN (salary < 10000) THEN Id ELSE null END)                AS "Under_10K",
       COUNT(CASE WHEN (salary >= 10000 AND salary < 20000) THEN Id ELSE null END) AS "10k-20k",
       COUNT(CASE WHEN (salary >= 20000 AND salary < 30000) THEN Id ELSE null END) AS "20k-30k",
	   COUNT(CASE WHEN (salary >= 30000 AND salary < 40000) THEN Id ELSE null END) AS "30k-40k",
	   COUNT(CASE WHEN (salary >= 40000 AND salary <= 50000) THEN Id ELSE null END) AS "40k-50k",
	   COUNT(CASE WHEN (salary > 50000) THEN Id ELSE null END)                AS "Above_50"
FROM Employee
GROUP BY GenderId;

/* 3. Employees list with first and last name who are above 40 */

SELECT (FirstName+' '+LastName) as Name FROM Employee
WHERE DATEDIFF(year, DateOfBirth, GETDATE()) > 40;

/* 4. Nivedhitha got married to Saravanan and wants her last name to be updated. */

BEGIN TRY
BEGIN TRAN
UPDATE Employee
SET LastName = 'Saravanan'
WHERE FirstName = 'Nivedhitha'
COMMIT TRAN
END TRY
BEGIN CATCH
Print('Error')
ROLLBACK TRAN
END CATCH

/* 5. Programmers designation to be changed to "Jr. Programmers" and Senior Programmers to "Sr. Programmers" (in a single query) */

UPDATE Employee SET designation = 
CASE 
    WHEN Designation = 'Programmer' THEN 'Jr. Programmer'
    WHEN Designation = 'Senior Programmer' THEN 'Sr. Programmer'
    ELSE designation
END


/* 28. Write a SQL statement to insert rows into the table called high achiever (Name, Age), Where a sales person must have salary of 1,00,000 or above */

CREATE TABLE High_Achiever(
Name VARCHAR(100),
Age INT,
);

INSERT INTO High_Achiever
SELECT (FirstName+' '+LastName), DATEDIFF(year, DateOfBirth, GETDATE()) FROM Employee
WHERE Salary > 100000;

select * from High_Achiever