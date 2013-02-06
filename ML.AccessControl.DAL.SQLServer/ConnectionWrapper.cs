using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ML.AccessControl.DAL.SQLServer
{
    internal class ConnectionWrapper : IDisposable
    {
        private bool _bIsDisposed = false;
        private SqlConnection _connection;
        private DBTransaction _transaction;

        internal ConnectionWrapper(SqlConnection pConnection)
        {
            _connection = pConnection;
            _transaction = null;
        }

        internal ConnectionWrapper(DBTransaction pTransaction)
        {
            _connection = pTransaction.InnerTransaction.Connection;
            _transaction = pTransaction;
        }

        internal SqlCommand CreateCommand()
        {
            if (_bIsDisposed)
                throw new ObjectDisposedException(this.GetType().ToString());
            SqlCommand cmd = _connection.CreateCommand();
            if (_transaction != null && !_transaction.IsDisposed)
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
