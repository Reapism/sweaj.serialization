using Microsoft.EntityFrameworkCore;
using Sweaj.Serialization.Data.Models;

namespace Sweaj.Serialization.Data
{
    public class VideoContext : DbContext
    {
        public VideoContext()
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
