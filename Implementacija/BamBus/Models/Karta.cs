using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BamBus.Models
{
    public class Karta
    {
        public int Id { get; set; }
        public bool Povratna { get; set; }
        public int IDPolazneVoznje1 { get; set; }
        public string QR { get; set; }
        public string ImePrezime { get; set; }
        public int IDPovratneVoznje { get ; set; }


        public virtual Kupac Korisnik { get; set; }
    }
}