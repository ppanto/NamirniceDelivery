﻿using Microsoft.EntityFrameworkCore;
using NamirniceDelivery.Data.Context;
using NamirniceDelivery.Data.Entities;
using NamirniceDelivery.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamirniceDelivery.Services.Services
{
    public class TransakcijaService : ITransakcija
    {
        private readonly MyContext _context;

        public TransakcijaService(MyContext context)
        {
            _context = context;
        }

        public void BrzaKupovina(NamirnicaPodruznica namirnicaPodruznica, int brojNamirnica, Kupac kupac)
        {
            Transakcija t = new Transakcija
            {
                DatumIniciranjaTransakcije = DateTime.Now,
                DostavaUspjesna = false,
                Kupac = kupac,
                KupacOstavioDojam = false,
                NarudzbaPrihvacenaOdRadnika = false,
                RadnikOstavioDojam = false,
                TipTransakcije = _context.TipTransakcije.Find(1),
                PodruznicaId = namirnicaPodruznica.PodruznicaId
            };
            _context.Transakcija.Add(t);
            _context.KupljeneNamirnice.Add(new KupljeneNamirnice
            {
                Kolicina = brojNamirnica,
                NamirnicaId = namirnicaPodruznica.NamirnicaId,
                Transakcija = t,
                Cijena = Math.Round(namirnicaPodruznica.CijenaSaPopustom,2)
            });
            namirnicaPodruznica.KolicinaNaStanju -= brojNamirnica;
            _context.SaveChanges();
        }

        public List<Transakcija> GetNepotvrdjeneTransakcijeForKupac(Kupac kupac)
        {
            return GetTransakcijeForKupac(kupac)
                .Where(t => t.NarudzbaPrihvacenaOdRadnika == false)
                .ToList();
        }

        public List<Transakcija> GetNepotvrdjeneTransakcijeForPodruznica(Podruznica podruznica)
        {
            var t = GetTransakcijeForPodruznica(podruznica)
                .Where(t => t.NarudzbaPrihvacenaOdRadnika == false)
                .ToList();
            return t;
        }

        public List<Transakcija> GetTransakcije()
        {
            var t = _context.Transakcija
                .Include(t => t.Kupac)
                .Include(t => t.AdministrativniRadnik)
                .Include(t => t.Podruznica)
                .Include(t => t.TipTransakcije)
                .Include(t => t.KupljeneNamirnice)
                    .ThenInclude(kn => kn.Namirnica)
                .ToList();
            return t;
        }

        public List<Transakcija> GetTransakcijeForKupac(Kupac kupac)
        {
            var t = GetTransakcije()
                .Where(t => t.Kupac == kupac)
                .ToList();
            return t;
        }

        public List<Transakcija> GetTransakcijeForPodruznica(Podruznica podruznica)
        {
            return GetTransakcije()
                .Where(t => t.Podruznica == podruznica)
                .ToList();
        }

        public List<Transakcija> GetTransakcijeForRadnik(AdministrativniRadnik radnik)
        {
            var tList = GetTransakcije();
            var list = new List<Transakcija>();
            foreach(var t in tList)
            {
                if(t.AdministrativniRadnik!=null && t.AdministrativniRadnik == radnik)
                {
                    list.Add(t);
                }
            }
            return list;
        }

        public void RealizujKupovine(List<KorpaStavka> list)
        {
            if (list.Count == 0) return;
            List<Podruznica> razlicitePodruznice = new List<Podruznica>();
            foreach(var item in list)
            {
                if (!razlicitePodruznice.Contains(item.NamirnicaPodruznica.Podruznica))
                {
                    razlicitePodruznice.Add(item.NamirnicaPodruznica.Podruznica);
                }
            }
            foreach(var podruznica in razlicitePodruznice)
            {
                Transakcija t = new Transakcija
                {
                    DatumIniciranjaTransakcije = DateTime.Now,
                    DostavaUspjesna = false,
                    Kupac = list[0].Kupac,
                    KupacOstavioDojam = false,
                    NarudzbaPrihvacenaOdRadnika = false,
                    RadnikOstavioDojam = false,
                    TipTransakcije = _context.TipTransakcije.Find(1),
                    PodruznicaId = podruznica.Id
                };

                foreach (var stavka in list)
                {
                    if (stavka.NamirnicaPodruznicaId == podruznica.Id)
                    {
                        _context.KupljeneNamirnice.Add(new KupljeneNamirnice
                        {
                            Kolicina = stavka.Kolicina,
                            Cijena = Math.Round(stavka.NamirnicaPodruznica.CijenaSaPopustom, 2),
                            Namirnica = stavka.NamirnicaPodruznica.Namirnica,
                            Transakcija = t
                        });
                        _context.KorpaStavka.Remove(stavka);

                        if(stavka.NamirnicaPodruznica.KolicinaNaStanju- stavka.Kolicina > 0) {
                            // kolicina to 0
                            stavka.NamirnicaPodruznica.KolicinaNaStanju -= stavka.Kolicina;
                        }
                        else
                        {
                            stavka.NamirnicaPodruznica.KolicinaNaStanju = 0;
                            stavka.NamirnicaPodruznica.Aktivna = false;
                        }
                    }
                }
                _context.Transakcija.Add(t);
            }
            _context.SaveChanges();
        }
    }
}