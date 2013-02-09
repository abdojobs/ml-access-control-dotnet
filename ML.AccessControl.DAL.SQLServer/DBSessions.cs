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

                    cmd.Parameters.Add(new SqlParameter("@pHash", result));
                    cmd.Parameters.Add(new SqlParameter("@pUserId", pUserId));
                    cmd.Parameters.Add(new SqlParameter("@pAccessPoint", (pAccessPoint == null) ? DBNull.Value : (object)pAccessPoint));
                    cmd.Parameters.Add(new SqlParameter("@pDateCreated", DateTime.Now));

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
    }
}
