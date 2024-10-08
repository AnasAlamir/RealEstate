﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IInquiryRepository : IBaseRepository<Inquiry>
    {
        bool IsDuplicateInquiry(int userId, int propertyId);
    }
}
