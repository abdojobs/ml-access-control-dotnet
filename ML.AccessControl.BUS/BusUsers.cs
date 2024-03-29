﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;
using ML.AccessControl.BUS.Common;
using System.Text.RegularExpressions;
using ML.AccessControl.BUS.Common.Utils;
using ML.AccessControl.Common.Enums;
using ML.AccessControl.Common.Entities;

namespace ML.AccessControl.BUS
{
    public sealed class BusUsers : AbsBusBase
    {
        internal BusUsers(BusManager pBusManager, AbsManager pDBManager) : base(pBusManager, pDBManager) { }

        /// <summary>
        /// Load user information from the database.
        /// </summary>
        /// <param name="pUserId">User Id</param>
        /// <returns>ACUser object if user record was found. Returns null if record not found.</returns>
        public ACUser LoadUserInfo(int pUserId)
        {
            return _dbManager.Users.LoadUserInfo(pUserId);
        }

        internal bool IsPersonNameValid(string pName, out MLAC_Error_Messages pErrorMessage)
        {
            pErrorMessage = MLAC_Error_Messages._NO_ERROR;

            if (string.IsNullOrEmpty(pName) && !Config.NAME_REQUIRED)
                return true;

            if (pName.Length < Config.NAME_LEN_MIN)
                pErrorMessage = MLAC_Error_Messages.ERR_NAME_TOOSHORT;
            else if (pName.Length > Config.NAME_LEN_MAX)
                pErrorMessage = MLAC_Error_Messages.ERR_NAME_TOOLONG;
            else if (!Regex.IsMatch(pName, Config.NAME_RGX))
                pErrorMessage = MLAC_Error_Messages.ERR_NAME_INVALID;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }

        internal bool IsPasswordValid(string pPassword, out MLAC_Error_Messages pErrorMessage)
        {
            pErrorMessage = MLAC_Error_Messages._NO_ERROR;

            if (pPassword.Length < Config.PASSWORD_LEN_MIN)
                pErrorMessage = MLAC_Error_Messages.ERR_PASSWORD_TOOSHORT;
            else if (pPassword.Length > Config.PASSWORD_LEN_MAX)
                pErrorMessage = MLAC_Error_Messages.ERR_PASSWORD_TOOLONG;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }

        internal bool IsEmailValid(string pEmail, out MLAC_Error_Messages pErrorMessage)
        {
            pErrorMessage = MLAC_Error_Messages._NO_ERROR;

            if (pEmail.Length < Config.EMAIL_LEN_MIN)
                pErrorMessage = MLAC_Error_Messages.ERR_EMAIL_TOOSHORT;
            else if (pEmail.Length > Config.EMAIL_LEN_MAX)
                pErrorMessage = MLAC_Error_Messages.ERR_EMAIL_TOOLONG;
            else if (!Regex.IsMatch(pEmail, Config.EMAIL_RGX))
                pErrorMessage = MLAC_Error_Messages.ERR_EMAIL_INVALID;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }

        internal bool IsLoginNameValid(string pLoginName, out MLAC_Error_Messages pErrorMessage)
        {
            pErrorMessage = MLAC_Error_Messages._NO_ERROR;

            if (pLoginName.Length < Config.LOGINNAME_LEN_MIN)
                pErrorMessage = MLAC_Error_Messages.ERR_LOGINNAME_TOOSHORT;
            else if (pLoginName.Length > Config.LOGINNAME_LEN_MAX)
                pErrorMessage = MLAC_Error_Messages.ERR_LOGINNAME_TOOLONG;
            else if (!Regex.IsMatch(pLoginName, Config.LOGINNAME_RGX))
                pErrorMessage = MLAC_Error_Messages.ERR_LOGINNAME_INVALID;

            return (pErrorMessage == MLAC_Error_Messages._NO_ERROR);
        }

        
    }
}
