using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.BUS.Common
{
    public enum MLAC_Error_Messages
    {
        _NO_ERROR = 0,

        ERR_LOGINNAME_INVALID = 1000,
        ERR_LOGINNAME_TOOSHORT = 1001,
        ERR_LOGINNAME_TOOLONG = 1002,
        ERR_LOGINNAME_UNAVAILABLE = 1003,
        ERR_EMAIL_INVALID = 1100,
        ERR_EMAIL_TOOSHORT = 1101,
        ERR_EMAIL_TOOLONG = 1102,
        ERR_EMAIL_UNAVAILABLE = 1103,
        ERR_NAME_INVALID = 1200,
        ERR_NAME_TOOSHORT = 1201,
        ERR_NAME_TOOLONG = 1202,
        ERR_FIRST_NAME_INVALID = 1220,
        ERR_FIRST_NAME_TOOSHORT = 1221,
        ERR_FIRST_NAME_TOOLONG = 1222,
        ERR_LAST_NAME_INVALID = 1240,
        ERR_LAST_NAME_TOOSHORT = 1241,
        ERR_LAST_NAME_TOOLONG = 1242,
        ERR_PASSWORD_INVALID = 1300,
        ERR_PASSWORD_TOOSHORT = 1301,
        ERR_PASSWORD_TOOLONG = 1302,
    }
}
