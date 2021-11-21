using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Hotel.Entidades
{
    //[DataContract]
    public class Cliente : Persona
    {
        //Declaracion de atributos
        private int _idCliente;
        private DateTime _fechaAlta;
        private bool _activo;
        private string _usuario;

        //creacion propiedades
        //Falta agregar los datamembers (checkear los nombres del postman)
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; } //estoy con duda si agregarlo o no
        public bool Activo { get => _activo; set => _activo = value; }
        public string Usuario { get => _usuario; set => _usuario = value; } //estoy con duda si agregarlo o no

        //creacion constructores. COMMENT: NO SE SI PONER EN EL CONSTRUCTOR LA FECHA DE ALTA Y EL NUM DE USUARIO!
        public Cliente()
        { 
        }
        public Cliente(int dni, string nombre, string apellido, string direccion, string email, string telefono, DateTime fechaNacimiento, int idCliente, DateTime fechaAlta, bool activo, string usuario ) : base(dni, nombre, apellido, direccion, email, telefono, fechaNacimiento)
        {
            idCliente = _idCliente;
            fechaAlta = _fechaAlta;
            activo = _activo;
            usuario = _usuario;
        }

    }
}
