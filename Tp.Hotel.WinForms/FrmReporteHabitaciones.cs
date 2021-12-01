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
using Tp.Hotel.Negocio;

namespace Tp.Hotel.WinForms
{
    public partial class FrmReporteHabitaciones : Form
    {
        private HotelNegocio _HotelNegocio;
        private HabitacionNegocio _HabitacionNegocio;
        public FrmReporteHabitaciones(Form main)
        {
            InitializeComponent();
            this.Owner = main;
            _HotelNegocio= new HotelNegocio();
            _HabitacionNegocio=new HabitacionNegocio(); 
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        private void FrmLoad(object sender, EventArgs e)
        {
            Carga();
            Limpiar();
        }
    private void Limpiar()
        {
            _cbxSelecHotel.Text = "Seleccione";
            _lstHabitaciones.Text = "Seleccione";
        
        }

        private void Carga()
        {
            _cbxSelecHotel.DataSource = null;
            _cbxSelecHotel.DataSource = _HotelNegocio.TraerHoteles();
            _cbxSelecHotel.DisplayMember = "DisplayHotel";
            _cbxSelecHotel.ValueMember = "id";
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TotalHabitaciones()
        {
            int canthabitaciones = 0;
            if (_lstHabitaciones != null)
            { 
            }
            _txtBoxTotalHabitaciones.Text=canthabitaciones.ToString();
        }

        public void CargaHotelesxid(object sender, EventArgs e)
        {
            Hotel1 hotelSelec = (Hotel1)_cbxSelecHotel.SelectedItem;
            MessageBox.Show(hotelSelec.id.ToString());
            _lstHabitaciones.DataSource = null;
            _lstHabitaciones.DataSource = _HabitacionNegocio.TraerHabitacionesPorHotel(hotelSelec.id);
            _lstHabitaciones.DisplayMember = "DisplayHabitacion";

        }

    }
}
