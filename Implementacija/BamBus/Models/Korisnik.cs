using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BamBus.Models
{
    public class Korisnik
    {
        public string Ime{get;set; }
        public string Prezime { get; set; }
        public DateTime Godiste { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Korisnik(string Ime,string Prezime,DateTime Godiste,string Email,string Password)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Godiste = Godiste;
            this.Email = Email;
            this.Password = Password;
        }
    }
}