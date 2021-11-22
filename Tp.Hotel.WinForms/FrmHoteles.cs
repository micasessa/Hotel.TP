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
        public FrmHoteles(Form main)
        {
            InitializeComponent();
            this.Owner = main;
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
    }
}
