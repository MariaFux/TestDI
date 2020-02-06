using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDI.Repository.Models;

namespace TestDI.Repository
{
    interface IEmployersRepo
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int employeeID);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int employeeID);
        void Save();
    }
}
