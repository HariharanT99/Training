/* 1.	Find the names, street address, and cities of residence for all employees who work for
'First Bank Corporation' and earn more than $10,000*/


SELECT Employee.EmployeeName, Employee.Street, Employee.City, Works.Salary
FROM Employee
INNER JOIN Works ON Employee.EmployeeId = Works.EmployeeId
INNER JOIN Company ON Company.CompanyId = Works.CompanyId
WHERE Works.Salary > 10000 AND Company.CompanyName = 'First Bank Corporation';


/* 2.	Find the names of all employees in the database who live in the same cities as the
companies for which they work. */

SELECT EmployeeName FROM Employee
INNER JOIN Works ON Employee.EmployeeId = Works.EmployeeId
INNER JOIN Company ON Company.CompanyId = Works.CompanyId
WHERE Employee.City = Company.City;


/* 3.	Find the names of all employees in the database who live in the same cities and on the
same streets as do their managers.
*/

SELECT EmployeeName FROM Employee e
INNER JOIN EmployeeManager ON EmployeeManager.EmployeeId = e.EmployeeId
INNER JOIN Managers m ON m.ManagerId = EmployeeManager.ManagerId
Where e.City = m.City AND e.Street = m.Street;

/* 4.	Find the names of all employees in the database who do not work for 'First Bank
Corporation'. Assume that all people work for exactly one company. */

SELECT e.EmployeeName
FROM Employee E
INNER JOIN Works W ON E.EmployeeId = W.EmployeeId
INNER JOIN Company C ON C.CompanyId = W.CompanyId
WHERE C.CompanyName != 'First Bank Corporation';

/* 5.	Assume that the companies may be located in several cities. Find all companies
located in every city in which 'Small Bank Corporation' is located. */







/* 6.	Find the names of all employees who earn more than the average salary of all
employees of their company. Assume that all people work for at most one company. */

SELECT E.EmployeeName, W.Salary, C.CompanyName FROM Employee E
INNER JOIN Works W ON W.EmployeeId = E.EmployeeId
INNER JOIN Company C ON C.CompanyId = W.CompanyId

INNER JOIN (
SELECT C.CompanyName, AVG(W.Salary) AS SAL
FROM Works W
INNER JOIN Employee E ON W.EmployeeId = E.EmployeeId
INNER JOIN Company C ON C.CompanyId = W.CompanyId
GROUP BY CompanyName ) AS AVGSAL ON AVGSAL.CompanyName = C.CompanyName AND W.Salary > AVGSAL.SAL


HAVING (SELECT w.Salary FROM Employee E
INNER JOIN Works W ON W.EmployeeId = E.EmployeeId) > AVG(W.Salary)

--WHERE W.Salary > 10000 AND Company.CompanyName = 'First Bank Corporation';

/*WHERE (SELECT AVG(W.Salary)
FROM Works W
INNER JOIN Company C ON C.CompanyId = W.CompanyId
GROUP BY CompanyName
) < W.Salary*/

/* 7.	Find the name of the company that has the smallest payroll. */

SELECT C.CompanyName,SUM(W.Salary)
FROM Works W
INNER JOIN Employee E ON W.EmployeeId = E.EmployeeId
INNER JOIN Company C ON C.CompanyId = W.CompanyId
GROUP BY CompanyName
HAVING SUM(W.Salary) = MIN(W.Salary)