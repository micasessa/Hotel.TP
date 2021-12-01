﻿using System;
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
    public partial class FrmReporteHuespedes : Form
    {
        private ReservaNegocio _ReservaNegocio;
        public FrmReporteHuespedes(Form main)
        {
            InitializeComponent();
            this.Owner = main;
            _ReservaNegocio = new ReservaNegocio();
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        private void FrmLoad(object sender, EventArgs e)
        {
            Carga();
            Limpiar();
        }

        private void Carga()
        {
            cboxSelecReserva.DataSource = null;
            cboxSelecReserva.DataSource = _ReservaNegocio.TraerReservas();
            cboxSelecReserva.DisplayMember = "DisplayReserva";
            cboxSelecReserva.ValueMember = "id";
        }

        private void Limpiar()
        {
            cboxSelecReserva.Text = "Seleccione";
            _lstHuespedes.DataSource = null;
        }

        private void CantHuespedes()
        {

        }
        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void HuespedesxRerserva(object sender, EventArgs e)
        {
            Reserva ReservaSelec = (Reserva)cboxSelecReserva.SelectedItem;
            _lstHuespedes.DataSource = null;
            _lstHuespedes.DataSource = _ReservaNegocio.TraerClientexReserva(ReservaSelec.id);
            _lstHuespedes.DisplayMember = "DisplayCliente";

        }
    }
}
