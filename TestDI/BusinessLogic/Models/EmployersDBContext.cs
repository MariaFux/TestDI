using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestDI.BusinessLogic.Models
{
    public class EmployersDBContext : DbContext
    {
        public EmployersDBContext()
        {
        }

        public EmployersDBContext(DbContextOptions<EmployersDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employers { get; set; }
    }
}
