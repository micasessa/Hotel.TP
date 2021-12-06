using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Tp.Hotel.Entidades;
using Tp.Hotel.Entidades.Modelos;
using Tp.Hotel.Negocio;


namespace Tp.Hotel.WinForms
{
    public partial class FrmReserva : Form
    {
        private ClienteNegocio _ClienteNegocio;
        private ReservaNegocio _ReservaNegocio;
        private Habitacion _Habitacion;
        private int _idHabitacion;
        private Hotel1 _hotel;
        private HotelNegocio _HotelNegocio;

        public int IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }

        public FrmReserva(Form main, int idHabitacion, Habitacion habitacion)
        {
            InitializeComponent();
            this.Owner = main;
            _ClienteNegocio = new ClienteNegocio();
            _ReservaNegocio = new ReservaNegocio();
            _HotelNegocio = new HotelNegocio();
            _Habitacion = habitacion;
            IdHabitacion = idHabitacion;
            
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
            
        private void Volver()
        {
                this.Hide();
                this.Owner.Show();
            
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNroReserva.Clear();
            txtFechaIngreso.Clear();
            txtFechaEgreso.Clear();
            txtHuespedes.Clear();
            _txtClienteSeleccionado.Clear();
            _txtHabitacionSeleccionada.Clear();
            _txtHotelSeleccionado.Clear();
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes FormClientes = new FrmClientes(this.Owner);
            this.Hide();
            FormClientes.Show();
        }

        private void lstClientes_Load(object sender, EventArgs e)
        {
            try
            {
                Carga();
                _txtHabitacionSeleccionada.Text = _Habitacion.DisplayHabitacion;
                _txtHotelSeleccionado.Text = _HotelNegocio.TraerHotelxId(_Habitacion.IdHotel).DisplayHotel;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Carga()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = _ClienteNegocio.TraerClientes();
            lstClientes.DisplayMember = "DisplayCliente";
            lstClientes.ValueMember = "id";

            CargaIdReserva();
            _txtClienteSeleccionado.Text = ((Cliente)lstClientes.SelectedItem).DisplayCliente;
        }

        private void CargaIdReserva()
        {
            cmbReserva.DataSource = null;
           // cmbReserva.DataSource = ListaReservas();
            cmbReserva.DisplayMember = "DisplayReserva";
            cmbReserva.ValueMember = "id";

        }

       /*private List<Reserva> ListaReservas()
        {
            List<Cliente> lista = new List<Cliente>();
            lista.Add(_ReservaNegocio.TraerReservasPorCliente());

            return lista;
           
        }*/

        private void Alta()
        {
            try
            {
                
                string huespedes = ValidacionesForm.ValidacionesAlta(txtHuespedes.Text, lblHuespedes.Text);
                string ingreso = ValidacionesForm.ValidacionesAlta(txtFechaIngreso.Text, lblFechaIngreso.Text);
                string egreso = ValidacionesForm.ValidacionesAlta(txtFechaEgreso.Text, lblFechaEgreso.Text);
                int canthuespedes = ValidacionesForm.ValidacionNumero(huespedes);
                DateTime fechaingreso = ValidacionesForm.ValidacionFecha(ingreso);
                DateTime fechaegreso = ValidacionesForm.ValidacionFecha(egreso);
                Cliente ClienteSel = (Cliente)lstClientes.SelectedItem;                
                TransactionResult operacion = _ReservaNegocio.AltaReserva(IdHabitacion,ClienteSel.id, canthuespedes, fechaingreso, fechaegreso);
                if (operacion.IsOk)
                {
                    MessageBox.Show("La reserva se ha registrado exitosamente");
                    Volver();
                }
                else
                {
                    MessageBox.Show(operacion.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alta();
            //Volver();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txtClienteSeleccionado.Text = ((Cliente)lstClientes.SelectedItem).DisplayCliente;
        }
    }
}
