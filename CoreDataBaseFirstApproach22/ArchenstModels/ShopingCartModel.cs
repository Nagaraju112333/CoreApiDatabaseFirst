using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class ShopingCartModel
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public string? ItemName { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
        public string? Imagepath { get; set; }
        public int? UnitPrice { get; set; }
        public int? TotalPrice { get; set; }
        public int CartId { get; set; }
        public int? UserId { get; set; }
        public DateTime? Ondate { get; set; }
        public int? Size { get; set; }

        public virtual Products1 Item { get; set; } = null!;
        public virtual Register? User { get; set; }
    }
}
