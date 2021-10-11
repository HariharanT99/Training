    
CREATE TABLE [Entry](
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


