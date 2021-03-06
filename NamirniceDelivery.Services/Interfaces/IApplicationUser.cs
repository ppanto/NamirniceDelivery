﻿using NamirniceDelivery.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NamirniceDelivery.Services.Interfaces
{
    public interface IApplicationUser
    {
        ApplicationUser GetUser(string username);
        void SetLogedInTimeStamp(ApplicationUser user);
    }
}
