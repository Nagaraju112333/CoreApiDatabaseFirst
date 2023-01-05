using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class OrderProductId
    {
        public int OrderPid { get; set; }
        public int? ProductId { get; set; }
        public int? Orderid { get; set; }

        public virtual OrderDetail? Order { get; set; }
        public virtual Products1? Product { get; set; }
    }
}
