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
    public class HabitacionMapper
    {
        private List<Habitacion> _habitaciones;

        //Para traer la lista de habitaciones:
        public List<Habitacion> TraerTodos()
        {
            string json2 = WebHelper.Get("Hotel/Habitaciones/{idHotel}"); //FALTA COMPLETAR TEMA URL + USUARIO/IdHOtel
            List <Habitacion> resultado = MapList(json2);
            _habitaciones = resultado;
            return _habitaciones;
        }

        private List<Habitacion> MapList(string json)
        {
            List<Habitacion> lst = JsonConvert.DeserializeObject<List<Habitacion>>(json);
            return lst;
        }

        //Para agregar habitaciones al servidor (Con un post)
        public TransactionResult Agregar(Habitacion habitacion)
        {
            NameValueCollection obj = ReverseMap(habitacion);
            string json = WebHelper.Post("Hotel/Habitaciones", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            _habitaciones.Add(habitacion);
            return lst;
        }

        private NameValueCollection ReverseMap(Habitacion habitacion)
        {
            NameValueCollection hab = new NameValueCollection();
            hab.Add("idHotel", habitacion.IdHotel.ToString());
            hab.Add("cantidadPlazas", habitacion.CantidadPlazas.ToString());
            hab.Add("categoria", habitacion.Categoria);
            hab.Add("precio", habitacion.Precio.ToString());
            hab.Add("cancelable", habitacion.Cancelable.ToString());
            hab.Add("usuario", "836465");
            return hab;
        }
    }
}
