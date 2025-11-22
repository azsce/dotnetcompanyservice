using Company.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.Data.Context
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }


    }
}
