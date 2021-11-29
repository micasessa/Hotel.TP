using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Hotel.Entidades
{
    public class Hotel1
    {
        //Declaracion de atributos
        private int _idHotel;
        private int _estrellas;
        private string _nombre;
        private string _direccion;
        private bool _amenities;
        private int _usuario;

        //Creacion de propiedades 
        public int IdHotel { get => _idHotel; set => _idHotel = value; }
        public int Estrellas { get => _estrellas; set => _estrellas = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public bool Amenities { get => _amenities; set => _amenities = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }

        //Creacion de constructores
        public Hotel1()
        { }


        public Hotel1(int estrellas, string nombre, string direccion, bool amenities)
        {
            
            _estrellas = estrellas;
            _nombre = nombre;
            _direccion = direccion;
             _amenities = amenities;
          
        }
       
        public string DisplayHotel
        {
            get
            {
                return (Nombre + " Estrellas: " + Estrellas);
            }
        }
    }
}
