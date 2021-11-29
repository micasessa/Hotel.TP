using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Hotel.Entidades;
using Newtonsoft.Json;
using Tp.Hotel.Entidades.Modelos;

namespace Tp.Hotel.AccesoDatos
{
    public class HotelMapper
    {
        private List<Hotel1> _hoteles;

        //Para traer la lista de HOTELES:
        public List<Hotel1> TraerTodos()
        {
            string json2 = WebHelper.Get("Hotel/Hoteles/"); //FALTA COMPLETAR TEMA USUARIO/IdHOtel
            List<Entidades.Hotel1> resultado = MapList(json2);
            _hoteles = resultado;
            return _hoteles;
        }

        private List<Hotel1> MapList(string json)
        {
            List<Hotel1> lst = JsonConvert.DeserializeObject<List<Hotel1>>(json);
            return lst;
        }

        //Para agregar Hoteles al servidor (Con un post)
        public TransactionResult Agregar(Hotel1 hotel)
        {
            NameValueCollection obj = ReverseMap(hotel);
            string json = WebHelper.Post("Hotel/Hoteles", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            _hoteles.Add(hotel);
            return lst;
        }

        private NameValueCollection ReverseMap(Hotel1 hotel)
        {
            NameValueCollection hot = new NameValueCollection();
            hot.Add("estrellas", hotel.Estrellas.ToString());
            hot.Add("nombre", hotel.Nombre);
            hot.Add("direccion", hotel.Direccion);
            hot.Add("amenities", hotel.Amenities.ToString());
            hot.Add("usuario", hotel.Usuario.ToString());
            return hot;
        }

    }
}
