using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;

namespace ML.AccessControl.BUS
{
    public abstract class AbsBusBase
    {
        protected AbsDBManager _dbManager;

        protected AbsBusBase(AbsDBManager pDBManager)
        {
            _dbManager = pDBManager;
        }
    }
}
