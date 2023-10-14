namespace EF_Project1TRY.Context
{
    using EF_Project1TRY.Models;
    using Microsoft.EntityFrameworkCore;

    public class CompanyContext
        : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
