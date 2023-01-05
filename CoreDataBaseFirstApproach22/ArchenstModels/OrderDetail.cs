using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            OrderProductIds = new HashSet<OrderProductId>();
        }

        public int? Amount { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Userid { get; set; }
        public int? Addressid { get; set; }
        public string? RazorpayKey { get; set; }
        public string? Currency { get; set; }
        public string? Description { get; set; }
        public string? RazorpayOrderid { get; set; }
        public int Orderid { get; set; }

        public virtual UserShipingAddress? Address { get; set; }
        public virtual Register? User { get; set; }
        public virtual ICollection<OrderProductId> OrderProductIds { get; set; }
    }
}
