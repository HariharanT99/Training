    

CREATE TABLE Gender(
ID int,
Gender nvarchar(6),
PRIMARY KEY(ID)
)


CREATE TABLE Employee(
ID int Identity,
[Name] nvarchar(50),
GenderID int,
Date_Of_Birth date,
Address nvarchar(200),
PRIMARY KEY (ID),
FOREIGN KEY(GenderID) REFERENCES Gender(ID)
)


CREATE TABLE Roll(
ID int Identity,
[Type] int,
PRIMARY KEY(ID),
)

CREATE TABLE Employee_Roll(
RollID int,
EmployeeID int,
FOREIGN KEY (RollID) REFERENCES Roll(ID),
FOREIGN KEY (EmployeeID) REFERENCES Employee(ID)
)


CREATE TABLE Entry(
ID int Identity,
[Date] date,
InTime time,
OutTime time,
PRIMARY KEY(ID)
)

CREATE TABLE [Break](
ID int Identity,
EntryID int,
BreakIn time,
BreakOut time,
PRIMARY KEY(ID),
FOREIGN KEY(EntryID)REFERENCES Entry(ID)
)




