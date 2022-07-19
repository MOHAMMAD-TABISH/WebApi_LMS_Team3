using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    public interface IEmployeeRepo
    {
        Task<Employee> MyDetailsAsync(int? id);
        Task<List<Employee>> ShowAllEMPAsync();
        Task<int> Insert_Employee_Async(EmployeeDb employee);
        Task<int> Login_Async(string email, string password);
        Task<int> DeleteEmp_Async(int? id);
    }
}
