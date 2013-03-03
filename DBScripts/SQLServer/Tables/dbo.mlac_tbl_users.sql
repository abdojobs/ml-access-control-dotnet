CREATE TABLE [dbo].[mlac_tbl_users]
(
[id] [int] NOT NULL IDENTITY(1, 1),
[login_name] [varchar] (100) COLLATE Latin1_General_CI_AS NOT NULL,
[password_hash] [varchar] (100) COLLATE Latin1_General_BIN NOT NULL,
[first_name] [nvarchar] (100) COLLATE Latin1_General_CI_AS NOT NULL,
[last_name] [nvarchar] (100) COLLATE Latin1_General_CI_AS NOT NULL,
[email] [nvarchar] (100) COLLATE Latin1_General_CI_AS NOT NULL,
[created_on] [datetime] NOT NULL,
[is_active] [bit] NOT NULL
)
ALTER TABLE [dbo].[mlac_tbl_users] ADD 
CONSTRAINT [PK_mlac_tbl_users] PRIMARY KEY CLUSTERED  ([id])
GO
