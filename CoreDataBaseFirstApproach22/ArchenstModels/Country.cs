using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
            UserShipingAddresses = new HashSet<UserShipingAddress>();
        }

        public int CountryId { get; set; }
        public string? CountryName { get; set; }

        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<UserShipingAddress> UserShipingAddresses { get; set; }
    }
}
