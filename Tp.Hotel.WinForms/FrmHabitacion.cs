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
    public partial class FrmHabitacion : Form
    {
        public FrmHabitacion(Form main)
        {
            InitializeComponent();
            this.Owner = main;
        }

        private void FrmHabitacion_Load(object sender, EventArgs e)
        {
            Carga();
            Limpiar();
        }

        private void Carga()
        {
            //Falta desarrollar
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
            _txtIdHabitacion.Clear();
            _txtCantidadPlazas.Clear();
            _txtPrecio.Clear();
        }

        private void _btnRegargar_Click(object sender, EventArgs e)
        {

        }

        private void _btnGuardarHabitacion_Click(object sender, EventArgs e)
        {

        }

        
    }
}
