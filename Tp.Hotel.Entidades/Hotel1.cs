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
        private int _id;
        private int _estrellas;
        private string _nombre;
        private string _direccion;
        private bool _amenities;
        private int _usuario;

        //Creacion de propiedades 
        public int id { get => _id; set => _id = value; }
        public int Estrellas { get => _estrellas; set => _estrellas = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public bool Amenities { get => _amenities; set => _amenities = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }

        //Creacion de constructores
        public Hotel1()
        { }

        public Hotel1(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }
        public Hotel1(int estrellas, string nombre, string direccion, bool amenities)
        {
            
            _estrellas = estrellas;
            _nombre = nombre;
            _direccion = direccion;
             _amenities = amenities;
          
        }
        public Hotel1(int id, int estrellas, string nombre, string direccion, bool amenities)
        {
            _id=id;
            _estrellas = estrellas;
            _nombre = nombre;
            _direccion = direccion;
            _amenities = amenities;

        }

        public string DisplayHotel
        {
            get
            {
                if (id <= 0)
                {
                    return Nombre;
                }
                else
                {
                    return (Nombre + " Estrellas: " + Estrellas);
                }
                
            }
        }
    }
}
