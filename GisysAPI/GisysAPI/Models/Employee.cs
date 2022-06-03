using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GisysAPI.Models
{

    public class Root
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public List<Employee> Employees { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

    }
    public class Emp
    {
        [JsonProperty("data")]
        public Employee OneEmpployee { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
    public class Employee
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("employee_name")]
        public string Name { get; set; }

        [JsonProperty("employee_salary")]
        public int Salary { get; set; }

        [JsonProperty("employee_age")]
        public int Age { get; set; }

        [JsonProperty("profile_image")]
        public string Image { get; set; }
    }
}