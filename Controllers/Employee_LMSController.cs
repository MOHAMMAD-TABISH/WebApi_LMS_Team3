using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.DataAccessLayer;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee_LMSController : ControllerBase
    {
        DataAccessLayer_LMS _dataAccessLayer_LMS;
        public Employee_LMSController(DataAccessLayer_LMS dataAccessLayer_LMS)
        {
            _dataAccessLayer_LMS = dataAccessLayer_LMS;
        }
        [HttpGet]
        public ActionResult<List<EmployeeDb>> ShowAll()
        {
            var ar = _dataAccessLayer_LMS.Employee_T.ToList();
            return ar;
        }
        [HttpPost]
        public ActionResult<List<EmployeeDb>> Insert(EmployeeDb EmpModel)
        {
            var ar = _dataAccessLayer_LMS.Employee_T.Add(new EmployeeDb { Emp_Name = EmpModel.Emp_Name, Emp_City = EmpModel.Emp_City, Emp_Dept = EmpModel.Emp_Dept, Emp_DOB = EmpModel.Emp_DOB, Emp_Email = EmpModel.Emp_Email, Emp_Gender = EmpModel.Emp_Gender, Emp_Id = EmpModel.Emp_Id, Emp_Mobile = EmpModel.Emp_Mobile, Emp_Salary = EmpModel.Emp_Salary });
            _dataAccessLayer_LMS.SaveChanges();
            var res = _dataAccessLayer_LMS.Employee_T.ToList();
            return res;
        }

    }
}
