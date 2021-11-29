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
using Tp.Hotel.Entidades.Enum;
using Tp.Hotel.Entidades.Modelos;
using Tp.Hotel.Negocio;

namespace Tp.Hotel.WinForms
{
    public partial class FrmHoteles : Form
    {
        private HotelNegocio _HotelNegocio;
        public FrmHoteles(Form main)
        {
            _HotelNegocio = new HotelNegocio();
            InitializeComponent();
            this.Owner = main;
        }
        private void FrmHoteles_Load(object sender, EventArgs e)
        {
            Carga();
            Limpiar();
        }
        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alta();
            Limpiar();
            Carga();
        }
        private void _btnLimpiarHabitacion_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
             _txtNombre.Clear();
            _txtDireccion.Clear();
            _cmbEstrellas.DataSource = null;
            _cmbEstrellas.SelectedItem = "--SELECCIONE--";
            _cmbAmenities.DataSource = null;
            _cmbAmenities.SelectedItem = "--SELECCIONE--";


        }
        private void Carga()
        {
            _lstHoteles.DataSource = null;
            _lstHoteles.DataSource = ListarHoteles();
            _lstHoteles.DisplayMember = "DisplayHotel";
            _cmbEstrellas.SelectedItem = "--SELECCIONE--";
            _cmbAmenities.SelectedItem = "--SELECCIONE--";
        }

        private void cmbEstrella_Click(object sender, EventArgs e)
        {
            _cmbEstrellas.DataSource = null;
            _cmbEstrellas.DataSource = Estrellas.GetValues(typeof(Estrellas));
        }
        private void cmbAmenities_Click(object sender, EventArgs e)
        {
            _cmbAmenities.DataSource = null;
            _cmbAmenities.DataSource = Amenities.GetValues(typeof(Amenities));
        }
        

        private List<Hotel1> ListarHoteles()
        {
            return _HotelNegocio.TraerHoteles();
        }

        private void Alta()
        {
            try
            {
                string nombre = ValidacionesForm.ValidacionesAlta(_txtNombre.Text, _lblNombre.Text);
                string direccion = ValidacionesForm.ValidacionesAlta(_txtDireccion.Text, _lblDireccion.Text);
               ValidacionesForm.ValidarSeleccion(_cmbAmenities.SelectedItem);
              ValidacionesForm.ValidarSeleccion(_cmbEstrellas.SelectedItem);
                Estrellas EstrellaSelect= (Estrellas)_cmbEstrellas.SelectedItem;
                Amenities AmenitieSelect = (Amenities)_cmbAmenities.SelectedItem;
                int estrellas = (int)EstrellaSelect;
                bool amenities = false;
               if(AmenitieSelect==Amenities.Si)
                {
                    amenities = true;
                }

                TransactionResult operacion = _HotelNegocio.AltaHotel(estrellas, nombre, direccion, amenities);
                if (operacion.IsOk)
                {
                    MessageBox.Show("El hotel ha sido registrado exitosamente");
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
    }
}
