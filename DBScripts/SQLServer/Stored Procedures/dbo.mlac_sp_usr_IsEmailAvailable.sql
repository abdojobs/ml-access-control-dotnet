SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_usr_IsEmailAvailable]
	@pEmail		NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT COUNT(*) 
	FROM [mlac_tbl_users] 
	WHERE LOWER([email])=LOWER(@pEmail)
END
GO
