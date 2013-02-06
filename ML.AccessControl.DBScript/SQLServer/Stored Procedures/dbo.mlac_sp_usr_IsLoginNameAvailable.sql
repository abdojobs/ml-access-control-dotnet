SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_usr_IsLoginNameAvailable]
	@pLoginName		VARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT COUNT(*) 
	FROM [mlac_tbl_users] 
	WHERE LOWER([login_name])=LOWER(@pLoginName)
END
GO
