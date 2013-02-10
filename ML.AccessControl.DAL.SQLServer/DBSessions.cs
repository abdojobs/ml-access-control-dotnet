using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ML.AccessControl.DAL.SQLServer
{
    internal sealed class DBSessions : AbsDBSessions
    {
        public DBSessions(AbsManager pDBManager) : base(pDBManager) { }

        public override Guid CreateSession(int pUserId, string pAccessPoint)
        {
            Guid result = Guid.NewGuid();

            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "mlac_sp_ses_CreateSession";

                    DateTime dtNow = DateTime.Now;
                    cmd.Parameters.Add(new SqlParameter("@pHash", result));
                    cmd.Parameters.Add(new SqlParameter("@pUserId", pUserId));
                    cmd.Parameters.Add(new SqlParameter("@pAccessPoint", (pAccessPoint == null) ? DBNull.Value : (object)pAccessPoint));
                    cmd.Parameters.Add(new SqlParameter("@pDateCreated", dtNow));
                    cmd.Parameters.Add(new SqlParameter("@pLastUpdated", dtNow));

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
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "mlac_sp_ses_DeleteSession";

                    cmd.Parameters.Add(new SqlParameter("@pSessionGuid", pSessionGuid));
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
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "mlac_sp_ses_DeleteSessions";

                    DateTime dtOlderThanDate = DateTime.Now - pOlderThan;
                    cmd.Parameters.Add(new SqlParameter("@pOlderThanDate", dtOlderThanDate));
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
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "mlac_sp_ses_DeleteAllSessions";

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
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "mlac_sp_ses_UpdateSession";

                    DateTime dtNow = DateTime.Now;
                    cmd.Parameters.Add(new SqlParameter("@pLastUpdated", dtNow));
                    cmd.Parameters.Add(new SqlParameter("@pSessionGuid", pSessionGuid));
                    cnn.Open();
                    bResult = (cmd.ExecuteNonQuery() > 0);
                }
            }
            return bResult;
        }
    }
}
