CREATE TABLE [dbo].[mlac_tbl_access_flags]
(
[id] [int] NOT NULL,
[description] [nvarchar] (100) COLLATE Latin1_General_CI_AS NULL
)
GO
ALTER TABLE [dbo].[mlac_tbl_access_flags] ADD CONSTRAINT [PK_mlac_tbl_access_flags] PRIMARY KEY CLUSTERED  ([id])
GO
