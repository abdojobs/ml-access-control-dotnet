﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL
{
    public abstract class AbsDBSessions : AbsDBBase
    {
        public AbsDBSessions(AbsDBManager pDBManager) : base(pDBManager) { }
    }
}
