using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL.SQLite
{
    internal sealed class DBFactory : AbsFactory
    {
        public override AbsDBManager CreateDBManager(string pConnectionString)
        {
            return new DBManager(pConnectionString);
        }
    }
}
