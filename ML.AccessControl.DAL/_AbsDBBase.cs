using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL
{
    public abstract class _AbsDBBase
    {
        protected AbsManager _dbManager;

        public _AbsDBBase(AbsManager pDBManager)
        {
            _dbManager = pDBManager;
        }
    }
}
