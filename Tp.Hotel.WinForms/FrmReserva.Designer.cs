
namespace Tp.Hotel.WinForms
{
    partial class FrmReserva
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
            this.lblDatosReserva = new System.Windows.Forms.Label();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtHuespedes = new System.Windows.Forms.TextBox();
            this.txtFechaEgreso = new System.Windows.Forms.TextBox();
            this.lblHuespedes = new System.Windows.Forms.Label();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.txtNroReserva = new System.Windows.Forms.TextBox();
            this.lblNroReserva = new System.Windows.Forms.Label();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReserva = new System.Windows.Forms.ComboBox();
            this._lblHotelSeleccionado = new System.Windows.Forms.Label();
            this._lblHabitacionSeleccionada = new System.Windows.Forms.Label();
            this._lblClienteSeleccionado = new System.Windows.Forms.Label();
            this._txtHotelSeleccionado = new System.Windows.Forms.TextBox();
            this._txtHabitacionSeleccionada = new System.Windows.Forms.TextBox();
            this._txtClienteSeleccionado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDatosReserva
            // 
            this.lblDatosReserva.AutoSize = true;
            this.lblDatosReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosReserva.Location = new System.Drawing.Point(572, 83);
            this.lblDatosReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosReserva.Name = "lblDatosReserva";
            this.lblDatosReserva.Size = new System.Drawing.Size(167, 25);
            this.lblDatosReserva.TabIndex = 11;
            this.lblDatosReserva.Text = "Datos de Reserva";
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(712, 214);
            this.txtFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(132, 22);
            this.txtFechaIngreso.TabIndex = 4;
            // 
            // txtHuespedes
            // 
            this.txtHuespedes.Location = new System.Drawing.Point(712, 322);
            this.txtHuespedes.Margin = new System.Windows.Forms.Padding(4);
            this.txtHuespedes.Name = "txtHuespedes";
            this.txtHuespedes.Size = new System.Drawing.Size(132, 22);
            this.txtHuespedes.TabIndex = 6;
            // 
            // txtFechaEgreso
            // 
            this.txtFechaEgreso.Location = new System.Drawing.Point(712, 265);
            this.txtFechaEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaEgreso.Name = "txtFechaEgreso";
            this.txtFechaEgreso.Size = new System.Drawing.Size(132, 22);
            this.txtFechaEgreso.TabIndex = 5;
            // 
            // lblHuespedes
            // 
            this.lblHuespedes.AutoSize = true;
            this.lblHuespedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuespedes.Location = new System.Drawing.Point(471, 321);
            this.lblHuespedes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHuespedes.Name = "lblHuespedes";
            this.lblHuespedes.Size = new System.Drawing.Size(189, 20);
            this.lblHuespedes.TabIndex = 25;
            this.lblHuespedes.Text = "Cantidad de huespedes:";
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEgreso.Location = new System.Drawing.Point(474, 264);
            this.lblFechaEgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(141, 20);
            this.lblFechaEgreso.TabIndex = 24;
            this.lblFechaEgreso.Text = "Fecha de Egreso:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(471, 214);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(143, 20);
            this.lblFechaIngreso.TabIndex = 23;
            this.lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(744, 403);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 62);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.BlueViolet;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(476, 403);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 62);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.BlueViolet;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(1393, 403);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 62);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCargarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCliente.Location = new System.Drawing.Point(32, 403);
            this.btnCargarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(116, 62);
            this.btnCargarCliente.TabIndex = 2;
            this.btnCargarCliente.Text = "Cargar Nuevo";
            this.btnCargarCliente.UseVisualStyleBackColor = false;
            this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // txtNroReserva
            // 
            this.txtNroReserva.Enabled = false;
            this.txtNroReserva.Location = new System.Drawing.Point(712, 162);
            this.txtNroReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroReserva.Name = "txtNroReserva";
            this.txtNroReserva.Size = new System.Drawing.Size(132, 22);
            this.txtNroReserva.TabIndex = 3;
            // 
            // lblNroReserva
            // 
            this.lblNroReserva.AutoSize = true;
            this.lblNroReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroReserva.Location = new System.Drawing.Point(471, 163);
            this.lblNroReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroReserva.Name = "lblNroReserva";
            this.lblNroReserva.Size = new System.Drawing.Size(163, 20);
            this.lblNroReserva.TabIndex = 42;
            this.lblNroReserva.Text = "Número de Reserva:";
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 16;
            this.lstClientes.Location = new System.Drawing.Point(32, 163);
            this.lstClientes.Margin = new System.Windows.Forms.Padding(4);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(377, 212);
            this.lstClientes.TabIndex = 1;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.Location = new System.Drawing.Point(28, 83);
            this.lblDatosCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(156, 25);
            this.lblDatosCliente.TabIndex = 10;
            this.lblDatosCliente.Text = "Datos de Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Filtrar por numero reserva:";
            // 
            // cmbReserva
            // 
            this.cmbReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReserva.FormattingEnabled = true;
            this.cmbReserva.Location = new System.Drawing.Point(238, 126);
            this.cmbReserva.Margin = new System.Windows.Forms.Padding(4);
            this.cmbReserva.Name = "cmbReserva";
            this.cmbReserva.Size = new System.Drawing.Size(171, 24);
            this.cmbReserva.TabIndex = 0;
            // 
            // _lblHotelSeleccionado
            // 
            this._lblHotelSeleccionado.AutoSize = true;
            this._lblHotelSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblHotelSeleccionado.Location = new System.Drawing.Point(902, 164);
            this._lblHotelSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblHotelSeleccionado.Name = "_lblHotelSeleccionado";
            this._lblHotelSeleccionado.Size = new System.Drawing.Size(54, 20);
            this._lblHotelSeleccionado.TabIndex = 45;
            this._lblHotelSeleccionado.Text = "Hotel ";
            // 
            // _lblHabitacionSeleccionada
            // 
            this._lblHabitacionSeleccionada.AutoSize = true;
            this._lblHabitacionSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblHabitacionSeleccionada.Location = new System.Drawing.Point(902, 216);
            this._lblHabitacionSeleccionada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblHabitacionSeleccionada.Name = "_lblHabitacionSeleccionada";
            this._lblHabitacionSeleccionada.Size = new System.Drawing.Size(89, 20);
            this._lblHabitacionSeleccionada.TabIndex = 46;
            this._lblHabitacionSeleccionada.Text = "Habitación";
            // 
            // _lblClienteSeleccionado
            // 
            this._lblClienteSeleccionado.AutoSize = true;
            this._lblClienteSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblClienteSeleccionado.Location = new System.Drawing.Point(902, 267);
            this._lblClienteSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblClienteSeleccionado.Name = "_lblClienteSeleccionado";
            this._lblClienteSeleccionado.Size = new System.Drawing.Size(66, 20);
            this._lblClienteSeleccionado.TabIndex = 47;
            this._lblClienteSeleccionado.Text = "Cliente ";
            // 
            // _txtHotelSeleccionado
            // 
            this._txtHotelSeleccionado.Enabled = false;
            this._txtHotelSeleccionado.Location = new System.Drawing.Point(1012, 164);
            this._txtHotelSeleccionado.Margin = new System.Windows.Forms.Padding(4);
            this._txtHotelSeleccionado.Name = "_txtHotelSeleccionado";
            this._txtHotelSeleccionado.ReadOnly = true;
            this._txtHotelSeleccionado.Size = new System.Drawing.Size(481, 22);
            this._txtHotelSeleccionado.TabIndex = 9;
            // 
            // _txtHabitacionSeleccionada
            // 
            this._txtHabitacionSeleccionada.Enabled = false;
            this._txtHabitacionSeleccionada.Location = new System.Drawing.Point(1012, 216);
            this._txtHabitacionSeleccionada.Margin = new System.Windows.Forms.Padding(4);
            this._txtHabitacionSeleccionada.Name = "_txtHabitacionSeleccionada";
            this._txtHabitacionSeleccionada.ReadOnly = true;
            this._txtHabitacionSeleccionada.Size = new System.Drawing.Size(481, 22);
            this._txtHabitacionSeleccionada.TabIndex = 10;
            // 
            // _txtClienteSeleccionado
            // 
            this._txtClienteSeleccionado.Enabled = false;
            this._txtClienteSeleccionado.Location = new System.Drawing.Point(1012, 267);
            this._txtClienteSeleccionado.Margin = new System.Windows.Forms.Padding(4);
            this._txtClienteSeleccionado.Name = "_txtClienteSeleccionado";
            this._txtClienteSeleccionado.ReadOnly = true;
            this._txtClienteSeleccionado.Size = new System.Drawing.Size(481, 22);
            this._txtClienteSeleccionado.TabIndex = 11;
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1532, 523);
            this.Controls.Add(this._txtClienteSeleccionado);
            this.Controls.Add(this._txtHabitacionSeleccionada);
            this.Controls.Add(this._txtHotelSeleccionado);
            this.Controls.Add(this._lblClienteSeleccionado);
            this.Controls.Add(this._lblHabitacionSeleccionada);
            this.Controls.Add(this._lblHotelSeleccionado);
            this.Controls.Add(this.cmbReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.txtNroReserva);
            this.Controls.Add(this.lblNroReserva);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCargarCliente);
            this.Controls.Add(this.lblDatosReserva);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtHuespedes);
            this.Controls.Add(this.txtFechaEgreso);
            this.Controls.Add(this.lblHuespedes);
            this.Controls.Add(this.lblFechaEgreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.lstClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatosReserva;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtHuespedes;
        private System.Windows.Forms.TextBox txtFechaEgreso;
        private System.Windows.Forms.Label lblHuespedes;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.TextBox txtNroReserva;
        private System.Windows.Forms.Label lblNroReserva;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbReserva;
        private System.Windows.Forms.Label _lblHotelSeleccionado;
        private System.Windows.Forms.Label _lblHabitacionSeleccionada;
        private System.Windows.Forms.Label _lblClienteSeleccionado;
        private System.Windows.Forms.TextBox _txtHotelSeleccionado;
        private System.Windows.Forms.TextBox _txtHabitacionSeleccionada;
        private System.Windows.Forms.TextBox _txtClienteSeleccionado;
    }
}