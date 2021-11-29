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
    public class HotelNegocio
    {

        private List<Hotel1> _hoteles;
        private HotelMapper _hotelMapper;


        public HotelNegocio()
        {
            //_hoteles = new List<Hotel1>();
            _hotelMapper = new HotelMapper();
        }


        public List<Hotel1> TraerHoteles() ///LISTA DE HOTELES
        {
            try
            {
                return _hotelMapper.TraerTodos();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TransactionResult AltaHotel(Hotel1 hotel) // ALTA DE HOTEL
        {


            TransactionResult resultado = _hotelMapper.Agregar(hotel);
            if (resultado.IsOk == false)
            {
                throw new Exception("No se pudo realizar el Alta del Hotel.");
            }
            else
            {
                return resultado;
            }
        }




    }
}

