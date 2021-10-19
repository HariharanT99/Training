
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
as
BEGIN
	Insert Into Applicant ( [Name]
							,[LastEmployer]
							,[LastDesignation]
							,[AppliedFor]
							,[ReferedBy]
							,[MedicalStatus]
							,[NoticePeriod]
							,[Resume])
	Values ( @Name
			 ,@LastEmployer
			 ,@LastDesignation
			 ,@AppliedFor
			 ,@ReferedBy
			 ,@MedicalStatus
			 ,@NoticePeriod
			 ,@Resume)
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
      ,[IsActive]
	From Applicant
	Where Is