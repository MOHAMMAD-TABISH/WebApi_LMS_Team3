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
    public class ManagerController : ControllerBase
    {
        DataAccessLayer_LMS _dataAccessLayer_LMS;
        public ManagerController(DataAccessLayer_LMS dataAccessLayer_LMS)
        {
            _dataAccessLayer_LMS = dataAccessLayer_LMS;
        }
        [HttpGet]
        public ActionResult<List<ManagerDb>> ShowAll()
        {
            var ab = _dataAccessLayer_LMS.Manager_T.ToList();
            return ab;
        }
        [HttpPost]
        public ActionResult<List<ManagerDb>> Insert(ManagerDb MngModel)
        {
            var ar = _dataAccessLayer_LMS.Manager_T.Add(new ManagerDb {Mng_Id=MngModel.Mng_Id, Mng_Email=MngModel.Mng_Email,Mng_Mobile=MngModel.Mng_Mobile,Mng_Name=MngModel.Mng_Name });
            _dataAccessLayer_LMS.SaveChanges();
            var res = _dataAccessLayer_LMS.Manager_T.ToList();
            return res;
        }
    }
}
