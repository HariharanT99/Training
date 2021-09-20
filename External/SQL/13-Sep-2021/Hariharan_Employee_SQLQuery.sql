CREATE DATABASE Employee;

USE Employee;

CREATE TABLE ROLE(
Role_Id INT,
Designation VARCHAR(150),
PRIMARY KEY (Role_Id)
);

CREATE TABLE EmployeeDetails(
Employee_Number  INT,
Employee_Name VARCHAR(100),
Role_Id INT,
Charge_Per_Hr MONEY,
PRIMARY KEY (Employee_Number),
FOREIGN KEY (Role_Id) REFERENCES ROLE(Role_Id)
);


CREATE TABLE ClientDetails(
Client_Number INT,
Client_Name VARCHAR(100),
Client_Address VARCHAR(500),
PRIMARY KEY (Client_Number)
);

CREATE TABLE ProjectDetails(
Project_Number INT,
Project_Name VARCHAR(250),
Project_Description VARCHAR(2000),
Client_Number INT,
PRIMARY KEY (Project_Number),
FOREIGN KEY (Client_Number) REFERENCES ClientDetails(Client_Number)
);


CREATE TABLE WorkDetails(
Work_Id INT,
Employee_Number INT,
Project_Number INT,
Hours_Spent INT,
FOREIGN KEY (Employee_Number) REFERENCES EmployeeDetails(Employee_Number),
FOREIGN KEY (Project_Number) REFERENCES ProjectDetails(Project_Number)
);



INSERT INTO ROLE
VALUES (1, 'Developer');
INSERT INTO ROLE
VALUES (2, 'Testor'); 
INSERT INTO ROLE
VALUES (3, 'Management'); 

INSERT INTO EmployeeDetails
VALUES (224, 'Madhan Kumar',1,15);
INSERT INTO EmployeeDetails
VALUES (225, 'Jeeva',1,16);
INSERT INTO EmployeeDetails
VALUES (229, 'Vishnu',2,8);
INSERT INTO EmployeeDetails
VALUES (226, 'Vanitha',3,15);

INSERT INTO ClientDetails
VALUES (1, 'Client-1', 'London');

INSERT INTO ProjectDetails
VALUES (1,'Food-Management', 'Example Discription', 1);

INSERT INTO WorkDetails
VALUES (1,224, 1, 10);
INSERT INTO WorkDetails
VALUES (1,225, 1, 10);
INSERT INTO WorkDetails
VALUES (1,229, 1, 10);
INSERT INTO WorkDetails
VALUES (1,226, 1, 10);



