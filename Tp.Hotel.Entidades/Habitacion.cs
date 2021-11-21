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
        private Hotel _idHotel;
        private int _cantidadPlazas;
        private string _categoria;
        private double _precio;
        private bool _cancelable;
        private int _usuario;

        //Creacion de propiedades
        public int IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }
        public Hotel IdHotel { get => _idHotel; set => _idHotel = value; }
        public int CantidadPlazas { get => _cantidadPlazas; set => _cantidadPlazas = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public bool Cancelable { get => _cancelable; set => _cancelable = value; }
        public int Usuario { get => _usuario; set => _usuario = value; } //estoy con duda si agregarlo o no


        //Creacion de constructores
        public Habitacion()
        { }

        public Habitacion(int idHabitacion, Hotel idHotel, int cantidadPlazas, string categoria, double precio, bool cancelable, int usuario)
        {
            idHabitacion = _idHabitacion;
            idHotel = _idHotel;
            cantidadPlazas = _cantidadPlazas;
            categoria = _categoria;
            precio = _precio;
            cancelable = _cancelable;
            usuario = _usuario;
        }


    }
}
