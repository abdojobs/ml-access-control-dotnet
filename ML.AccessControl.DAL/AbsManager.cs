using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL
{
    public abstract class AbsManager
    {
        public abstract string ConnectionString { get; }

        public abstract AbsTransaction BeginTransaction();

        public abstract AbsDBSessions Sessions { get; }
        public abstract AbsDBUsers Users { get; }

    }
}
