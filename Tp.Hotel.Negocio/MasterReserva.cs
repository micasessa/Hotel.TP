using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Hotel.Entidades;
using Tp.Hotel.AccesoDatos;
using Tp.Hotel.Entidades.Modelos;

namespace Tp.Hotel.Negocio
{
    public class MasterReserva
    {
        
        private ReservaMapper _reservaMapper;
        private ClienteMapper _clienteMapper;
        private HabitacionMapper _habitacionMapper;
        private HotelMapper _hotelMapper;


        public MasterReserva()
        {
            //_reservas = new List<Reserva>();
            _reservaMapper = new ReservaMapper();
            _clienteMapper = new ClienteMapper();
            _habitacionMapper = new HabitacionMapper();
            _hotelMapper = new HotelMapper();   

        }
        public List<Reserva> TraerReservaPorFecha(DateTime fechaDesde)
        {
            List<Reserva> lista = new List<Reserva>();
            foreach (Reserva re in _reservaMapper.TraerTodos())
            {
                if (re.FechaIngreso >= fechaDesde)
                {
                    lista.Add(re);
                }
            }



            return lista;
        }



        public string Display(Reserva reserva)
        {
            //List<Reserva> listaReserva = TraerReservaPorFecha(fechaDesde);

            int idCliente = reserva.IdCliente;
            int idHabitacion = reserva.IdHabitacion;
            Habitacion habitacion = new Habitacion();
            Hotel1 hotel = new Hotel1();
            Cliente cliente = new Cliente();

            foreach (Hotel1 ho in _hotelMapper.TraerTodos())
            {
                foreach(Habitacion hab in _habitacionMapper.Traerxhotel(ho.id))
                {
                    if(hab.id == idHabitacion)
                    {
                        habitacion = hab;   
                        hotel = ho;
                        break;
                    }
                }
            }
            
            foreach(Cliente cli in _clienteMapper.TraerTodos())
            {
                if(cli.id == idCliente)
                {
                    cliente = cli;
                    break;
                }
            }


            return reserva.Display + cliente.Display + hotel.Nombre;
            //return $"Reserva n°: {reserva.id} - Ingreso: {reserva.FechaIngreso.ToString("dd-MM-yyyy")} - Egreso: {reserva.FechaEgreso.ToString("dd-MM-yyyy")} - Cant. Huéspedes: {reserva.CantidadHuespedes} - Cliente: {cliente.Apellido.ToUpper()}, {cliente.Nombre.ToUpper()} - Hotel: {hotel.Nombre.ToUpper()}";

        }





    }
}
