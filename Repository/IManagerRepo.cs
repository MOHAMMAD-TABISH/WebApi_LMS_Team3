using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    interface IManagerRepo
    {
        Task<Manager> getManagerAsync(int? id);

    }
}
