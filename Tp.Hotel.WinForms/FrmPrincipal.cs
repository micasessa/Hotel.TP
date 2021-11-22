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
            FrmClientes cli = new FrmClientes(this);
            cli.Show();
            this.Hide();
        }

        private void _btnReserva_Click(object sender, EventArgs e)
        {
            FrmReserva res = new FrmReserva(this);
            res.Show();
            this.Hide();
        }

        private void _btnHoteles_Click(object sender, EventArgs e)
        {
            FrmHoteles hot = new FrmHoteles(this);
            hot.Show();
            this.Hide();
        }

        private void _btnHabitaciones_Click(object sender, EventArgs e)
        {
            FrmHabitacion hab = new FrmHabitacion(this);
            hab.Show();
            this.Hide();
        }

        private void _btnHuespedesReserva_Click(object sender, EventArgs e)
        {
            FrmReporteHuespedes repHue = new FrmReporteHuespedes(this);
            repHue.Show();
            this.Hide();
        }

        private void _btnReporteHabitaciones_Click(object sender, EventArgs e)
        {
            FrmReporteHabitaciones repHab = new FrmReporteHabitaciones(this);
            repHab.Show();
            this.Hide();
        }
        private void _btnReporteReservas_Click(object sender, EventArgs e)
        {
            FrmReporteReservas repRes = new FrmReporteReservas(this);
            repRes.Show();
            this.Hide();
        }
    }
}
