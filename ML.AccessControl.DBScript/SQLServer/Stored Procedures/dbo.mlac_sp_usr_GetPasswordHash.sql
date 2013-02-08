SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_usr_GetPasswordHash]
	@pLoginName		VARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [id],[password_hash] 
	FROM [mlac_tbl_users] WHERE 
	LOWER([login_name])=LOWER(@pLoginName);
END
GO
