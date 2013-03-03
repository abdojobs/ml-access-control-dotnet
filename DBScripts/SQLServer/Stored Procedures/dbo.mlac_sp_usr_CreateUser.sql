SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_usr_CreateUser]
	@pLoginName		VARCHAR(100),
	@pPasswordHash	VARCHAR(100),
	@pFirstName		NVARCHAR(100),
	@pLastName		NVARCHAR(100),
	@pEmail			NVARCHAR(100),
	@pCreatedOn		DATETIME,
	@pIsActive		BIT
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [mlac_tbl_users]
		   ([login_name]
		   ,[password_hash]
		   ,[first_name]
		   ,[last_name]
		   ,[email]
		   ,[created_on]
		   ,[is_active])
	VALUES
		   (@pLoginName
		   ,@pPasswordHash
		   ,@pFirstName
		   ,@pLastName
		   ,@pEmail
		   ,@pCreatedOn
		   ,@pIsActive)
	
	SELECT SCOPE_IDENTITY()

END
GO
