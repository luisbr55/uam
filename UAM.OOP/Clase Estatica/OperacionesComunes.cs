using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public static class OperacionesOperacionesComunes
	{
		static int _numero1;
		static int _numero2;

		public static int Sumar(int n1, int n2) {
			return n1 + n2;
		}

		public static int Sumar(int n1, int n2, int n3)
		{
			return n1 + n2 + n3;
		}

		public static void EscribirNumero1(int n1)
		{
			_numero1 = n1;
		}

		public static void setNumero1(int n1)
		{
			_numero1 = n1;
		}

		public static void EscribirNumero2(int n2)
		{
			_numero2 = n2;
		}

		public static void setNumero2(int n2)
		{
			_numero2 = n2;
		}
	}
}
