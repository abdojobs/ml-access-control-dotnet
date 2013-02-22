CREATE TABLE [mlac_tbl_modules] ([id] INTEGER PRIMARY KEY NOT NULL UNIQUE, [parent_id] INTEGER REFERENCES [mlac_tbl_modules] ([id]), [name] VARCHAR (100) NOT NULL);
