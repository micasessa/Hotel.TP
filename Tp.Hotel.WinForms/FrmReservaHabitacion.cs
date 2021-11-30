using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp.Hotel.Entidades;
using Tp.Hotel.Entidades.Modelos;
using Tp.Hotel.Negocio;

namespace Tp.Hotel.WinForms
{
    public partial class FrmReservaHabitacion : Form
    {
        HabitacionNegocio _HabitacionNegocio;
        HotelNegocio _HotelNeg;
        
        public FrmReservaHabitacion(Form main)
        {
            _HabitacionNegocio = new HabitacionNegocio();
            _HotelNeg = new HotelNegocio();
            InitializeComponent();
            this.Owner = main; 
        }

       
        private void FrmReservaHabitacion_Load(object sender, EventArgs e)
        {
            Carga();
            Limpiar();
        }



        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        private void Carga()
        {
            cmbHoteles.DataSource = null;
            cmbHoteles.DataSource = ListaHoteles();
            cmbHoteles.DisplayMember = "DisplayHotel";
            cmbHoteles.ValueMember = "id";
        }
        private void CargaHotelesxid(int Hotelid)
        {
            _lstHoteles.DataSource = null;
            _lstHoteles.DataSource = _HabitacionNegocio.TraerHabitacionesPorHotel(Hotelid);
            _lstHoteles.DisplayMember = "DisplayHabitacion";

        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            cmbHoteles.Text = "Seleccione";           
        }


        
        private List<Habitacion> ListarHabitaciones(int hotelid)
        {
            return _HabitacionNegocio.TraerHabitacionesPorHotel(hotelid);
        }
        private List<Hotel1> ListaHoteles()
        {
            return _HotelNeg.TraerHoteles();
        }
        

        private void cmbHabitaciones_Select(object sender, EventArgs e)
        {
            try
            {
                int Hotelid = (int)cmbHoteles.SelectedIndex;
                Hotel1 HotelSelec = (Hotel1)cmbHoteles.SelectedItem;
                ValidacionesForm.ExisteHabitacion(_HabitacionNegocio.TraerHabitacionesPorHotel(Hotelid));
                CargaHotelesxid(Hotelid);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSeleccionar_click(object sender, EventArgs e)
        {
            int idHabitacion = _lstHoteles.SelectedIndex;
            Habitacion habitacionSelec = (Habitacion)_lstHoteles.SelectedItem;
            FrmReserva Res = new FrmReserva(this.Owner, idHabitacion, habitacionSelec);
            this.Hide();
            Res.Show();
        }
    }
}

