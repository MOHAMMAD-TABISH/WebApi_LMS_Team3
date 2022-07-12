using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LMS_Team3.Model
{
    public class LeaveDb
    {
        [Key]
        public int LeaveId { get; set; }
        public int Emp_Id { get; set; }
        public int EarnedLeaves { get; set; }
        public int MedicalLeaves { get; set; }
        public int TotalRemainingLeaves { get; set; }
        public int PendingLeaveApproval { get; set; }
        public int LeavesApproved { get; set; }

    }
}
