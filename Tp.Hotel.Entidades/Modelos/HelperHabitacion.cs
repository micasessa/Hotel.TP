using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tp.Hotel.Entidades.Modelos
{
    public class HelperHabitacion
    {

        private List<Hotel1> _Hoteles;
       
        public HelperHabitacion(List<Hotel1> _LstHoteles)
        {

            _Hoteles = _LstHoteles;
        }

        public Hotel1 HotelxId(int IdHotel)
        {
            foreach (Hotel1 hotel in _Hoteles)
            {
                if (hotel.IdHotel == IdHotel)
                {
                    return hotel;
                }
            }
            return null;
        }

       

    }
}
