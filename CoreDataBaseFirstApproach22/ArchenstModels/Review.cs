using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.ArchenstModels
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? ReviewTittle { get; set; }
        public string? Body { get; set; }
    }
}
