using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace ML.AccessControl.DAL.SQLite
{
    internal class ConnectionWrapper : IDisposable
    {
        private bool _bIsDisposed = false;
        private SQLiteConnection _connection;
        private DBTransaction _transaction;

        internal ConnectionWrapper(SQLiteConnection pConnection)
        {
            _connection = pConnection;
            _transaction = null;
        }

        internal ConnectionWrapper(DBTransaction pTransaction)
        {
            _connection = pTransaction.InnerTransaction.Connection;
            _transaction = pTransaction;
        }

        internal SQLiteCommand CreateCommand()
        {
            if (_bIsDisposed)
                throw new ObjectDisposedException(this.GetType().ToString());
            SQLiteCommand cmd = _connection.CreateCommand();
            if(_transaction != null && !_transaction.IsDisposed)
                cmd.Transaction = _transaction.InnerTransaction;
            return cmd;
        }

        internal void Open()
        {
            if (_bIsDisposed)
                throw new ObjectDisposedException(this.GetType().ToString());
            if (_transaction == null || _transaction.IsDisposed)
            {
                if (_connection != null)
                    _connection.Open();
            }
        }

        internal void Close()
        {
            if (_bIsDisposed)
                throw new ObjectDisposedException(this.GetType().ToString());
            Dispose();
        }

        public void Dispose()
        {
            if (!_bIsDisposed)
            {
                if (_transaction == null || _transaction.IsDisposed)
                {
                    if (_connection != null && _connection.State != System.Data.ConnectionState.Closed)
                        _connection.Close();
                }
                _connection = null;
                _transaction = null;
                _bIsDisposed = true;
            }
        }
    }
}
