using Microsoft.EntityFrameworkCore;
using Sweaj.Serialization.Api.Models;

namespace Sweaj.Serialization.Api
{
    public class DemoContext : DbContext
    {
        public DemoContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=serialization-demo;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<VideoMetadata> VideoMetadatas { get; set; }
    }
}
