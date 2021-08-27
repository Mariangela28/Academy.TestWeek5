using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.TestWeek5.Core.Models
{
    
        public enum Role
        {
            Ristoratore,
            Cliente
        }
        public class Account
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public Role Role { get; set; }
        }
    
}
