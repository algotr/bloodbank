using System;
using System.Collections.Generic;

namespace BloodBankProject.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Profile UserProfile { get; set; }

        public virtual IList<PrivateMessage> UserMessages { get; set; }
    }
}
