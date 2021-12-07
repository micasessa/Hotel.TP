using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp.Hotel.Entidades;
using Tp.Hotel.AccesoDatos;
using Tp.Hotel.Entidades.Modelos;
using Tp.Hotel.Entidades.Exceptions;

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
           
            if(ValidarDniRepetido(dni) == true) // SI ENCUENTRA DNI REPETIDO TIRAR EXCEPTION
            {
                throw new DniRepetidoException(dni);
            }
            else//SINO, QUE PASE
            {
                if (ValidarEdad(fechaNacimiento) == false)
                {
                    throw new Exception("Debe ser mayor de edad");

                }
                else
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

        public bool ValidarDniRepetido(int dni)
        {
            bool valor = false;
            foreach(Cliente cli in _clienteMapper.TraerTodos())
            {
                if (cli.Dni == dni) 
                {
                    valor = true;
                    break;
                    
                }
                else
                {
                    valor= false;
                }
            }
            return valor;
        }

        public bool ValidarEdad(DateTime fechanac)
        {
            int edad = 0;
            if(fechanac> DateTime.Now)
            {
                throw new Exception("Debe ingresar una fecha anterior a la actual");
            }
            else
            {
                edad = DateTime.Now.Year - fechanac.Year;
                if (fechanac.Month > DateTime.Now.Month || fechanac.Month == DateTime.Now.Month && fechanac.Day > DateTime.Now.Day)
                {
                    --edad;
                }
                if(edad <18)
                {
                    return false;
                }
                else { return true; }

            }


        }
        



    }
}
