CREATE DATABASE SepDatabase

Use sepDatabase;

CREATE TABLE Employee(
EmployeeId INT,
EmployeeName VARCHAR(100),
Street VARCHAR(250),
City VARCHAR(150),
PRIMARY KEY(EmployeeId)
);

CREATE TABLE Company(
CompanyId INT,
CompanyName VARCHAR(150),
City VARCHAR(150),
PRIMARY KEY(CompanyId)
);

CREATE TABLE Works(
WorkId INT,
EmployeeId INT,
CompanyId INT,
Salary MONEY,
PRIMARY KEY(WorkId),
FOREIGN KEY(EmployeeId) REFERENCES Employee(EmployeeId),
FOREIGN KEY(CompanyId) REFERENCES Company(CompanyId),
);



CREATE TABLE Managers(
ManagerId INT,
ManagerName VARCHAR(100),
Street VARCHAR(250),
City VARCHAR(150),
PRIMARY KEY (ManagerId),
);


CREATE TABLE EmployeeManager(
EMId INT,
EmployeeId INT,
ManagerId INT,
PRIMARY KEY (EMId),
FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
FOREIGN KEY (ManagerId) REFERENCES Managers(ManagerId)
);

INSERT INTO Employee  
VALUES (0,'Sanjay','MainRoad', 'Kumbakonam');

INSERT INTO Employee  
VALUES (1,'Hari','Bank Road', 'Kumbakonam');
INSERT INTO Employee  
VALUES (2,'Ram','South Street', 'Thanjavur');
INSERT INTO Employee  
VALUES (3,'Zara','West Street', 'Trichy');
INSERT INTO Employee  
VALUES (4,'Jeo','Tambaram', 'Chennai');
INSERT INTO Employee  
VALUES (5,'Sam','Police Station Street', 'Kumbakonam');
INSERT INTO Employee  
VALUES (6,'Hannah','Post Office Street', 'Trichy');
INSERT INTO Employee  
VALUES (7,'Raghul','Down Street', 'Thanjavur');

INSERT INTO Company  
VALUES (0,'First Bank Corporation', 'Kumbakonam');
INSERT INTO Company  
VALUES (1,'City Bank LTD', 'Trichy');
INSERT INTO Company  
VALUES (2,'New Textile', 'Trichy');
INSERT INTO Company  
VALUES (3,'NO1 Steels', 'Thanjavur');

INSERT INTO Managers  
VALUES (0, 'Raju','Post Office Street', 'Trichy');
INSERT INTO Managers  
VALUES (1, 'Jhon','Down Street', 'Thanjavur');
INSERT INTO Managers  
VALUES (2, 'Ramesh','Police Station Street', 'Kumbakonam');
INSERT INTO Managers  
VALUES (3, 'Bala','North Street', 'Trichy');
INSERT INTO Managers  
VALUES (4, 'Karthi','Sannadhi Street', 'Kumbakonam');

INSERT INTO Works  
VALUES (0,1,0,12000);
INSERT INTO Works  
VALUES (1,0,0,9000);
INSERT INTO Works  
VALUES (2,4,1,15000);
INSERT INTO Works  
VALUES (3,3,2,8000);
INSERT INTO Works  
VALUES (4,2,2,10000);
INSERT INTO Works  
VALUES (5,7,0,10000);
INSERT INTO Works  
VALUES (6,5,1,10000);
INSERT INTO Works  
VALUES (7,6,3,10000);



INSERT INTO EmployeeManager
VALUES (0, 0, 2);
INSERT INTO EmployeeManager
VALUES (1, 1, 4);
INSERT INTO EmployeeManager
VALUES (2, 6, 1);
INSERT INTO EmployeeManager
VALUES (3, 4, 3);
