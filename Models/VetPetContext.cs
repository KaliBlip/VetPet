using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetPet.Models
{
    public class VetPetContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<VetConsultation> VetConsultations { get; set; }
        public DbSet<LostFound> LostFounds { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=vetpet.db");
        }
    }
}
