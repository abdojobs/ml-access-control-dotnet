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

        public override void Commit()
        {
            if (_bIsDisposed)
                throw new Exception("Cannot commit disposed transaction");
            _transaction.Commit();
            Dispose();
        }

        public override void Rollback()
        {
            if (_bIsDisposed)
                throw new Exception("Cannot rollback disposed transaction");
            _transaction.Rollback();
            Dispose();
        }

        protected override void OnDispose()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }
        }
    }
}
