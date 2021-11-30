﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Hotel.Entidades;
using Tp.Hotel.AccesoDatos;
using Tp.Hotel.Entidades.Modelos;

namespace Tp.Hotel.Negocio
{
    public class ReservaNegocio
    {

        private List<Reserva> _reservas;
        private ReservaMapper _reservaMapper;
        private ClienteMapper _clienteMapper;


        public ReservaNegocio()
        {
            //_reservas = new List<Reserva>();
            _reservaMapper = new ReservaMapper();
        }


        public List<Reserva> TraerReservas()
        {
            try
            {
                return _reservaMapper.TraerTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Cliente> TraerReservasPorCliente (int idCliente)  //TRAER RESERVAS POR CLIENTE
        {
            List<Cliente> clientexReserva = new List<Cliente>();           
            
            foreach (Reserva reserva in ListaReserva_Cliente())
            {
                if ( reserva.IdCliente == idCliente)
                {
                    clientexReserva.Add(reserva.Cliente);
                }
            }
            return clientexReserva;
        }


        public List<Reserva> TraerReservasPorHabitacion(int idHabitacion)  //TRAER RESERVAS POR HABITACION
        {
            List<Reserva> reservasPorHabitacion = new List<Reserva>();
            List<Reserva> todas = TraerReservas();
            foreach (Reserva reserva in todas)
            {
                if (reserva.IdHabitacion == idHabitacion)
                {
                    reservasPorHabitacion.Add(reserva);
                }
            }
            return reservasPorHabitacion;
        }

        public int TraerHuespedesPorReserva(int idreserva)
        {
           // List<Reserva> todas = TraerReservas();
            Reserva reserva = TraerReservas().Find(x => x.IdReserva == idreserva);

            return reserva.CantidadHuespedes;
        }

        public List<Reserva> ListaReserva_Cliente()
        {           
            List<Reserva> reservasPorCliente = new List<Reserva>();
            List<Reserva> todas = TraerReservas();
            List<Cliente> cliente = _clienteMapper.TraerTodos();
            
            foreach (Reserva re in todas)
            {
                foreach (Cliente cl in cliente)
                {
                    if (re.IdCliente == cl.IdCliente)
                    {
                        re.Cliente = cl;
                    }
                }                
            }
            return reservasPorCliente;

        }

        public TransactionResult AltaReserva (int idHabitacion, int idCliente, int cantidadHuespedes, DateTime fechaIngreso, DateTime fechaEgreso) // ALTA DE RESERVA
        {

            Reserva reserva = new Reserva(idHabitacion, idCliente, cantidadHuespedes, fechaIngreso, fechaEgreso);
            TransactionResult resultado = _reservaMapper.Agregar(reserva);
            if (resultado.IsOk == false)
            {
                throw new Exception("No se pudo realizar la registración de la reserva.");
            }
            else
            {
                return resultado;
            }
        }



    }
}
