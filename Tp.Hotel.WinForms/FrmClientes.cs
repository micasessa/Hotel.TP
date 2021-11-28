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
            //Falta desarrollar metodo
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
            try
            {
                //Completar con los valores ingresados por el usuario (y mas)


                Limpiar();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            //Falta desarrollar
        }
    }
}
