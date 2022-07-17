using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    interface IEmployeeRepo
    {
        Task<Employee> MyDetailsAsync(int? id);
        Task<List<Employee>> ShowAllEMPAsync();
        Task<int> Insert_Employee_Async(Employee employee);
    }
}
