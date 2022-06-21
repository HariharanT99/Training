--Get Locations

CREATE PROC uspGetLocation
as
BEGIN
	Select ID
	,[Name]
	from [Location]
END
GO

Exec uspGetLocation
GO

--Get Movies


CREATE PROC uspGetMovie
as
BEGIN
	Select ID
	,[Name]
	from Movie
END
GO

Exec uspGetMovie
GO

-- Get Show Time


CREATE PROC uspGetShow
as
BEGIN
	Select ID
	,ShowTime
	from [Time]
END
GO

Exec uspGetShow
GO

--Create Booking

CREATE PROC uspCreateBooking
@Date date,
@LocationID int,
@MovieID int,
@TimeID int,
@No_Of_Seats int,
@TotalAmount money,
@Cancelled bit = 'false'
as
BEGIN
	--First Get ShowId respected to selected Movie and Time.
	DECLARE @ShowID int = (Select ID
						from [Show]
						Where MovieID = @MovieID AND TimeID = @TimeID)
	IF (@No_Of_Seats > 0)
	BEGIN
		--Insert the Booking Deatils
		Insert Into Booking( [Date], LocationID, ShowID, No_Of_Seats, Total_Amount, Cancelled)
		Values (@Date, @LocationID, @ShowID, @No_Of_Seats, @TotalAmount, @Cancelled);
	END
	ELSE
	BEGIN
		Print ('Number of seatd should be more than 0');
	END
END
GO

EXEC uspCreateBooking '2021-10-12',100, 1, 2, 1, 110, 'false';
GO

--Get Bookings

CREATE PROC uspGetBooking
as
BEGIN
	Select ID
	,[Date]
	,LocationID
	,ShowID
	,No_Of_Seats
	,Total_Amount
	,Cancelled
	from Booking
END
GO

Exec uspGetBooking
GO

--Cancel Booking

CREATE PROC uspCancelBooking
@ID int,
@Date date,
@Time time
as
BEGIN
	IF ((@Date >= Cast(GETDATE() as Date)) AND (@Time <= Cast( GETDATE() as Time)))
	BEGIN
		Update Booking
		Set Cancelled = 'True'
		Where ID = @ID;
	END
	ELSE
	BEGIN
		Print 'Should not able to cancle the current and past Bookings'
	END
END

Print(Cast( GETDATE() as Time))
