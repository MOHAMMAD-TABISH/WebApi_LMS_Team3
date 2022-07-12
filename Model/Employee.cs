using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LMS_Team3.Model
{
    public class Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public DateTime Emp_DOB { get; set; }
        public string Emp_City { get; set; }
        public string Emp_Email { get; set; }
        public long Emp_Mobile { get; set; }
        public string Emp_Dept { get; set; }
        public string Emp_Gender { get; set; }
        public long Emp_Salary { get; set; }
    }
}
