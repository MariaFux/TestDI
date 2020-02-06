using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestDI.BusinessLogic.Services;

namespace TestDI.Controllers
{
    public class EmployeeController : Controller
    {
        public SaveService saveService { get; set; }
        public GetEmployeeService employeeService { get; set; }
        public EmployeeController(SaveService saveService, GetEmployeeService employeeService)
        {
            this.saveService = saveService;
            this.employeeService = employeeService;
        }

        public void Save()
        {
            saveService.Save();
        }
    }
}