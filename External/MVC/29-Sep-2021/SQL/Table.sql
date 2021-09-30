


CREATE TABLE Gender(
Gender_Id int,
Gender_Name nvarchar(6),
PRIMARY KEY(Gender_id)
)

CREATE TABLE Employee(
Employee_Id int Identity,
Name nvarchar(50),
Gender_Id int,
Date_Of_Birth date,
Address nvarchar(200),
PRIMARY KEY (Employee_Id),
FOREIGN KEY(Gender_Id) REFERENCES Gender(Gender_Id)
)

CREATE TABLE Admin(
Admin_Id int Identity,
Employee_Id int,
PRIMARY KEY(Admin_Id),
FOREIGN KEY(Employee_Id) REFERENCES Employee(Employee_Id)
)

CREATE TABLE TimeEntry(
TE_Id int Identity,
Employee_Id int,
[Date] date,
In_Time datetime,
Out_Time datetime,
Break_In datetime,
Break_Out datetime,
Total_Break AS CONVERT(time,(Break_In - Break_Out)) PERSISTED,
Total_Working AS CONVERT(time,((In_Time - Out_Time) - (Break_In - Break_Out))) PERSISTED,
PRIMARY KEY(TE_Id),
FOREIGN KEY (Employee_Id) REFERENCES Employee(Employee_Id)
)


