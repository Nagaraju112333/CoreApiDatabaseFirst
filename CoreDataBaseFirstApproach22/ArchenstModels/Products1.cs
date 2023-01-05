using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class Products1
    {
        public Products1()
        {
            OrderProductIds = new HashSet<OrderProductId>();
            ShopingCartModels = new HashSet<ShopingCartModel>();
            Sizes = new HashSet<Size>();
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
        public int? Pstatus { get; set; }
        public string? Image5 { get; set; }
        public string? Image6 { get; set; }
        public string? Image7 { get; set; }
        public string? Image8 { get; set; }
        public int? Quantity { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<OrderProductId> OrderProductIds { get; set; }
        public virtual ICollection<ShopingCartModel> ShopingCartModels { get; set; }
        public virtual ICollection<Size> Sizes { get; set; }
    }
}
