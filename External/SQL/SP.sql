
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
		IF NOT EXISTS (Select [Date] from [Entry] Where ([Date] = @Date AND EmployeeId = @Id))
		BEGIN 
			Insert INTO [Entry] ([Date], EmployeeId)
			Values (@Date, @Id)
		END
		IF (@Intime IS NOT NULL)
		BEGIN
			Update Entry
			Set Intime = @Intime
			Where Date = @date And EmployeeId = @Id
		END
		ELSE
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
@Id nvarchar(450)
as
BEGIN
	Select e.ID
	,e.EmployeeId
	,e.[Date]
	,e.InTime
	,e.OutTime
	,e.[TotalWorkingTime]
	,b.BreakIn
	,b.BreakOut
	,b.TotalBreakTime
	from [Entry] e
	Join [Break] b
	on e.ID = b.EntryID AND e.EmployeeId = @Id
END

exec uspGetEntryByID '4027c6f0-2bed-4120-8454-e8bf00f00451'


	Select e.ID
	,e.EmployeeId
	,e.[Date]
	,e.InTime
	,e.OutTime
	,e.[TotalWorkingTime]
	,SUM(b.TotalBreakTime) as 'TotalBreakTime'
	from [Entry] e
	Join [Break] b
	on e.ID = b.EntryID AND e.EmployeeId = '4027c6f0-2bed-4120-8454-e8bf00f00451'
	Group By b.EntryID
	,e.ID
	,e.EmployeeId
	,e.[Date]
	,e.InTime
	,e.OutTime
	,e.[TotalWorkingTime]