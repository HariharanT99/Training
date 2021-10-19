
CREATE TABLE [Employee] (
  [ID] int PRIMARY KEY identity,
  [Name] nvarchar(200)
)
GO

CREATE TABLE [Applicant] (
  [ID] int PRIMARY KEY identity,
  [Name] nvarchar(100),
  [LastEmployer] nvarchar(250),
  [LastDesignation] nvarchar(250),
  [AppliedFor] nvarchar(200),
  [ReferedBy] nvarchar(150),
  [MedicalStatus] nvarchar(500),
  [NoticePeriod] int,
  [Resume] varchar(200),
  CreatedBy int,
  CreatedOn datetime,
  ModifiedBY int,
  ModifiedOn datetime,
  IsActive Bit,
  IsDeleted Bit,
  FOREIGN KEY(CreatedBy) REFERENCES Employee(ID)
)
GO


CREATE TABLE [Assessment] (
  [ID] int PRIMARY KEY identity,
  [Name] nvarchar(250)
)
GO

CREATE TABLE [Interview] (
  [ID] int PRIMARY KEY identity,
  [ApplicantID] int,
  [AssessmentID] int,
  [Date] datetime,
  [Result] nvarchar(50),
  FOREIGN KEY(ApplicantID) REFERENCES [Applicant](ID),
  FOREIGN KEY([AssessmentID]) REFERENCES [Assessment](ID)
)
GO

CREATE TABLE [Role](
  [ID] int PRIMARY KEY identity,
  [Type] nvarchar(150)
)
GO


CREATE TABLE [EmployeeRole](
  [RoleID] int,
  [EmployeeID] int
  FOREIGN KEY(RoleID) REFERENCES [Role](ID),
  FOREIGN KEY(EmployeeID) REFERENCES [Employee](ID)
)
GO

CREATE TABLE [Skill] (
  [ID] int PRIMARY KEY identity,
  [Name] nvarchar(250),
  [ParentID] int NULL,
  FOREIGN KEY (ParentID) REFERENCES Skill(ID)
)
GO

CREATE TABLE [Rating](
  [ID] int PRIMARY KEY identity,
  [Value] int,
  Category varchar(20)
)
GO

CREATE TABLE [InterviewerReview] (
  [EmployeeID] int,
  [InterviewID] int,
  [Pros] nvarchar(500),
  [Cons] nvarchar(500),
  [Comments] nvarchar(1000),
  [Status] varchar(20),
  [SkillID] int,
  [RatingID] int,
  IsActive Bit,
  FOREIGN KEY (InterviewID) REFERENCES Interview(ID),
  FOREIGN KEY(EmployeeID) REFERENCES Employee(ID),
  FOREIGN KEY (SkillID) REFERENCES Skill(ID),
  FOREIGN KEY (RatingID) REFERENCES Rating(ID)
)
GO




