using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Tp.Hotel.Entidades
{
    [DataContract]
    public class Persona
    {
        protected int _dni;
        protected string _nombre;
        protected string _apellido;
        protected string _direccion;
        protected string _email;
        protected string _telefono;
        protected DateTime _fechaNacimiento;

        //Creacion de constructores
        [DataMember]
        public int Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

    }
}
