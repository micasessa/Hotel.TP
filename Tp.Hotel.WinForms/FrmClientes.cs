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

            _clienteNegocio = new ClienteNegocio;
        }

        
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

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

        }
    }
}
