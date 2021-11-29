using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Hotel.Entidades;
using Tp.Hotel.AccesoDatos;
using Tp.Hotel.Entidades.Modelos;

namespace Tp.Hotel.Negocio
{
    public class ClienteNegocio
    {

        private List<Cliente> _clientes;
        private ClienteMapper _clienteMapper;   


        public ClienteNegocio()
        {
           //  _clientes = new List<Cliente>();
            _clienteMapper = new ClienteMapper();
        }


        public List<Cliente> TraerClientes() //TRAER LISTA DE CLIENTES
        {
            try
            {
                return _clienteMapper.TraerTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public TransactionResult AltaCliente(int dni, string nombre, string apellido, string direccion,string email, string telefono, DateTime fechaNacimiento) //ALTA DE CLIENTE
        {
            Cliente cliente = new Cliente(dni, nombre, apellido, direccion, email, telefono, fechaNacimiento);

            TransactionResult resultado = _clienteMapper.Agregar(cliente);
            if (resultado.IsOk == false)
            {
                throw new Exception("No se pudo realizar el Alta del Cliente.");
                }
            else
            {
                return resultado;
            }
        }






    }
}
