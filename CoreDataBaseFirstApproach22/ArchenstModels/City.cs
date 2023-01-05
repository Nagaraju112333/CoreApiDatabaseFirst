using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class City
    {
        public City()
        {
            UserShipingAddresses = new HashSet<UserShipingAddress>();
        }

        public int CityId { get; set; }
        public string? CityName { get; set; }
        public int? StateId { get; set; }

        public virtual State? State { get; set; }
        public virtual ICollection<UserShipingAddress> UserShipingAddresses { get; set; }
    }
}
