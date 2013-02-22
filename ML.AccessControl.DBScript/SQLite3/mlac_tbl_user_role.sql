CREATE TABLE [mlac_tbl_user_role] ([user_id] INTEGER NOT NULL REFERENCES [mlac_tbl_users] ([id]), [role_id] INTEGER NOT NULL REFERENCES [mlac_tbl_roles] ([id]), PRIMARY KEY ([user_id], [role_id]));
