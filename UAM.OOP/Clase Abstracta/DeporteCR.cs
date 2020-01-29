using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class DeporteCR : PersonaDeportesCAbst
	{
		public override void Basket()
		{
			Console.WriteLine("DeporteCR-> FIBA");
		}

		public override void Futbol()
		{
			Console.WriteLine("DeporteCR-> FIFA");
		}
	}
}
