﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL.SQLServer
{
    internal sealed class DBSessions : AbsDBSessions
    {
        public override string CreateSession()
        {
            return "Session Created";
        }
    }
}
