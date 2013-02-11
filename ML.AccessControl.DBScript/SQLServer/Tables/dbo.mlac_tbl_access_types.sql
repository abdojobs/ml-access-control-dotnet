CREATE TABLE [dbo].[mlac_tbl_access_types]
(
[id] [int] NOT NULL,
[description] [nvarchar] (100) COLLATE Latin1_General_CI_AS NULL
)
GO
ALTER TABLE [dbo].[mlac_tbl_access_types] ADD CONSTRAINT [PK_mlac_tbl_access_types] PRIMARY KEY CLUSTERED  ([id])
GO
