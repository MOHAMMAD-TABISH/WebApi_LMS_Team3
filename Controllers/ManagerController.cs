using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.DataAccessLayer;
using WebApi_LMS_Team3.Model;
using WebApi_LMS_Team3.Repository;

namespace WebApi_LMS_Team3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {

       
            private readonly IManagerRepo managerRepo;

            public ManagerController(IManagerRepo managerRepo)
            {
                this.managerRepo = managerRepo;
            }

            [HttpGet]
            [Route("MyMangerDetails/{id}")]

            public async Task<IActionResult> getMangaerDetails(int? id)
            {
                var get_details_manager = await managerRepo.getManagerAsync(id);
                return Ok(get_details_manager);
            }
        }
    }
