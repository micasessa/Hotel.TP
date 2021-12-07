using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp.Hotel.Negocio;
using Tp.Hotel.Entidades;


namespace Tp.Hotel.WinForms
{
    public partial class FrmReporteTodasReservas : Form
    {
        private bool firstRender;
        private ReservaNegocio _ReservaNegocio;
        private ClienteNegocio _ClienteNegocio;
        private HotelNegocio _HotelNegocio;
        private MasterReserva _masterReserva;
        private List<Cliente> _clientes;
        private List<Hotel1> _hoteles;


        public FrmReporteTodasReservas(Form main)
        {
            InitializeComponent();
            this.Owner = main;
            _ReservaNegocio = new ReservaNegocio();
            _ClienteNegocio = new ClienteNegocio();
            _HotelNegocio = new HotelNegocio();
            _masterReserva = new MasterReserva();
            _clientes = _ClienteNegocio.TraerClientes();
            _hoteles = _HotelNegocio.TraerHoteles();
            this.firstRender = true;
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmReporteTodasReservas_Load(object sender, EventArgs e)
        {
            Carga();
            _dateTimeFechaDesde.Value = DateTime.Today.AddDays(-366);
            _txtBoxTotalReservas.Text = ReservasPorFecha(DateTime.Today.AddDays(-366)).Count.ToString();
            _lstViewReservas.View = View.Details;
        }

        private void Carga()
        {
            //
            try
            {
                //_lstReservas.DataSource = null;
                //_lstReservas.DataSource = ReservasPorFecha(DateTime.Today.AddDays(-366));
                //_lstReservas.DisplayMember = "Display";
                //_lstReservas.ValueMember = "id";
                
                CargarLisView(); 



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CargarLisView()
        {
            //limpio la grilla
            _lstViewReservas.Items.Clear();
            //traigo todas las reservas por fecha seleecionada
            List<Reserva> listaReservas = ReservasPorFecha(_dateTimeFechaDesde.Value);
            foreach (Reserva re in listaReservas)
            {
                //para cada reserva, busco y traigo al cliente, busco y traigo el nombre del hotel 
                Cliente cliente = _masterReserva.ClienteDeReserva(re, _clientes);
                string hotel = _masterReserva.HotelDeReserva(re, _hoteles);

                //para cada reserva instancio un nuevo item en la grilla, usando un array de strings para mostrar texto
                ListViewItem item = new ListViewItem(new string[]
                {
                        re.id.ToString(),
                        re.FechaIngreso.ToString("dd-MM-yyyy"),
                        re.FechaEgreso.ToString("dd-MM-yyyy"),
                        cliente.Nombre ,
                        cliente.Apellido,
                        hotel,
                        re.CantidadHuespedes.ToString()

                });
                //por cada reserva, instancio el item de la grilla y lo agrego a la lista de Items que se van a mostrar
                _lstViewReservas.Items.Add(item);
            }
        }

        private void Limpiar()
        {
            //
            _dateTimeFechaDesde.Value = DateTime.Today.AddDays(-366);
            //_lstReservas.DataSource = ReservasPorFecha(DateTime.Today.AddDays(-366));
            _txtBoxTotalReservas.Text = ReservasPorFecha(DateTime.Today.AddDays(-366)).Count.ToString();
            //_lstViewReservas.Items.Clear();
            //_txtBoxTotalReservas.Text = "0";
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void _dateTimeFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            if (!this.firstRender)
            {
                try
                {
                    //_lstReservas.DataSource = ReservasPorFecha(_dateTimeFechaDesde.Value);
                    Carga();
                    _txtBoxTotalReservas.Text = ReservasPorFecha(_dateTimeFechaDesde.Value).Count.ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }



        private List<Reserva> ReservasPorFecha(DateTime fechaDesde)
        {
            List<Reserva> lista = _ReservaNegocio.TraerReservaPorFecha(fechaDesde);
            return lista;

        }


        private string Display(Reserva reserva)
        {
            return _masterReserva.Display(reserva);
        }
    }
}
