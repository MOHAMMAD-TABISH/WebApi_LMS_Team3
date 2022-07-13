﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LMS_Team3.Model
{
    public class ApplyLeaveDb
    {
        [Key]
       
        public int Emp_Id { get; set; }
        public int NoOfDays { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveType { get; set; }
        public string LeaveStatus { get; set; }
        public string LeaveReason { get; set; }
        public DateTime AppliedOn { get; set; }
        public string Mng_Comments{ get; set; }

    }
}
