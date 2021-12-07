﻿using System;
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
        private int _id;
        private int _idHabitacion; 
        private int _idCliente; 
        private int _cantidadHuespedes;
        private DateTime _fechaIngreso;
        private DateTime _fechaEgreso;
        private int _usuario;
        private Cliente _cliente;

        //Creacion de propiedades
        public int id { get => _id; set => _id = value; }
        public int IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int CantidadHuespedes { get => _cantidadHuespedes; set => _cantidadHuespedes = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public DateTime FechaEgreso { get => _fechaEgreso; set => _fechaEgreso = value; }
        public int Usuario { get => _usuario; set => _usuario = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }


        //Creacion de constructores.
        public Reserva()
        { }
        public Reserva(int idHabitacion, int idCliente, int cantidadHuespedes, DateTime fechaIngreso, DateTime fechaEgreso)
        {
            _idHabitacion = idHabitacion;
            _idCliente = idCliente;
            _cantidadHuespedes = cantidadHuespedes;
            _fechaIngreso = fechaIngreso;
            _fechaEgreso = fechaEgreso;
            _cliente = new Cliente();


        }
        public Reserva( int idReserva, int idHabitacion, int idCliente, int cantidadHuespedes, DateTime fechaIngreso, DateTime fechaEgreso)
        {

            _id = idReserva;
            _idHabitacion = idHabitacion;
            _cliente = new Cliente();
            _idCliente = idCliente;
            _cantidadHuespedes = cantidadHuespedes;
            _fechaIngreso = fechaIngreso;
            _fechaEgreso = fechaEgreso;
            

        }

        public string DisplayReserva
        {
            get
            {
                return ("Numero Reserva: " + id + " - Cantidad Huespedes: " + CantidadHuespedes + " - Fecha Ingreso: " + FechaIngreso.ToString("dd-MM-yyyy") + " - Fecha Egreso: " + FechaEgreso.ToString("dd-MM-yyyy"));
            }
        }

        // todas las reservas existentes en una lista con código de reserva, fechas, nombre y apellido del cliente, cantidad de huéspedes y nombre del hotel

        public string Display
        {
            get
            {
                return $"Reserva n°: {id} - Ingreso: {FechaIngreso.ToString("dd-MM-yyyy")} - Egreso: {FechaEgreso.ToString("dd-MM-yyyy")} - Cant. Huéspedes: {CantidadHuespedes} Cliente n°: {IdCliente} ";

            }


        }






    }
}
