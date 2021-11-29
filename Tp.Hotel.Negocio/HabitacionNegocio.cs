using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Hotel.AccesoDatos;
using Tp.Hotel.Entidades;
using Tp.Hotel.Entidades.Modelos;

namespace Tp.Hotel.Negocio
{
    public class HabitacionNegocio
    {

        private List<Habitacion> _habitaciones;
        private HabitacionMapper _habitacionMapper;
        private HelperHabitacion _Helper;
        private HotelNegocio _HotelNegocio;


        public HabitacionNegocio()
        {
            //_habitaciones = new List<Habitacion>();
            _habitacionMapper = new HabitacionMapper();
            _HotelNegocio = new HotelNegocio();
            _Helper = new HelperHabitacion(_HotelNegocio.TraerHoteles());
        }


        public List<Habitacion> TraerHabitaciones()
        {
            try
            {
                List<Habitacion> _Habitaciones=_habitacionMapper.TraerTodos();
                foreach(Habitacion habitacion in _Habitaciones)
                {
                    habitacion.Hotel = _Helper.HotelxId(habitacion.IdHotel);
                }

                return _Habitaciones;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Habitacion> TraerHabitacionesPorHotel(int hotel)
        {
            List<Habitacion> habitacionPotHotel = new List<Habitacion>();
            List<Habitacion> todas = TraerHabitaciones();
            foreach(Habitacion hab in todas)
            {
                if(hab.IdHotel == hotel)
                {
                    habitacionPotHotel.Add(hab);
                }
            }
            return habitacionPotHotel;
        }

       


    }
}
