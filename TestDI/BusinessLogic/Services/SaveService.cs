using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDI.Repository;

namespace TestDI.BusinessLogic.Services
{
    public class SaveService : ISaveService
    {
        public EmployersRepo employersRepo;
        public SaveService(EmployersRepo employersRepo)
        {
            this.employersRepo = employersRepo;
        }

        public void Save()
        {
            employersRepo.Save();
        }
    }
}
