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
    public class ClienteMapper
    {
        private List<Cliente> _clientes;

        //Para traer la lista de clientes:
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get(""); //FALTA COMPLETAR TEMA URL
            List<Cliente> resultado = MapList(json2);
            _clientes = resultado;
            return _clientes;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }

        //Para agregar clientes al servidor (Con un post)
        public TransactionResult Agregar (Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Post("", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            _clientes.Add(cliente);
            return lst;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection cl = new NameValueCollection();
            cl.Add("dni", cliente.Dni.ToString());
            cl.Add("nombre", cliente.Nombre);
            cl.Add("apellido", cliente.Apellido);
            cl.Add("direccion", cliente.Direccion);
            cl.Add("email", cliente.Email);
            cl.Add("telefono", cliente.Telefono);
            cl.Add("fechaNacimiento", cliente.FechaNacimiento.ToString());
            cl.Add("fechaAlta", cliente.FechaAlta.ToString());
            cl.Add("activo", cliente.Activo.ToString());
            cl.Add("usuario", cliente.Usuario);
            return cl;
        }
    }
}
