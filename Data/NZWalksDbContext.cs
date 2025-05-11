using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using WebApplication2.Models.Domain;

namespace WebApplication2.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
                
        }

        //Data sets

        public DbSet<Difficuilty> Difficuilties { get; set; }

        public DbSet<Region> Regions { get; set; }
        
        public DbSetSource

    }
}
