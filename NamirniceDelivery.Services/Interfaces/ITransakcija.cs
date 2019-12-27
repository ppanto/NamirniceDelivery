﻿using System;
using System.Collections.Generic;
using System.Text;
using NamirniceDelivery.Data.Entities;

namespace NamirniceDelivery.Services.Interfaces
{
    public interface ITransakcija
    {
        void BrzaKupovina(NamirnicaPodruznica namirnicaPodruznica, int brojNamirnica, Kupac kupac);
        void RealizujKupovine(List<KorpaStavka> list);
        List<Transakcija> GetTransakcije();
        public List<Transakcija> GetTransakcijeForKupac(Kupac kupac);
        public List<Transakcija> GetNepotvrdjeneTransakcijeForKupac(Kupac kupac);
        public List<Transakcija> GetTransakcijeForPodruznica(Podruznica podruznica);
        public List<Transakcija> GetTransakcijeForRadnik(AdministrativniRadnik radnik);
        public List<Transakcija> GetNepotvrdjeneTransakcijeForPodruznica(Podruznica podruznica);
    }
}