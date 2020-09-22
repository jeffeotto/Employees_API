using System;
using Microsoft.EntityFrameworkCore;
namespace Employees_API.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeContext> Employees { get; set; }
    }
}
