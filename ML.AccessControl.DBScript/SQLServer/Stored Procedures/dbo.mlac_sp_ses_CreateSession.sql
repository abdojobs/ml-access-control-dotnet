SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[mlac_sp_ses_CreateSession]
	@pHash			UNIQUEIDENTIFIER,
	@pUserId		INT,
	@pAccessPoint	NVARCHAR(100),
	@pDateCreated	DATETIME
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [mlac_tbl_sessions]
           ([hash]
           ,[user_id]
           ,[access_point]
           ,[date_created])
     VALUES
           (@pHash
           ,@pUserId
           ,@pAccessPoint
           ,@pDateCreated)

	SELECT SCOPE_IDENTITY()

END
GO
