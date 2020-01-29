using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public abstract class PersonaDeportesCAbst
	{

		public abstract void Futbol();

		public abstract void Basket();

		public virtual void Tennis() {
			Console.WriteLine("AbstClass->Jugando Tennis");
		}

		public void BaseBall() {
			Console.WriteLine("AbstClass->Jugando BaseBall");
		}

	}
}
