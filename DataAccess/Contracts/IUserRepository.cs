﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IUserRepository :IBaseRepository<User>
    {
        bool IsDuplicateUser(string email, string phoneNumber);
    }
}
