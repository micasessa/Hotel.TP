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
    public class ReservaNegocio
    {

        private List<Reserva> _reservas;
        private ReservaMapper _reservaMapper;
        private ClienteMapper _clienteMapper;


        public ReservaNegocio()
        {
            //_reservas = new List<Reserva>();
            _reservaMapper = new ReservaMapper();
            _clienteMapper = new ClienteMapper();
            
        }


        public List<Reserva> TraerReservas()
        {
            try
            {
                return _reservaMapper.TraerTodos();
            }
            catch (Exception)
            {

                throw;
            }
        }

       
        public List<Reserva> TraerReservasPorCliente(int idCliente)  //TRAER RESERVAS POR CLIENTE
        {
            List<Reserva> Todas = TraerReservas();
            List<Reserva> _lstReserva =new List<Reserva>();
            foreach (Reserva reserva in Todas)
            {
                if (reserva.IdCliente == idCliente)
                {
                    _lstReserva.Add(reserva);
                }
            }
            return _lstReserva;
        }
        public List<Cliente> TraerClientexReserva(int idReserva)  //TRAER CLIENTE POR RESERVA
        {
            List<Cliente> _ClientexReserva = new List<Cliente>();
            int idCliente = BuscarIdCliente(idReserva);
            foreach (Cliente c in _clienteMapper.TraerTodos())
            {
                if (c.id==idCliente)
                {
                    _ClientexReserva.Add(c);
                }
            }
            if(_ClientexReserva.Count()==0)
            {
                throw new Exception("No se ha podido ubicar a los huespedes!!!");
            }
            return _ClientexReserva;
        }


        public int BuscarIdCliente(int idReserva)  //TRAER RESERVAS POR HABITACION
        {
            int idCliente = 0;
            foreach (Reserva r in TraerReservas())
            {
                if (r.id == idReserva)
                {
                    idCliente = r.IdCliente;
                }
            }
            return idCliente;
        }

        

        public List<Reserva> ListaReserva_Cliente()
        {           
            List<Reserva> reservasPorCliente = TraerReservas();
            List<Cliente> cliente = _clienteMapper.TraerTodos();
            
            foreach (Reserva re in reservasPorCliente)
            {
                foreach (Cliente cl in cliente)
                {
                    if (re.IdCliente == cl.id)
                    {
                        re.Cliente = cl;
                    }
                    else
                    {
                        re.Cliente=new Cliente();
                    }
                }                
            }
            return reservasPorCliente;

        }

        public TransactionResult AltaReserva (int idHabitacion, int idCliente, int cantidadHuespedes, DateTime fechaIngreso, DateTime fechaEgreso) // ALTA DE RESERVA
        {
            if(ValidacionFechaIngreso(fechaIngreso) == false)
            {
                throw new Exception("La fecha de ingreso debe ser superior o igual al día de hoy");
            }
            else
            {
                if(ValidacionFechaEgreso(fechaIngreso, fechaEgreso) == false)
                {
                    throw new Exception("La estadía mínima es de 1 noche");
                }
                else
                {
                    Reserva reserva = new Reserva(idHabitacion, idCliente, cantidadHuespedes, fechaIngreso, fechaEgreso);
                    TransactionResult resultado = _reservaMapper.Agregar(reserva);
                    if (resultado.IsOk == false)
                    {
                        throw new Exception("No se pudo realizar la registración de la reserva.");
                    }
                    else
                    {
                        return resultado;
                    }
                }
            }
           
        }

        public bool ValidacionFechaIngreso(DateTime fechaIngreso)
        {
            bool valor;
            if(fechaIngreso < DateTime.Today)
            {
                valor = false;
            }
            else
            {
                valor = true;
            }

            return valor;
        }

        public bool ValidacionFechaEgreso(DateTime fechaIngreso, DateTime fechaEgreso)
        {
            bool valor;
            if (fechaEgreso <= fechaIngreso)
            {
                valor = false; 
               
            }
            else
            {
                valor = true;
            }

            return valor;
        }







    }
}
