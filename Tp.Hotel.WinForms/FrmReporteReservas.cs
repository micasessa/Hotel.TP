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
    public partial class FrmReporteReservas : Form
    {
        private ClienteNegocio _ClienteNegocio;
        private ReservaNegocio _ReservaNegocio;
        public FrmReporteReservas(Form main)
        {
            InitializeComponent();
            this.Owner = main;
            _ClienteNegocio = new ClienteNegocio();
            _ReservaNegocio = new ReservaNegocio();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void CargaCliente()
        {
            _cBoxSelCliente.DataSource = null;
            _cBoxSelCliente.DataSource = _ClienteNegocio.TraerClientes(); ;
            _cBoxSelCliente.DisplayMember = "DisplayCliente";
            _cBoxSelCliente.ValueMember = "id";

        }

        private void FrmLoad (object sender, EventArgs e)
        {
            CargaCliente();
            Limpiar();
        }

        private void Limpiar()
        {
            _cBoxSelCliente.Text = "Seleccione";
            _lstReservaxCliente.Text = "Seleccione";
            _txtBoxTotalHabitaciones.Clear();
        }
        public void cmbClientes_Click(object sender, EventArgs e)
        {
            
            ClienteNegocio client = new ClienteNegocio();
            Cliente cliente = (Cliente)_cBoxSelCliente.SelectedItem;
            _lstReservaxCliente.DataSource = null;
            _lstReservaxCliente.DataSource=_ReservaNegocio.TraerReservasPorCliente(cliente.id);
            _lstReservaxCliente.DisplayMember = "DisplayReserva";
            _lstReservaxCliente.ValueMember = "id";
            CantidadReservas();
           

        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        
        private void CantidadReservas()
        {
            int cantReservas = 0;
            if (_lstReservaxCliente != null)
            {
                cantReservas = _lstReservaxCliente.Items.Count;
            }
            _txtBoxTotalHabitaciones.Text = cantReservas.ToString();
          
        }
    }
}
