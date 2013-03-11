using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.Common.Entities;

namespace ML.AccessControl.DAL
{
    public abstract class AbsDBUsers : _AbsDBBase
    {
        public AbsDBUsers(AbsManager pDBManager) : base(pDBManager) { }

        public abstract bool IsLoginNameAvailable(string pLoginName);
        public abstract bool IsEmailAvailable(string pEmail);
        public abstract int CreateUser(string pLoginName, string pPasswordHash, string pFirstName, string pLastName, string pEmail, DateTime pCreatedOn, bool pIsActive);
        public abstract bool GetPasswordHash(string pLoginName, out int pUserId, out string pPasswordHash);
        public abstract ACUser LoadUserInfo(int pUserId);
    }
}
