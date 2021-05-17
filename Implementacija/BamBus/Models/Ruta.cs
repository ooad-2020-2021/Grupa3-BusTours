using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BamBus.Models
{
	public class Ruta
	{
		public string MapaURL { get; set; }
		public double Duzina { get; set; }
		public List<string> AlternativnaMapa { get; set; }
		public double Troskovi { get; set; }
		public int Id { get; set; }
		public List<Veza> VezeStanica { get; set; }

		public Ruta()
		{
		}

		public Ruta(string mapaURL, double duzina, List<Veza> vezeStanica, double troskovi, int id)
		{
			this.MapaURL = mapaURL;
			this.Duzina = duzina;
			this.Troskovi = troskovi;
			this.VezeStanica = vezeStanica;
			this.Id = id;
		}

		public bool dodajVezu(Veza veza)
		{
			if (VezeStanica.Contains(veza))
			{
				return false;
			}
			VezeStanica.Add(veza);
			return true;
		}

		public bool dodajAlternativnuMapu(string mapa)
		{
			if (AlternativnaMapa.Contains(mapa))
			{
				return false;
			}
			this.AlternativnaMapa.Add(mapa);
			return true;
		}

		public bool obrisiVezu(Veza veza)
		{
			if (VezeStanica.Contains(veza))
			{
				VezeStanica.Remove(veza);
				return true;
			}
			return false;
		}

		public bool obrisiAlternativnuMapu(string mapa)
		{
			if (AlternativnaMapa.Contains(mapa))
			{
				AlternativnaMapa.Remove(mapa);
				return true;
			}
			return false;
		}




	}
}
