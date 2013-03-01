using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace ML.AccessControl.DAL.SQLite
{
    internal sealed class DBManager : AbsManager
    {
        private string _sConnectionString;
        private DBTransaction _transaction = null;
        private DBSessions _dbSessions = null;
        private DBUsers _dbUsers = null;
        private DBRoles _dbRoles = null;

        internal DBManager(string pConnectionString)
        {
            _sConnectionString = pConnectionString;
        }

        public override string ConnectionString
        {
            get { return _sConnectionString; }
        }

        public override AbsTransaction BeginTransaction()
        {
            if (_transaction != null && !_transaction.IsDisposed)
                throw new Exception("Transaction already in progress");
            SQLiteConnection cnn = new SQLiteConnection(_sConnectionString);
            cnn.Open();
            _transaction = new DBTransaction(cnn.BeginTransaction());
            return _transaction;
        }

        internal ConnectionWrapper GetConnection()
        {
            if (_transaction != null && !_transaction.IsDisposed)
                return new ConnectionWrapper(_transaction);
            else
                return new ConnectionWrapper(new SQLiteConnection(_sConnectionString));
        }

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

        public override AbsDBRoles Roles
        {
            get
            {
                if (_dbRoles == null)
                    _dbRoles = new DBRoles(this);
                return _dbRoles;
            }
        }
    }
}
