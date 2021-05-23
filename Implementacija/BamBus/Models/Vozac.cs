using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BamBus.Models
{
    public class Vozac:Korisnik
    {
        public string TekstOUposleniku { get; set; }

        public Vozac(string Ime, string Prezime, DateTime Godiste, string Email, string Password,string Tekst):base(Ime,Prezime, Godiste, Email, Password)
        {
            TekstOUposleniku = Tekst;
        }
    }
}