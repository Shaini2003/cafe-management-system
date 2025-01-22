using cafe_management_system.Models;
using Microsoft.EntityFrameworkCore;

namespace cafe_management_system.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>contextOptions):
            base(contextOptions)
        {

        }
        
        public DbSet<Employee> Employees { get; set; }
    }
}
