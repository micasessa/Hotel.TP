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

        private ReservaNegocio _ReservaNegocio;
        private MasterReserva _masterReserva;


        public FrmReporteTodasReservas(Form main)
        {
            InitializeComponent();
            this.Owner = main;
            _ReservaNegocio = new ReservaNegocio();
            _masterReserva = new MasterReserva();   
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmReporteTodasReservas_Load(object sender, EventArgs e)
        {
            Carga();

        }

        private void Carga()
        {
            //
            try
            {
                _dateTimeFechaDesde.Value = DateTime.Today.AddDays(-366);

                _lstReservas.DataSource = null;
                _lstReservas.DataSource = ReservasPorFecha(DateTime.Today.AddDays(-366));
                _lstReservas.DisplayMember = "Display";
                _lstReservas.ValueMember = "id";

                _txtBoxTotalReservas.Text = ReservasPorFecha(DateTime.Today.AddDays(-366)).Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            //
            _dateTimeFechaDesde.Value = DateTime.Today.AddDays(-366);
            _lstReservas.DataSource = ReservasPorFecha(DateTime.Today.AddDays(-366));
            _txtBoxTotalReservas.Text = ReservasPorFecha(DateTime.Today.AddDays(-366)).Count.ToString();
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void _dateTimeFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _lstReservas.DataSource = ReservasPorFecha(_dateTimeFechaDesde.Value);
                _txtBoxTotalReservas.Text = ReservasPorFecha(_dateTimeFechaDesde.Value).Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
