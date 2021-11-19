
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoteles));
            this.panel1 = new System.Windows.Forms.Panel();
            this._lblIdHotel = new System.Windows.Forms.Label();
            this._lblAmenities = new System.Windows.Forms.Label();
            this._lblEstrellas = new System.Windows.Forms.Label();
            this._lblDireccion = new System.Windows.Forms.Label();
            this._lblNombre = new System.Windows.Forms.Label();
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnAgregarHabitacion = new System.Windows.Forms.Button();
            this._btnMostrarHabitacion = new System.Windows.Forms.Button();
            this._btnLimpiarHabitacion = new System.Windows.Forms.Button();
            this._txtIdHotel = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this._cmbEstrellas = new System.Windows.Forms.ComboBox();
            this._cmbAmenities = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this._cmbAmenities);
            this.panel1.Controls.Add(this._cmbEstrellas);
            this.panel1.Controls.Add(this._txtDireccion);
            this.panel1.Controls.Add(this._txtNombre);
            this.panel1.Controls.Add(this._txtIdHotel);
            this.panel1.Controls.Add(this._btnLimpiarHabitacion);
            this.panel1.Controls.Add(this._btnMostrarHabitacion);
            this.panel1.Controls.Add(this._btnAgregarHabitacion);
            this.panel1.Controls.Add(this._btnVolver);
            this.panel1.Controls.Add(this._lblNombre);
            this.panel1.Controls.Add(this._lblDireccion);
            this.panel1.Controls.Add(this._lblEstrellas);
            this.panel1.Controls.Add(this._lblAmenities);
            this.panel1.Controls.Add(this._lblIdHotel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 509);
            this.panel1.TabIndex = 0;
            // 
            // _lblIdHotel
            // 
            this._lblIdHotel.AutoSize = true;
            this._lblIdHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblIdHotel.Location = new System.Drawing.Point(55, 65);
            this._lblIdHotel.Name = "_lblIdHotel";
            this._lblIdHotel.Size = new System.Drawing.Size(78, 25);
            this._lblIdHotel.TabIndex = 0;
            this._lblIdHotel.Text = "Id Hotel";
            // 
            // _lblAmenities
            // 
            this._lblAmenities.AutoSize = true;
            this._lblAmenities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblAmenities.Location = new System.Drawing.Point(55, 251);
            this._lblAmenities.Name = "_lblAmenities";
            this._lblAmenities.Size = new System.Drawing.Size(98, 25);
            this._lblAmenities.TabIndex = 1;
            this._lblAmenities.Text = "Amenities";
            // 
            // _lblEstrellas
            // 
            this._lblEstrellas.AutoSize = true;
            this._lblEstrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblEstrellas.Location = new System.Drawing.Point(55, 202);
            this._lblEstrellas.Name = "_lblEstrellas";
            this._lblEstrellas.Size = new System.Drawing.Size(86, 25);
            this._lblEstrellas.TabIndex = 2;
            this._lblEstrellas.Text = "Estrellas";
            // 
            // _lblDireccion
            // 
            this._lblDireccion.AutoSize = true;
            this._lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblDireccion.Location = new System.Drawing.Point(55, 157);
            this._lblDireccion.Name = "_lblDireccion";
            this._lblDireccion.Size = new System.Drawing.Size(93, 25);
            this._lblDireccion.TabIndex = 3;
            this._lblDireccion.Text = "Direccion";
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this._lblNombre.Location = new System.Drawing.Point(55, 112);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(81, 25);
            this._lblNombre.TabIndex = 4;
            this._lblNombre.Text = "Nombre";
            // 
            // _btnVolver
            // 
            this._btnVolver.Location = new System.Drawing.Point(13, 406);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(159, 34);
            this._btnVolver.TabIndex = 5;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = true;
            // 
            // _btnAgregarHabitacion
            // 
            this._btnAgregarHabitacion.Location = new System.Drawing.Point(60, 314);
            this._btnAgregarHabitacion.Name = "_btnAgregarHabitacion";
            this._btnAgregarHabitacion.Size = new System.Drawing.Size(134, 34);
            this._btnAgregarHabitacion.TabIndex = 6;
            this._btnAgregarHabitacion.Text = "Agregar";
            this._btnAgregarHabitacion.UseVisualStyleBackColor = true;
            // 
            // _btnMostrarHabitacion
            // 
            this._btnMostrarHabitacion.Location = new System.Drawing.Point(239, 314);
            this._btnMostrarHabitacion.Name = "_btnMostrarHabitacion";
            this._btnMostrarHabitacion.Size = new System.Drawing.Size(134, 34);
            this._btnMostrarHabitacion.TabIndex = 7;
            this._btnMostrarHabitacion.Text = "Mostrar";
            this._btnMostrarHabitacion.UseVisualStyleBackColor = true;
            // 
            // _btnLimpiarHabitacion
            // 
            this._btnLimpiarHabitacion.Location = new System.Drawing.Point(539, 406);
            this._btnLimpiarHabitacion.Name = "_btnLimpiarHabitacion";
            this._btnLimpiarHabitacion.Size = new System.Drawing.Size(159, 34);
            this._btnLimpiarHabitacion.TabIndex = 8;
            this._btnLimpiarHabitacion.Text = "Limpiar";
            this._btnLimpiarHabitacion.UseVisualStyleBackColor = true;
            // 
            // _txtIdHotel
            // 
            this._txtIdHotel.Location = new System.Drawing.Point(211, 64);
            this._txtIdHotel.Name = "_txtIdHotel";
            this._txtIdHotel.Size = new System.Drawing.Size(162, 26);
            this._txtIdHotel.TabIndex = 9;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(211, 113);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(162, 26);
            this._txtNombre.TabIndex = 10;
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(211, 158);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(162, 26);
            this._txtDireccion.TabIndex = 11;
            // 
            // _cmbEstrellas
            // 
            this._cmbEstrellas.FormattingEnabled = true;
            this._cmbEstrellas.Location = new System.Drawing.Point(211, 203);
            this._cmbEstrellas.Name = "_cmbEstrellas";
            this._cmbEstrellas.Size = new System.Drawing.Size(162, 28);
            this._cmbEstrellas.TabIndex = 12;
            // 
            // _cmbAmenities
            // 
            this._cmbAmenities.FormattingEnabled = true;
            this._cmbAmenities.Location = new System.Drawing.Point(211, 251);
            this._cmbAmenities.Name = "_cmbAmenities";
            this._cmbAmenities.Size = new System.Drawing.Size(162, 28);
            this._cmbAmenities.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 189);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHoteles";
            this.Text = "Hoteles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnLimpiarHabitacion;
        private System.Windows.Forms.Button _btnMostrarHabitacion;
        private System.Windows.Forms.Button _btnAgregarHabitacion;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblDireccion;
        private System.Windows.Forms.Label _lblEstrellas;
        private System.Windows.Forms.Label _lblAmenities;
        private System.Windows.Forms.Label _lblIdHotel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox _cmbAmenities;
        private System.Windows.Forms.ComboBox _cmbEstrellas;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtIdHotel;
    }
}