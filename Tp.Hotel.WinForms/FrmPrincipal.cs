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

namespace Tp.Hotel.WinForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


       

  
        private void _btnCliente_Click(object sender, EventArgs e)
        {

        }

        private void _btnReserva_Click(object sender, EventArgs e)
        {

        }

        private void _btnHoteles_Click(object sender, EventArgs e)
        {

        }

        private void _btnHabitaciones_Click(object sender, EventArgs e)
        {
            FrmHabitacion hab = new FrmHabitacion(this);
            hab.Show();
            this.Hide();
        }

        private void _btnHuespedesReserva_Click(object sender, EventArgs e)
        {

        }

        private void _btnReporteHabitaciones_Click(object sender, EventArgs e)
        {

        }
        private void _btnReporteReservas_Click(object sender, EventArgs e)
        {

        }
    }
}
