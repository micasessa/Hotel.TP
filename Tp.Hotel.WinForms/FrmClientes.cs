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
            cmbClientes.SelectedItem = "--SELECCIONE--";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
                AltaCliente();
                Limpiar();
                Carga();

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            //Falta desarrollar
        }

        private List<Cliente> ListarClientes()
        {
           return _clienteNegocio.TraerClientes();
        }

        private void AltaCliente()
        {
            try
            {
                string nombre= ValidacionesAlta(txtNombre.Text, lblNombre.Text);
                string apellido=ValidacionesAlta(txtApellido.Text, lblApellido.Text);
                string direccion=ValidacionesAlta(txtDireccion.Text, lblDireccion.Text);
                string email = ValidacionesAlta(txtMail.Text, lblMail.Text);
                string Dni=ValidacionesAlta(txtDni.Text, lblDni.Text);
                string telefono=ValidacionesAlta(txtTelefono.Text, lblTelefono.Text);
                string mail= ValidacionesAlta(txtMail.Text, lblMail.Text);
                string fechaNac=ValidacionesAlta(txtFechaNacimiento.Text, lblFechNacimiento.Text);
                DateTime fechaNacimiento=ValidacionFecha(fechaNac);
                int dni=ValidacionNumero(Dni);
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

        private string ValidacionesAlta(string txt, string lbl)
        {
            if(txt==string.Empty)
            {
                throw new Exception("Falta ingresar el valor en el campo " + lbl);
            }
            return txt;
        }

        private int ValidacionNumero(string txt)
        {
            if(!int.TryParse(txt, out int numero))
                {
                throw new Exception("Debe ingresar un valor con formato de número");
            }
            return numero;
        }

        private DateTime ValidacionFecha(string txt)
        {
            if (!DateTime.TryParse(txt, out DateTime fecha))
            {
                throw new Exception("Debe ingresar un valor con formato de fecha");
            }
            return fecha;
        }
    }
}
