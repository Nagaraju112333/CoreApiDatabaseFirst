using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
            UserShipingAddresses = new HashSet<UserShipingAddress>();
        }

        public int StateId { get; set; }
        public string? StateName { get; set; }
        public int? CountryId { get; set; }

        public virtual Country? Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<UserShipingAddress> UserShipingAddresses { get; set; }
    }
}
