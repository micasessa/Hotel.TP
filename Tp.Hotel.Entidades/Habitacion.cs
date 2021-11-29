using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Hotel.Entidades
{
    public class Habitacion
    {
        //Declaracion de atributos
        private int _idHabitacion;
        private int _idHotel;
        private int _cantidadPlazas;
        private string _categoria;
        private double _precio;
        private bool _cancelable;
        private int _usuario;

        //Creacion de propiedades
        public int IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }
        public int IdHotel { get => _idHotel; set => _idHotel = value; }
        public int CantidadPlazas { get => _cantidadPlazas; set => _cantidadPlazas = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public bool Cancelable { get => _cancelable; set => _cancelable = value; }
        public int Usuario { get => _usuario; set => _usuario = value; } 


        //Creacion de constructores
        public Habitacion()
        { }

        public Habitacion(int idHabitacion, int idHotel, int cantidadPlazas, string categoria, double precio, bool cancelable, int usuario)
        {
            _idHabitacion = idHabitacion;
            _cantidadPlazas = cantidadPlazas;
            _categoria = categoria;
            _precio = precio;
            _cancelable = cancelable;
            _usuario = usuario;
            _idHotel = idHotel;
        }


    }
}
