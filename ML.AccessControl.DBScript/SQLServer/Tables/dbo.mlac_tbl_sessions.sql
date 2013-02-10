CREATE TABLE [dbo].[mlac_tbl_sessions]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[hash] [uniqueidentifier] NOT NULL,
[user_id] [int] NOT NULL,
[access_point] [nvarchar] (100) COLLATE Latin1_General_CI_AS NULL,
[date_created] [datetime] NOT NULL,
[last_updated] [datetime] NOT NULL
)
ALTER TABLE [dbo].[mlac_tbl_sessions] ADD 
CONSTRAINT [PK_mlac_tbl_sessions] PRIMARY KEY CLUSTERED  ([id])
CREATE UNIQUE NONCLUSTERED INDEX [IX_mlac_tbl_sessions] ON [dbo].[mlac_tbl_sessions] ([hash])

ALTER TABLE [dbo].[mlac_tbl_sessions] ADD
CONSTRAINT [FK_mlac_tbl_sessions_mlac_tbl_users] FOREIGN KEY ([user_id]) REFERENCES [dbo].[mlac_tbl_users] ([id])





GO
