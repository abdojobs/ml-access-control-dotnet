﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;

namespace ML.AccessControl.BUS
{
    public sealed class BusSessions : AbsBusBase
    {
        internal BusSessions(BusManager pBusManager, AbsManager pDBManager) : base(pBusManager, pDBManager) { }

        //public string CreateSession()
        //{
        //    return _dbManager.Sessions.CreateSession();
        //}
    }
}
