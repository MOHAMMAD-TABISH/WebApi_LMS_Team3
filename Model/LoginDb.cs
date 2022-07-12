using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LMS_Team3.Model
{
    public class LoginDb
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Emp_Password { get; set; }
        public string SecurityQuestion { get; set; }
        public int SecurityAnswer { get; set; }
    }
}
