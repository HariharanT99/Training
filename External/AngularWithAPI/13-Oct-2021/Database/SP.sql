
--Insert Applicant

CREATE PROC uspInsertApplicant
@Name nvarchar(100)
,@LastEmployer nvarchar(250)
,@LastDesignation nvarchar(250)
,@AppliedFor nvarchar(200)
,@ReferedBy nvarchar(150)
,@MedicalStatus nvarchar(500)
,@NoticePeriod int
,@Resume varchar(200)
,@Active bit = 1
,@Deleted bit = 0
as
BEGIN
	Insert Into Applicant ( [Name]
							,[LastEmployer]
							,[LastDesignation]
							,[AppliedFor]
							,[ReferedBy]
							,[MedicalStatus]
							,[NoticePeriod]
							,[Resume]
							,IsActive
							,IsDeleted)
	Values ( @Name
			 ,@LastEmployer
			 ,@LastDesignation
			 ,@AppliedFor
			 ,@ReferedBy
			 ,@MedicalStatus
			 ,@NoticePeriod
			 ,@Resume
			 ,@Active
			 ,@Deleted)
END

--Get all applicants

CREATE PROC uspGetApplicants
as
BEGIN
	Select ID
      ,[Name]
      ,[LastEmployer]
      ,[LastDesignation]
      ,[AppliedFor]
      ,[ReferedBy]
      ,[MedicalStatus]
      ,[NoticePeriod]
      ,[Resume]
      ,[CreatedBy]
      ,[CreatedOn]
      ,[ModifiedBY]
      ,[ModifiedOn]
      ,[IsActive]
      ,[IsDeleted]
	From Applicant
	Where IsActive = 1 AND IsDeleted = 0
END

exec uspGetApplicants