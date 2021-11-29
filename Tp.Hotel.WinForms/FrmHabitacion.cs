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
    public partial class FrmHabitacion : Form
    {
        HabitacionNegocio _HabitacionNegocio;
        public FrmHabitacion(Form main)
        {
            _HabitacionNegocio = new HabitacionNegocio();
            InitializeComponent();
            this.Owner = main;
        }

        private void FrmHabitacion_Load(object sender, EventArgs e)
        {
            Carga();
            Limpiar();
        }

        private void Carga()
        {
            _lstHabitaciones.DataSource = null;
            _lstHabitaciones.DataSource = ListarHabitaciones();
            _lstHabitaciones.DisplayMember = "DisplayHabitacion";
            /* _cmbEstrellas.SelectedItem = "--SELECCIONE--";
             _cmbAmenities.SelectedItem = "--SELECCIONE--";*/
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnLimpiarHabitacion_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _txtIdHabitacion.Clear();
            _txtCantidadPlazas.Clear();
            _txtPrecio.Clear();
        }

        private void _btnRegargar_Click(object sender, EventArgs e)
        {
            Carga();
        }

        private void _btnGuardarHabitacion_Click(object sender, EventArgs e)
        {

        }
       
        private List<Habitacion> ListarHabitaciones()
        {
            return _HabitacionNegocio.TraerHabitaciones();
        }

    }
}
