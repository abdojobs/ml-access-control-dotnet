using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL.Common;
using ML.AccessControl.DAL.Common.Enums;

namespace ML.AccessControl.DAL
{
    public abstract class AbsDBRoles : _AbsDBBase
    {
        public AbsDBRoles(AbsManager pDBManager) : base(pDBManager) { }

        public abstract DBRole[] ListRoles(RoleListingOptions pListingOptions);
    }
}
