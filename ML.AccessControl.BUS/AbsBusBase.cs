using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;

namespace ML.AccessControl.BUS
{
    public abstract class AbsBusBase
    {
        protected AbsManager _dbManager;
        protected BusManager _busManager;

        protected AbsBusBase(BusManager pBusManager, AbsManager pDBManager)
        {
            _dbManager = pDBManager;
            _busManager = pBusManager;
        }
    }
}
