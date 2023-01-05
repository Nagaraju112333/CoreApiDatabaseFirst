using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class Payment
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? ContectNumber { get; set; }
        public string? Address { get; set; }
        public int? Amount { get; set; }
    }
}
