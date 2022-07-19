﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_LMS_Team3.Model;

namespace WebApi_LMS_Team3.Repository
{
    public interface IManagerRepo
    {
        Task<Manager> getManagerAsync(int? id);
        Task <List<Manager>> ShowAllMNGAsync();
    }
}
