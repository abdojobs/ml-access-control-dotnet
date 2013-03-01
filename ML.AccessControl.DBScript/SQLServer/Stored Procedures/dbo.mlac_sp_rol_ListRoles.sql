
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_rol_ListRoles]
	@pListHidden BIT=NULL
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [id]
      ,[name]
      ,[is_system]
      ,[is_deletable]
      ,[is_hidden]
	FROM [mlac_tbl_roles]
	WHERE (@pListHidden IS NULL OR [is_hidden]=@pListHidden)

END
GO
