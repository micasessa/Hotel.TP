namespace Tp.Hotel.WinForms
{
    partial class FrmReporteTodasReservas
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
            this._btnLimpiar = new System.Windows.Forms.Button();
            this._txtBoxTotalReservas = new System.Windows.Forms.TextBox();
            this._btnVolver = new System.Windows.Forms.Button();
            this._lblTotalHabitaciones = new System.Windows.Forms.Label();
            this._lblRepoSeleccioneCliente = new System.Windows.Forms.Label();
            this._dateTimeFechaDesde = new System.Windows.Forms.DateTimePicker();
            this._lstViewReservas = new System.Windows.Forms.ListView();
            this.CodigoReserva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaIngreso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaEgreso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ApellidoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hotel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantHuespedes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _btnLimpiar
            // 
            this._btnLimpiar.Location = new System.Drawing.Point(633, 44);
            this._btnLimpiar.Name = "_btnLimpiar";
            this._btnLimpiar.Size = new System.Drawing.Size(74, 24);
            this._btnLimpiar.TabIndex = 1;
            this._btnLimpiar.Text = "Limpiar";
            this._btnLimpiar.UseVisualStyleBackColor = true;
            this._btnLimpiar.Click += new System.EventHandler(this._btnLimpiar_Click);
            // 
            // _txtBoxTotalReservas
            // 
            this._txtBoxTotalReservas.Enabled = false;
            this._txtBoxTotalReservas.Location = new System.Drawing.Point(202, 376);
            this._txtBoxTotalReservas.Name = "_txtBoxTotalReservas";
            this._txtBoxTotalReservas.ReadOnly = true;
            this._txtBoxTotalReservas.Size = new System.Drawing.Size(102, 22);
            this._txtBoxTotalReservas.TabIndex = 19;
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(836, 371);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(136, 32);
            this._btnVolver.TabIndex = 3;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _lblTotalHabitaciones
            // 
            this._lblTotalHabitaciones.AutoSize = true;
            this._lblTotalHabitaciones.Location = new System.Drawing.Point(59, 379);
            this._lblTotalHabitaciones.Name = "_lblTotalHabitaciones";
            this._lblTotalHabitaciones.Size = new System.Drawing.Size(106, 16);
            this._lblTotalHabitaciones.TabIndex = 18;
            this._lblTotalHabitaciones.Text = "Total Reservas: ";
            // 
            // _lblRepoSeleccioneCliente
            // 
            this._lblRepoSeleccioneCliente.AutoSize = true;
            this._lblRepoSeleccioneCliente.Location = new System.Drawing.Point(57, 48);
            this._lblRepoSeleccioneCliente.Name = "_lblRepoSeleccioneCliente";
            this._lblRepoSeleccioneCliente.Size = new System.Drawing.Size(160, 16);
            this._lblRepoSeleccioneCliente.TabIndex = 17;
            this._lblRepoSeleccioneCliente.Text = "Seleccione Fecha Desde";
            // 
            // _dateTimeFechaDesde
            // 
            this._dateTimeFechaDesde.Location = new System.Drawing.Point(249, 46);
            this._dateTimeFechaDesde.Name = "_dateTimeFechaDesde";
            this._dateTimeFechaDesde.Size = new System.Drawing.Size(341, 22);
            this._dateTimeFechaDesde.TabIndex = 0;
            this._dateTimeFechaDesde.ValueChanged += new System.EventHandler(this._dateTimeFechaDesde_ValueChanged);
            // 
            // _lstViewReservas
            // 
            this._lstViewReservas.AllowColumnReorder = true;
            this._lstViewReservas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodigoReserva,
            this.FechaIngreso,
            this.FechaEgreso,
            this.ApellidoCliente,
            this.NombreCliente,
            this.Hotel,
            this.CantHuespedes});
            this._lstViewReservas.FullRowSelect = true;
            this._lstViewReservas.HideSelection = false;
            this._lstViewReservas.Location = new System.Drawing.Point(60, 108);
            this._lstViewReservas.Name = "_lstViewReservas";
            this._lstViewReservas.Size = new System.Drawing.Size(912, 244);
            this._lstViewReservas.TabIndex = 2;
            this._lstViewReservas.UseCompatibleStateImageBehavior = false;
            // 
            // CodigoReserva
            // 
            this.CodigoReserva.Tag = "CodigoRes";
            this.CodigoReserva.Text = "Numero Reserva";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Tag = "FechaIngreso";
            this.FechaIngreso.Text = "Fecha Ingreso";
            this.FechaIngreso.Width = 70;
            // 
            // FechaEgreso
            // 
            this.FechaEgreso.Tag = "FechaEgreso";
            this.FechaEgreso.Text = "Fecha Egreso";
            this.FechaEgreso.Width = 70;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.Tag = "ApellidoClient";
            this.ApellidoCliente.Text = "Apellido Cliente";
            this.ApellidoCliente.Width = 100;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Tag = "NombreClient";
            this.NombreCliente.Text = "Nombre Cliente";
            this.NombreCliente.Width = 100;
            // 
            // Hotel
            // 
            this.Hotel.Tag = "Hotel";
            this.Hotel.Text = "Hotel";
            this.Hotel.Width = 100;
            // 
            // CantHuespedes
            // 
            this.CantHuespedes.Tag = "CantHuesped";
            this.CantHuespedes.Text = "Huespedes";
            // 
            // FrmReporteTodasReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this._lstViewReservas);
            this.Controls.Add(this._dateTimeFechaDesde);
            this.Controls.Add(this._btnLimpiar);
            this.Controls.Add(this._txtBoxTotalReservas);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._lblTotalHabitaciones);
            this.Controls.Add(this._lblRepoSeleccioneCliente);
            this.Name = "FrmReporteTodasReservas";
            this.Text = "Reporte de Reservas";
            this.Load += new System.EventHandler(this.FrmReporteTodasReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnLimpiar;
        private System.Windows.Forms.TextBox _txtBoxTotalReservas;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label _lblTotalHabitaciones;
        private System.Windows.Forms.Label _lblRepoSeleccioneCliente;
        private System.Windows.Forms.DateTimePicker _dateTimeFechaDesde;
        private System.Windows.Forms.ListView _lstViewReservas;
        private System.Windows.Forms.ColumnHeader CodigoReserva;
        private System.Windows.Forms.ColumnHeader FechaIngreso;
        private System.Windows.Forms.ColumnHeader FechaEgreso;
        private System.Windows.Forms.ColumnHeader ApellidoCliente;
        private System.Windows.Forms.ColumnHeader NombreCliente;
        private System.Windows.Forms.ColumnHeader Hotel;
        private System.Windows.Forms.ColumnHeader CantHuespedes;
    }
}