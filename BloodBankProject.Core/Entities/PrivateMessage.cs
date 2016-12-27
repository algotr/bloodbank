using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankProject.Core.Entities
{
    public class PrivateMessage
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string SenderUsername { get; set; }
        public string Message { get; set; }
        public bool IsNew { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual User User { get; set; }
    }
}
