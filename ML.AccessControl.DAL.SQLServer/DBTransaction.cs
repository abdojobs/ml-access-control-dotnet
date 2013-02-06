using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ML.AccessControl.DAL.SQLServer
{
    internal sealed class DBTransaction : AbsTransaction
    {
        private SqlTransaction _transaction;

        internal DBTransaction(SqlTransaction pTransaction)
        {
            _transaction = pTransaction;
        }

        internal SqlTransaction InnerTransaction
        {
            get { return _transaction; }
        }

        public override void Commit()
        {
            if (IsDisposed)
                throw new ObjectDisposedException(this.GetType().ToString());
            SqlConnection cnn = _transaction.Connection;
            _transaction.Commit();
            if (cnn != null && cnn.State != System.Data.ConnectionState.Closed)
                cnn.Close();
            _transaction = null;
            cnn = null;
        }

        public override void Rollback()
        {
            if (IsDisposed)
                throw new ObjectDisposedException(this.GetType().ToString());
            SqlConnection cnn = _transaction.Connection;
            _transaction.Rollback();
            if (cnn != null && cnn.State != System.Data.ConnectionState.Closed)
                cnn.Close();
            _transaction = null;
            cnn = null;
        }

        protected override void OnDispose()
        {
            if (_transaction != null)
            {
                SqlConnection cnn = _transaction.Connection;
                _transaction.Rollback();
                if (cnn != null && cnn.State != System.Data.ConnectionState.Closed)
                    cnn.Close();
                _transaction = null;
                cnn = null;
            }
        }
    }
}
