using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace ML.AccessControl.DAL.SQLite
{
    internal sealed class DBSessions : AbsDBSessions
    {
        public DBSessions(AbsManager pDBManager) : base(pDBManager) { }

        public override Guid CreateSession(int pUserId, string pAccessPoint)
        {
            Guid result = Guid.NewGuid();

            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [mlac_tbl_sessions] ([hash],[user_id],[access_point],[date_created],[last_updated]) " +
                                      "VALUES (@pHash,@pUserId,@pAccessPoint,@pDateCreated,@pLastUpdated);";

                    DateTime dtNow = DateTime.Now;
                    cmd.Parameters.Add(new SQLiteParameter("@pHash", result));
                    cmd.Parameters.Add(new SQLiteParameter("@pUserId", pUserId));
                    cmd.Parameters.Add(new SQLiteParameter("@pAccessPoint", pAccessPoint));//(pAccessPoint == null) ? DBNull.Value : (object)pAccessPoint));
                    cmd.Parameters.Add(new SQLiteParameter("@pDateCreated", dtNow));
                    cmd.Parameters.Add(new SQLiteParameter("@pLastUpdated", dtNow));

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return result;
        }

        public override bool DeleteSession(Guid pSessionGuid)
        {
            bool bResult = false;

            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [mlac_tbl_sessions] WHERE [hash]=@pSessionGuid;";

                    cmd.Parameters.Add(new SQLiteParameter("@pSessionGuid", pSessionGuid));
                    cnn.Open();
                    bResult = (cmd.ExecuteNonQuery() > 0);
                }
            }
            return bResult;
        }

        public override int DeleteSessions(TimeSpan pOlderThan)
        {
            int iResult = 0;

            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [mlac_tbl_sessions] WHERE [last_updated] < @pOlderThanDate;";

                    DateTime dtOlderThanDate = DateTime.Now - pOlderThan;
                    cmd.Parameters.Add(new SQLiteParameter("@pOlderThanDate", dtOlderThanDate));
                    cnn.Open();
                    iResult = cmd.ExecuteNonQuery();
                }
            }
            return iResult;
        }

        public override int DeleteAllSessions()
        {
            int iResult = 0;

            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [mlac_tbl_sessions];";

                    cnn.Open();
                    iResult = cmd.ExecuteNonQuery();
                }
            }
            return iResult;
        }

        public override bool UpdateSession(Guid pSessionGuid)
        {
            bool bResult = false;

            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [mlac_tbl_sessions] SET [last_updated]=@pLastUpdated WHERE [hash]=@pSessionGuid;";

                    DateTime dtNow = DateTime.Now;
                    cmd.Parameters.Add(new SQLiteParameter("@pLastUpdated", dtNow));
                    cmd.Parameters.Add(new SQLiteParameter("@pSessionGuid", pSessionGuid));
                    cnn.Open();
                    bResult = (cmd.ExecuteNonQuery() > 0);
                }
            }
            return bResult;
        }


    }
}
