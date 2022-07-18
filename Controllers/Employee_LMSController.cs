using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.DataAccessLayer;
using WebApi_LMS_Team3.Model;
using WebApi_LMS_Team3.Repository;

namespace WebApi_LMS_Team3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee_LMSController : ControllerBase
    {
        private readonly IEmployeeRepo employeeRepo;

        public Employee_LMSController(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }
        [HttpGet]
        [Route("MyDetails/{id}")]

        public async Task<IActionResult> MyDetails_Id(int? id)
        {
            var get_details = await employeeRepo.MyDetailsAsync(id);
            return Ok(get_details);
        }
        [HttpGet]
        [Route("ShowAll")]

        public async Task<IActionResult> ShowAll()
        {
            var get_allemp = await employeeRepo.ShowAllEMPAsync();
            return Ok(get_allemp);
        }
        [HttpPost]
        [Route("InsertEmpolyee")]
        public async Task<int> InsertEmployee(Employee employeeModel)
        {
            var add = await employeeRepo.Insert_Employee_Async(employeeModel);
            return 1;
        }
        [HttpPut]
        [Route("Login/{email}/{password}")] 
        public async Task<int> Login(string email, string password)
        {
            var add = await employeeRepo.Login_Async(email, password);
            return 1;
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<int> Delete(int? id)
        {
            var get_details = await employeeRepo.DeleteEmp_Async(id);
            return 1;
        }

    }
}
