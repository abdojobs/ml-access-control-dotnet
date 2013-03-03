using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.Common.Entities
{
    public class ACUser
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
