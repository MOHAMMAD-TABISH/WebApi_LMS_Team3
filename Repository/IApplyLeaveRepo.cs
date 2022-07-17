using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    interface IApplyLeaveRepo
    {
        List<ApplyLeave> ShowAllLeaves(int? id);
        int ManagerState(int? id, ApplyLeave applyleave);

        Task<int> NewLeave(ApplyLeave applyleave);

    }
}
