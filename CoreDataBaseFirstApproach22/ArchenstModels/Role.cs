using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class Role
    {
        public Role()
        {
            Registers = new HashSet<Register>();
        }

        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ICollection<Register> Registers { get; set; }
    }
}
