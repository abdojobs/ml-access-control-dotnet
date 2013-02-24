CREATE TABLE [mlac_tbl_sessions] ([id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, [hash] GUID NOT NULL UNIQUE, [user_id] INTEGER NOT NULL REFERENCES [mlac_tbl_users] ([id]), [access_point] VARCHAR (100) COLLATE 'NOCASE', [date_created] DATETIME NOT NULL, [last_updated] DATETIME NOT NULL);