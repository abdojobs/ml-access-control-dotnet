using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.Common.Entities;
using ML.AccessControl.Common.Enums;

namespace ML.AccessControl.DAL
{
    public abstract class AbsDBRoles : _AbsDBBase
    {
        public AbsDBRoles(AbsManager pDBManager) : base(pDBManager) { }

        public abstract ACRole[] ListRoles(RoleListingOptions pListingOptions);
    }
}
