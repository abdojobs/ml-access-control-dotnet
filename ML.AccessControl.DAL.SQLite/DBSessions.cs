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
                    cmd.CommandText = "INSERT INTO [mlac_tbl_sessions] ([hash],[user_id],[access_point],[date_created]) " +
                                      "VALUES (@pHash,@pUserId,@pAccessPoint,@pDateCreated);";

                    cmd.Parameters.Add(new SQLiteParameter("@pHash", result));
                    cmd.Parameters.Add(new SQLiteParameter("@pUserId", pUserId));
                    cmd.Parameters.Add(new SQLiteParameter("@pAccessPoint", pAccessPoint));//(pAccessPoint == null) ? DBNull.Value : (object)pAccessPoint));
                    cmd.Parameters.Add(new SQLiteParameter("@pDateCreated", DateTime.Now));

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return result;
        }

    }
}
