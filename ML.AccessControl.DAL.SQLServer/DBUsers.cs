using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ML.AccessControl.DAL.SQLServer
{
    internal sealed class DBUsers : AbsDBUsers
    {
        public DBUsers(AbsManager pDBManager) : base(pDBManager) { }

        public override bool IsLoginNameAvailable(string pLoginName)
        {
            bool bResult = false;
            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "mlac_sp_usr_IsLoginNameAvailable";
                    cmd.Parameters.Add(new SqlParameter("@pLoginName", pLoginName));
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
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "mlac_sp_usr_IsEmailAvailable";
                    cmd.Parameters.Add(new SqlParameter("@pEmail", pEmail));
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
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "mlac_sp_usr_CreateUser";

                    cmd.Parameters.Add(new SqlParameter("@pLoginName", pLoginName));
                    cmd.Parameters.Add(new SqlParameter("@pPasswordHash", pPasswordHash));
                    cmd.Parameters.Add(new SqlParameter("@pFirstName", pFirstName));
                    cmd.Parameters.Add(new SqlParameter("@pLastName", pLastName));
                    cmd.Parameters.Add(new SqlParameter("@pEmail", pEmail));
                    cmd.Parameters.Add(new SqlParameter("@pCreatedOn", pCreatedOn));
                    cmd.Parameters.Add(new SqlParameter("@pIsActive", pIsActive));

                    cnn.Open();
                    iResult = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return iResult;
        }
    }
}
