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
using Tp.Hotel.Entidades.Modelos;
using Tp.Hotel.Entidades.Enum;

namespace Tp.Hotel.WinForms
{
    public partial class FrmHabitacion : Form
    {
        HabitacionNegocio _HabitacionNegocio;
        HotelNegocio _HotelNeg;
        public FrmHabitacion(Form main)
        {
            _HabitacionNegocio = new HabitacionNegocio();
            _HotelNeg = new HotelNegocio();
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
            CargarCategorias();
            CargarCancelable();
            CargarHoteles();

        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        private void CargarHoteles()
        {
            cmbHabitaciones.DataSource = null;
            cmbHabitaciones.DataSource = ListaHoteles();
            cmbHabitaciones.DisplayMember = "DisplayHotel";
            cmbHabitaciones.ValueMember = "IdHotel";
        }
       
        private void CargarCategorias()
        {
            _cmbCategoria.DataSource = null;
            _cmbCategoria.DataSource = Estrellas.GetValues(typeof(Estrellas));
            _cmbCategoria.ValueMember = "";
        }
        private void CargarCancelable()
        {
            _cmbCancelable.DataSource = null;
            _cmbCancelable.DataSource = Booleano.GetValues(typeof(Booleano));
            _cmbCancelable.ValueMember = "";
        }
        private void _btnLimpiarHabitacion_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _txtCantidadPlazas.Clear();
            _txtPrecio.Clear();
            _cmbCategoria.SelectedIndex = 0;
            _cmbCancelable.SelectedIndex = 0;
            cmbHabitaciones.Text = "Seleccione";

        }
        
        
        private void _btnGuardarHabitacion_Click(object sender, EventArgs e)
        {
            Alta();
            Limpiar();
        }
       
        private List<Habitacion> ListarHabitaciones(int hotelid)
        {
            return _HabitacionNegocio.TraerHabitacionesPorHotel(hotelid);
        }
        private List<Hotel1> ListaHoteles()
        {
            return _HotelNeg.TraerHoteles();
        }
        private void Alta()
        {
            try
            {
                
                string cantplazas= ValidacionesForm.ValidacionesAlta(_txtCantidadPlazas.Text, _lblCantidadPlazas.Text);
                string prec = ValidacionesForm.ValidacionesAlta(_txtPrecio.Text, _lblPrecio.Text);
                int cantidadplazas = ValidacionesForm.ValidacionNumero(cantplazas);
                double precio= ValidacionesForm.ValidacionDouble(prec);
                ValidacionesForm.ValidarSeleccion(_cmbCategoria.SelectedItem);
                ValidacionesForm.ValidarSeleccion(_cmbCancelable.SelectedItem);
                Booleano CancelableSelect = (Booleano)_cmbCancelable.SelectedItem;
                string categoria = _cmbCategoria.SelectedItem.ToString();
                bool cancelable = false;
                if (CancelableSelect == Booleano.Si)
                {
                    cancelable = true;
                }
                int idHotel = cmbHabitaciones.SelectedIndex;
                Hotel1 HotelSelec = (Hotel1)cmbHabitaciones.SelectedItem;
                TransactionResult operacion = _HabitacionNegocio.AltaHabitacion(idHotel, cantidadplazas, categoria, precio, cancelable);
                if (operacion.IsOk)
                {
                    MessageBox.Show("La habitación ha sido registrada para el hotel " + HotelSelec.Nombre);
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

        private void cmbHabitaciones_Select(object sender, EventArgs e)
        {
            try
            {
                int Hotelid = (int)cmbHabitaciones.SelectedIndex;
                Hotel1 HotelSelec = (Hotel1)cmbHabitaciones.SelectedItem;
                ValidacionesForm.ExisteHabitacion(ListarHabitaciones(Hotelid));
                _lstHabitaciones.DataSource = null;
                _lstHabitaciones.DataSource = ListarHabitaciones(Hotelid);
                _lstHabitaciones.DisplayMember = "DisplayHabitacion";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
    }
}
