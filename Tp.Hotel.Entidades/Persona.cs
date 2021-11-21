using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Tp.Hotel.Entidades
{
    //[DataContract]
    public class Persona
    {
        //Declaracion de atributos
        protected int _dni;
        protected string _nombre;
        protected string _apellido;
        protected string _direccion;
        protected string _email;
        protected string _telefono;
        protected DateTime _fechaNacimiento;

        //Creacion de propiedades
        //[DataMember]
        public int Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        //Creacion de constructores
        public Persona()
        { }

        public Persona(int dni, string nombre, string apellido, string direccion, string email, string telefono, DateTime fechaNacimiento )
        {
            dni = _dni;
            nombre = _nombre;
            apellido = _apellido;
            direccion = _direccion;
            email = _email;
            telefono = _telefono;
            fechaNacimiento = _fechaNacimiento;
        }
    }
}
