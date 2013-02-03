using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;

namespace ML.AccessControl.BUS
{
    public sealed class BusUsers : AbsBusBase
    {
        internal BusUsers(BusManager pBusManager, AbsDBManager pDBManager) : base(pBusManager, pDBManager) { }

        public int CreateUser(string pLoginName, string pPasswordHash, string pFirstName, string pLastName, string pEmail, bool pIsActive)
        {
            return _dbManager.Users.CreateUser(pLoginName, pPasswordHash, pFirstName, pLastName, pEmail, DateTime.Now, pIsActive);
        }
        
    }
}
