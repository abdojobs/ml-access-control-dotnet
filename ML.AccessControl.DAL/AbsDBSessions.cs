using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL
{
    public abstract class AbsDBSessions : _AbsDBBase
    {
        public AbsDBSessions(AbsManager pDBManager) : base(pDBManager) { }

        public abstract Guid CreateSession(int pUserId, string pAccessPoint);
    }
}
