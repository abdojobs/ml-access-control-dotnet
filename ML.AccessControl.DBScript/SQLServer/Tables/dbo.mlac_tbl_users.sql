CREATE TABLE [dbo].[mlac_tbl_users]
(
[id] [int] NOT NULL IDENTITY(1, 1)
)
GO
ALTER TABLE [dbo].[mlac_tbl_users] ADD CONSTRAINT [PK_mlac_tbl_users] PRIMARY KEY CLUSTERED  ([id])
GO
