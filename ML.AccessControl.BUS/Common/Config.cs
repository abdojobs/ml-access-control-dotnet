using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.BUS.Common
{
    /// <summary>
    /// Temporary class to hold the configurations.
    /// Should be moved later to database or setting file (may be serialized)
    /// </summary>
    public class Config
    {
        //Login name should be from 3 to 20 English letters, numbers, underscors and starts with a letter.
        public static readonly string LOGINNAME_RGX = @"^[a-zA-Z0-9]+[a-zA-Z0-9_.@]*$";
        public static readonly int LOGINNAME_LEN_MAX = 20;
        public static readonly int LOGINNAME_LEN_MIN = 3;
        public static readonly string EMAIL_RGX = @"^[A-Za-z0-9._%+-]+@(?:[A-Za-z0-9-]+\.)+[A-Za-z]{2,4}$";
        public static readonly int EMAIL_LEN_MAX = 50;
        public static readonly int EMAIL_LEN_MIN = 6;
        public static readonly string PASSWORD_RGX = @"^[\S ]+$";
        public static readonly int PASSWORD_LEN_MAX = 20;
        public static readonly int PASSWORD_LEN_MIN = 6;
        public static readonly string NAME_RGX = @"^[\w- '().]+$";
        public static readonly int NAME_LEN_MAX = 20;
        public static readonly int NAME_LEN_MIN = 1;
        public static readonly bool NAME_REQUIRED = false;

        


    }
}
