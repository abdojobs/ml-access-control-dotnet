﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL.SQLite
{
    internal sealed class DBSessions : AbsDBSessions
    {
        public DBSessions(AbsManager pDBManager) : base(pDBManager) { }
    }
}
