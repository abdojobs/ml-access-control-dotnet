using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.Common.Enums
{
    /// <summary>
    /// Bit flags to specify what objects to load from database when loading the Session object
    /// </summary>
    [Flags]
    public enum SessionLoadOptions
    {
        Load_Roles = 1,
        Load_User_Info = 2,
        Load_Permissions = 4
    }
}
