using CodePlusAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodePlusAPI.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
