using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;
using System.Text.RegularExpressions;
using ML.AccessControl.BUS.Common;
using ML.AccessControl.BUS.Common.Utils;
using ML.AccessControl.Common.Enums;

namespace ML.AccessControl.BUS
{
    public sealed class BusRegistration : AbsBusBase
    {
        internal BusRegistration(BusManager pBusManager, AbsManager pDBManager) : base(pBusManager, pDBManager) { }

        public bool IsLoginNameAvailableAndValid(string pLoginName, out MLAC_Error_Messages pErrorMessage)
        {
            pLoginName = pLoginName.Trim();

            if (!_busManager.Users.IsLoginNameValid(pLoginName, out pErrorMessage))
                return false;

            if (!_dbManager.Users.IsLoginNameAvailable(pLoginName))
                pErrorMessage = MLAC_Error_Messages.ERR_LOGINNAME_UNAVAILABLE;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }

        public bool IsEmailAvailableAndValid(string pEmail, out MLAC_Error_Messages pErrorMessage)
        {
            pEmail = pEmail.Trim();

            if (!_busManager.Users.IsEmailValid(pEmail, out pErrorMessage))
                return false;

            if (!_dbManager.Users.IsEmailAvailable(pEmail))
                pErrorMessage = MLAC_Error_Messages.ERR_EMAIL_UNAVAILABLE;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }

        public bool IsPersonNameValid(string pName, out MLAC_Error_Messages pErrorMessage)
        {
            return _busManager.Users.IsPersonNameValid(pName.Trim(), out pErrorMessage);
        }

        public bool IsPasswordValid(string pPassword, out MLAC_Error_Messages pErrorMessage)
        {
            return _busManager.Users.IsPasswordValid(pPassword, out pErrorMessage);
        }

        public bool CreateAccount(string pLoginName, string pPassword, string pFirstName, string pLastName, string pEmail, out MLAC_Error_Messages[] pErrorMessages)
        {
            List<MLAC_Error_Messages> lstErrors  = new List<MLAC_Error_Messages>();
            MLAC_Error_Messages errorMessage;

            pLoginName = pLoginName.Trim();
            pFirstName = pFirstName.Trim();
            pLastName = pLastName.Trim();
            pEmail = pEmail.Trim();

            if (!_busManager.Users.IsPasswordValid(pPassword, out errorMessage))
                lstErrors.Add(errorMessage);
            if (!_busManager.Users.IsPersonNameValid(pFirstName, out errorMessage))
            {
                switch (errorMessage)
                {
                    case MLAC_Error_Messages.ERR_NAME_INVALID:
                        errorMessage = MLAC_Error_Messages.ERR_FIRST_NAME_INVALID;
                        break;
                    case MLAC_Error_Messages.ERR_NAME_TOOSHORT:
                        errorMessage = MLAC_Error_Messages.ERR_FIRST_NAME_TOOSHORT;
                        break;
                    case MLAC_Error_Messages.ERR_NAME_TOOLONG:
                        errorMessage = MLAC_Error_Messages.ERR_FIRST_NAME_TOOLONG;
                        break;
                }
                lstErrors.Add(errorMessage);
            }
            if (!_busManager.Users.IsPersonNameValid(pLastName, out errorMessage))
            {
                switch (errorMessage)
                {
                    case MLAC_Error_Messages.ERR_NAME_INVALID:
                        errorMessage = MLAC_Error_Messages.ERR_LAST_NAME_INVALID;
                        break;
                    case MLAC_Error_Messages.ERR_NAME_TOOSHORT:
                        errorMessage = MLAC_Error_Messages.ERR_LAST_NAME_TOOSHORT;
                        break;
                    case MLAC_Error_Messages.ERR_NAME_TOOLONG:
                        errorMessage = MLAC_Error_Messages.ERR_LAST_NAME_TOOLONG;
                        break;
                }
                lstErrors.Add(errorMessage);
            }
            if (!_busManager.Users.IsLoginNameValid(pLoginName, out errorMessage))
                lstErrors.Add(errorMessage);
            if (!_busManager.Users.IsEmailValid(pEmail, out errorMessage))
                lstErrors.Add(errorMessage);

            using(AbsTransaction transaction = _dbManager.BeginTransaction())
            {
                if (!_dbManager.Users.IsLoginNameAvailable(pLoginName))
                    lstErrors.Add(MLAC_Error_Messages.ERR_LOGINNAME_UNAVAILABLE);
                if (!_dbManager.Users.IsEmailAvailable(pEmail))
                    lstErrors.Add(MLAC_Error_Messages.ERR_EMAIL_UNAVAILABLE);

                if (lstErrors.Count == 0)
                {
                    string sPasswordHash = PasswordHash.CreateHash(pPassword);
                    _dbManager.Users.CreateUser(pLoginName, sPasswordHash, pFirstName, pLastName, pEmail, DateTime.Now, true);
                    transaction.Commit();
                }
            }

            pErrorMessages = lstErrors.ToArray();
            return (pErrorMessages.Length == 0);
        }
    }
}
