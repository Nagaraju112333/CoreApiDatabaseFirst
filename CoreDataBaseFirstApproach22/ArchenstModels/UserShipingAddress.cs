using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class UserShipingAddress
    {
        public UserShipingAddress()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int AdderssId { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? Firstname { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Apartment { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Pincode { get; set; }
        public string? PhoneNumber { get; set; }
        public int? UserId { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? Cityid { get; set; }

        public virtual City? CityNavigation { get; set; }
        public virtual Country? CountryNavigation { get; set; }
        public virtual State? StateNavigation { get; set; }
        public virtual Register? User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
