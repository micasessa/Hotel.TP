using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Tp.Hotel.Entidades
{
    public class Reserva
    {
        //Declaracion de atributos
        private int _idReserva;
        private Habitacion _idHabitacion; //dejo el int como en el DER o pongo Habitacion?
        private Cliente _idCliente; //dejo el int como en el DER o pongo Cliente?
        private int _cantidadHuespedes;
        private DateTime _fechaIngreso;
        private DateTime _fechaEgreso;
        private int _usuario;

        //Creacion de propiedades
        public int IdReserva { get => _idReserva; set => _idReserva = value; }
        public Habitacion IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }
        public Cliente IdCliente { get => _idCliente; set => _idCliente = value; }
        public int CantidadHuespedes { get => _cantidadHuespedes; set => _cantidadHuespedes = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public DateTime FechaEgreso { get => _fechaEgreso; set => _fechaEgreso = value; }
        public int Usuario { get => _usuario; set => _usuario = value; } //estoy con duda si agregarlo o no


        //Creacion de constructores.
        public Reserva()
        { }

        public Reserva(int idReserva, Habitacion idHabitacion, Cliente idCliente, int cantidadHuespedes, DateTime fechaIngreso, DateTime fechaEgreso, int usuario)
        {
            idReserva = _idReserva;
            idHabitacion = _idHabitacion;
            idCliente = _idCliente;
            cantidadHuespedes = _cantidadHuespedes;
            fechaIngreso = _fechaIngreso;
            fechaEgreso = _fechaEgreso;
            usuario = _usuario;

        }


    }
}
