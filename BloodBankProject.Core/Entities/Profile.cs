using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankProject.Core.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BloodType { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public bool IsDonor { get; set; }
        public string Phone { get; set; }
        public DateTime? LastDontaionDate { get; set; }

        
    }
}
