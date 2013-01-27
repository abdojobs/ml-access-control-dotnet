using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL
{
    public abstract class AbsDBManager
    {
        protected string _sConnectionString = "";

        public AbsDBManager(string pConnectionString)
        {
            _sConnectionString = pConnectionString;
        }

        public string ConnectionString
        {
            get
            {
                return _sConnectionString;
            }
        }

        public abstract AbsDBSessions Sessions { get; }

    }
}
