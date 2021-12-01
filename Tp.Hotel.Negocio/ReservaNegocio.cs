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
            List<Reserva> Todas = ListaReserva_Cliente();
            List<Cliente> _lstClientes = new List<Cliente>();
            foreach (Reserva r in Todas)
            {
                if (r.id==idReserva)
                {
                    _lstClientes.Add(r.Cliente);
                }
            }
            return _lstClientes;
        }


        public List<Reserva> TraerReservasPorHabitacion(int idHabitacion)  //TRAER RESERVAS POR HABITACION
        {
            List<Reserva> reservasPorHabitacion = new List<Reserva>();
            List<Reserva> todas = TraerReservas();
            foreach (Reserva reserva in todas)
            {
                if (reserva.IdHabitacion == idHabitacion)
                {
                    reservasPorHabitacion.Add(reserva);
                }
            }
            return reservasPorHabitacion;
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
