using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP.Clases_simple
{
	public class Profesor: Empleado
	{
		#region atributos
		private string _carrera;
		private int  _experiencia;
		#endregion

		#region Propiedades
		public string Carrera { get => _carrera; set => _carrera = value; }
		public int Experiencia { get => _experiencia; set => _experiencia = value; }
		#endregion

		public Profesor()
		{

		}

		public Profesor(string carrera, int experiencia)
		{
			_carrera = carrera;
			_experiencia = experiencia;
		}

		public Profesor(string carrera, int experiencia, int carnet, string sede, string nombre, string apellidos, int identificacion, int fechaNacimiento, int telefono, string correo)
			: base(carnet, sede, nombre, apellidos, identificacion, fechaNacimiento, telefono, correo)
		{
			_carrera = carrera;
			_experiencia = experiencia;
		}
	}
}
