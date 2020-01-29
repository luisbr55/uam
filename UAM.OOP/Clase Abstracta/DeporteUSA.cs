using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class DeporteUSA : PersonaDeportesCAbst
	{
		public override void Basket()
		{
			Console.WriteLine("DeporteUSA-> NBA");
		}

		public override void Futbol()
		{
			Console.WriteLine("DeporteUSA-> NFL");
		}

		public override void Tennis()
		{
			Console.WriteLine("DeporteUSA->Jugando Tennis Sintetico");
		}
	}
}
