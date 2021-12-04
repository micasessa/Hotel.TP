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

        private List<Entidades.Hotel1> _hoteles;
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

        public List<Hotel1> TraerHotelSeleccione()
        {
            List<Hotel1> _listaSeleccione = new List<Hotel1>();
            _listaSeleccione.Add(new Hotel1(0, "--Seleccione--"));
            //Hotel1 hotel;
            foreach(Hotel1 h1 in _hotelMapper.TraerTodos())
            {
                //hotel = h1;
                _listaSeleccione.Add(h1);
            }

            return _listaSeleccione;
        }

        public TransactionResult AltaHotel(int estrellas, string nombre, string direccion, bool amenities) // ALTA DE HOTEL
        {

            Hotel1 hotel = new Hotel1(estrellas, nombre, direccion, amenities);
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
        public List<Hotel1> HotelesxEstrellas(int Estrellas)
        {
            List<Hotel1> _Hoteles = new List<Hotel1>();

            foreach ( Hotel1 hotel in _hotelMapper.TraerTodos())
            {
                if(hotel.Estrellas==Estrellas)
                {
                    _Hoteles.Add(hotel);
                }
            }
            return _Hoteles;
        }



    }
}

