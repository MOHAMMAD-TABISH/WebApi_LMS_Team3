using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplyLeaveController : ControllerBase
    {
        private readonly IApplyLeaveRepo applyLeaveRepo;

        public ApplyLeaveController(IApplyLeaveRepo applyLeaveRepo)
        {
            this.applyLeaveRepo = applyLeaveRepo;

        }
        [HttpGet]
        [Route("ShowAll_Leaves/{id}")]
        public List<ApplyLeave> Leave_List(int? id)
        {
            var list = applyLeaveRepo.ShowAllLeaves(id);
            return list;
        }
        [HttpPatch]
        [Route("ChangeStatus/{id}")]

        public int ChangeState(int? id, ApplyLeave applyLeave)
        {
            var data = applyLeaveRepo.ManagerState(id, applyLeave);
            return 1;
        }
        [HttpPut]
        [Route("NewLeave")]

        public async Task<int> AddNewLeave(ApplyLeave leave)
        {
            var newleave = await applyLeaveRepo.NewLeave(leave);
            return 1;
        }

    }
}
