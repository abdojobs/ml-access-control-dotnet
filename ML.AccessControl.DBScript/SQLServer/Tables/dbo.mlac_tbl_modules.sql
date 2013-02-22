CREATE TABLE [dbo].[mlac_tbl_modules]
(
[id] [int] NOT NULL,
[parent_id] [int] NULL,
[name] [nvarchar] (100) COLLATE Latin1_General_CI_AS NOT NULL
)
GO
ALTER TABLE [dbo].[mlac_tbl_modules] ADD CONSTRAINT [PK_mlac_tbl_modules] PRIMARY KEY CLUSTERED  ([id])
GO
ALTER TABLE [dbo].[mlac_tbl_modules] ADD CONSTRAINT [FK_mlac_tbl_modules_mlac_tbl_modules] FOREIGN KEY ([parent_id]) REFERENCES [dbo].[mlac_tbl_modules] ([id])
GO
