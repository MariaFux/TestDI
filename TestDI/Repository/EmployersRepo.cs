using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDI.Repository.Models;

namespace TestDI.Repository
{
    public class EmployersRepo : IEmployersRepo
    {
        private readonly EmployersDbContext context;

        public EmployersRepo(EmployersDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return context.Employers.ToList();
        }

        public Employee GetById(int employeeID)
        {
            return context.Employers.Find(employeeID);
        }

        public void Insert(Employee employee)
        {
            context.Employers.Add(employee);
        }

        public void Update(Employee employee)
        {
            context.Entry(employee).State = EntityState.Modified;
        }

        public void Delete(int employeeID)
        {
            Employee employee = context.Employers.Find(employeeID);
            context.Employers.Remove(employee);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
