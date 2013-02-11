CREATE TABLE [dbo].[mlac_tbl_object_types]
(
[id] [int] NOT NULL,
[description] [nvarchar] (100) COLLATE Latin1_General_CI_AS NOT NULL
)
GO
ALTER TABLE [dbo].[mlac_tbl_object_types] ADD CONSTRAINT [PK_mlac_tbl_object_types] PRIMARY KEY CLUSTERED  ([id])
GO
