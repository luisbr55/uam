using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
	public class Persona
	{
		#region Atributos
		private string _nombre;
		private string _apellidos;
		private int _identificacion;
		private int _fechaNacimiento;
		private int _telefono;
		public string _correo;
		#endregion

		#region Propiedades
		//Forma1
		public string Nombre { get => _nombre; set => _nombre = value; }

		//Forma2
		public string Apellidos { get; set; }

		//Forma3
		public int Identificacion
		{
			get { return _identificacion; }
			//set { _identificacion = value; }
		}

		public int FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

		public int Telefono
		{
			get { return _telefono; }

			set { _telefono = value; }
		}


		#endregion

		#region Constructores
		public Persona()
		{

		}

		public Persona(string nombre, string apellidos, int identificacion, int fechaNacimiento, int telefono, string correo)
		{
			_nombre = nombre;
			_apellidos = apellidos;
			_identificacion = identificacion;
			_fechaNacimiento = fechaNacimiento;
			_telefono = telefono;
			_correo = correo;
		}
		#endregion

		#region Metodos
		public String NombreCompleto()
		{
			return string.Format("Nombre: {0}, {1} -> Clase Persona", _apellidos, _nombre);
		}

		public String DatosPersonales()
		{
			return string.Format("Nombre: {0}, {1} /n Telefono {2}", _apellidos, _nombre, _telefono);
		}
		#endregion
	}
}
