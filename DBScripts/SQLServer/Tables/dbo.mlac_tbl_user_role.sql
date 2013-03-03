CREATE TABLE [dbo].[mlac_tbl_user_role]
(
[user_id] [int] NOT NULL,
[role_id] [int] NOT NULL
)
GO
ALTER TABLE [dbo].[mlac_tbl_user_role] ADD CONSTRAINT [PK_mlac_tbl_user_role] PRIMARY KEY CLUSTERED  ([user_id], [role_id])
GO
ALTER TABLE [dbo].[mlac_tbl_user_role] ADD CONSTRAINT [FK_mlac_tbl_user_role_mlac_tbl_roles] FOREIGN KEY ([role_id]) REFERENCES [dbo].[mlac_tbl_roles] ([id])
GO
ALTER TABLE [dbo].[mlac_tbl_user_role] ADD CONSTRAINT [FK_mlac_tbl_user_role_mlac_tbl_users] FOREIGN KEY ([user_id]) REFERENCES [dbo].[mlac_tbl_users] ([id])
GO
