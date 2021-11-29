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

        private void _btnLimpiarHabitacion_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _txtIdHotel.Clear();
            _txtNombre.Clear();
            _txtDireccion.Clear();
            
        }
        private void Carga()
        {
            _lstHoteles.DataSource = null;
            _lstHoteles.DataSource = ListarHoteles();
            _lstHoteles.DisplayMember = "DisplayHotel";

        }

        private List<Hotel1> ListarHoteles()
        {
           return _HotelNegocio.TraerHoteles();
        }

        private void Alta()
        { 
         try
            {
                string nombre = ValidacionesForm.ValidacionesAlta(txtNombre.Text, lblNombre.Text);
        string apellido = ValidacionesForm.ValidacionesAlta(txtApellido.Text, lblApellido.Text);
        string direccion = ValidacionesForm.ValidacionesAlta(txtDireccion.Text, lblDireccion.Text);
        string email = ValidacionesForm.ValidacionesAlta(txtMail.Text, lblMail.Text);
        string Dni = ValidacionesForm.ValidacionesAlta(txtDni.Text, lblDni.Text);
        string telefono = ValidacionesForm.ValidacionesAlta(txtTelefono.Text, lblTelefono.Text);
        string mail = ValidacionesForm.ValidacionesAlta(txtMail.Text, lblMail.Text);
        string fechaNac = ValidacionesForm.ValidacionesAlta(txtFechaNacimiento.Text, lblFechNacimiento.Text);
        DateTime fechaNacimiento = ValidacionesForm.ValidacionFecha(fechaNac);
        int dni = ValidacionesForm.ValidacionNumero(Dni);
        TransactionResult operacion = _clienteNegocio.AltaCliente(dni, nombre, apellido, direccion, email, telefono, fechaNacimiento);
                if(operacion.IsOk)
                {
                    MessageBox.Show("El cliente ha sido registrado exitosamente");
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
