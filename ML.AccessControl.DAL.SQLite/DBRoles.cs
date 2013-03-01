using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL.Common;
using System.Data.SQLite;
using ML.AccessControl.DAL.Common.Enums;

namespace ML.AccessControl.DAL.SQLite
{
    internal sealed class DBRoles : AbsDBRoles
    {
        public DBRoles(AbsManager pDBManager) : base(pDBManager) { }

        public override DBRole[] ListRoles(RoleListingOptions pListingOptions)
        {
            List<DBRole> lstResult = new List<DBRole>();
            
            using (ConnectionWrapper cnn = ((DBManager)_dbManager).GetConnection())
            {
                using (SQLiteCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [id],[name],[is_system],[is_deletable],[is_hidden] FROM [mlac_tbl_roles]";
                    if (pListingOptions != RoleListingOptions.All)
                    {
                        cmd.CommandText += " WHERE [is_hidden]=@pListHidden;";
                        if (pListingOptions == RoleListingOptions.Hidden)
                            cmd.Parameters.Add(new SQLiteParameter("@pListHidden", true));
                        else if (pListingOptions == RoleListingOptions.Non_Hidden)
                            cmd.Parameters.Add(new SQLiteParameter("@pListHidden", false));
                    }
                    cnn.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
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
