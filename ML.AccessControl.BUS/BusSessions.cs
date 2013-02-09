using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;
using ML.AccessControl.BUS.Common.Utils;

namespace ML.AccessControl.BUS
{
    public sealed class BusSessions : AbsBusBase
    {
        internal BusSessions(BusManager pBusManager, AbsManager pDBManager) : base(pBusManager, pDBManager) { }

        /// <summary>
        /// Authenticate user as per the given credentials
        /// </summary>
        /// <param name="pLoginName">User login name</param>
        /// <param name="pPassword">User password</param>
        /// <returns>Returns the session Guid identifier (represents the session id) in case of success; Empty Guid in case of failure</returns>
        public Guid Authenticate(string pLoginName, string pPassword)
        {
            return Authenticate(pLoginName, pPassword, null);
        }

        /// <summary>
        /// Authenticate user as per the given credentials
        /// </summary>
        /// <param name="pLoginName">User login name</param>
        /// <param name="pPassword">User password</param>
        /// <param name="pAccessPoint">Name or IP address of user workstation</param>
        /// <returns>Returns the session Guid identifier (represents the session id) in case of success; Empty Guid in case of failure</returns>
        public Guid Authenticate(string pLoginName, string pPassword, string pAccessPoint)
        {
            Guid pSessionHash = Guid.Empty;
            if (!string.IsNullOrEmpty(pLoginName))
            {
                pLoginName = pLoginName.Trim();
                if (pAccessPoint != null)
                    pAccessPoint = pAccessPoint.Trim();

                int iUserId;
                string sPasswordHash;
                if (_dbManager.Users.GetPasswordHash(pLoginName, out iUserId, out sPasswordHash))
                {
                    if (PasswordHash.ValidatePassword(pPassword, sPasswordHash))
                    {
                        pSessionHash = _dbManager.Sessions.CreateSession(iUserId, pAccessPoint);
                    }
                }
            }
            return pSessionHash;
        }

        /// <summary>
        /// End an active session. This method should be called to logout certain user
        /// </summary>
        /// <param name="pSessionGuid">Session Guid id</param>
        /// <returns>True if the session found, and false in case the session record was not found</returns>
        public bool EndSession(Guid pSessionGuid)
        {
            bool bResult = false;

            bResult = _dbManager.Sessions.DeleteSession(pSessionGuid);

            return bResult;
        }

        ///// <summary>
        ///// Retrieves ACSession object for the given session hash
        ///// </summary>
        ///// <param name="pSessionHash">The session record hash</param>
        ///// <returns>ACSession object on success, and null in case of failure</returns>
        //public ACSession GetSession(string pSessionHash)
        //{

        //}
    }
}
