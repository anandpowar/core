using Microsoft.EntityFrameworkCore;
using RecipeApi.Entities;

namespace RecipeApi.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        // public DbSet<Recipe> Recipes { get; set; }
    }
}
