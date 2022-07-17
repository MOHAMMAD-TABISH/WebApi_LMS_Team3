using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.DataAccessLayer;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    public class ManagerRepo:IManagerRepo
    {
        private readonly DataAccessLayer_LMS dataAccessLayer_LMS;
        private readonly IMapper mapper;

        public ManagerRepo(DataAccessLayer_LMS dataAccessLayer_LMS, IMapper mapper)
        {
            this.dataAccessLayer_LMS = dataAccessLayer_LMS;
            this.mapper = mapper;
        }


        public async Task<Manager> getManagerAsync(int? id)
        {
            var details = await dataAccessLayer_LMS.Manager_T.FirstOrDefaultAsync(x => x.Mng_Id == id);
            var details_View = mapper.Map<Manager>(details);

            return details_View;

        }
    }
}
