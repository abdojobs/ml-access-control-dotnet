﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace ML.AccessControl.DAL.SQLite
{
    internal sealed class DBUsers : AbsDBUsers
    {
        public DBUsers(AbsDBManager pDBManager) : base(pDBManager) { }

        public override int CreateUser(string pLoginName, string pPasswordHash, string pFirstName, string pLastName, string pEmail, DateTime pCreatedOn, bool pIsActive)
        {
            int iResult = -1;

            using (SQLiteConnection cnn = new SQLiteConnection(_dbManager.ConnectionString))
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [mlac_tbl_users] ([login_name],[password_hash],[first_name],[last_name],[email],[created_on],[is_active]) " +
                                                    "VALUES (@pLoginName,@pPasswordHash,@pFirstName,@pLastName,@pEmail,@pCreatedOn,@pIsActive)"+
                                      ";SELECT last_insert_rowid() AS [id];";

                    cmd.Parameters.Add(new SQLiteParameter("@pLoginName",pLoginName));
                    cmd.Parameters.Add(new SQLiteParameter("@pPasswordHash",pPasswordHash));
                    cmd.Parameters.Add(new SQLiteParameter("@pFirstName",pFirstName));
                    cmd.Parameters.Add(new SQLiteParameter("@pLastName",pLastName));
                    cmd.Parameters.Add(new SQLiteParameter("@pEmail",pEmail));
                    cmd.Parameters.Add(new SQLiteParameter("@pCreatedOn",pCreatedOn));
                    cmd.Parameters.Add(new SQLiteParameter("@pIsActive", pIsActive));

                    cnn.Open();
                    iResult = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iResult;
        }
    }
}