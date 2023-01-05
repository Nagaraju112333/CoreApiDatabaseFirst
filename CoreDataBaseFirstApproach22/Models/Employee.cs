using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int? Salary { get; set; }
        public string? Gender { get; set; }
    }
}
