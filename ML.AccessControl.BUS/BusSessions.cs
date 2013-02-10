using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;
using ML.AccessControl.BUS.Common.Utils;
using ML.AccessControl.BUS.Common;

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
        /// Ends an active session. This method should be called to logout certain user
        /// </summary>
        /// <param name="pSessionGuid">Session Guid id</param>
        /// <returns>True if the session found, and false in case the session record was not found</returns>
        public bool EndSession(Guid pSessionGuid)
        {
            bool bResult = false;
            bResult = _dbManager.Sessions.DeleteSession(pSessionGuid);
            return bResult;
        }

        /// <summary>
        /// Ends and deletes all expired sessions which have not been updated for a period longer than the configured timespan MLAC_SESSION_EXPIRE_AFTER
        /// </summary>
        /// <returns>Number of sessions ended</returns>
        public int EndOldSessions()
        {
            int iResult = 0;
            iResult = _dbManager.Sessions.DeleteSessions(Config.MLAC_SESSION_EXPIRE_AFTER);
            return iResult;
        }

        /// <summary>
        /// Ends all sessions
        /// </summary>
        /// <returns>Number of sessions ended</returns>
        public int EndAllSessions()
        {
            int iResult = 0;
            iResult = _dbManager.Sessions.DeleteAllSessions();
            return iResult;
        }

        /// <summary>
        /// Ends and deletes all expired sessions which have not been updated for a period longer than the configured timespan MLAC_SESSION_EXPIRE_AFTER
        /// Updates the given session to prevent it from expiration.
        /// This method is useful to apply session maintenance in process. This means no stand-alone service is required to clean expired sessions
        /// </summary>
        /// <param name="pSessionGuid">Session Guid id</param>
        /// <returns>Returns true in case the session is found and renewed, and false if the session is not found.</returns>
        public bool KeepAlive(Guid pSessionGuid)
        {
            return KeepAlive(pSessionGuid, true);
        }

        /// <summary>
        /// Updates the given session to prevent it from expiration
        /// </summary>
        /// <param name="pSessionGuid">Session Guid id</param>
        /// <param name="pEndOldSessions">If true then will end all expired sessions</param>
        /// <returns>Returns true in case the session is found and renewed, and false if the session is not found.</returns>
        public bool KeepAlive(Guid pSessionGuid, bool pEndOldSessions)
        {
            bool bResult = false;
            if(pEndOldSessions)
                _dbManager.Sessions.DeleteSessions(Config.MLAC_SESSION_EXPIRE_AFTER);
            bResult = _dbManager.Sessions.UpdateSession(pSessionGuid);
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
