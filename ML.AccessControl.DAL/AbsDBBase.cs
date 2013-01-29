using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL
{
    public abstract class AbsDBBase
    {
        protected AbsDBManager _dbManager;

        public AbsDBBase(AbsDBManager pDBManager)
        {
            _dbManager = pDBManager;
        }
    }
}
