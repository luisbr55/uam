using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class Estudiante : Persona
	{
		#region Atributos
		private string _universidad;
		private string _carrera;
		private int _ingreso;
		#endregion

		#region Propiedades
		public string Universidad { get => _universidad; set => _universidad = value; }
		public string Carrera { get => _carrera; set => _carrera = value; }
		public int Ingreso { get => _ingreso; set => _ingreso = value; }
		#endregion

		#region Constructores
		public Estudiante()
		{
				
		}

		public Estudiante(string universidad, string carrera, int ingreso)
		{
			_universidad = universidad;
			_carrera = carrera;
			_ingreso = ingreso;
		}

		//Este contructor llama al constructor de la clase Base
		//Persona(string nombre, string apellidos, int identificacion, int fechaNacimiento, int telefono, string correo)
		public Estudiante(string universidad, string carrera, int ingreso, string nombre, string apellidos, int identificacion, int fechaNacimiento, int telefono, string correo) 
			: base(nombre, apellidos, identificacion, fechaNacimiento, telefono, correo)
		{
			_universidad = universidad;
			_carrera = carrera;
			_ingreso = ingreso;
		}
		#endregion
	}
}
