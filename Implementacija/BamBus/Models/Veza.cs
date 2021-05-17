using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BamBus.Models
{
	public class Veza
	{
		public Stanica Stanica1 { get; set; }
		public Stanica Stanica2 { get; set; }
		public double Cijena { get; set; }
		public double MedjuVrijeme { get; set; }

		public Veza()
		{
		}

		public Veza(Stanica stanica1, Stanica stanica2, double cijena, double medjuVrijeme)
		{
			this.Stanica1 = stanica1;
			this.Stanica2 = stanica2;
			this.Cijena = cijena;
			this.MedjuVrijeme = medjuVrijeme;
		}
	}

}
