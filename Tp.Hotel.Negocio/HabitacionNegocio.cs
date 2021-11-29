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


        public HabitacionNegocio()
        {
            _habitaciones = new List<Habitacion>();
        }


        public List<Habitacion> TraerHabitaciones()
        {
            try
            {
                return _habitacionMapper.TraerTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }









    }
}
