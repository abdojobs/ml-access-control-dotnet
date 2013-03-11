using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using ML.AccessControl.Common.Entities;

namespace ML.AccessControl.DAL.SQLite
{
    internal sealed class DBUsers : AbsDBUsers
    {
        public DBUsers(AbsManager pDBManager) : base(pDBManager) { }

        public override bool IsLoginNameAvailable(string pLoginName)
        {
            bool bResult = false;
            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM [mlac_tbl_users] WHERE LOWER([login_name])=@pLoginName;";
                    cmd.Parameters.Add(new SQLiteParameter("@pLoginName", pLoginName.ToLower()));
                    cnn.Open();
                    bResult = (Convert.ToInt32(cmd.ExecuteScalar()) == 0);
                }
            }
            return bResult;
        }

        public override bool IsEmailAvailable(string pEmail)
        {
            bool bResult = false;
            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM [mlac_tbl_users] WHERE LOWER([email])=@pEmail;";
                    cmd.Parameters.Add(new SQLiteParameter("@pEmail", pEmail.ToLower()));
                    cnn.Open();
                    bResult = (Convert.ToInt32(cmd.ExecuteScalar()) == 0);
                }
            }
            return bResult;
        }

        public override int CreateUser(string pLoginName, string pPasswordHash, string pFirstName, string pLastName, string pEmail, DateTime pCreatedOn, bool pIsActive)
        {
            int iResult = -1;

            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
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

        public override bool GetPasswordHash(string pLoginName, out int pUserId, out string pPasswordHash)
        {
            bool bResult = false;
            pUserId = 0;
            pPasswordHash = null;
            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [id],[password_hash] FROM [mlac_tbl_users] WHERE LOWER([login_name])=@pLoginName;";
                    cmd.Parameters.Add(new SQLiteParameter("@pLoginName", pLoginName.ToLower()));
                    cnn.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pUserId = reader.GetInt32(0);
                            pPasswordHash = reader.GetString(1);
                            bResult = true;
                        }
                    }
                }
            }
            return bResult;
        }

        public override ACUser LoadUserInfo(int pUserId)
        {
            ACUser result = null;

            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [login_name],[first_name],[last_name],[email] FROM [mlac_tbl_users] WHERE [id]=@pUserId;";
                    cmd.Parameters.Add(new SQLiteParameter("@pUserId", pUserId));
                    cnn.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = new ACUser()
                            {
                                Id = pUserId,
                                LoginName = reader.GetString(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Email = reader.GetString(3)
                            };
                        }
                    }
                }
            }
            return result;
        }
    }
}
