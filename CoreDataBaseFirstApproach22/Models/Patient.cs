using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.Models
{
    public partial class Patient
    {
        public int Id { get; set; }
        public string? PatientName { get; set; }
        public int? Age { get; set; }
    }
}
