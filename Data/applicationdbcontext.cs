using EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class Applicationdbcontext : DbContext
    {
        public Applicationdbcontext(DbContextOptions<Applicationdbcontext> options) : base(options) 
        {   
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
