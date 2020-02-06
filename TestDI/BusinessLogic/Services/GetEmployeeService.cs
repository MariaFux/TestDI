using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDI.Repository;
using TestDI.Repository.Models;

namespace TestDI.BusinessLogic.Services
{
    public class GetEmployeeService : IGetEmployeeService
    {
        public EmployersRepo employersRepo { get; set; }
        public GetEmployeeService(EmployersRepo employersRepo)
        {
            this.employersRepo = employersRepo;
        }
        public Employee GetEmployee(int employeeID)
        {
            return employersRepo.GetById(employeeID);
        }
    }
}
