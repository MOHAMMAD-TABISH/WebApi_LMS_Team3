using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LMS_Team3.Model
{
    public class Login
    {
        [Required]
        public int Emp_Id { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Emp_Password { get; set; }
        [Required]
        public string SecurityQuestion { get; set; }
        [Required]
        public int SecurityAnswer { get; set; }
    }
}
