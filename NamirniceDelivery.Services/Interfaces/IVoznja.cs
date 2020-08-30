﻿using NamirniceDelivery.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NamirniceDelivery.Services.Interfaces
{
    public interface IVoznja
    {
        List<Voznja> GetVoznje();
        List<Voznja> GetVoznjeForVozacNeObavljenje(string vozacUsername);
        void PreuzmiRobu(string name, int voznjaId);
        void OznaciKaoZavrsenu(string name, int voznjaId);
    }
}
