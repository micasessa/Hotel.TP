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
           
        }
        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alta();

        }
        private void _btnLimpiarHabitacion_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
             _txtNombre.Clear();
            _txtDireccion.Clear();
            _cmbEstrellas.SelectedIndex = 0;
            _cmbAmenities.SelectedIndex = 0;
            cmbHoteles.SelectedIndex =0;
            
        }
        private void Carga()
        {
            CargarHoteles();
            CargarAmenities();
            CargarEstrellas();
           CargarComboHoteles();
            
            
        }

        public void CargarEstrellas()
        {
            _cmbEstrellas.DataSource = null;
            _cmbEstrellas.DataSource = Estrellas.GetValues(typeof(Estrellas));
            _cmbEstrellas.ValueMember = "";
           
        }

        public void CargarAmenities()
        {
            _cmbAmenities.DataSource = null;
            _cmbAmenities.DataSource = Booleano.GetValues(typeof(Booleano));
            _cmbEstrellas.ValueMember = "";
           
        }


        public void CargarHoteles()
        {
            _lstHoteles.DataSource = null;
            _lstHoteles.DataSource = ListarHoteles();
            _lstHoteles.DisplayMember = "DisplayHotel";
            _lstHoteles.ValueMember = "id";
        }

        public void CargarComboHoteles()
        {
            cmbHoteles.DataSource = null;
            cmbHoteles.DataSource = Enum.GetValues(typeof(EstrellasHoteles));
            //cmbHoteles.DisplayMember = "";
            //cmbHoteles.ValueMember = "";
           
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
                    Limpiar();
                    Carga();
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
            if (cmbHoteles.SelectedIndex <= 0)
            {
                //Limpiar();                
                CargarHoteles();
               
            }
            else
            {
                
                _lstHoteles.DataSource = null;
                _lstHoteles.DataSource = _HotelNegocio.HotelesxEstrellas(estrellaSelect);
                _lstHoteles.DisplayMember = "DisplayHotel";
            }
        }
        
        private void _btnRegargar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Carga();
        }
    }
}
