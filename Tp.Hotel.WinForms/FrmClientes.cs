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
    public partial class FrmClientes : Form
    {
        private ClienteNegocio _clienteNegocio;
        private List<Cliente> _clientes;
        
        public FrmClientes(Form main)
        {
            InitializeComponent();
            this.Owner = main;
            
            _clienteNegocio = new ClienteNegocio();
        }

        
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Carga();
            Limpiar();            
        }

        private void Carga()
        {
            
            lstClientes.DataSource = null;
            lstClientes.DataSource=ListarClientes();
            lstClientes.DisplayMember = "DisplayCliente";
            lstClientes.ValueMember = "idCliente";

        }

        private void btnVolver_Click(object sender, EventArgs e)
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
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtMail.Clear();
            txtFechaNacimiento.Clear();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
                AltaCliente();
                Limpiar();
                Carga();

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesForm.ValidarSeleccion(lstClientes.SelectedItem);
                Cliente ClienteSelect = (Cliente)lstClientes.SelectedItem;
                txtNombre.Text = ClienteSelect.Nombre;
                txtApellido.Text = ClienteSelect.Apellido;
                txtDireccion.Text = ClienteSelect.Direccion;
                txtDni.Text = ClienteSelect.Dni.ToString();
                txtTelefono.Text = ClienteSelect.Telefono.ToString();
                txtMail.Text = ClienteSelect.Email;
                txtFechaNacimiento.Text = ClienteSelect.FechaNacimiento.ToString("dd-MM-yyyy");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private List<Cliente> ListarClientes()
        {
           return _clienteNegocio.TraerClientes();
        }

        private void AltaCliente()
        {
            try
            {
                string nombre= ValidacionesForm.ValidacionesAlta(txtNombre.Text, lblNombre.Text);
                string apellido= ValidacionesForm.ValidacionesAlta(txtApellido.Text, lblApellido.Text);
                string direccion= ValidacionesForm.ValidacionesAlta(txtDireccion.Text, lblDireccion.Text);
                string email = ValidacionesForm.ValidacionesAlta(txtMail.Text, lblMail.Text);
                string Dni= ValidacionesForm.ValidacionesAlta(txtDni.Text, lblDni.Text);
                string telefono= ValidacionesForm.ValidacionesAlta(txtTelefono.Text, lblTelefono.Text);
                string mail= ValidacionesForm.ValidacionesAlta(txtMail.Text, lblMail.Text);
                string fechaNac= ValidacionesForm.ValidacionesAlta(txtFechaNacimiento.Text, lblFechNacimiento.Text);
                DateTime fechaNacimiento=ValidacionesForm.ValidacionFecha(fechaNac);
                int dni=ValidacionesForm.ValidacionNumero(Dni);
               TransactionResult operacion= _clienteNegocio.AltaCliente(dni, nombre, apellido, direccion, email, telefono, fechaNacimiento);
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
}
