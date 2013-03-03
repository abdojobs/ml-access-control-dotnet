CREATE TABLE [dbo].[mlac_tbl_roles]
(
[id] [int] NOT NULL,
[name] [nvarchar] (100) COLLATE Latin1_General_CI_AS NOT NULL,
[is_system] [bit] NOT NULL,
[is_deletable] [bit] NOT NULL,
[is_hidden] [bit] NOT NULL
)
GO
ALTER TABLE [dbo].[mlac_tbl_roles] ADD CONSTRAINT [PK_mlac_tbl_roles] PRIMARY KEY CLUSTERED  ([id])
GO
