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
using Tp.Hotel.Entidades.Modelos;
using Tp.Hotel.Negocio;


namespace Tp.Hotel.WinForms
{
    public partial class FrmReserva : Form
    {
        private ClienteNegocio _ClienteNegocio;
        private ReservaNegocio _ReservaNegocio;
        private Habitacion _Habitacion;
        private int _idHabitacion;

        public int IdHabitacion { get => _idHabitacion; set => _idHabitacion = value; }

        public FrmReserva(Form main, int idHabitacion, Habitacion habitacion)
        {
            InitializeComponent();
            this.Owner = main;
            _ClienteNegocio = new ClienteNegocio();
            _ReservaNegocio = new ReservaNegocio();
            _Habitacion = habitacion;
            IdHabitacion = idHabitacion;
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
            
        private void Volver()
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
            txtNroReserva.Clear();
            txtFechaIngreso.Clear();
            txtFechaEgreso.Clear();
            txtHuespedes.Clear();
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes FormClientes = new FrmClientes(this.Owner);
            this.Hide();
            FormClientes.Show();
        }

        private void lstClientes_Load(object sender, EventArgs e)
        {
            Carga();
        }

        private void Carga()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = _ClienteNegocio.TraerClientes();
            lstClientes.DisplayMember = "DisplayCliente";
            lstClientes.ValueMember = "idCliente";

            CargaIdReserva();
        }

        private void CargaIdReserva()
        {
            cmbReserva.DataSource = null;
            cmbReserva.DataSource = ListaReservas();
            cmbReserva.DisplayMember = "DisplayReserva";
            cmbReserva.ValueMember = "IdReserva";

        }

        private List<Reserva> ListaReservas()
        {
            List<Cliente> lista = new List<Cliente>();
            lista.Add(_ReservaNegocio.TraerReservasPorCliente());

            return lista;
           
        }

        private void Alta()
        {
            try
            {
                
                string huespedes = ValidacionesForm.ValidacionesAlta(txtHuespedes.Text, lblHuespedes.Text);
                string ingreso = ValidacionesForm.ValidacionesAlta(txtFechaIngreso.Text, lblFechaIngreso.Text);
                string egreso = ValidacionesForm.ValidacionesAlta(txtFechaEgreso.Text, lblFechaEgreso.Text);
                int canthuespedes = ValidacionesForm.ValidacionNumero(huespedes);
                DateTime fechaingreso = ValidacionesForm.ValidacionFecha(ingreso);
                DateTime fechaegreso = ValidacionesForm.ValidacionFecha(egreso);
                int idCliente = lstClientes.SelectedIndex;                
                TransactionResult operacion = _ReservaNegocio.AltaReserva(IdHabitacion,idCliente, canthuespedes, fechaingreso, fechaegreso);
                    if (operacion.IsOk)
                {
                    MessageBox.Show("La reserva se ha registrado exitosamente");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alta();
            Volver();
        }
    }
}
