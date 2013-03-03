SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_ses_DeleteSessions]
	@pOlderThanDate		DATETIME
AS
BEGIN
	--SET NOCOUNT ON;

	DELETE FROM [mlac_tbl_sessions]
	WHERE [last_updated] < @pOlderThanDate

END
GO
