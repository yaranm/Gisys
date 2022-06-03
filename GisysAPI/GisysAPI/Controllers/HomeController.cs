using GisysAPI.Models;
using GisysAPI.Services;
using GisysAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GisysAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeApiRepository _employeeRep;

        public HomeController(ILogger<HomeController> logger, IEmployeeApiRepository employeeRep)
        {
            _logger = logger;
            _employeeRep = employeeRep;
        }
        
        public async Task<IActionResult> Index()
        {
            var viewModel = new EmployeeListViewModel();
            var apiResp = await _employeeRep.GetAll();

            if(apiResp.Employees != null)
            {
                viewModel.ListOfEmployee = apiResp.Employees.Select(a => new EmployeeViewModel
                {
                    Name = a.Name,
                    Id = a.Id
                }).ToList();
            }
            else
                ViewBag.StatusCode = apiResp.Status;


            return View(viewModel);
        }

        
        public async Task<IActionResult> GetEmployee(int id)
        {
            var viewModel = new EmployeeViewModel();
            var apiResp = await _employeeRep.GetOne(id);

            if (apiResp.OneEmpployee != null)
            {
                viewModel.Image = apiResp.OneEmpployee.Image;
                viewModel.Name = apiResp.OneEmpployee.Name;
                viewModel.Salary = apiResp.OneEmpployee.Salary;
                viewModel.Age = apiResp.OneEmpployee.Age;
            }
            else
            {
                ViewBag.StatusCode = apiResp.Status;
            }
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
