using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL.SQLServer
{
    internal sealed class DBManager : AbsDBManager
    {
        private DBSessions _dbSessions = null;

        public DBManager(string pConnectionString) : base(pConnectionString) { }

        public override AbsDBSessions Sessions
        {
            get
            {
                if (_dbSessions == null)
                    _dbSessions = new DBSessions(this);
                return _dbSessions;
            }
        }

        public override AbsDBUsers Users
        {
            get { throw new NotImplementedException(); }
        }
    }
}
