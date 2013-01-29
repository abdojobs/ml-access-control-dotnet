using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL.SQLite
{
    internal sealed class DBManager : AbsDBManager
    {
        private DBSessions _dbSessions = null;
        private DBUsers _dbUsers = null;

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
            get
            {
                if (_dbUsers == null)
                    _dbUsers = new DBUsers(this);
                return _dbUsers;
            }
        }
    }
}
