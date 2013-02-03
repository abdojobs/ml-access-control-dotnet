using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ML.AccessControl.DAL.SQLServer
{
    internal sealed class DBManager : AbsManager
    {
        private string _sConnectionString;
        private DBTransaction _transaction = null;
        private DBSessions _dbSessions = null;

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
            SqlConnection cnn = new SqlConnection(_sConnectionString);
            cnn.Open();
            _transaction = new DBTransaction(cnn.BeginTransaction());
            return _transaction;
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
            get { throw new NotImplementedException(); }
        }
    }
}
