using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.DAL
{
    public abstract class AbsDBUsers : AbsDBBase
    {
        public AbsDBUsers(AbsDBManager pDBManager) : base(pDBManager) { }

        public abstract bool IsLoginNameAvailable(string pLoginName);
        public abstract bool IsEmailAvailable(string pEmail);
        public abstract int CreateUser(string pLoginName, string pPasswordHash, string pFirstName, string pLastName, string pEmail, DateTime pCreatedOn, bool pIsActive);
    }
}
