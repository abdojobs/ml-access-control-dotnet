using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ML.AccessControl.DAL;
using ML.AccessControl.DAL.Common;
using ML.AccessControl.DAL.Common.Enums;
using ML.AccessControl.Common.Entities;

namespace ML.AccessControl.BUS
{
    /// <summary>
    /// Business logic class provides functionality to manage roles
    /// </summary>
    public sealed class BusRoles : AbsBusBase
    {
        internal BusRoles(BusManager pBusManager, AbsManager pDBManager) : base(pBusManager, pDBManager) { }

        /// <summary>
        /// List all roles in the database. This method does not list hidden roles
        /// </summary>
        /// <returns>Array of ACRole objects</returns>
        public ACRole[] ListRoles()
        {
            return ListRoles(RoleListingOptions.Non_Hidden);
        }

        /// <summary>
        /// List all roles in the database including hidden ones
        /// </summary>
        /// <returns>Array of ACRole objects</returns>
        public ACRole[] ListAllRoles()
        {
            return ListRoles(RoleListingOptions.All);
        }

        /// <summary>
        /// List only roles marked as hidden
        /// </summary>
        /// <returns>Array of ACRole objects</returns>
        public ACRole[] ListHiddenRoles()
        {
            return ListRoles(RoleListingOptions.Hidden);
        }

        internal ACRole[] ListRoles(RoleListingOptions pListingOptions)
        {
            List<ACRole> lstRoles = new List<ACRole>();

            DBRole[] roles = _dbManager.Roles.ListRoles(pListingOptions);
            foreach (var role in roles)
            {
                lstRoles.Add(new ACRole()
                {
                    Id = role.Id,
                    Name = role.Name,
                    IsSystem = role.IsSystem,
                    IsDeletable = role.IsDeletable,
                    IsHidden = role.IsHidden
                });
            }

            return lstRoles.ToArray();
        }
    }
}
