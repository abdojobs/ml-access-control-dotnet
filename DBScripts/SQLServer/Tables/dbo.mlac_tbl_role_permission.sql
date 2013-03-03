CREATE TABLE [dbo].[mlac_tbl_role_permission]
(
[role_id] [int] NOT NULL,
[object_type_id] [int] NOT NULL,
[object_id] [int] NOT NULL,
[access_flag_id] [int] NOT NULL
)
GO
ALTER TABLE [dbo].[mlac_tbl_role_permission] ADD CONSTRAINT [PK_mlac_tbl_role_permission] PRIMARY KEY CLUSTERED  ([role_id], [object_type_id], [object_id])
GO
ALTER TABLE [dbo].[mlac_tbl_role_permission] ADD CONSTRAINT [FK_mlac_tbl_role_permission_mlac_tbl_access_flags] FOREIGN KEY ([access_flag_id]) REFERENCES [dbo].[mlac_tbl_access_flags] ([id])
GO
ALTER TABLE [dbo].[mlac_tbl_role_permission] ADD CONSTRAINT [FK_mlac_tbl_role_permission_mlac_tbl_object_types] FOREIGN KEY ([object_type_id]) REFERENCES [dbo].[mlac_tbl_object_types] ([id])
GO
ALTER TABLE [dbo].[mlac_tbl_role_permission] ADD CONSTRAINT [FK_mlac_tbl_role_permission_mlac_tbl_roles] FOREIGN KEY ([role_id]) REFERENCES [dbo].[mlac_tbl_roles] ([id])
GO
