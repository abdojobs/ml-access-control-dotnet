CREATE TABLE [dbo].[mlac_tbl_session]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[hash] [varchar] (100) COLLATE Arabic_CI_AS NOT NULL
)
ALTER TABLE [dbo].[mlac_tbl_session] ADD CONSTRAINT [PK_mlac_tbl_session] PRIMARY KEY CLUSTERED  ([id])
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_mlac_tbl_session] ON [dbo].[mlac_tbl_session] ([hash])
GO
