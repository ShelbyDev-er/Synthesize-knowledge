using Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class PodStoreContext : DbContext
    {
        public DbSet<PodDataModel> Pods { get; set; }
        public DbSet<PodCategoryDataModel> PodCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SQL Tutorial;Trusted_Connection=True;"); 
        }
    }
}
