
namespace Tp.Hotel.WinForms
{
    partial class FrmHabitacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDatosHabitacion = new System.Windows.Forms.Label();
            this._btnRegargar = new System.Windows.Forms.Button();
            this._lstHabitaciones = new System.Windows.Forms.ListBox();
            this.cmbHabitaciones = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this._btnLimpiarHabitacion = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnGuardarHabitacion = new System.Windows.Forms.Button();
            this._cmbCategoria = new System.Windows.Forms.ComboBox();
            this._cmbCancelable = new System.Windows.Forms.ComboBox();
            this._txtIdHabitacion = new System.Windows.Forms.TextBox();
            this._txtCantidadPlazas = new System.Windows.Forms.TextBox();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this._lblIdHabitacion = new System.Windows.Forms.Label();
            this._lblCantidadPlazas = new System.Windows.Forms.Label();
            this._lblCategoria = new System.Windows.Forms.Label();
            this._lblPrecio = new System.Windows.Forms.Label();
            this._lblCancelable = new System.Windows.Forms.Label();
            this._txtIdHotel = new System.Windows.Forms.TextBox();
            this._lblIdHotel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.lblDatosHabitacion);
            this.panel1.Controls.Add(this._btnRegargar);
            this.panel1.Controls.Add(this._lstHabitaciones);
            this.panel1.Controls.Add(this.cmbHabitaciones);
            this.panel1.Controls.Add(this.lblFiltrar);
            this.panel1.Controls.Add(this.lblHabitaciones);
            this.panel1.Controls.Add(this._btnLimpiarHabitacion);
            this.panel1.Controls.Add(this._btnVolver);
            this.panel1.Controls.Add(this._btnGuardarHabitacion);
            this.panel1.Controls.Add(this._cmbCategoria);
            this.panel1.Controls.Add(this._cmbCancelable);
            this.panel1.Controls.Add(this._txtIdHabitacion);
            this.panel1.Controls.Add(this._txtCantidadPlazas);
            this.panel1.Controls.Add(this._txtPrecio);
            this.panel1.Controls.Add(this._lblIdHabitacion);
            this.panel1.Controls.Add(this._lblCantidadPlazas);
            this.panel1.Controls.Add(this._lblCategoria);
            this.panel1.Controls.Add(this._lblPrecio);
            this.panel1.Controls.Add(this._lblCancelable);
            this.panel1.Controls.Add(this._txtIdHotel);
            this.panel1.Controls.Add(this._lblIdHotel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 675);
            this.panel1.TabIndex = 0;
            // 
            // lblDatosHabitacion
            // 
            this.lblDatosHabitacion.AutoSize = true;
            this.lblDatosHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosHabitacion.Location = new System.Drawing.Point(577, 99);
            this.lblDatosHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosHabitacion.Name = "lblDatosHabitacion";
            this.lblDatosHabitacion.Size = new System.Drawing.Size(254, 29);
            this.lblDatosHabitacion.TabIndex = 31;
            this.lblDatosHabitacion.Text = "Datos de la Habitación";
            // 
            // _btnRegargar
            // 
            this._btnRegargar.BackColor = System.Drawing.Color.MistyRose;
            this._btnRegargar.Location = new System.Drawing.Point(66, 456);
            this._btnRegargar.Name = "_btnRegargar";
            this._btnRegargar.Size = new System.Drawing.Size(159, 34);
            this._btnRegargar.TabIndex = 30;
            this._btnRegargar.Text = "Recargar";
            this._btnRegargar.UseVisualStyleBackColor = false;
            // 
            // _lstHabitaciones
            // 
            this._lstHabitaciones.FormattingEnabled = true;
            this._lstHabitaciones.ItemHeight = 20;
            this._lstHabitaciones.Location = new System.Drawing.Point(66, 150);
            this._lstHabitaciones.Name = "_lstHabitaciones";
            this._lstHabitaciones.Size = new System.Drawing.Size(367, 284);
            this._lstHabitaciones.TabIndex = 29;
            // 
            // cmbHabitaciones
            // 
            this.cmbHabitaciones.FormattingEnabled = true;
            this.cmbHabitaciones.Location = new System.Drawing.Point(144, 103);
            this.cmbHabitaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbHabitaciones.Name = "cmbHabitaciones";
            this.cmbHabitaciones.Size = new System.Drawing.Size(289, 28);
            this.cmbHabitaciones.TabIndex = 28;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(61, 103);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(75, 29);
            this.lblFiltrar.TabIndex = 27;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.BackColor = System.Drawing.Color.LightCoral;
            this.lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(59, 30);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(214, 37);
            this.lblHabitaciones.TabIndex = 26;
            this.lblHabitaciones.Text = "Habitaciones";
            // 
            // _btnLimpiarHabitacion
            // 
            this._btnLimpiarHabitacion.BackColor = System.Drawing.Color.MistyRose;
            this._btnLimpiarHabitacion.Location = new System.Drawing.Point(524, 456);
            this._btnLimpiarHabitacion.Name = "_btnLimpiarHabitacion";
            this._btnLimpiarHabitacion.Size = new System.Drawing.Size(159, 34);
            this._btnLimpiarHabitacion.TabIndex = 25;
            this._btnLimpiarHabitacion.Text = "Limpiar";
            this._btnLimpiarHabitacion.UseVisualStyleBackColor = false;
            this._btnLimpiarHabitacion.Click += new System.EventHandler(this._btnLimpiarHabitacion_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.Color.MistyRose;
            this._btnVolver.Location = new System.Drawing.Point(274, 456);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(159, 34);
            this._btnVolver.TabIndex = 24;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnGuardarHabitacion
            // 
            this._btnGuardarHabitacion.BackColor = System.Drawing.Color.MistyRose;
            this._btnGuardarHabitacion.Location = new System.Drawing.Point(712, 456);
            this._btnGuardarHabitacion.Name = "_btnGuardarHabitacion";
            this._btnGuardarHabitacion.Size = new System.Drawing.Size(156, 34);
            this._btnGuardarHabitacion.TabIndex = 22;
            this._btnGuardarHabitacion.Text = "Guardar";
            this._btnGuardarHabitacion.UseVisualStyleBackColor = false;
            // 
            // _cmbCategoria
            // 
            this._cmbCategoria.FormattingEnabled = true;
            this._cmbCategoria.Location = new System.Drawing.Point(708, 306);
            this._cmbCategoria.Name = "_cmbCategoria";
            this._cmbCategoria.Size = new System.Drawing.Size(162, 28);
            this._cmbCategoria.TabIndex = 21;
            // 
            // _cmbCancelable
            // 
            this._cmbCancelable.FormattingEnabled = true;
            this._cmbCancelable.Location = new System.Drawing.Point(708, 393);
            this._cmbCancelable.Name = "_cmbCancelable";
            this._cmbCancelable.Size = new System.Drawing.Size(162, 28);
            this._cmbCancelable.TabIndex = 20;
            // 
            // _txtIdHabitacion
            // 
            this._txtIdHabitacion.Location = new System.Drawing.Point(708, 222);
            this._txtIdHabitacion.Name = "_txtIdHabitacion";
            this._txtIdHabitacion.Size = new System.Drawing.Size(162, 26);
            this._txtIdHabitacion.TabIndex = 19;
            // 
            // _txtCantidadPlazas
            // 
            this._txtCantidadPlazas.Location = new System.Drawing.Point(708, 264);
            this._txtCantidadPlazas.Name = "_txtCantidadPlazas";
            this._txtCantidadPlazas.Size = new System.Drawing.Size(162, 26);
            this._txtCantidadPlazas.TabIndex = 18;
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Location = new System.Drawing.Point(708, 351);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(162, 26);
            this._txtPrecio.TabIndex = 16;
            // 
            // _lblIdHabitacion
            // 
            this._lblIdHabitacion.AutoSize = true;
            this._lblIdHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblIdHabitacion.Location = new System.Drawing.Point(519, 221);
            this._lblIdHabitacion.Name = "_lblIdHabitacion";
            this._lblIdHabitacion.Size = new System.Drawing.Size(125, 25);
            this._lblIdHabitacion.TabIndex = 15;
            this._lblIdHabitacion.Text = "Id Habitacion";
            // 
            // _lblCantidadPlazas
            // 
            this._lblCantidadPlazas.AutoSize = true;
            this._lblCantidadPlazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblCantidadPlazas.Location = new System.Drawing.Point(519, 263);
            this._lblCantidadPlazas.Name = "_lblCantidadPlazas";
            this._lblCantidadPlazas.Size = new System.Drawing.Size(155, 25);
            this._lblCantidadPlazas.TabIndex = 14;
            this._lblCantidadPlazas.Text = "Cantidad Plazas";
            // 
            // _lblCategoria
            // 
            this._lblCategoria.AutoSize = true;
            this._lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblCategoria.Location = new System.Drawing.Point(519, 309);
            this._lblCategoria.Name = "_lblCategoria";
            this._lblCategoria.Size = new System.Drawing.Size(97, 25);
            this._lblCategoria.TabIndex = 13;
            this._lblCategoria.Text = "Categoria";
            // 
            // _lblPrecio
            // 
            this._lblPrecio.AutoSize = true;
            this._lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblPrecio.Location = new System.Drawing.Point(519, 352);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(67, 25);
            this._lblPrecio.TabIndex = 12;
            this._lblPrecio.Text = "Precio";
            // 
            // _lblCancelable
            // 
            this._lblCancelable.AutoSize = true;
            this._lblCancelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblCancelable.Location = new System.Drawing.Point(519, 396);
            this._lblCancelable.Name = "_lblCancelable";
            this._lblCancelable.Size = new System.Drawing.Size(111, 25);
            this._lblCancelable.TabIndex = 11;
            this._lblCancelable.Text = "Cancelable";
            // 
            // _txtIdHotel
            // 
            this._txtIdHotel.Location = new System.Drawing.Point(708, 173);
            this._txtIdHotel.Name = "_txtIdHotel";
            this._txtIdHotel.Size = new System.Drawing.Size(162, 26);
            this._txtIdHotel.TabIndex = 10;
            // 
            // _lblIdHotel
            // 
            this._lblIdHotel.AutoSize = true;
            this._lblIdHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblIdHotel.Location = new System.Drawing.Point(519, 174);
            this._lblIdHotel.Name = "_lblIdHotel";
            this._lblIdHotel.Size = new System.Drawing.Size(78, 25);
            this._lblIdHotel.TabIndex = 1;
            this._lblIdHotel.Text = "Id Hotel";
            // 
            // FrmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 585);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHabitacion";
            this.Text = "FrmHabitacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label _lblIdHotel;
        private System.Windows.Forms.TextBox _txtIdHabitacion;
        private System.Windows.Forms.TextBox _txtCantidadPlazas;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.Label _lblIdHabitacion;
        private System.Windows.Forms.Label _lblCantidadPlazas;
        private System.Windows.Forms.Label _lblCategoria;
        private System.Windows.Forms.Label _lblPrecio;
        private System.Windows.Forms.Label _lblCancelable;
        private System.Windows.Forms.TextBox _txtIdHotel;
        private System.Windows.Forms.ComboBox _cmbCancelable;
        private System.Windows.Forms.ComboBox _cmbCategoria;
        private System.Windows.Forms.Button _btnGuardarHabitacion;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnLimpiarHabitacion;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cmbHabitaciones;
        private System.Windows.Forms.ListBox _lstHabitaciones;
        private System.Windows.Forms.Button _btnRegargar;
        private System.Windows.Forms.Label lblDatosHabitacion;
    }
}