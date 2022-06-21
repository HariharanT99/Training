
Create database InterviewManagement
use InterviewManagement

CREATE TABLE [User] (
  [UserID] int PRIMARY KEY identity,
  [Name] nvarchar(200)
)
GO

CREATE TABLE [Status](
  StatusID tinyint primary key identity,
  [StatusType] varchar(20)
)
GO

CREATE TABLE [Designation](
  DesignationID int PRIMARY KEY,
  Designation varchar(20),
  IsActive bit
)

CREATE TABLE [Applicant] (
  [ApplicantID] int PRIMARY KEY identity,
  [FirstName] nvarchar(24),
  [LastName] nvarchar(24),
  [LastEmployer] nvarchar(50),
  [LastDesignation] nvarchar(20),
  [AppliedFor] int,
  [ReferedBy] nvarchar(150),
  [MedicalStatus] nvarchar(500),
  [NoticePeriod] int,
  [Resume] varchar(200),
  CreatedBy int,
  CreatedOn datetime,
  ModifiedBY int,
  ModifiedOn datetime,
  [IsActive] Bit,
  IsDeleted Bit,
  FOREIGN KEY(AppliedFor) REFERENCES [Designation](DesignationID),
  FOREIGN KEY(CreatedBy) REFERENCES [User](UserID)
)
GO


CREATE TABLE [InterviewRound] (
  [InterviewRoundID] tinyint PRIMARY KEY identity,
  [RoundOrder] tinyint,
  [InterviewRoundName] varchar(30)
)
GO

CREATE TABLE [Interview] (
  [InterviewID] int PRIMARY KEY identity,
  [ApplicantID] int,
  [InterviewRoundID] tinyint,
  [Date] datetime,
  [Result] tinyint,
  FOREIGN KEY ([Result]) REFERENCES [Status](StatusID),
  FOREIGN KEY(ApplicantID) REFERENCES [Applicant](ApplicantID),
  FOREIGN KEY([InterviewRoundID]) REFERENCES [InterviewRound]([InterviewRoundID])
)
GO

CREATE TABLE [Role](
  [RoleID] int PRIMARY KEY identity,
  [Type] nvarchar(150)
)
GO


CREATE TABLE [UserRole](
  [UserRoleID] int PRIMARY KEY,
  [RoleID] int,
  [UserID] int,
  FOREIGN KEY(RoleID) REFERENCES [Role](RoleID),
  FOREIGN KEY(UserID) REFERENCES [User](UserID)
)
GO

CREATE TABLE [Skill] (
  [SkillID] int PRIMARY KEY identity,
  [Name] nvarchar(250),
  [ParentID] int NULL,
  FOREIGN KEY (ParentID) REFERENCES Skill(SkillID)
)
GO

CREATE TABLE [Rating](
  [RatingID] int PRIMARY KEY identity,
  [Value] int,
  Category varchar(20)
)
GO


CREATE TABLE [InterviewerReview] (
  [InterviewerReviewID] int PRIMARY KEY identity,
  [UserID] int,
  [InterviewID] int,
  [Pros] nvarchar(500),
  [Cons] nvarchar(500),
  [Comments] nvarchar(1000),
  [Status] tinyint,
  IsActive Bit,
  FOREIGN KEY ([Status]) REFERENCES [Status](StatusID),
  FOREIGN KEY (InterviewID) REFERENCES Interview(InterviewID),
  FOREIGN KEY(UserID) REFERENCES [User](UserID)
)
GO



CREATE TABLE [SkillRating](
  [SkillRatingID] int PRIMARY KEY,
  [ReviewID] int,
  [SkillID] int,
  [RatingID] int,
  FOREIGN KEY (ReviewID) REFERENCES InterviewerReview(InterviewerReviewID),
  FOREIGN KEY (SkillID) REFERENCES Skill(SkillID),
  FOREIGN KEY (RatingID) REFERENCES Rating(RatingID)
)

