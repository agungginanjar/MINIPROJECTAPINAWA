USE MINIDB
GO
CREATE TABLE [dbo].[APP](
	[id] int IDENTITY(1,1) PRIMARY KEY,
	[AP_REGNO] [varchar](20) NOT NULL,
	[APPTYPEID] [varchar](50) NULL,
	[REGION] [varchar](50) NULL,
	[BRANCHID] [varchar](10) NULL,
	[NIK_REFERENSI] [varchar](20) NULL,
	[NPWP_REFERENSI] [varchar](15) NULL,
	[USERID] [varchar](20) NULL,
	[ACTIVE] [varchar](20) NULL)

	GO
	CREATE TABLE [dbo].[SCUSER](
	[id] int IDENTITY(1,1) PRIMARY KEY,
	[USERID] [varchar](20) NOT NULL,
	[GROUPID] [varchar](20) NULL,
	[SU_FULLNAME] [varchar](300) NULL,
	[SU_ACTIVE] [bit] NULL,)
GO

	GO
	CREATE TABLE [dbo].[CUSTDEBITUR](
	[id] int IDENTITY(1,1) PRIMARY KEY,
	[AP_REGNO] [varchar](20) NOT NULL,
	[CU_NAME] [varchar](50) NULL,
	[CU_CIF] [varchar](50) NULL,
	[CU_DOB] [varchar](10) NULL,
	[CU_POB] [varchar](20) NULL,
	[CU_KTP_NO] [varchar](15) NULL,
	[CU_HP] [varchar](20) NULL,
	[CU_EMAIL] [varchar](20) NULL,
	[CU_NPWP] [varchar](20) NULL,)

