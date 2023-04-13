using EmployeesWebAppication.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesWebAppication.Data
{
    public class EmployContext: DbContext
    {
        public EmployContext(DbContextOptions<EmployContext> options):base(options) 
        {

        }

        public DbSet<Employ> Employees { get; set; } 
    }
}
