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
    public class ReservaMapper
    {
        private List<Reserva> _reserva;

        //Para traer la lista de Reservas:
        public List<Reserva> TraerTodos()
        {
            string json2 = WebHelper.Get("Hotel/Reservas/{registro}"); //FALTA COMPLETAR TEMA USUARIO/IdHOtel
            List<Reserva> resultado = MapList(json2);
            _reserva = resultado;
            return _reserva;
        }

        private List<Reserva> MapList(string json)
        {
            List<Reserva> lst = JsonConvert.DeserializeObject<List<Reserva>>(json);
            return lst;
        }

        //Para agregar Reservas al servidor (Con un post)
        public TransactionResult Agregar(Reserva reserva)
        {
            NameValueCollection obj = ReverseMap(reserva);
            string json = WebHelper.Post("Hotel/Reservas", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            _reserva.Add(reserva);
            return lst;
        }

        private NameValueCollection ReverseMap(Reserva reserva)
        {
            NameValueCollection res = new NameValueCollection();
            res.Add("idHabitacion", reserva.IdHabitacion.ToString());
            res.Add("idCliente", reserva.IdCliente.ToString());
            res.Add("cantidadHuespedes", reserva.CantidadHuespedes.ToString());
            res.Add("fechaIngreso", "2021-11-29T00:49:02.390Z");
            res.Add("fechaEgreso", "2021-11-29T00:49:02.390Z");
            res.Add("usuario", reserva.Usuario.ToString());
            return res;
        }

    }
}
