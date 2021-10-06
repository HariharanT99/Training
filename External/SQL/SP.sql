
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
		ELSE
		BEGIN
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
END

EXEC uspInsertEntry @Date = '2020-12-16',@Id= 'f62ffc69-6b9b-4a5a-b230-63f385d1d0bf', @Intime = '8:30' 

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

EXEC uspInsertPeviousEntry '2020-12-17', 'f62ffc69-6b9b-4a5a-b230-63f385d1d0bf', '08:00', '18:30'
--Get Entry by ID

CREATE PROC uspGetEntryByID
@Id nvarchar(450)
as
BEGIN
	Select ID
	,EmployeeId
	,[Date]
	,InTime
	,OutTime
	from [Entry]
	Where EmployeeId = @Id
END


select au.Id, au.Name, au.Email, ar.Name from AspNetUsers au
Join AspNetUserRoles aur
on au.Id = aur.UserId and au.Email = 'harit@gmail.com'
join AspNetRoles ar
on aur.RoleId = ar.Id