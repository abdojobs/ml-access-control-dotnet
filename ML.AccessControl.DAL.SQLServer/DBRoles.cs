using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL.Common;
using System.Data.SqlClient;
using ML.AccessControl.DAL.Common.Enums;

namespace ML.AccessControl.DAL.SQLServer
{
    internal sealed class DBRoles : AbsDBRoles
    {
        public DBRoles(AbsManager pDBManager) : base(pDBManager) { }

        public override DBRole[] ListRoles(RoleListingOptions pListingOptions)
        {
            List<DBRole> lstResult = new List<DBRole>();

            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "mlac_sp_rol_ListRoles";
                    if (pListingOptions != RoleListingOptions.All)
                    {
                        if (pListingOptions == RoleListingOptions.Hidden)
                            cmd.Parameters.Add(new SqlParameter("@pListHidden", true));
                        else if (pListingOptions == RoleListingOptions.Non_Hidden)
                            cmd.Parameters.Add(new SqlParameter("@pListHidden", false));
                    }
                    cnn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lstResult.Add(new DBRole()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                IsSystem = reader.GetBoolean(2),
                                IsDeletable = reader.GetBoolean(3),
                                IsHidden = reader.GetBoolean(4)
                            });
                        }
                    }
                }
            }
            return lstResult.ToArray();
        }
    }
}
