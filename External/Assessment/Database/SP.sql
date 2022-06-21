--Get Locations

CREATE PROC uspGetLocation
as
BEGIN
	Select ID
	,[Name]
	from [Location]
END
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

-- Get Show Time


CREATE PROC uspGetShow
as
BEGIN
	Select ID
	,ShowTime
	from [Time]
END
GO

--Create Booking

CREATE PROC uspCreateBooking
@Date date,
@LocationID int,
@ShowID int,
@No_Of_Seats int,
@TotalAmount money,
@Cancelled bit = 'false'
as
BEGIN
	Insert Into Booking( [Date], LocationID, ShowID, No_Of_Seats, Total_Amount, Cancelled)
	Values (@Date, @LocationID, @ShowID, @No_Of_Seats, @TotalAmount, @Cancelled);
END
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

--Cancel Booking

CREATE PROC uspCancelBooking
@ID int
as
BEGIN
	Update Booking
	Set Cancelled = 'True'
	Where ID = @ID;
END
