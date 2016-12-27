using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankProject.Core.Utils;
using BloodBankProject.Core.Entities;

namespace BloodBankProject.Core.Data
{
    public class BloodBankContext : DbContext, IDisposable
    {
        public BloodBankContext() : base(Helpers.ConnectionString) { }


        public DbSet<User> Users { get; set; }
        public DbSet<Profile> UserProfiles { get; set; }
        public DbSet<PrivateMessage> PrivateMessages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
