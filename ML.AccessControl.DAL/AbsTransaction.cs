using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL
{
    public abstract class AbsTransaction : IDisposable
    {
        protected bool _bIsDisposed = false;

        public abstract void Commit();
        public abstract void Rollback();
        protected abstract void OnDispose();

        public bool IsDisposed
        {
            get
            {
                return _bIsDisposed;
            }
        }

        public void Dispose()
        {
            if (!_bIsDisposed)
            {
                OnDispose();
                _bIsDisposed = true;
            }
        }
    }
}
