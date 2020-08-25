using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDI.Repository;
using TestDI.Repository.Models;

namespace TestDI.BusinessLogic.Services
{
    interface IGetEmployeeService
    {
        Employee GetEmployee(int employeeID);
    }
}
