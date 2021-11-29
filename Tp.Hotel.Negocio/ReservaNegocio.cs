using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Hotel.Entidades;
using Tp.Hotel.AccesoDatos;


namespace Tp.Hotel.Negocio
{
    public class ReservaNegocio
    {

        private List<Reserva> _reservas;
        private ReservaMapper _reservaMapper;


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

        public List<Reserva> TraerReservasPorCliente (int idCliente)  //TRAER RESERVAS POR CLIENTE
        {
            List<Reserva> reservasPorCliente = new List<Reserva>();
            List<Reserva> todas = TraerReservas();
            foreach (Reserva reserva in todas)
            {
                if ( reserva.IdCliente == idCliente)
                {
                    reservasPorCliente.Add(reserva);
                }
            }
            return reservasPorCliente;
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





    }
}
