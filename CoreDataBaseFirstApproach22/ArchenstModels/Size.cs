using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class Size
    {
        public int SizeId { get; set; }
        public int? Size1 { get; set; }
        public int? Quantity { get; set; }
        public int? ProductId { get; set; }

        public virtual Products1? Product { get; set; }
    }
}
