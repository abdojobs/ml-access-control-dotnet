SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_usr_LoadUserInfo]
	@pUserId INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		 [login_name]
		,[first_name]
		,[last_name]
		,[email] 
	FROM [mlac_tbl_users]
	WHERE [id]=@pUserId

END
GO
