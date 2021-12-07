using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Hotel.Entidades
{
    
    public class Cliente : Persona
    {
        //Declaracion de atributos
        private int _id;
        private DateTime _fechaAlta;
        private bool _activo;
        private string _usuario;

        //creacion propiedades        
        public int id { get => _id; set => _id = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; } 
        public bool Activo { get => _activo; set => _activo = value; }
        public string Usuario { get => _usuario; set => _usuario = value; } 

        //creacion constructores
        public Cliente()
        { 
        }
        public Cliente(int dni, string nombre, string apellido, string direccion, string email, string telefono, 
            DateTime fechaNacimiento ) : base(dni, nombre, apellido, direccion, email, telefono, fechaNacimiento)
        {
           
            _fechaAlta = DateTime.Now;
            _activo = true;
            
           
        }
        public Cliente(int idCliente, int dni, string nombre, string apellido, string direccion, string email, string telefono,
            DateTime fechaNacimiento) : base(dni, nombre, apellido, direccion, email, telefono, fechaNacimiento)
        {
            _id = id;
            _fechaAlta = DateTime.Now;
            _activo = true;


        }
        public string DisplayCliente
        {
            get
            {
                return (Nombre + " " + Apellido + " Dni: " + Dni);
            }
        }

        public string Display
        {
            get
            {
                return $"Cliente: {Apellido.ToUpper()}, {Nombre.ToUpper()} ";
            }
        }



    }
}
