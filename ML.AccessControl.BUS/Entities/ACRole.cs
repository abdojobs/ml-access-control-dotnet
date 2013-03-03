using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ML.AccessControl.BUS.Entities
{
    public class ACRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSystem { get; set; }
        public bool IsDeletable { get; set; }
        public bool IsHidden { get; set; }
    }
}
