using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.Models
{
    public partial class Register
    {
        public int RegisterId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsEmailVerified { get; set; }
        public Guid ActivationCode { get; set; }
        public string? ResetpasswordCode { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
