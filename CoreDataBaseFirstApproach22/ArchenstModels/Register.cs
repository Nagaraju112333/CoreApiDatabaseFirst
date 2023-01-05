using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class Register
    {
        public Register()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ShopingCartModels = new HashSet<ShopingCartModel>();
            UserShipingAddresses = new HashSet<UserShipingAddress>();
        }

        public int RegisterId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsEmailVerified { get; set; }
        public Guid ActivationCode { get; set; }
        public string? ResetpasswordCode { get; set; }
        public string? PhoneNumber { get; set; }
        public int? RoleType { get; set; }
        public int? Roleid { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ShopingCartModel> ShopingCartModels { get; set; }
        public virtual ICollection<UserShipingAddress> UserShipingAddresses { get; set; }
    }
}
