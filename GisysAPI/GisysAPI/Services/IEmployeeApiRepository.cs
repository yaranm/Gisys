using GisysAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GisysAPI.Services
{
    public interface IEmployeeApiRepository
    {
        public Task<Root> GetAll();
        public Task<Emp> GetOne(int id);
    }
}
