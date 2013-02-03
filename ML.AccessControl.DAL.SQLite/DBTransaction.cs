using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace ML.AccessControl.DAL.SQLite
{
    internal sealed class DBTransaction : AbsTransaction
    {
        private SQLiteTransaction _transaction;

        internal DBTransaction(SQLiteTransaction pTransaction)
        {
            _transaction = pTransaction;
        }

        internal SQLiteTransaction InnerTransaction
        {
            get { return _transaction; }
        }

        public override void Commit()
        {
            if (IsDisposed)
                throw new ObjectDisposedException(this.GetType().ToString());
            SQLiteConnection cnn = _transaction.Connection;
            _transaction.Commit();
            if(cnn != null && cnn.State != System.Data.ConnectionState.Closed)
                cnn.Close();
            _transaction = null;
            cnn = null;
        }

        public override void Rollback()
        {
            if (IsDisposed)
                throw new ObjectDisposedException(this.GetType().ToString());
            SQLiteConnection cnn = _transaction.Connection;
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
                SQLiteConnection cnn = _transaction.Connection;
                _transaction.Rollback();
                if (cnn != null && cnn.State != System.Data.ConnectionState.Closed)
                    cnn.Close();
                _transaction = null;
                cnn = null;
            }
        }
    }
}
