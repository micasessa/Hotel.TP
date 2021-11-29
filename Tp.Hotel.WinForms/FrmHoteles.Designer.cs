
namespace Tp.Hotel.WinForms
{
    partial class FrmHoteles
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
            this._btnRegargar = new System.Windows.Forms.Button();
            this.cmbHoteles = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblDatosHotel = new System.Windows.Forms.Label();
            this.lblHoteles = new System.Windows.Forms.Label();
            this._lstHoteles = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._cmbAmenities = new System.Windows.Forms.ComboBox();
            this._cmbEstrellas = new System.Windows.Forms.ComboBox();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._btnLimpiarHabitacion = new System.Windows.Forms.Button();
            this._btnGuardarHabitacion = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblDireccion = new System.Windows.Forms.Label();
            this._lblEstrellas = new System.Windows.Forms.Label();
            this._lblAmenities = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this._btnRegargar);
            this.panel1.Controls.Add(this.cmbHoteles);
            this.panel1.Controls.Add(this.lblFiltrar);
            this.panel1.Controls.Add(this.lblDatosHotel);
            this.panel1.Controls.Add(this.lblHoteles);
            this.panel1.Controls.Add(this._lstHoteles);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this._cmbAmenities);
            this.panel1.Controls.Add(this._cmbEstrellas);
            this.panel1.Controls.Add(this._txtDireccion);
            this.panel1.Controls.Add(this._txtNombre);
            this.panel1.Controls.Add(this._btnLimpiarHabitacion);
            this.panel1.Controls.Add(this._btnGuardarHabitacion);
            this.panel1.Controls.Add(this._btnVolver);
            this.panel1.Controls.Add(this._lblNombre);
            this.panel1.Controls.Add(this._lblDireccion);
            this.panel1.Controls.Add(this._lblEstrellas);
            this.panel1.Controls.Add(this._lblAmenities);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 430);
            this.panel1.TabIndex = 0;
            // 
            // _btnRegargar
            // 
            this._btnRegargar.BackColor = System.Drawing.Color.PaleTurquoise;
            this._btnRegargar.Location = new System.Drawing.Point(31, 281);
            this._btnRegargar.Margin = new System.Windows.Forms.Padding(2);
            this._btnRegargar.Name = "_btnRegargar";
            this._btnRegargar.Size = new System.Drawing.Size(89, 22);
            this._btnRegargar.TabIndex = 10;
            this._btnRegargar.Text = "Recargar";
            this._btnRegargar.UseVisualStyleBackColor = false;
            // 
            // cmbHoteles
            // 
            this.cmbHoteles.FormattingEnabled = true;
            this.cmbHoteles.Location = new System.Drawing.Point(83, 57);
            this.cmbHoteles.Name = "cmbHoteles";
            this.cmbHoteles.Size = new System.Drawing.Size(194, 21);
            this.cmbHoteles.TabIndex = 8;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(28, 55);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(49, 20);
            this.lblFiltrar.TabIndex = 21;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // lblDatosHotel
            // 
            this.lblDatosHotel.AutoSize = true;
            this.lblDatosHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosHotel.Location = new System.Drawing.Point(383, 55);
            this.lblDatosHotel.Name = "lblDatosHotel";
            this.lblDatosHotel.Size = new System.Drawing.Size(119, 20);
            this.lblDatosHotel.TabIndex = 20;
            this.lblDatosHotel.Text = "Datos del Hotel";
            // 
            // lblHoteles
            // 
            this.lblHoteles.AutoSize = true;
            this.lblHoteles.BackColor = System.Drawing.Color.PowderBlue;
            this.lblHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoteles.Location = new System.Drawing.Point(27, 8);
            this.lblHoteles.Name = "lblHoteles";
            this.lblHoteles.Size = new System.Drawing.Size(92, 25);
            this.lblHoteles.TabIndex = 21;
            this.lblHoteles.Text = "Hoteles";
            // 
            // _lstHoteles
            // 
            this._lstHoteles.FormattingEnabled = true;
            this._lstHoteles.Location = new System.Drawing.Point(31, 83);
            this._lstHoteles.Margin = new System.Windows.Forms.Padding(2);
            this._lstHoteles.Name = "_lstHoteles";
            this._lstHoteles.Size = new System.Drawing.Size(246, 186);
            this._lstHoteles.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _cmbAmenities
            // 
            this._cmbAmenities.FormattingEnabled = true;
            this._cmbAmenities.Location = new System.Drawing.Point(429, 212);
            this._cmbAmenities.Margin = new System.Windows.Forms.Padding(2);
            this._cmbAmenities.Name = "_cmbAmenities";
            this._cmbAmenities.Size = new System.Drawing.Size(109, 21);
            this._cmbAmenities.TabIndex = 5;
            this._cmbAmenities.Click += new System.EventHandler(this.cmbAmenities_Click);
            // 
            // _cmbEstrellas
            // 
            this._cmbEstrellas.FormattingEnabled = true;
            this._cmbEstrellas.Location = new System.Drawing.Point(429, 173);
            this._cmbEstrellas.Margin = new System.Windows.Forms.Padding(2);
            this._cmbEstrellas.Name = "_cmbEstrellas";
            this._cmbEstrellas.Size = new System.Drawing.Size(109, 21);
            this._cmbEstrellas.TabIndex = 4;
            this._cmbEstrellas.Click += new System.EventHandler(this.cmbEstrella_Click);
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(429, 139);
            this._txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(109, 20);
            this._txtDireccion.TabIndex = 3;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(429, 102);
            this._txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(109, 20);
            this._txtNombre.TabIndex = 2;
            // 
            // _btnLimpiarHabitacion
            // 
            this._btnLimpiarHabitacion.BackColor = System.Drawing.Color.PaleTurquoise;
            this._btnLimpiarHabitacion.Location = new System.Drawing.Point(346, 281);
            this._btnLimpiarHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this._btnLimpiarHabitacion.Name = "_btnLimpiarHabitacion";
            this._btnLimpiarHabitacion.Size = new System.Drawing.Size(89, 22);
            this._btnLimpiarHabitacion.TabIndex = 6;
            this._btnLimpiarHabitacion.Text = "Limpiar";
            this._btnLimpiarHabitacion.UseVisualStyleBackColor = false;
            this._btnLimpiarHabitacion.Click += new System.EventHandler(this._btnLimpiarHabitacion_Click);
            // 
            // _btnGuardarHabitacion
            // 
            this._btnGuardarHabitacion.BackColor = System.Drawing.Color.PaleTurquoise;
            this._btnGuardarHabitacion.Location = new System.Drawing.Point(449, 281);
            this._btnGuardarHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this._btnGuardarHabitacion.Name = "_btnGuardarHabitacion";
            this._btnGuardarHabitacion.Size = new System.Drawing.Size(89, 22);
            this._btnGuardarHabitacion.TabIndex = 7;
            this._btnGuardarHabitacion.Text = "Guardar";
            this._btnGuardarHabitacion.UseVisualStyleBackColor = false;
            this._btnGuardarHabitacion.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.Color.PaleTurquoise;
            this._btnVolver.Location = new System.Drawing.Point(187, 281);
            this._btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(89, 22);
            this._btnVolver.TabIndex = 11;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblNombre.Location = new System.Drawing.Point(348, 103);
            this._lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(57, 16);
            this._lblNombre.TabIndex = 4;
            this._lblNombre.Text = "Nombre";
            // 
            // _lblDireccion
            // 
            this._lblDireccion.AutoSize = true;
            this._lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblDireccion.Location = new System.Drawing.Point(345, 139);
            this._lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblDireccion.Name = "_lblDireccion";
            this._lblDireccion.Size = new System.Drawing.Size(65, 16);
            this._lblDireccion.TabIndex = 3;
            this._lblDireccion.Text = "Direccion";
            // 
            // _lblEstrellas
            // 
            this._lblEstrellas.AutoSize = true;
            this._lblEstrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblEstrellas.Location = new System.Drawing.Point(345, 173);
            this._lblEstrellas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblEstrellas.Name = "_lblEstrellas";
            this._lblEstrellas.Size = new System.Drawing.Size(60, 16);
            this._lblEstrellas.TabIndex = 2;
            this._lblEstrellas.Text = "Estrellas";
            // 
            // _lblAmenities
            // 
            this._lblAmenities.AutoSize = true;
            this._lblAmenities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblAmenities.Location = new System.Drawing.Point(345, 214);
            this._lblAmenities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblAmenities.Name = "_lblAmenities";
            this._lblAmenities.Size = new System.Drawing.Size(67, 16);
            this._lblAmenities.TabIndex = 1;
            this._lblAmenities.Text = "Amenities";
            // 
            // FrmHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 355);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHoteles";
            this.Text = "Hoteles";
            this.Load += new System.EventHandler(this.FrmHoteles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnLimpiarHabitacion;
        private System.Windows.Forms.Button _btnGuardarHabitacion;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblDireccion;
        private System.Windows.Forms.Label _lblEstrellas;
        private System.Windows.Forms.Label _lblAmenities;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox _cmbAmenities;
        private System.Windows.Forms.ComboBox _cmbEstrellas;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.ListBox _lstHoteles;
        private System.Windows.Forms.Label lblHoteles;
        private System.Windows.Forms.Label lblDatosHotel;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Button _btnRegargar;
        private System.Windows.Forms.ComboBox cmbHoteles;
    }
}