    

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
EmployeeId nvarchar(450), 
[Date] date,
InTime time,
OutTime time,
TotalWorkingTime AS CONVERT(decimal(5,1),DATEDIFF(minute, InTime, OutTime)/60.0),
PRIMARY KEY(ID),
FOREIGN KEY(EmployeeId) REFERENCES AspNetUsers(Id)
)

CREATE TABLE [Break](
ID int Identity,
EntryID int,
BreakIn time,
BreakOut time,
TotalBreakTime AS CONVERT(decimal(5,1),(DATEDIFF( minute, BreakIn, BreakOut)/60.0)),
PRIMARY KEY(ID),
FOREIGN KEY(EntryID)REFERENCES Entry(ID)
)

--Scaffold
/* Scaffold-DbContext 'Server=TRAINEE-05; Database=NTireApp;User Id=SA; Password=harant@26031999;Trusted_Connection=false;MultipleActiveResultSets=true;'
Microsoft.EntityFrameworkCore.SqlServer -OutputDir "Models" -ContextDir "Data" -DataAnnotations
-Tables  AspNetUsers, AspNetUserRoles, AspNetRoles, Entry, Break -f */


