using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TestDI.Repository.Models
{
    public class EmployersDbContext : DbContext
    {
        public EmployersDbContext()
        {
        }

        public EmployersDbContext(DbContextOptions<EmployersDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employers { get; set; }
    }
}
