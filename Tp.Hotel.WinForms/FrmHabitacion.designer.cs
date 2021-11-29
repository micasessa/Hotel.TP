
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
            this._lstHabitaciones = new System.Windows.Forms.ListBox();
            this.cmbHabitaciones = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this._btnLimpiarHabitacion = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnGuardarHabitacion = new System.Windows.Forms.Button();
            this._cmbCategoria = new System.Windows.Forms.ComboBox();
            this._cmbCancelable = new System.Windows.Forms.ComboBox();
            this._txtCantidadPlazas = new System.Windows.Forms.TextBox();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this._lblCantidadPlazas = new System.Windows.Forms.Label();
            this._lblCategoria = new System.Windows.Forms.Label();
            this._lblPrecio = new System.Windows.Forms.Label();
            this._lblCancelable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.lblDatosHabitacion);
            this.panel1.Controls.Add(this._lstHabitaciones);
            this.panel1.Controls.Add(this.cmbHabitaciones);
            this.panel1.Controls.Add(this.lblFiltrar);
            this.panel1.Controls.Add(this.lblHabitaciones);
            this.panel1.Controls.Add(this._btnLimpiarHabitacion);
            this.panel1.Controls.Add(this._btnVolver);
            this.panel1.Controls.Add(this._btnGuardarHabitacion);
            this.panel1.Controls.Add(this._cmbCategoria);
            this.panel1.Controls.Add(this._cmbCancelable);
            this.panel1.Controls.Add(this._txtCantidadPlazas);
            this.panel1.Controls.Add(this._txtPrecio);
            this.panel1.Controls.Add(this._lblCantidadPlazas);
            this.panel1.Controls.Add(this._lblCategoria);
            this.panel1.Controls.Add(this._lblPrecio);
            this.panel1.Controls.Add(this._lblCancelable);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 439);
            this.panel1.TabIndex = 0;
            // 
            // lblDatosHabitacion
            // 
            this.lblDatosHabitacion.AutoSize = true;
            this.lblDatosHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosHabitacion.Location = new System.Drawing.Point(385, 64);
            this.lblDatosHabitacion.Name = "lblDatosHabitacion";
            this.lblDatosHabitacion.Size = new System.Drawing.Size(170, 20);
            this.lblDatosHabitacion.TabIndex = 31;
            this.lblDatosHabitacion.Text = "Datos de la Habitación";
            // 
            // _lstHabitaciones
            // 
            this._lstHabitaciones.FormattingEnabled = true;
            this._lstHabitaciones.Location = new System.Drawing.Point(11, 132);
            this._lstHabitaciones.Margin = new System.Windows.Forms.Padding(2);
            this._lstHabitaciones.Name = "_lstHabitaciones";
            this._lstHabitaciones.Size = new System.Drawing.Size(325, 186);
            this._lstHabitaciones.TabIndex = 29;
            // 
            // cmbHabitaciones
            // 
            this.cmbHabitaciones.FormattingEnabled = true;
            this.cmbHabitaciones.Location = new System.Drawing.Point(15, 90);
            this.cmbHabitaciones.Name = "cmbHabitaciones";
            this.cmbHabitaciones.Size = new System.Drawing.Size(194, 21);
            this.cmbHabitaciones.TabIndex = 28;
            this.cmbHabitaciones.DropDownClosed += new System.EventHandler(this.cmbHabitaciones_Select);
            
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFiltrar.Location = new System.Drawing.Point(41, 64);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(133, 17);
            this.lblFiltrar.TabIndex = 27;
            this.lblFiltrar.Text = "Seleccione el Hotel:";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.BackColor = System.Drawing.Color.LightCoral;
            this.lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(39, 19);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(149, 25);
            this.lblHabitaciones.TabIndex = 26;
            this.lblHabitaciones.Text = "Habitaciones";
            // 
            // _btnLimpiarHabitacion
            // 
            this._btnLimpiarHabitacion.BackColor = System.Drawing.Color.MistyRose;
            this._btnLimpiarHabitacion.Location = new System.Drawing.Point(349, 296);
            this._btnLimpiarHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this._btnLimpiarHabitacion.Name = "_btnLimpiarHabitacion";
            this._btnLimpiarHabitacion.Size = new System.Drawing.Size(106, 22);
            this._btnLimpiarHabitacion.TabIndex = 25;
            this._btnLimpiarHabitacion.Text = "Limpiar";
            this._btnLimpiarHabitacion.UseVisualStyleBackColor = false;
            this._btnLimpiarHabitacion.Click += new System.EventHandler(this._btnLimpiarHabitacion_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.Color.MistyRose;
            this._btnVolver.Location = new System.Drawing.Point(201, 332);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(106, 22);
            this._btnVolver.TabIndex = 24;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnGuardarHabitacion
            // 
            this._btnGuardarHabitacion.BackColor = System.Drawing.Color.MistyRose;
            this._btnGuardarHabitacion.Location = new System.Drawing.Point(475, 296);
            this._btnGuardarHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this._btnGuardarHabitacion.Name = "_btnGuardarHabitacion";
            this._btnGuardarHabitacion.Size = new System.Drawing.Size(104, 22);
            this._btnGuardarHabitacion.TabIndex = 22;
            this._btnGuardarHabitacion.Text = "Guardar";
            this._btnGuardarHabitacion.UseVisualStyleBackColor = false;
            this._btnGuardarHabitacion.Click += new System.EventHandler(this._btnGuardarHabitacion_Click);
            // 
            // _cmbCategoria
            // 
            this._cmbCategoria.FormattingEnabled = true;
            this._cmbCategoria.Location = new System.Drawing.Point(475, 135);
            this._cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this._cmbCategoria.Name = "_cmbCategoria";
            this._cmbCategoria.Size = new System.Drawing.Size(109, 21);
            this._cmbCategoria.TabIndex = 21;
            
            // 
            // _cmbCancelable
            // 
            this._cmbCancelable.FormattingEnabled = true;
            this._cmbCancelable.Location = new System.Drawing.Point(475, 191);
            this._cmbCancelable.Margin = new System.Windows.Forms.Padding(2);
            this._cmbCancelable.Name = "_cmbCancelable";
            this._cmbCancelable.Size = new System.Drawing.Size(109, 21);
            this._cmbCancelable.TabIndex = 20;
            
            // 
            // _txtCantidadPlazas
            // 
            this._txtCantidadPlazas.Location = new System.Drawing.Point(475, 108);
            this._txtCantidadPlazas.Margin = new System.Windows.Forms.Padding(2);
            this._txtCantidadPlazas.Name = "_txtCantidadPlazas";
            this._txtCantidadPlazas.Size = new System.Drawing.Size(109, 20);
            this._txtCantidadPlazas.TabIndex = 18;
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Location = new System.Drawing.Point(475, 164);
            this._txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(109, 20);
            this._txtPrecio.TabIndex = 16;
            // 
            // _lblCantidadPlazas
            // 
            this._lblCantidadPlazas.AutoSize = true;
            this._lblCantidadPlazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblCantidadPlazas.Location = new System.Drawing.Point(349, 107);
            this._lblCantidadPlazas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblCantidadPlazas.Name = "_lblCantidadPlazas";
            this._lblCantidadPlazas.Size = new System.Drawing.Size(106, 16);
            this._lblCantidadPlazas.TabIndex = 14;
            this._lblCantidadPlazas.Text = "Cantidad Plazas";
            // 
            // _lblCategoria
            // 
            this._lblCategoria.AutoSize = true;
            this._lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblCategoria.Location = new System.Drawing.Point(349, 137);
            this._lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblCategoria.Name = "_lblCategoria";
            this._lblCategoria.Size = new System.Drawing.Size(67, 16);
            this._lblCategoria.TabIndex = 13;
            this._lblCategoria.Text = "Categoria";
            // 
            // _lblPrecio
            // 
            this._lblPrecio.AutoSize = true;
            this._lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblPrecio.Location = new System.Drawing.Point(349, 165);
            this._lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(47, 16);
            this._lblPrecio.TabIndex = 12;
            this._lblPrecio.Text = "Precio";
            // 
            // _lblCancelable
            // 
            this._lblCancelable.AutoSize = true;
            this._lblCancelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblCancelable.Location = new System.Drawing.Point(349, 193);
            this._lblCancelable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblCancelable.Name = "_lblCancelable";
            this._lblCancelable.Size = new System.Drawing.Size(77, 16);
            this._lblCancelable.TabIndex = 11;
            this._lblCancelable.Text = "Cancelable";
            // 
            // FrmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 380);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHabitacion";
            this.Text = "FrmHabitacion";
            this.Load += new System.EventHandler(this.FrmHabitacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _txtCantidadPlazas;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.Label _lblCantidadPlazas;
        private System.Windows.Forms.Label _lblCategoria;
        private System.Windows.Forms.Label _lblPrecio;
        private System.Windows.Forms.Label _lblCancelable;
        private System.Windows.Forms.ComboBox _cmbCancelable;
        private System.Windows.Forms.ComboBox _cmbCategoria;
        private System.Windows.Forms.Button _btnGuardarHabitacion;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnLimpiarHabitacion;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cmbHabitaciones;
        private System.Windows.Forms.ListBox _lstHabitaciones;
        private System.Windows.Forms.Label lblDatosHabitacion;
    }
}