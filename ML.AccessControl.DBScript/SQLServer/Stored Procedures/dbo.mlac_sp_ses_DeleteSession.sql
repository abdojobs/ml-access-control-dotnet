SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_ses_DeleteSession]
	@pSessionGuid			UNIQUEIDENTIFIER
AS
BEGIN
	--SET NOCOUNT ON;

	DELETE FROM [mlac_tbl_sessions]
	WHERE [hash]=@pSessionGuid

END
GO
