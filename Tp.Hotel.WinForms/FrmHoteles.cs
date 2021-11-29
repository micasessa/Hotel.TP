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
            //Limpiar();
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
           // _cmbEstrellas.DataSource = null;
            _cmbEstrellas.SelectedIndex = 0;
           // _cmbAmenities.DataSource = null;
            _cmbAmenities.SelectedIndex = 0;
           // cmbHoteles.DataSource = null;
            cmbHoteles.SelectedIndex =0;


        }
        private void Carga()
        {
            CargarHoteles();
            CargarAmenities();
            CargarEstrellas();
            CargarComboHoteles();
            
            //_cmbEstrellas.SelectedItem = 0;
            //_cmbAmenities.SelectedItem = "--SELECCIONE--";
        }

        public void CargarEstrellas()
        {
            _cmbEstrellas.DataSource = null;
            _cmbEstrellas.DataSource = Estrellas.GetValues(typeof(Estrellas));
            _cmbEstrellas.ValueMember = "";
            //_cmbEstrellas.DisplayMember = "";
        }

        public void CargarAmenities()
        {
            _cmbAmenities.DataSource = null;
            _cmbAmenities.DataSource = Booleano.GetValues(typeof(Booleano));
            _cmbEstrellas.ValueMember = "";
            //_cmbEstrellas.DisplayMember = "";
        }


        public void CargarHoteles()
        {
            _lstHoteles.DataSource = null;
            _lstHoteles.DataSource = ListarHoteles();
            _lstHoteles.DisplayMember = "DisplayHotel";
            _lstHoteles.ValueMember = "IdHotel";
        }

        public void CargarComboHoteles()
        {
            cmbHoteles.DataSource = null;
            cmbHoteles.DataSource = Estrellas.GetValues(typeof(Estrellas));
            cmbHoteles.DisplayMember = "";
            //cmbHoteles.ValueMember = "";
        }

        private void cmbEstrella_Click(object sender, EventArgs e)
        {
            //_cmbEstrellas.DataSource = null;
            //_cmbEstrellas.DataSource = Estrellas.GetValues(typeof(Estrellas));
        }
        private void cmbAmenities_Click(object sender, EventArgs e)
        {
            //_cmbAmenities.DataSource = null;
            //_cmbAmenities.DataSource = Booleano.GetValues(typeof(Booleano));
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
                Booleano AmenitieSelect = (Booleano)_cmbAmenities.SelectedItem;
                int estrellas = (int)EstrellaSelect;
                bool amenities = false;
               if(AmenitieSelect==Booleano.Si)
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

        private void cmbHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int estrellaSelect = cmbHoteles.SelectedIndex;
            if(cmbHoteles.SelectedIndex <=0)
            {
                Limpiar();
                CargarComboHoteles();
            }
            else
            {
                
                _lstHoteles.DataSource = null;
                _lstHoteles.DataSource = _HotelNegocio.HotelesxEstrellas(estrellaSelect);
                _lstHoteles.DisplayMember = "DisplayHotel";
            }
        }
        private void cmbHoteles_Click(object sender, EventArgs e)
        {
            //cmbHoteles.DataSource = null;
            //cmbHoteles.DataSource = Estrellas.GetValues(typeof(Estrellas));
        }

        private void _btnRegargar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Carga();
        }
    }
}
