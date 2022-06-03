using GisysAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GisysAPI.Services
{
    public class EmployeeService : IEmployeeApiRepository
    {
        public async Task<Root> GetAll()
        {
            Root employeeList = new Root();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://dummy.restapiexample.com/api/v1/employees"))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        employeeList = JsonConvert.DeserializeObject<Root>(apiResponse);
                    }
                   else
                    {
                        employeeList.Status = response.StatusCode.ToString();
                    }

                }
            }
            return employeeList;
        }

        public async Task<Emp> GetOne(int id)
        {
            Emp employeeById = new Emp();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://dummy.restapiexample.com/api/v1/employee/{id}"))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        employeeById = JsonConvert.DeserializeObject<Emp>(apiResponse);
                    }
                    else
                        employeeById.Status = response.StatusCode.ToString();
                }
            }
            return employeeById;
        }
    }
}
