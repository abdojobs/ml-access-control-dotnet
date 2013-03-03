using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.Common.Entities
{
    public class ACSession
    {
        public int Id { get; set; }
        public Guid SessionGuid { get; set; }
        public ACRole[] Roles { get; set; }
        public ACUser UserInfo { get; set; }
    }
}
