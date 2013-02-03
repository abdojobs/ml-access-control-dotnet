using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;
using System.Text.RegularExpressions;
using ML.AccessControl.BUS.Common;

namespace ML.AccessControl.BUS
{
    public sealed class BusRegistration : AbsBusBase
    {
        internal BusRegistration(BusManager pBusManager, AbsDBManager pDBManager) : base(pBusManager, pDBManager) { }

        public bool IsLoginNameAvailableAndValid(string pLoginName, out MLAC_Error_Messages pErrorMessage)
        {
            pErrorMessage = MLAC_Error_Messages._NO_ERROR;
            pLoginName = pLoginName.Trim();

            if (pLoginName.Length < Config.LOGINNAME_LEN_MIN)
                pErrorMessage = MLAC_Error_Messages.ERR_LOGINNAME_TOOSHORT;
            else if (pLoginName.Length > Config.LOGINNAME_LEN_MAX)
                pErrorMessage = MLAC_Error_Messages.ERR_LOGINNAME_TOOLONG;
            else if (!Regex.IsMatch(pLoginName, Config.LOGINNAME_RGX))
                pErrorMessage = MLAC_Error_Messages.ERR_LOGINNAME_INVALID;
            else if (!_dbManager.Users.IsLoginNameAvailable(pLoginName))
                pErrorMessage = MLAC_Error_Messages.ERR_LOGINNAME_UNAVAILABLE;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }

        public bool IsEmailAvailableAndValid(string pEmail, out MLAC_Error_Messages pErrorMessage)
        {
            pErrorMessage = MLAC_Error_Messages._NO_ERROR;
            pEmail = pEmail.Trim();

            if (pEmail.Length < Config.EMAIL_LEN_MIN)
                pErrorMessage = MLAC_Error_Messages.ERR_EMAIL_TOOSHORT;
            else if (pEmail.Length > Config.EMAIL_LEN_MAX)
                pErrorMessage = MLAC_Error_Messages.ERR_EMAIL_TOOLONG;
            else if (!Regex.IsMatch(pEmail, Config.EMAIL_RGX))
                pErrorMessage = MLAC_Error_Messages.ERR_EMAIL_INVALID;
            else if (!_dbManager.Users.IsEmailAvailable(pEmail))
                pErrorMessage = MLAC_Error_Messages.ERR_EMAIL_UNAVAILABLE;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }

        public bool IsPersonNameValid(string pName, out MLAC_Error_Messages pErrorMessage)
        {
            pErrorMessage = MLAC_Error_Messages._NO_ERROR;
            pName = pName.Trim();

            if (pName.Length < Config.NAME_LEN_MIN)
                pErrorMessage = MLAC_Error_Messages.ERR_NAME_TOOSHORT;
            else if (pName.Length > Config.NAME_LEN_MAX)
                pErrorMessage = MLAC_Error_Messages.ERR_NAME_TOOLONG;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }

        public bool IsPasswordValid(string pPassword, out MLAC_Error_Messages pErrorMessage)
        {
            pErrorMessage = MLAC_Error_Messages._NO_ERROR;
            pPassword = pPassword.Trim();

            if (pPassword.Length < Config.PASSWORD_LEN_MIN)
                pErrorMessage = MLAC_Error_Messages.ERR_PASSWORD_TOOSHORT;
            else if (pPassword.Length > Config.PASSWORD_LEN_MAX)
                pErrorMessage = MLAC_Error_Messages.ERR_PASSWORD_TOOLONG;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }
    }
}
