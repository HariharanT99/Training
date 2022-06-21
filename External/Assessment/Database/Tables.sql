CREATE DATABASE TicketManagement

USE TicketManagement

CREATE TABLE [Location](
	ID int PRIMARY KEY identity(100,1),
	[Name] varchar(100)
)

CREATE TABLE [Time](
	ID int PRIMARY KEY identity,
	[Time] time
)

CREATE TABLE Movie(
	ID int PRIMARY KEY identity,
	[Name] nvarchar(100)
)

CREATE TABLE Show(
	ID int PRIMARY KEY identity,
	TimeID int,
	MovieID int,
	FOREIGN KEY(TimeID) REFERENCES [Time](ID),
	FOREIGN KEY(MovieID) REFERENCES Movie(ID)
)

CREATE TABLE Seat(
	ID int PRIMARY KEY identity,
	Row_No char,
	Column_no int
)

CREATE TABLE Booking(
	ID int PRIMARY KEY identity(10000,1),
	[Date] date,
	LocationID int,
	ShowID int,
	No_Of_Seats int,
	Total_Amount money,
	Cancelled bit,
	FOREIGN KEY(LocationID) REFERENCES [Location](ID),
	FOREIGN KEY(ShowID) REFERENCES Show(ID)
)

CREATE TABLE Booking_Seat(
	BookingID int,
	SeatID int,
	FOREIGN KEY(BookingID) REFERENCES Booking(ID),
	FOREIGN KEY(SeatID) REFERENCES Seat(ID)
)

INSERT INTO Movie([Name])
Values('Kala'),
('Thuppaki'),
('VIP'),
('End Game'),
('Black Panther'),
('Theri'),
('Vikram'),
('Maya');

INSERT INTO [Location]([Name])
Values ('Adayar'),
('T.Nagar'),
('Velachery'),
('Porur'),
('Anna Nagar'),
('Pallavaram'),
('Egmore'),
('Triplicane');

INSERT INTO Booking( Date, LocationID, ShowID, No_Of_Seats, Total_Amount, Cancelled)
Values ('2021-10-22', 103, 14, 6, 660.00,'false'),
('2021-10-28', 104, 01, 3, 330.00,'false'),
('2021-10-01', 100, 05, 8, 880.00,'false'),
('2021-10-03', 105, 32, 2, 220.00,'false'),
('2021-10-26', 102, 20, 1, 110.00,'false'),
('2021-10-25', 107, 19, 6, 660.00,'false'),
('2021-10-30', 104, 11, 3, 330.00,'true'),
('2021-11-01', 105, 15, 6, 660.00,'false'),
('2021-10-14', 102, 18, 8, 880.00,'false'),
('2021-10-10', 104, 19, 2, 220.00,'false'),
('2021-10-09', 108, 13, 5, 550.00,'false');

