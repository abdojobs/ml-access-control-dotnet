using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL
{
    /// <summary>
    /// AbsFactory allows safe use of AbsDBManager when it is cached in a multithreaded environment.
    /// So if AbsFactory is dynamically activated at runtime, it can be cached, while AbsDBManager is instantiated without activation
    /// </summary>
    public abstract class AbsFactory
    {
        public abstract AbsManager CreateDBManager(string pConnectionString);
    }
}
