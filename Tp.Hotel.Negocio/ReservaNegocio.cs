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
        private HabitacionMapper _habitacionMapper;
        

        public ReservaNegocio()
        {
            //_reservas = new List<Reserva>();
            _reservaMapper = new ReservaMapper();
            _clienteMapper = new ClienteMapper();
            _habitacionMapper = new HabitacionMapper();
            
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

        public TransactionResult AltaReserva (int idHabitacion, int idCliente, int cantidadHuespedes, DateTime fechaIngreso, DateTime fechaEgreso, string clienteMail, string clienteApellido, string nombreHotel, int idHotel) // ALTA DE RESERVA
        {
            string asunto = "Reserva Creada con Exito";
            string mensaje = $"Sr {clienteApellido.ToUpper()}, le confirmamos que su reserva en el Hotel {nombreHotel} para la fecha {fechaIngreso.ToString("dd-MM-yyyy")} hasta {fechaEgreso.ToString("dd-MM-yyyy")} para {cantidadHuespedes} huespedes, se ha creado con exito. Lo esperamos para disfrutar su merecido descanso en nuestras instalaciones.";
            
            
            ////
            
            //VALIDAR CANTHUESPEDES contra habitaicon. 

            ////
            ///


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
                    if (ValidarCantHuespedes(cantidadHuespedes, idHabitacion, idHotel)==false)
                    {
                        throw new Exception("La cantidad de huespedes no puede superar las plazas de la habitación elegida");
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
                            //ENVIAR MAIL AL CLIENTE
                            _reservaMapper.EnviarMail(clienteMail, asunto, mensaje);

                            return resultado;
                        }
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

        public List<Reserva> TraerReservaPorFecha(DateTime fechaDesde)
        {
            List<Reserva> lista = new List<Reserva>();
            foreach(Reserva re in _reservaMapper.TraerTodos())
            {
                if(re.FechaIngreso >= fechaDesde)
                {
                    lista.Add(re);
                }
            }



            return lista;
        }


        public bool ValidarCantHuespedes(int cantHuespedes, int IdHabitacion,int idHotel)
        {
            Habitacion habitacionSel = new Habitacion();
           
            foreach (Habitacion habitacion in _habitacionMapper.Traerxhotel(idHotel))
            {

                if (habitacion.id == IdHabitacion)
                {
                    habitacionSel = habitacion;
                }
            }
            if (habitacionSel.CantidadPlazas >= cantHuespedes)
            { 
                return true;
            }
            else
            {
                return false;
            }
             
           
        }


    }
}
