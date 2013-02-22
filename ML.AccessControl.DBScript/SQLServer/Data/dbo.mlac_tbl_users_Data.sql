SET IDENTITY_INSERT [dbo].[mlac_tbl_users] ON
INSERT INTO [dbo].[mlac_tbl_users] ([id], [login_name], [password_hash], [first_name], [last_name], [email], [created_on], [is_active]) VALUES (1, 'administrator', '1000:EAy9yCaB+pS5366hSfpCwGmr7CEtoR0V:8VuNt3UGBlysY5m+Cg+uVs8HusYyiB8B', N'', N'', N'administrator@example.com', '2013-01-01 10:00:00', 1)
SET IDENTITY_INSERT [dbo].[mlac_tbl_users] OFF
