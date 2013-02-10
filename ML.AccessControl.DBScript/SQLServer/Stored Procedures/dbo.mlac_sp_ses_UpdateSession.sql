SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_ses_UpdateSession]
	@pLastUpdated		DATETIME,
	@pSessionGuid		UNIQUEIDENTIFIER
AS
BEGIN
	--SET NOCOUNT ON;

	UPDATE [mlac_tbl_sessions]
	SET [last_updated]=@pLastUpdated
	WHERE [hash] = @pSessionGuid

END
GO
