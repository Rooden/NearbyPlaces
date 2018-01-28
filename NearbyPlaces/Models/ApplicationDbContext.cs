namespace NearbyPlaces.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationDbContext : DbContext
    {
        public DbSet<Places> Places { get; set; }

        public ApplicationDbContext()
            : base("name=DefaultConnection")
        {
        }
    }
}
