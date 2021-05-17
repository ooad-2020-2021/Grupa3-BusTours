using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BamBus.Models
{
    public class Stanica
    {
		public string Grad { get; set; }
		public long XOsa { get; set; }
		public long YOsa { get; set; }
		public string Opis { get; set; }

		public Stanica()
        {
        }

		public Stanica(string grad, long xOsa, long yOsa, string opis = "")
		{
			this.Grad = grad;
			this.XOsa = xOsa;
			this.YOsa = yOsa;
			this.OpisOpis = opis;
		}
	}
}
