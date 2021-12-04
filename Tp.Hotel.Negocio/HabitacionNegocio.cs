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

       
        private HabitacionMapper _habitacionMapper;
        private HotelMapper _hotelMapper;
             

        public HabitacionNegocio()
        {
            _habitacionMapper = new HabitacionMapper();
            
        }


        public List<Habitacion> TraerHabitacionesPorHotel(int hotel)
        {
            if (hotel == 0)
            {
                List <Habitacion > hab = new List<Habitacion>();
                return hab;
            }
            else
            {
                return _habitacionMapper.Traerxhotel(hotel);
            }
            
        }

        //public List<Habitacion> TraerHabitaciones()
        //{
        //    List<Habitacion> _todas = new List<Habitacion>();
        //    foreach(Hotel1 hotel in _hotelMapper.TraerTodos())
        //    {
                
        //    }


        //    return _todas;
        //}

        public TransactionResult AltaHabitacion(int idHotel, int cantidadPlazas, string categoria, double precio, bool cancelable) // ALTA DE HABITACION
        {

            Habitacion habitacion = new Habitacion(idHotel, cantidadPlazas, categoria, precio, cancelable);
            TransactionResult resultado = _habitacionMapper.Agregar(habitacion);
            if (resultado.IsOk == false)
            {
                throw new Exception("No se pudo realizar el Alta de la habitación.");
            }
            else
            {
                return resultado;
            }
        }


    }
}
