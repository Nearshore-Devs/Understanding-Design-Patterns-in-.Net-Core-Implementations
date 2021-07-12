﻿using NearshoreDevs.Application.CQRS.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.CQRS.Interfaces
{
    public interface ISaveCustomerCommandHandler
    {
        Task<int> SaveAsync(SaveCustomerRequestModel saveCustomerRequestModel);
    }
}
