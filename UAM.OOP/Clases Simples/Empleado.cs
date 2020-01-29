using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP.Clases_simple
{
	public class Empleado: Persona
	{
		#region atributos
		private int _carnet;
		private string _sede;
		#endregion

		#region Propiedades
		public int Carnet { get => _carnet; set => _carnet = value; }
		public string Sede { get => _sede; set => _sede = value; }
		#endregion

		#region Constructores
		public Empleado()
		{

		}

		public Empleado(int carnet, string sede)
		{
			_carnet = carnet;
			_sede = sede;
		}

		public Empleado(int carnet, string sede, string nombre, string apellidos, int identificacion, int fechaNacimiento, int telefono, string correo)
			: base(nombre, apellidos, identificacion, fechaNacimiento, telefono, correo)
		{
			_carnet = carnet;
			_sede = sede;
		}

		#endregion
	}
}
