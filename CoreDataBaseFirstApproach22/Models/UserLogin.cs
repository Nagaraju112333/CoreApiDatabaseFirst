using System;
using System.Collections.Generic;

namespace CoreDataBaseFirstApproach22.Models
{
    public partial class UserLogin
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Token { get; set; }
    }
}
