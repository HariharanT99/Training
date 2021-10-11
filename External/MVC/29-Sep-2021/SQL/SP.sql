
use NTireApp;

CREATE PROC uspGetEmployee
@Email nvarchar(50)
as
BEGIN
	Select Id
	,[Name]
	,Email
	,Gender
	,Date_Of_Birth
	,[Address]
	from AspNetUsers 
	Where @Email IS NULL OR Email = @Email
END


CREATE PROC uspInsertEntry
@Date date,
@Id nvarchar(450),
@Intime time = NULL,
@Outtime time = NUlL
as 
BEGIN
	SET NOCOUNT ON
	IF (@Date IS NOT NULL AND @Id IS NOT NULL)
	BEGIN
		IF NOT EXISTS (Select 1 from [Entry] Where ([Date] = @Date AND EmployeeId = @Id))
		BEGIN 
			Insert INTO [Entry] ([Date], EmployeeId)
			Values (@Date, @Id)
			IF (@Intime IS NOT NULL)
			BEGIN
				Update Entry
				Set Intime = @Intime
				Where Date = @date And EmployeeId = @Id
			END
		END
		IF (@Outtime IS NOT NULL)
		BEGIN
			Update Entry
			Set Outtime = @Outtime
			Where [Date] = @Date AND EmployeeId = @Id
		END
		
	END
END

EXEC uspInsertEntry @Date = '2020-12-18',@Id= '4027c6f0-2bed-4120-8454-e8bf00f00451', @Intime = '8:30' 

--Insert Previous Entry

CREATE PROC uspInsertPeviousEntry
@Date date,
@Id nvarchar(450),
@Intime time,
@Outtime time
as 
BEGIN
	SET NOCOUNT ON
	IF NOT EXISTS (Select [Date] from [Entry] Where ([Date] = @Date AND EmployeeId = @Id))
	BEGIN 
		Insert INTO [Entry] ([Date], EmployeeId, InTime, OutTime)
		Values (@Date, @Id, @Intime, @OutTime)
	END
END

EXEC uspInsertPeviousEntry '2020-12-17', '4027c6f0-2bed-4120-8454-e8bf00f00451', '08:00', '18:30'

--Get Entry by ID

CREATE PROC uspGetEntryByID
@Id nvarchar(450),
@Month int
as
BEGIN
	With cteBreak (EntryId, TotalBreakTime)
	as(
		Select EntryID
		,Sum(TotalBreakTime)
		from [Break]
		Group By EntryID )
	
		Select e.[Date]
		,e.InTime
		,e.OutTime
		,(e.TotalWorkingTime - b.TotalBreakTime) as TotalWorkingTime
		,b.TotalBreakTime
		from [Entry] e
		Join cteBreak b
		on e.ID = b.EntryId AND e.EmployeeId = @Id And DATEPART(month,e.[Date]) = @Month
END

exec uspGetEntryByID '4027c6f0-2bed-4120-8454-e8bf00f00451', 10


--Get Entry By EmployeeId and Break


CREATE PROC uspGetEntryByID_Date
@Id nvarchar(450),
@Date date
as
BEGIN
	Select ID
	from [Entry]
	Where EmployeeId = @Id AND Date = @Date;
END

exec uspGetEntryByID_Date '4027c6f0-2bed-4120-8454-e8bf00f00451','2021-10-11'

--Set Break

CREATE PROC uspSetFormBreak
@EntryId int,
@BreakIn time,
@BreakOut time
as
BEGIN
	Insert INTO [Break] (EntryID,BreakIn,BreakOut)
	Values (@EntryId,@BreakIn,@BreakOut)
END

exec uspSetFormBreak 2,'12:30','12:14'

--Get Employees entry by date (Admin Dashboard)

CREATE PROC uspGetEmployeesByDate
@Date date
as
BEGIN
	With Breakcte (EntryId, TotalBreakTime)
	as(
		Select EntryID
		,Sum(TotalBreakTime)
		from [Break]
		Group By EntryID )
	
		Select ans.[Name]
		,e.InTime
		,e.OutTime
		,(e.TotalWorkingTime - b.TotalBreakTime) as TotalWorkingTime
		,b.TotalBreakTime
		from [Entry] e
		Join AspNetUsers ans
		On e.EmployeeId = ans.Id AND e.[Date] = @Date
		Join Breakcte b
		On e.ID = b.EntryID
END

exec uspGetEmployeesByDate '2021-10-07'

--Get Employees present Today

CREATE PROC uspEmployeePresentToday
as
BEGIN
	Select COUNT(ID) as PresentEmployees
	from [Entry]
	Where [Date] = CONVERT(date, getdate())
END

exec uspEmployeePresentToday 


--Set Break Start Time (Current day entry)

CREATE PROC uspSetBreakStart
@EntryId int,
@StartTime time
as
BEGIN
	Insert INTO [Break](EntryID,BreakIn)
	Values(@EntryId,@StartTime)
END

--Set Workoff Time

CREATE PROC uspSetWorkOff
@WorkOff time,
@Emp_Id nvarchar(450),
@Date date
as
BEGIN
	Update [Entry]
	Set OutTime = @WorkOff
	Where [Date] = @Date AND EmployeeId = @Emp_Id
END


--Get the active employees

CREATE PROC uspGetActiveEmployee
as 
BEGIN
	WITH ActiveEmployeecte (EntryId)
	as(
		Select Distinct b.EntryID
		from [Break] b
		Join [Entry] e
		On b.EntryID = e.ID AND e.[Date] = CONVERT(date, getdate())
		Where (b.BreakIn IS NULL OR b.BreakOut IS NOT NULL))

		Select COUNT(EntryId) as ActiveEmployees
		from ActiveEmployeecte
END


EXEC uspGetActiveEmployee