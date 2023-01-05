using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class OrderDetail1
    {
        public int OderDetaislId { get; set; }
        public int Orderid { get; set; }
        public int Productid { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }
}
